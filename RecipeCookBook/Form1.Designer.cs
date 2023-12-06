using System.Windows.Forms;

namespace RecipeCookBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.RecClearFieldsB = new System.Windows.Forms.Button();
            this.CreateRecipeB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.recipeCreationPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.recNameTxtBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.AddImageB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.recTagsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.recMealCourseComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.recYieldNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.recTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.recIngrRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.recInstrucRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.recNotesRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recSourceTxtBox = new System.Windows.Forms.TextBox();
            this.GoBackB = new System.Windows.Forms.Button();
            this.recipeShowCasePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RecDeleteB = new System.Windows.Forms.Button();
            this.ClearFiltersB = new System.Windows.Forms.Button();
            this.RecSearchTagscheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FilterB = new System.Windows.Forms.Button();
            this.YieldNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.RecSearchIngrsTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RecSearchNamesTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editRecB = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.relRecName = new System.Windows.Forms.Label();
            this.relRecMeal = new System.Windows.Forms.Label();
            this.relRecTags = new System.Windows.Forms.Label();
            this.relRecTime = new System.Windows.Forms.Label();
            this.relRecYield = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.relRecIngr = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.relRecInstr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.relRecNotes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.relRecSource = new System.Windows.Forms.LinkLabel();
            this.RecipeGridView = new System.Windows.Forms.DataGridView();
            this.ToRecipeCreationB = new System.Windows.Forms.Button();
            this.recipeCreationPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recYieldNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recTimeNumericUpDown)).BeginInit();
            this.recipeShowCasePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YieldNumUpDown)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create-a-Recipe";
            // 
            // RecClearFieldsB
            // 
            this.RecClearFieldsB.BackColor = System.Drawing.Color.DarkCyan;
            this.RecClearFieldsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RecClearFieldsB.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecClearFieldsB.ForeColor = System.Drawing.Color.White;
            this.RecClearFieldsB.Location = new System.Drawing.Point(12, 756);
            this.RecClearFieldsB.Name = "RecClearFieldsB";
            this.RecClearFieldsB.Size = new System.Drawing.Size(451, 76);
            this.RecClearFieldsB.TabIndex = 13;
            this.RecClearFieldsB.Text = "Clear";
            this.RecClearFieldsB.UseVisualStyleBackColor = false;
            this.RecClearFieldsB.Click += new System.EventHandler(this.RecClearFieldsB_Click);
            // 
            // CreateRecipeB
            // 
            this.CreateRecipeB.BackColor = System.Drawing.Color.DarkCyan;
            this.CreateRecipeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateRecipeB.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRecipeB.ForeColor = System.Drawing.Color.White;
            this.CreateRecipeB.Location = new System.Drawing.Point(469, 759);
            this.CreateRecipeB.Name = "CreateRecipeB";
            this.CreateRecipeB.Size = new System.Drawing.Size(436, 73);
            this.CreateRecipeB.TabIndex = 18;
            this.CreateRecipeB.Text = "Add";
            this.CreateRecipeB.UseVisualStyleBackColor = false;
            this.CreateRecipeB.Click += new System.EventHandler(this.CreateRecipeB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // recipeCreationPanel
            // 
            this.recipeCreationPanel.BackColor = System.Drawing.Color.LightCyan;
            this.recipeCreationPanel.Controls.Add(this.tableLayoutPanel1);
            this.recipeCreationPanel.Controls.Add(this.GoBackB);
            this.recipeCreationPanel.Controls.Add(this.label1);
            this.recipeCreationPanel.Controls.Add(this.CreateRecipeB);
            this.recipeCreationPanel.Controls.Add(this.RecClearFieldsB);
            this.recipeCreationPanel.Location = new System.Drawing.Point(0, 2);
            this.recipeCreationPanel.Name = "recipeCreationPanel";
            this.recipeCreationPanel.Size = new System.Drawing.Size(1317, 858);
            this.recipeCreationPanel.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.21101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.78899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 684F));
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.recNameTxtBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddImageB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.recTagsCheckedListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.recMealCourseComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.recYieldNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.recTimeNumericUpDown, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.recIngrRichTxtBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.recInstrucRichTxtBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.recNotesRichTxtBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.recSourceTxtBox, 3, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18357F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.81642F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1290, 648);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = "Name:";
            // 
            // recNameTxtBox
            // 
            this.recNameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recNameTxtBox.Location = new System.Drawing.Point(123, 6);
            this.recNameTxtBox.Name = "recNameTxtBox";
            this.recNameTxtBox.Size = new System.Drawing.Size(289, 33);
            this.recNameTxtBox.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(421, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 25);
            this.label21.TabIndex = 20;
            this.label21.Text = "Upload Image:";
            // 
            // AddImageB
            // 
            this.AddImageB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddImageB.BackColor = System.Drawing.Color.DarkCyan;
            this.AddImageB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddImageB.Location = new System.Drawing.Point(915, 4);
            this.AddImageB.Name = "AddImageB";
            this.AddImageB.Size = new System.Drawing.Size(63, 37);
            this.AddImageB.TabIndex = 19;
            this.AddImageB.Text = "+";
            this.AddImageB.UseVisualStyleBackColor = false;
            this.AddImageB.Click += new System.EventHandler(this.AddImageB_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tags:";
            // 
            // recTagsCheckedListBox
            // 
            this.recTagsCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recTagsCheckedListBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recTagsCheckedListBox.FormattingEnabled = true;
            this.recTagsCheckedListBox.Items.AddRange(new object[] {
            "Vegetarian",
            "Vegan",
            "Fast-Friendly",
            "Dairy-Free",
            "Egg-Free",
            "Gluten-Free",
            "Bulgarian",
            "American",
            "Italian",
            "French",
            "Indian",
            "Asian",
            "Middle-Eastern",
            "Healthy",
            "Festive",
            "Favorite"});
            this.recTagsCheckedListBox.Location = new System.Drawing.Point(123, 65);
            this.recTagsCheckedListBox.Name = "recTagsCheckedListBox";
            this.recTagsCheckedListBox.Size = new System.Drawing.Size(289, 106);
            this.recTagsCheckedListBox.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(421, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 25);
            this.label17.TabIndex = 3;
            this.label17.Text = "Meal Course:";
            // 
            // recMealCourseComboBox
            // 
            this.recMealCourseComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recMealCourseComboBox.FormattingEnabled = true;
            this.recMealCourseComboBox.Location = new System.Drawing.Point(611, 101);
            this.recMealCourseComboBox.Name = "recMealCourseComboBox";
            this.recMealCourseComboBox.Size = new System.Drawing.Size(671, 33);
            this.recMealCourseComboBox.TabIndex = 0;
            this.recMealCourseComboBox.Text = "--Select One--";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 25);
            this.label18.TabIndex = 17;
            this.label18.Text = "Yield:";
            // 
            // recYieldNumericUpDown
            // 
            this.recYieldNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recYieldNumericUpDown.Location = new System.Drawing.Point(123, 203);
            this.recYieldNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recYieldNumericUpDown.Name = "recYieldNumericUpDown";
            this.recYieldNumericUpDown.Size = new System.Drawing.Size(289, 33);
            this.recYieldNumericUpDown.TabIndex = 8;
            this.recYieldNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(421, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 50);
            this.label19.TabIndex = 5;
            this.label19.Text = "Cooking Time (in minutes):";
            // 
            // recTimeNumericUpDown
            // 
            this.recTimeNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recTimeNumericUpDown.Location = new System.Drawing.Point(610, 203);
            this.recTimeNumericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.recTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recTimeNumericUpDown.Name = "recTimeNumericUpDown";
            this.recTimeNumericUpDown.Size = new System.Drawing.Size(672, 33);
            this.recTimeNumericUpDown.TabIndex = 14;
            this.recTimeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 50);
            this.label16.TabIndex = 6;
            this.label16.Text = "Ingredients:";
            // 
            // recIngrRichTxtBox
            // 
            this.recIngrRichTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recIngrRichTxtBox.Location = new System.Drawing.Point(123, 255);
            this.recIngrRichTxtBox.Name = "recIngrRichTxtBox";
            this.recIngrRichTxtBox.Size = new System.Drawing.Size(289, 276);
            this.recIngrRichTxtBox.TabIndex = 10;
            this.recIngrRichTxtBox.Text = "";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Instructions:";
            // 
            // recInstrucRichTxtBox
            // 
            this.recInstrucRichTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recInstrucRichTxtBox.Location = new System.Drawing.Point(609, 255);
            this.recInstrucRichTxtBox.Name = "recInstrucRichTxtBox";
            this.recInstrucRichTxtBox.Size = new System.Drawing.Size(675, 276);
            this.recInstrucRichTxtBox.TabIndex = 9;
            this.recInstrucRichTxtBox.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Notes:";
            // 
            // recNotesRichTxtBox
            // 
            this.recNotesRichTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recNotesRichTxtBox.Location = new System.Drawing.Point(123, 542);
            this.recNotesRichTxtBox.Name = "recNotesRichTxtBox";
            this.recNotesRichTxtBox.Size = new System.Drawing.Size(289, 102);
            this.recNotesRichTxtBox.TabIndex = 16;
            this.recNotesRichTxtBox.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "Source of Recipe:";
            // 
            // recSourceTxtBox
            // 
            this.recSourceTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recSourceTxtBox.Location = new System.Drawing.Point(609, 576);
            this.recSourceTxtBox.Name = "recSourceTxtBox";
            this.recSourceTxtBox.Size = new System.Drawing.Size(675, 33);
            this.recSourceTxtBox.TabIndex = 24;
            // 
            // GoBackB
            // 
            this.GoBackB.BackColor = System.Drawing.Color.DarkCyan;
            this.GoBackB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackB.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackB.ForeColor = System.Drawing.Color.White;
            this.GoBackB.Location = new System.Drawing.Point(911, 759);
            this.GoBackB.Name = "GoBackB";
            this.GoBackB.Size = new System.Drawing.Size(381, 73);
            this.GoBackB.TabIndex = 19;
            this.GoBackB.Text = "Go Back";
            this.GoBackB.UseVisualStyleBackColor = false;
            this.GoBackB.Click += new System.EventHandler(this.GoBackB_Click);
            // 
            // recipeShowCasePanel
            // 
            this.recipeShowCasePanel.BackColor = System.Drawing.Color.Pink;
            this.recipeShowCasePanel.Controls.Add(this.tableLayoutPanel2);
            this.recipeShowCasePanel.Controls.Add(this.flowLayoutPanel1);
            this.recipeShowCasePanel.Controls.Add(this.RecipeGridView);
            this.recipeShowCasePanel.Controls.Add(this.ToRecipeCreationB);
            this.recipeShowCasePanel.Location = new System.Drawing.Point(1, 2);
            this.recipeShowCasePanel.Name = "recipeShowCasePanel";
            this.recipeShowCasePanel.Size = new System.Drawing.Size(1316, 851);
            this.recipeShowCasePanel.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.RecDeleteB, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.ClearFiltersB, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.RecSearchTagscheckedListBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.FilterB, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.YieldNumUpDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RecSearchIngrsTxtBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.RecSearchNamesTxtBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editRecB, 2, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(31, 635);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 196);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // RecDeleteB
            // 
            this.RecDeleteB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecDeleteB.BackColor = System.Drawing.Color.Thistle;
            this.RecDeleteB.Location = new System.Drawing.Point(381, 143);
            this.RecDeleteB.Name = "RecDeleteB";
            this.RecDeleteB.Size = new System.Drawing.Size(121, 50);
            this.RecDeleteB.TabIndex = 4;
            this.RecDeleteB.Text = "Delete";
            this.RecDeleteB.UseVisualStyleBackColor = false;
            this.RecDeleteB.Click += new System.EventHandler(this.RecDeleteB_Click);
            // 
            // ClearFiltersB
            // 
            this.ClearFiltersB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFiltersB.BackColor = System.Drawing.Color.Thistle;
            this.ClearFiltersB.Location = new System.Drawing.Point(129, 143);
            this.ClearFiltersB.Name = "ClearFiltersB";
            this.ClearFiltersB.Size = new System.Drawing.Size(120, 50);
            this.ClearFiltersB.TabIndex = 8;
            this.ClearFiltersB.Text = "Clear Filters";
            this.ClearFiltersB.UseVisualStyleBackColor = false;
            this.ClearFiltersB.Click += new System.EventHandler(this.ClearFiltersB_Click);
            // 
            // RecSearchTagscheckedListBox
            // 
            this.RecSearchTagscheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecSearchTagscheckedListBox.FormattingEnabled = true;
            this.RecSearchTagscheckedListBox.Items.AddRange(new object[] {
            "Vegetarian",
            "Vegan",
            "Fast-Friendly",
            "Dairy-Free",
            "Egg-Free",
            "Gluten-Free",
            "Bulgarian",
            "American",
            "Italian",
            "French",
            "Indian",
            "Asian",
            "Middle-Eastern",
            "Healthy",
            "Festive",
            "Favorite"});
            this.RecSearchTagscheckedListBox.Location = new System.Drawing.Point(381, 12);
            this.RecSearchTagscheckedListBox.Name = "RecSearchTagscheckedListBox";
            this.RecSearchTagscheckedListBox.Size = new System.Drawing.Size(120, 46);
            this.RecSearchTagscheckedListBox.TabIndex = 14;
            // 
            // FilterB
            // 
            this.FilterB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterB.BackColor = System.Drawing.Color.Thistle;
            this.FilterB.Location = new System.Drawing.Point(3, 143);
            this.FilterB.Name = "FilterB";
            this.FilterB.Size = new System.Drawing.Size(120, 50);
            this.FilterB.TabIndex = 7;
            this.FilterB.Text = "Filter";
            this.FilterB.UseVisualStyleBackColor = false;
            this.FilterB.Click += new System.EventHandler(this.FilterB_Click);
            // 
            // YieldNumUpDown
            // 
            this.YieldNumUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YieldNumUpDown.DecimalPlaces = 1;
            this.YieldNumUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.YieldNumUpDown.Location = new System.Drawing.Point(129, 22);
            this.YieldNumUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.YieldNumUpDown.Name = "YieldNumUpDown";
            this.YieldNumUpDown.Size = new System.Drawing.Size(120, 26);
            this.YieldNumUpDown.TabIndex = 5;
            this.YieldNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RecSearchIngrsTxtBox
            // 
            this.RecSearchIngrsTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecSearchIngrsTxtBox.Location = new System.Drawing.Point(381, 92);
            this.RecSearchIngrsTxtBox.Name = "RecSearchIngrsTxtBox";
            this.RecSearchIngrsTxtBox.Size = new System.Drawing.Size(121, 26);
            this.RecSearchIngrsTxtBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search in Names:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Search in Ingredients:";
            // 
            // RecSearchNamesTxtBox
            // 
            this.RecSearchNamesTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RecSearchNamesTxtBox.Location = new System.Drawing.Point(129, 92);
            this.RecSearchNamesTxtBox.Name = "RecSearchNamesTxtBox";
            this.RecSearchNamesTxtBox.Size = new System.Drawing.Size(120, 26);
            this.RecSearchNamesTxtBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter By Tags:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adjust Yield:";
            // 
            // editRecB
            // 
            this.editRecB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editRecB.BackColor = System.Drawing.Color.Thistle;
            this.editRecB.Location = new System.Drawing.Point(255, 143);
            this.editRecB.Name = "editRecB";
            this.editRecB.Size = new System.Drawing.Size(120, 50);
            this.editRecB.TabIndex = 3;
            this.editRecB.Text = "Edit";
            this.editRecB.UseVisualStyleBackColor = false;
            this.editRecB.Click += new System.EventHandler(this.EditRecB_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.flowLayoutPanel1.Controls.Add(this.relRecName);
            this.flowLayoutPanel1.Controls.Add(this.relRecMeal);
            this.flowLayoutPanel1.Controls.Add(this.relRecTags);
            this.flowLayoutPanel1.Controls.Add(this.relRecTime);
            this.flowLayoutPanel1.Controls.Add(this.relRecYield);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.relRecIngr);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.relRecInstr);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.relRecNotes);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.relRecSource);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(577, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 20, 20, 50);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(703, 812);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // relRecName
            // 
            this.relRecName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecName.AutoSize = true;
            this.relRecName.BackColor = System.Drawing.Color.White;
            this.relRecName.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecName.ForeColor = System.Drawing.Color.Thistle;
            this.relRecName.Location = new System.Drawing.Point(284, 20);
            this.relRecName.Name = "relRecName";
            this.relRecName.Padding = new System.Windows.Forms.Padding(2);
            this.relRecName.Size = new System.Drawing.Size(130, 42);
            this.relRecName.TabIndex = 0;
            this.relRecName.Text = "label2";
            this.relRecName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecMeal
            // 
            this.relRecMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecMeal.AutoSize = true;
            this.relRecMeal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecMeal.Location = new System.Drawing.Point(324, 62);
            this.relRecMeal.Name = "relRecMeal";
            this.relRecMeal.Padding = new System.Windows.Forms.Padding(2);
            this.relRecMeal.Size = new System.Drawing.Size(49, 18);
            this.relRecMeal.TabIndex = 2;
            this.relRecMeal.Text = "label3";
            this.relRecMeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecTags
            // 
            this.relRecTags.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecTags.AutoSize = true;
            this.relRecTags.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecTags.Location = new System.Drawing.Point(321, 80);
            this.relRecTags.Name = "relRecTags";
            this.relRecTags.Padding = new System.Windows.Forms.Padding(2);
            this.relRecTags.Size = new System.Drawing.Size(55, 22);
            this.relRecTags.TabIndex = 3;
            this.relRecTags.Text = "label4";
            this.relRecTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecTime
            // 
            this.relRecTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecTime.AutoSize = true;
            this.relRecTime.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecTime.Location = new System.Drawing.Point(321, 102);
            this.relRecTime.Name = "relRecTime";
            this.relRecTime.Padding = new System.Windows.Forms.Padding(2);
            this.relRecTime.Size = new System.Drawing.Size(55, 22);
            this.relRecTime.TabIndex = 4;
            this.relRecTime.Text = "label5";
            this.relRecTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecYield
            // 
            this.relRecYield.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecYield.AutoSize = true;
            this.relRecYield.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecYield.Location = new System.Drawing.Point(321, 124);
            this.relRecYield.Name = "relRecYield";
            this.relRecYield.Padding = new System.Windows.Forms.Padding(2);
            this.relRecYield.Size = new System.Drawing.Size(55, 22);
            this.relRecYield.TabIndex = 5;
            this.relRecYield.Text = "label9";
            this.relRecYield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox.Location = new System.Drawing.Point(53, 149);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(592, 227);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 379);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label9.Size = new System.Drawing.Size(144, 43);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ingredients:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecIngr
            // 
            this.relRecIngr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecIngr.AutoSize = true;
            this.relRecIngr.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecIngr.Location = new System.Drawing.Point(318, 422);
            this.relRecIngr.Name = "relRecIngr";
            this.relRecIngr.Size = new System.Drawing.Size(61, 18);
            this.relRecIngr.TabIndex = 6;
            this.relRecIngr.Text = "label10";
            this.relRecIngr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Instructions:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecInstr
            // 
            this.relRecInstr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecInstr.AutoSize = true;
            this.relRecInstr.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecInstr.Location = new System.Drawing.Point(318, 463);
            this.relRecInstr.Name = "relRecInstr";
            this.relRecInstr.Size = new System.Drawing.Size(61, 18);
            this.relRecInstr.TabIndex = 7;
            this.relRecInstr.Text = "label11";
            this.relRecInstr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Notes:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecNotes
            // 
            this.relRecNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecNotes.AutoSize = true;
            this.relRecNotes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecNotes.Location = new System.Drawing.Point(318, 504);
            this.relRecNotes.Name = "relRecNotes";
            this.relRecNotes.Size = new System.Drawing.Size(61, 18);
            this.relRecNotes.TabIndex = 8;
            this.relRecNotes.Text = "label13";
            this.relRecNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(322, 522);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 14);
            this.label14.TabIndex = 9;
            this.label14.Text = "label14";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // relRecSource
            // 
            this.relRecSource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relRecSource.AutoSize = true;
            this.relRecSource.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relRecSource.Location = new System.Drawing.Point(314, 536);
            this.relRecSource.Name = "relRecSource";
            this.relRecSource.Size = new System.Drawing.Size(70, 16);
            this.relRecSource.TabIndex = 10;
            this.relRecSource.TabStop = true;
            this.relRecSource.Text = "linkLabel1";
            this.relRecSource.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.relRecSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.relRecSource_LinkClicked);
            // 
            // RecipeGridView
            // 
            this.RecipeGridView.AllowUserToAddRows = false;
            this.RecipeGridView.AllowUserToDeleteRows = false;
            this.RecipeGridView.AllowUserToResizeColumns = false;
            this.RecipeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.RecipeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RecipeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecipeGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecipeGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.RecipeGridView.GridColor = System.Drawing.Color.Thistle;
            this.RecipeGridView.Location = new System.Drawing.Point(31, 136);
            this.RecipeGridView.MultiSelect = false;
            this.RecipeGridView.Name = "RecipeGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipeGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.RecipeGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RecipeGridView.RowTemplate.Height = 25;
            this.RecipeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecipeGridView.Size = new System.Drawing.Size(505, 458);
            this.RecipeGridView.TabIndex = 1;
            this.RecipeGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeGridView_RowEnter);
            // 
            // ToRecipeCreationB
            // 
            this.ToRecipeCreationB.BackColor = System.Drawing.Color.Thistle;
            this.ToRecipeCreationB.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToRecipeCreationB.Location = new System.Drawing.Point(31, 16);
            this.ToRecipeCreationB.Name = "ToRecipeCreationB";
            this.ToRecipeCreationB.Size = new System.Drawing.Size(501, 93);
            this.ToRecipeCreationB.TabIndex = 0;
            this.ToRecipeCreationB.Text = "Create New Recipe";
            this.ToRecipeCreationB.UseVisualStyleBackColor = false;
            this.ToRecipeCreationB.Click += new System.EventHandler(this.ToRecipeCreationB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1314, 853);
            this.Controls.Add(this.recipeShowCasePanel);
            this.Controls.Add(this.recipeCreationPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.recipeCreationPanel.ResumeLayout(false);
            this.recipeCreationPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recYieldNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recTimeNumericUpDown)).EndInit();
            this.recipeShowCasePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YieldNumUpDown)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Button RecClearFieldsB;
        private Button CreateRecipeB;
        private OpenFileDialog openFileDialog1;
        private Panel recipeCreationPanel;
        private Button GoBackB;
        private Panel recipeShowCasePanel;
        private Button ToRecipeCreationB;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label20;
        private TextBox recNameTxtBox;
        private Label label21;
        private Button AddImageB;
        private Label label7;
        private CheckedListBox recTagsCheckedListBox;
        private Label label17;
        private ComboBox recMealCourseComboBox;
        private Label label18;
        private NumericUpDown recYieldNumericUpDown;
        private Label label19;
        private NumericUpDown recTimeNumericUpDown;
        private Label label16;
        private RichTextBox recIngrRichTxtBox;
        private Label label12;
        private RichTextBox recInstrucRichTxtBox;
        private Label label8;
        private RichTextBox recNotesRichTxtBox;
        private Label label6;
        private TextBox recSourceTxtBox;
        private DataGridView RecipeGridView;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label relRecName;
        private Label relRecMeal;
        private Label relRecTags;
        private Label relRecTime;
        private Label relRecYield;
        private PictureBox pictureBox;
        private Label relRecIngr;
        private Label relRecInstr;
        private Label relRecNotes;
        private Label label14;
        private LinkLabel relRecSource;
        private Button editRecB;
        private Button RecDeleteB;
        private Button FilterB;
        private Label label2;
        private NumericUpDown YieldNumUpDown;
        private Button ClearFiltersB;
        private TextBox RecSearchIngrsTxtBox;
        private TextBox RecSearchNamesTxtBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckedListBox RecSearchTagscheckedListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}