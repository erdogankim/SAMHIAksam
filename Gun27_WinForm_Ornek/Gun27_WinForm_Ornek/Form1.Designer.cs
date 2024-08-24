namespace Gun27_WinForm_Ornek
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
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(23, 20);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(96, 20);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Kategori Adı:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(125, 17);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(307, 27);
            txtCategoryName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(125, 50);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(307, 138);
            txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 53);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Açıklama:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(125, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(307, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 235);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategoryName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnSave;
    }
}
