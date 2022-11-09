namespace WinFormsControls
{
    partial class MyControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(22, 61);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(78, 17);
            this.CheckBox.TabIndex = 0;
            this.CheckBox.Text = "Check Box";
            this.CheckBox.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(22, 24);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(194, 20);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "Type here...";
            this.TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.CheckBox);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(296, 105);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.TextBox TextBox;
    }
}
