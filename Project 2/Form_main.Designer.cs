namespace Project_2
{
    partial class Form_main
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
            this.button_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(236, 31);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 0;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 265);
            this.Controls.Add(this.button_logout);
            this.Name = "Form_main";
            this.Text = "Student Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
    }
}