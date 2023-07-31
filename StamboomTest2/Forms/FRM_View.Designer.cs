namespace StamboomTest2.Forms
{
    partial class FRM_View
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
            this.CB_Persons = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Father = new System.Windows.Forms.TextBox();
            this.TB_Mother = new System.Windows.Forms.TextBox();
            this.TB_Gender = new System.Windows.Forms.TextBox();
            this.LBL_Gender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_LifeSpan = new System.Windows.Forms.TextBox();
            this.TB_Spouse = new System.Windows.Forms.TextBox();
            this.TB_ExSpouse = new System.Windows.Forms.TextBox();
            this.TB_Person = new System.Windows.Forms.TextBox();
            this.RTB_Children = new System.Windows.Forms.RichTextBox();
            this.RTB_Siblings = new System.Windows.Forms.RichTextBox();
            this.RTB_HalfSiblings = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_PaternalGrandfather = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_PaternalGrandmother = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_MaternalGrandmother = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_MaternalGrandfather = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RTB_ExChildren = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CB_Persons
            // 
            this.CB_Persons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Persons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Persons.FormattingEnabled = true;
            this.CB_Persons.Location = new System.Drawing.Point(73, 6);
            this.CB_Persons.Name = "CB_Persons";
            this.CB_Persons.Size = new System.Drawing.Size(148, 23);
            this.CB_Persons.TabIndex = 0;
            this.CB_Persons.SelectedIndexChanged += new System.EventHandler(this.CB_Persons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // TB_Father
            // 
            this.TB_Father.Location = new System.Drawing.Point(593, 280);
            this.TB_Father.Name = "TB_Father";
            this.TB_Father.PlaceholderText = "father";
            this.TB_Father.ReadOnly = true;
            this.TB_Father.Size = new System.Drawing.Size(148, 23);
            this.TB_Father.TabIndex = 4;
            // 
            // TB_Mother
            // 
            this.TB_Mother.Location = new System.Drawing.Point(901, 280);
            this.TB_Mother.Name = "TB_Mother";
            this.TB_Mother.PlaceholderText = "mother";
            this.TB_Mother.ReadOnly = true;
            this.TB_Mother.Size = new System.Drawing.Size(148, 23);
            this.TB_Mother.TabIndex = 5;
            // 
            // TB_Gender
            // 
            this.TB_Gender.Location = new System.Drawing.Point(278, 6);
            this.TB_Gender.Name = "TB_Gender";
            this.TB_Gender.PlaceholderText = "gender";
            this.TB_Gender.ReadOnly = true;
            this.TB_Gender.Size = new System.Drawing.Size(148, 23);
            this.TB_Gender.TabIndex = 6;
            // 
            // LBL_Gender
            // 
            this.LBL_Gender.AutoSize = true;
            this.LBL_Gender.Location = new System.Drawing.Point(227, 9);
            this.LBL_Gender.Name = "LBL_Gender";
            this.LBL_Gender.Size = new System.Drawing.Size(45, 15);
            this.LBL_Gender.TabIndex = 7;
            this.LBL_Gender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Life Span";
            // 
            // TB_LifeSpan
            // 
            this.TB_LifeSpan.Location = new System.Drawing.Point(493, 6);
            this.TB_LifeSpan.Name = "TB_LifeSpan";
            this.TB_LifeSpan.PlaceholderText = "lifespan";
            this.TB_LifeSpan.ReadOnly = true;
            this.TB_LifeSpan.Size = new System.Drawing.Size(148, 23);
            this.TB_LifeSpan.TabIndex = 9;
            // 
            // TB_Spouse
            // 
            this.TB_Spouse.Location = new System.Drawing.Point(901, 374);
            this.TB_Spouse.Name = "TB_Spouse";
            this.TB_Spouse.PlaceholderText = "spouse";
            this.TB_Spouse.ReadOnly = true;
            this.TB_Spouse.Size = new System.Drawing.Size(148, 23);
            this.TB_Spouse.TabIndex = 10;
            // 
            // TB_ExSpouse
            // 
            this.TB_ExSpouse.Location = new System.Drawing.Point(593, 374);
            this.TB_ExSpouse.Name = "TB_ExSpouse";
            this.TB_ExSpouse.PlaceholderText = "ex-spouse";
            this.TB_ExSpouse.ReadOnly = true;
            this.TB_ExSpouse.Size = new System.Drawing.Size(148, 23);
            this.TB_ExSpouse.TabIndex = 13;
            // 
            // TB_Person
            // 
            this.TB_Person.Location = new System.Drawing.Point(747, 374);
            this.TB_Person.Name = "TB_Person";
            this.TB_Person.PlaceholderText = "person";
            this.TB_Person.ReadOnly = true;
            this.TB_Person.Size = new System.Drawing.Size(148, 23);
            this.TB_Person.TabIndex = 14;
            // 
            // RTB_Children
            // 
            this.RTB_Children.Location = new System.Drawing.Point(813, 465);
            this.RTB_Children.Name = "RTB_Children";
            this.RTB_Children.ReadOnly = true;
            this.RTB_Children.Size = new System.Drawing.Size(148, 167);
            this.RTB_Children.TabIndex = 19;
            this.RTB_Children.Text = "";
            // 
            // RTB_Siblings
            // 
            this.RTB_Siblings.Location = new System.Drawing.Point(372, 374);
            this.RTB_Siblings.Name = "RTB_Siblings";
            this.RTB_Siblings.ReadOnly = true;
            this.RTB_Siblings.Size = new System.Drawing.Size(156, 167);
            this.RTB_Siblings.TabIndex = 21;
            this.RTB_Siblings.Text = "";
            // 
            // RTB_HalfSiblings
            // 
            this.RTB_HalfSiblings.Location = new System.Drawing.Point(210, 374);
            this.RTB_HalfSiblings.Name = "RTB_HalfSiblings";
            this.RTB_HalfSiblings.ReadOnly = true;
            this.RTB_HalfSiblings.Size = new System.Drawing.Size(156, 167);
            this.RTB_HalfSiblings.TabIndex = 23;
            this.RTB_HalfSiblings.Text = "";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(210, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Half Siblings";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(372, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Siblings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(593, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Father";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(901, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mother";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(901, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Spouse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(593, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ex-Spouse";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(813, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Children";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(518, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Paternal Grandfather";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_PaternalGrandfather
            // 
            this.TB_PaternalGrandfather.Location = new System.Drawing.Point(518, 236);
            this.TB_PaternalGrandfather.Name = "TB_PaternalGrandfather";
            this.TB_PaternalGrandfather.PlaceholderText = "paternal grandfather";
            this.TB_PaternalGrandfather.ReadOnly = true;
            this.TB_PaternalGrandfather.Size = new System.Drawing.Size(148, 23);
            this.TB_PaternalGrandfather.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(672, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Paternal Grandmother";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_PaternalGrandmother
            // 
            this.TB_PaternalGrandmother.Location = new System.Drawing.Point(672, 236);
            this.TB_PaternalGrandmother.Name = "TB_PaternalGrandmother";
            this.TB_PaternalGrandmother.PlaceholderText = "paternal grandmother";
            this.TB_PaternalGrandmother.ReadOnly = true;
            this.TB_PaternalGrandmother.Size = new System.Drawing.Size(148, 23);
            this.TB_PaternalGrandmother.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(980, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Maternal Grandmother";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_MaternalGrandmother
            // 
            this.TB_MaternalGrandmother.Location = new System.Drawing.Point(980, 236);
            this.TB_MaternalGrandmother.Name = "TB_MaternalGrandmother";
            this.TB_MaternalGrandmother.PlaceholderText = "maternal grandmother";
            this.TB_MaternalGrandmother.ReadOnly = true;
            this.TB_MaternalGrandmother.Size = new System.Drawing.Size(148, 23);
            this.TB_MaternalGrandmother.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(826, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Maternal Grandfather";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_MaternalGrandfather
            // 
            this.TB_MaternalGrandfather.Location = new System.Drawing.Point(826, 236);
            this.TB_MaternalGrandfather.Name = "TB_MaternalGrandfather";
            this.TB_MaternalGrandfather.PlaceholderText = "maternal grandfather";
            this.TB_MaternalGrandfather.ReadOnly = true;
            this.TB_MaternalGrandfather.Size = new System.Drawing.Size(148, 23);
            this.TB_MaternalGrandfather.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(659, 446);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 16);
            this.label15.TabIndex = 39;
            this.label15.Text = "Children";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RTB_ExChildren
            // 
            this.RTB_ExChildren.Location = new System.Drawing.Point(659, 465);
            this.RTB_ExChildren.Name = "RTB_ExChildren";
            this.RTB_ExChildren.ReadOnly = true;
            this.RTB_ExChildren.Size = new System.Drawing.Size(148, 167);
            this.RTB_ExChildren.TabIndex = 38;
            this.RTB_ExChildren.Text = "";
            // 
            // FRM_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 801);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.RTB_ExChildren);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TB_MaternalGrandmother);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TB_MaternalGrandfather);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_PaternalGrandmother);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TB_PaternalGrandfather);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RTB_HalfSiblings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RTB_Siblings);
            this.Controls.Add(this.RTB_Children);
            this.Controls.Add(this.TB_Person);
            this.Controls.Add(this.TB_ExSpouse);
            this.Controls.Add(this.TB_Spouse);
            this.Controls.Add(this.TB_LifeSpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_Gender);
            this.Controls.Add(this.TB_Gender);
            this.Controls.Add(this.TB_Mother);
            this.Controls.Add(this.TB_Father);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Persons);
            this.Name = "FRM_View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.FRM_View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CB_Persons;
        private Label label1;
        private TextBox TB_Father;
        private TextBox TB_Mother;
        private TextBox TB_Gender;
        private Label LBL_Gender;
        private Label label4;
        private TextBox TB_LifeSpan;
        private TextBox TB_Spouse;
        private TextBox TB_ExSpouse;
        private TextBox TB_Person;
        private RichTextBox RTB_Children;
        private Label label10;
        private RichTextBox RTB_Siblings;
        private RichTextBox RTB_HalfSiblings;
        private Label label9;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label11;
        private TextBox TB_PaternalGrandfather;
        private Label label12;
        private TextBox TB_PaternalGrandmother;
        private Label label13;
        private TextBox TB_MaternalGrandmother;
        private Label label14;
        private TextBox TB_MaternalGrandfather;
        private Label label15;
        private RichTextBox RTB_ExChildren;
    }
}