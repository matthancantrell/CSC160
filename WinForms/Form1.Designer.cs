namespace WinForms
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
            this.btn_pissboy = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_pissboy
            // 
            this.btn_pissboy.AccessibleName = "btn_pressIt";
            this.btn_pissboy.Location = new System.Drawing.Point(301, 205);
            this.btn_pissboy.Name = "btn_pissboy";
            this.btn_pissboy.Size = new System.Drawing.Size(182, 34);
            this.btn_pissboy.TabIndex = 0;
            this.btn_pissboy.Text = "Press It, Pissboy";
            this.btn_pissboy.UseVisualStyleBackColor = true;
            this.btn_pissboy.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AccessibleName = "lbl_title";
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(315, 76);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(146, 25);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Do It. I Dare You.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_pissboy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_pissboy;
        private Label lbl_title;
    }
}