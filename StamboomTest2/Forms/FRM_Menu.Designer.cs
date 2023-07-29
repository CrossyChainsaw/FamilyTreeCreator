namespace StamboomTest2.Forms
{
    partial class FRM_Menu
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
            this.BTN_Create = new System.Windows.Forms.Button();
            this.FRM_View = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Create
            // 
            this.BTN_Create.Location = new System.Drawing.Point(3, 12);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(402, 212);
            this.BTN_Create.TabIndex = 0;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = true;
            this.BTN_Create.Click += new System.EventHandler(this.BTN_Create_Click);
            // 
            // FRM_View
            // 
            this.FRM_View.Location = new System.Drawing.Point(3, 230);
            this.FRM_View.Name = "FRM_View";
            this.FRM_View.Size = new System.Drawing.Size(785, 208);
            this.FRM_View.TabIndex = 1;
            this.FRM_View.Text = "View";
            this.FRM_View.UseVisualStyleBackColor = true;
            this.FRM_View.Click += new System.EventHandler(this.FRM_View_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Location = new System.Drawing.Point(411, 12);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(377, 212);
            this.BTN_Edit.TabIndex = 2;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Edit);
            this.Controls.Add(this.FRM_View);
            this.Controls.Add(this.BTN_Create);
            this.Name = "FRM_Menu";
            this.Text = "FRM_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTN_Create;
        private Button FRM_View;
        private Button BTN_Edit;
    }
}