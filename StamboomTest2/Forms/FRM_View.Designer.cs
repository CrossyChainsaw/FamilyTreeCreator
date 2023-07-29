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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Father = new System.Windows.Forms.TextBox();
            this.TB_Mother = new System.Windows.Forms.TextBox();
            this.TB_Gender = new System.Windows.Forms.TextBox();
            this.LBL_Gender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_LifeSpan = new System.Windows.Forms.TextBox();
            this.TB_Spouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Persons
            // 
            this.CB_Persons.FormattingEnabled = true;
            this.CB_Persons.Location = new System.Drawing.Point(56, 6);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Father";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mother";
            // 
            // TB_Father
            // 
            this.TB_Father.Location = new System.Drawing.Point(56, 64);
            this.TB_Father.Name = "TB_Father";
            this.TB_Father.PlaceholderText = "father";
            this.TB_Father.ReadOnly = true;
            this.TB_Father.Size = new System.Drawing.Size(148, 23);
            this.TB_Father.TabIndex = 4;
            // 
            // TB_Mother
            // 
            this.TB_Mother.Location = new System.Drawing.Point(56, 93);
            this.TB_Mother.Name = "TB_Mother";
            this.TB_Mother.PlaceholderText = "mother";
            this.TB_Mother.ReadOnly = true;
            this.TB_Mother.Size = new System.Drawing.Size(148, 23);
            this.TB_Mother.TabIndex = 5;
            // 
            // TB_Gender
            // 
            this.TB_Gender.Location = new System.Drawing.Point(261, 6);
            this.TB_Gender.Name = "TB_Gender";
            this.TB_Gender.PlaceholderText = "gender";
            this.TB_Gender.ReadOnly = true;
            this.TB_Gender.Size = new System.Drawing.Size(148, 23);
            this.TB_Gender.TabIndex = 6;
            // 
            // LBL_Gender
            // 
            this.LBL_Gender.AutoSize = true;
            this.LBL_Gender.Location = new System.Drawing.Point(210, 9);
            this.LBL_Gender.Name = "LBL_Gender";
            this.LBL_Gender.Size = new System.Drawing.Size(45, 15);
            this.LBL_Gender.TabIndex = 7;
            this.LBL_Gender.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Life Span";
            // 
            // TB_LifeSpan
            // 
            this.TB_LifeSpan.Location = new System.Drawing.Point(476, 6);
            this.TB_LifeSpan.Name = "TB_LifeSpan";
            this.TB_LifeSpan.PlaceholderText = "lifespan";
            this.TB_LifeSpan.ReadOnly = true;
            this.TB_LifeSpan.Size = new System.Drawing.Size(148, 23);
            this.TB_LifeSpan.TabIndex = 9;
            // 
            // TB_Spouse
            // 
            this.TB_Spouse.Location = new System.Drawing.Point(56, 35);
            this.TB_Spouse.Name = "TB_Spouse";
            this.TB_Spouse.PlaceholderText = "spouse";
            this.TB_Spouse.ReadOnly = true;
            this.TB_Spouse.Size = new System.Drawing.Size(148, 23);
            this.TB_Spouse.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Spouse";
            // 
            // FRM_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Spouse);
            this.Controls.Add(this.TB_LifeSpan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_Gender);
            this.Controls.Add(this.TB_Gender);
            this.Controls.Add(this.TB_Mother);
            this.Controls.Add(this.TB_Father);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label label3;
        private TextBox TB_Father;
        private TextBox TB_Mother;
        private TextBox TB_Gender;
        private Label LBL_Gender;
        private Label label4;
        private TextBox TB_LifeSpan;
        private TextBox TB_Spouse;
        private Label label5;
    }
}