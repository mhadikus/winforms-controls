namespace WinFormsApp
{
    partial class Form
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
            this.myControl1 = new WinFormsControls.MyControl();
            this.SuspendLayout();
            // 
            // myControl1
            // 
            this.myControl1.BackColor = System.Drawing.Color.LawnGreen;
            this.myControl1.Location = new System.Drawing.Point(12, 21);
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(296, 105);
            this.myControl1.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myControl1);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsControls.MyControl myControl1;
    }
}

