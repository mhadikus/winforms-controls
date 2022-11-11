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
            this.ExecuteScriptButton = new System.Windows.Forms.Button();
            this.WebView2Control = new WinFormsControls.WebView2Control();
            this.MyControl = new WinFormsControls.MyControl();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecuteScriptButton
            // 
            this.ExecuteScriptButton.Location = new System.Drawing.Point(336, 559);
            this.ExecuteScriptButton.Name = "ExecuteScriptButton";
            this.ExecuteScriptButton.Size = new System.Drawing.Size(112, 23);
            this.ExecuteScriptButton.TabIndex = 4;
            this.ExecuteScriptButton.Text = "Execute Script";
            this.ExecuteScriptButton.UseVisualStyleBackColor = true;
            this.ExecuteScriptButton.Click += new System.EventHandler(this.ExecuteScriptButton_Click);
            // 
            // WebView2Control
            // 
            this.WebView2Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebView2Control.Location = new System.Drawing.Point(336, 43);
            this.WebView2Control.Name = "WebView2Control";
            this.WebView2Control.Size = new System.Drawing.Size(518, 496);
            this.WebView2Control.TabIndex = 3;
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
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(336, 21);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(455, 20);
            this.UrlBox.TabIndex = 1;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(795, 19);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(57, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 603);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.ExecuteScriptButton);
            this.Controls.Add(this.WebView2Control);
            this.Controls.Add(this.MyControl);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsControls.MyControl MyControl;
        private WinFormsControls.WebView2Control WebView2Control;
        private System.Windows.Forms.Button ExecuteScriptButton;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button GoButton;
    }
}

