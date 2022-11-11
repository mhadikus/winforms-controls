﻿using System;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await WebView2Control.WebView.EnsureCoreWebView2Async(null);
            WebView2Control.CoreWebView.Navigate(@"https://www.google.com");
        }

        private void ExecuteScriptButton_Click(object sender, EventArgs e)
        {
            string htmlContent = "<body>Test executing JavaScript</body>";
            WebView2Control.WebView.NavigateToString(htmlContent);
            WebView2Control.WebView.NavigationCompleted += ExecuteScriptButton_NavigationCompleted;
        }

        private void ExecuteScriptButton_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            WebView2Control.WebView.NavigationCompleted -= ExecuteScriptButton_NavigationCompleted;
            ExecuteScriptAsync();
        }

        private async Task<string> ExecuteScriptAsync()
        {
            var result = await WebView2Control.CoreWebView.ExecuteScriptAsync("alert('Executing JavaScript!')");
            return result;
        }
    }
}
