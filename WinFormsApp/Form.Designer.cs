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
            this.MyControl = new WinFormsControls.MyControl();
            this.WebView2Control = new WinFormsControls.WebView2Control();
            this.SuspendLayout();
            // 
            // MyControl
            // 
            this.MyControl.BackColor = System.Drawing.Color.LawnGreen;
            this.MyControl.IsChecked = false;
            this.MyControl.Location = new System.Drawing.Point(12, 21);
            this.MyControl.Name = "MyControl";
            this.MyControl.Size = new System.Drawing.Size(289, 86);
            this.MyControl.TabIndex = 0;
            this.MyControl.TextBoxText = "Type here...";
            // 
            // WebView2Control
            // 
            this.WebView2Control.Location = new System.Drawing.Point(345, 21);
            this.WebView2Control.Name = "WebView2Control";
            this.WebView2Control.Size = new System.Drawing.Size(516, 495);
            this.WebView2Control.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 556);
            this.Controls.Add(this.WebView2Control);
            this.Controls.Add(this.MyControl);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsControls.MyControl MyControl;
        private WinFormsControls.WebView2Control WebView2Control;
    }
}

