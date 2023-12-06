using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Business;
using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace RecipeCookBook
{
    public partial class Form1 : Form
    {
        private RecipeBusiness recipeBusiness = new RecipeBusiness();
        private int editId = 0;
        private double recYield = 1;
        string PathFile = "";
        int highlightedIndex = 0;

        public Form1()
        {
            InitializeComponent();
            //I am adding data to ComboBox like that, so that it'd automatically data bind, thus eliminating the chance of a null value ruining my program.
            string[] meals = { "Breakfast & Brunch", "Lunch", "Appetizers & Snacks", "Salads", "Side Dishes", "Soups", "Bread", "Drinks", "Desserts", "Sauces", "Other"};
            recMealCourseComboBox.DataSource = meals;
        }
        private void UpdateGrid()
        {
            if (RecipeGridView.SelectedRows.Count > 0) {
                highlightedIndex = RecipeGridView.SelectedRows[0].Index;
            }
            RecipeGridView.DataSource = recipeBusiness.GetAll().Select(o => new {ID = o.ID, Name = o.Name, Cooking_Time = o.CookingTime }).ToList();
            RecipeGridView.ReadOnly = true;
            RecipeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void GoBackB_Click(object sender, EventArgs e)
        {
            GoBackWithoutB();
            ChangeTextFields("", "Breakfast & Brunch", "", 1, 1, "", "", "", "", "");
        }
        private void GoBackWithoutB() {
            recipeShowCasePanel.Visible = true;
            recipeCreationPanel.Visible = false;
        }
        private void GoToRecCreation(string buttonText)
        {
            recipeShowCasePanel.Visible = false;
            recipeCreationPanel.Visible = true;
            CreateRecipeB.Text = buttonText;
        }
        private void ToRecipeCreationB_Click(object sender, EventArgs e)
        {
            GoToRecCreation("Create");
        }

        private void CreateRecipeB_Click(object sender, EventArgs e)
        {
            string selected = "";
            foreach (object itemChecked in recTagsCheckedListBox.CheckedItems)
            {
                selected += (itemChecked.ToString() + ", ");
            }
            if (selected.Length > 2)
            {
                selected = selected.Substring(0, selected.Length - 2);
            }
            Recipe recipe = new Recipe();
            recipe = CreateRecipeWithoutB(selected, recipe);
            if (CreateRecipeB.Text == "Save Edits")
            {
                recipe.ID = editId;
                recipeBusiness.Update(recipe);
            }
            else {
                recipeBusiness.Add(recipe);
            }
            UpdateGrid();
            if (CreateRecipeB.Text == "Save Edits")
            {
                DealWithRecipePanel(highlightedIndex);
            }
            else
            {
                DealWithRecipePanel(RecipeGridView.RowCount - 1);
            }
            ClearRecFields();
            GoBackWithoutB();
        }
        //this adds new recipe, if recipe doesn't exist, and edits existing recipe. All in one function.
        private Recipe CreateRecipeWithoutB(string selected, Recipe rec)
        {
            rec.Name = recNameTxtBox.Text;
            rec.MealCourse = recMealCourseComboBox.SelectedItem.ToString();
            rec.Tags = selected;
            rec.CookingTime = Convert.ToInt32(recTimeNumericUpDown.Value);
            rec.Yield = Convert.ToInt32(recYieldNumericUpDown.Value);
            rec.ImageFile = PathFile;
            rec.Ingredients = recIngrRichTxtBox.Text;
            rec.Instructions = recInstrucRichTxtBox.Text;
            rec.Notes = recNotesRichTxtBox.Text;
            rec.SourceOfRec = recSourceTxtBox.Text;
            return rec;
        }
        private void RecClearFieldsB_Click(object sender, EventArgs e)
        {
            ClearRecFields();
        }
        private void ClearRecFields()
        {
            ChangeTextFields("", "Breakfast & Brunch", "", 1, 1, "", "","","", "");
        }
        private void AddImageB_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "images|*.png;*.jpeg;*.jpg"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PathFile = dialog.FileName;
            }
        }
        //I use this function both to clear text fields and set text fields to values of recipe I'm editing.
        private void ChangeTextFields(string name, string mealC,string tags, int time, int yield, string pathName, string ingr, string instr, string notes, string sourceInt)
        {
            recNameTxtBox.Text = name;
            recMealCourseComboBox.SelectedIndex = recMealCourseComboBox.Items.IndexOf(mealC);
            ClearTags();
            foreach (string tag in tags.Split(','))
            {
                int index = recTagsCheckedListBox.Items.IndexOf(tag.Trim());
                if (index >= 0)
                {
                    recTagsCheckedListBox.SetItemChecked(index, true);
                }
            }
            recTimeNumericUpDown.Value = time;
            recYieldNumericUpDown.Value = yield;
            PathFile = pathName;
            recIngrRichTxtBox.Text = ingr;
            recInstrucRichTxtBox.Text = instr;
            recNotesRichTxtBox.Text = notes;
            recSourceTxtBox.Text = sourceInt;
        }
        private void ClearTags()
        {
            for (int i = recTagsCheckedListBox.Items.Count - 1; i >= 0; i--)
            {
                recTagsCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void RecipeGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Recipe rec = recipeBusiness.Get(Convert.ToInt32(RecipeGridView.Rows[e.RowIndex].Cells[0].Value));
            if (rec != null)
            {
                RecipePanel(rec);
            }
        }
        private void RecipePanel(Recipe rec)
        {
            if (rec.ImageFile != "")
            {
                pictureBox.Visible = true;
                pictureBox.ImageLocation = rec.ImageFile;
            }
            else
            {
                pictureBox.Visible = false;
            }
            relRecName.Text = rec.Name.ToUpper();
            relRecMeal.Text = rec.MealCourse;
            relRecTags.Text = $"This recipe is {string.Join(", ", rec.Tags)}!";
            relRecTime.Text = $"Cook Time: {rec.CookingTime}";
            relRecYield.Text = $"Yield: {rec.Yield*recYield} \n\n";
            relRecIngr.Text = $"\n\n{getIngredients(rec.Ingredients)}\n\n\n";
            relRecInstr.Text = $"\n\n{rec.Instructions}\n\n\n";
            relRecNotes.Text = $"\n\n{rec.Notes}\n\n\n";
            label14.Text = "\nThis recipe was inspired by: ";
            relRecSource.Text = $"{rec.SourceOfRec}\n\n\n\n\n";
        }
        //this will calculate the quantity of ingredients and yield
        private string getIngredients(string ingrStr) {
            List<string> listAll = new List<string>();
            foreach (string el in ingrStr.Split('\n')) {
                string[] elArr = el.Split(' ');
                if (Double.TryParse(el.Split(' ')[0], out _)) {
                    elArr[0] = (Convert.ToDouble(el.Split(' ')[0], CultureInfo.InvariantCulture) * recYield).ToString();
                }
                listAll.Add(string.Join(" ", elArr));
            }
            return string.Join("\n",listAll);
        }
        private void EditRecB_Click(object sender, EventArgs e)
        {
            GoToRecCreation("Save Edits");
            var item = RecipeGridView.SelectedRows[0].Cells;
            var id = int.Parse(item[0].Value.ToString());
            var rec = recipeBusiness.Get(id);
            editId = id;
            ChangeTextFields(rec.Name, rec.MealCourse, rec.Tags, rec.CookingTime, rec.Yield, rec.ImageFile, rec.Ingredients, rec.Instructions, rec.Notes, rec.SourceOfRec);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearRecFields();
            YieldNumUpDown.Value = 1;
            this.WindowState = FormWindowState.Maximized;
        }

        private void RecDeleteB_Click(object sender, EventArgs e)
        {
            if (RecipeGridView.SelectedRows.Count > 0)
            {
                var item = RecipeGridView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                recipeBusiness.Delete(id);
                UpdateGrid();
            }
        }

        private void relRecSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(relRecSource.Text);
        }

        private void FilterB_Click(object sender, EventArgs e)
        {
            recYield = double.Parse(YieldNumUpDown.Value.ToString());
            string selected = "";
            foreach (object itemChecked in RecSearchTagscheckedListBox.CheckedItems)
            {
                selected += (itemChecked.ToString().ToLower() + ", ");
            }
            if (selected.Length > 2)
            {
                selected = selected.Substring(0, selected.Length - 2);
            }
            RecipeGridView.DataSource = recipeBusiness.GetAll().Where(o => o.Tags.ToLower().Contains(selected) && o.Name.ToLower().Contains(RecSearchNamesTxtBox.Text.ToLower()) && o.Ingredients.ToLower().Contains(RecSearchIngrsTxtBox.Text.ToLower())).Select(o => new { ID = o.ID, Name = o.Name, Cooking_Time = o.CookingTime }).ToList();
            if (RecipeGridView.Rows.Count > 0)
            {
                flowLayoutPanel1.Visible = true;
                DealWithRecipePanel();
            }
            else {
                flowLayoutPanel1.Visible = false;
            }
        }

        private void ClearFiltersB_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            RecSearchNamesTxtBox.Text = "";
            RecSearchIngrsTxtBox.Text = "";
            YieldNumUpDown.Value = 1;
            recYield = 1;
            for (int i = RecSearchTagscheckedListBox.Items.Count - 1; i >= 0; i--)
            {
                RecSearchTagscheckedListBox.SetItemChecked(i, false);
            }
            UpdateGrid();
            DealWithRecipePanel();
        }
        private void DealWithRecipePanel(int selectInd = 0) {
            if (RecipeGridView.Rows.Count > 0) { 
                RecipeGridView.Rows[selectInd].Selected = true;
                var item = RecipeGridView.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                RecipePanel(recipeBusiness.Get(id));
            }
        }
    }
}