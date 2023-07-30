namespace StamboomTest2.Forms
{
    partial class FRM_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Edit = new System.Windows.Forms.ComboBox();
            this.CB_Mother = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Father = new System.Windows.Forms.ComboBox();
            this.Father = new System.Windows.Forms.Label();
            this.CB_LastName = new System.Windows.Forms.ComboBox();
            this.CB_Spouse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Gender = new System.Windows.Forms.ComboBox();
            this.LBL_Gender = new System.Windows.Forms.Label();
            this.TB_DeathYear = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.Label();
            this.TB_YearOfBirth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.CB_ExSpouse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Person";
            // 
            // CB_Edit
            // 
            this.CB_Edit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_Edit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Edit.FormattingEnabled = true;
            this.CB_Edit.Location = new System.Drawing.Point(107, 6);
            this.CB_Edit.Name = "CB_Edit";
            this.CB_Edit.Size = new System.Drawing.Size(160, 23);
            this.CB_Edit.TabIndex = 1;
            this.CB_Edit.SelectedIndexChanged += new System.EventHandler(this.CB_Edit_SelectedIndexChanged);
            // 
            // CB_Mother
            // 
            this.CB_Mother.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Mother.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Mother.FormattingEnabled = true;
            this.CB_Mother.Location = new System.Drawing.Point(107, 267);
            this.CB_Mother.Name = "CB_Mother";
            this.CB_Mother.Size = new System.Drawing.Size(160, 23);
            this.CB_Mother.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Mother";
            // 
            // CB_Father
            // 
            this.CB_Father.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Father.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Father.FormattingEnabled = true;
            this.CB_Father.Location = new System.Drawing.Point(107, 238);
            this.CB_Father.Name = "CB_Father";
            this.CB_Father.Size = new System.Drawing.Size(160, 23);
            this.CB_Father.TabIndex = 28;
            // 
            // Father
            // 
            this.Father.AutoSize = true;
            this.Father.Location = new System.Drawing.Point(12, 238);
            this.Father.Name = "Father";
            this.Father.Size = new System.Drawing.Size(40, 15);
            this.Father.TabIndex = 34;
            this.Father.Text = "Father";
            // 
            // CB_LastName
            // 
            this.CB_LastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_LastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_LastName.FormattingEnabled = true;
            this.CB_LastName.Location = new System.Drawing.Point(107, 64);
            this.CB_LastName.Name = "CB_LastName";
            this.CB_LastName.Size = new System.Drawing.Size(160, 23);
            this.CB_LastName.TabIndex = 20;
            // 
            // CB_Spouse
            // 
            this.CB_Spouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Spouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Spouse.FormattingEnabled = true;
            this.CB_Spouse.Location = new System.Drawing.Point(107, 209);
            this.CB_Spouse.Name = "CB_Spouse";
            this.CB_Spouse.Size = new System.Drawing.Size(160, 23);
            this.CB_Spouse.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Spouse";
            // 
            // CB_Gender
            // 
            this.CB_Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Gender.FormattingEnabled = true;
            this.CB_Gender.Location = new System.Drawing.Point(107, 93);
            this.CB_Gender.Name = "CB_Gender";
            this.CB_Gender.Size = new System.Drawing.Size(160, 23);
            this.CB_Gender.TabIndex = 21;
            // 
            // LBL_Gender
            // 
            this.LBL_Gender.AutoSize = true;
            this.LBL_Gender.Location = new System.Drawing.Point(12, 93);
            this.LBL_Gender.Name = "LBL_Gender";
            this.LBL_Gender.Size = new System.Drawing.Size(45, 15);
            this.LBL_Gender.TabIndex = 32;
            this.LBL_Gender.Text = "Gender";
            // 
            // TB_DeathYear
            // 
            this.TB_DeathYear.Location = new System.Drawing.Point(107, 151);
            this.TB_DeathYear.Name = "TB_DeathYear";
            this.TB_DeathYear.PlaceholderText = "year of decease";
            this.TB_DeathYear.Size = new System.Drawing.Size(160, 23);
            this.TB_DeathYear.TabIndex = 25;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Location = new System.Drawing.Point(12, 151);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(89, 15);
            this.LB.TabIndex = 30;
            this.LB.Text = "Year of Decease";
            // 
            // TB_YearOfBirth
            // 
            this.TB_YearOfBirth.Location = new System.Drawing.Point(107, 122);
            this.TB_YearOfBirth.Name = "TB_YearOfBirth";
            this.TB_YearOfBirth.PlaceholderText = "year of birth";
            this.TB_YearOfBirth.Size = new System.Drawing.Size(160, 23);
            this.TB_YearOfBirth.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Year of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "First Name";
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(12, 306);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(255, 118);
            this.BTN_Edit.TabIndex = 31;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Location = new System.Drawing.Point(107, 35);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.PlaceholderText = "first name";
            this.TB_FirstName.Size = new System.Drawing.Size(160, 23);
            this.TB_FirstName.TabIndex = 19;
            // 
            // CB_ExSpouse
            // 
            this.CB_ExSpouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_ExSpouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ExSpouse.FormattingEnabled = true;
            this.CB_ExSpouse.Location = new System.Drawing.Point(107, 180);
            this.CB_ExSpouse.Name = "CB_ExSpouse";
            this.CB_ExSpouse.Size = new System.Drawing.Size(160, 23);
            this.CB_ExSpouse.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ex-Spouse";
            // 
            // FRM_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_ExSpouse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_Mother);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_Father);
            this.Controls.Add(this.Father);
            this.Controls.Add(this.CB_LastName);
            this.Controls.Add(this.CB_Spouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Gender);
            this.Controls.Add(this.LBL_Gender);
            this.Controls.Add(this.TB_DeathYear);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.TB_YearOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.TB_FirstName);
            this.Controls.Add(this.CB_Edit);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.FRM_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CB_Edit;
        private ComboBox CB_Mother;
        private Label label6;
        private ComboBox CB_Father;
        private Label Father;
        private ComboBox CB_LastName;
        private ComboBox CB_Spouse;
        private Label label4;
        private ComboBox CB_Gender;
        private Label LBL_Gender;
        private TextBox TB_DeathYear;
        private Label LB;
        private TextBox TB_YearOfBirth;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button BTN_Edit;
        private TextBox TB_FirstName;
        private ComboBox CB_ExSpouse;
        private Label label7;
    }
}