using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class WebView2Control : UserControl
    {
        public WebView2Control()
        {
            InitializeComponent();
        }

        public WebView2 WebView => WebView2;

        public CoreWebView2 CoreWebView => WebView2.CoreWebView2;

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool IsInitialized => WebView2.CoreWebView2 != null;

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public void Navigate(string url)
        {
            if (IsInitialized)
            {
                WebView2.CoreWebView2.Navigate(url);
            }
        }
    }
}
