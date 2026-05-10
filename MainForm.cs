using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Gemini
{
    public partial class MainForm : Form
    {
        // The WebView2 control that completely bypasses standard browser restrictions
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;

        public MainForm()
        {
            InitializeComponent();
            InitializeGemini();
        }

        private async void InitializeGemini()
        {
            // Initialize the web view control programmatically for a clean, frameless canvas
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);

            // Define a secure, writable user data folder in AppData to store cookies and active sessions permanently.
            // This prevents UnauthorizedAccessException when installed in protected directories like C:\Program Files (x86).
            string userDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GeminiApp");

            // Initialize the environment using the customized user data path
            var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);

            // Ensure the underlying CoreWebView2 engine is fully initialized
            await webView.EnsureCoreWebView2Async(env);

            // Navigate directly to Google Gemini
            webView.CoreWebView2.Navigate("https://gemini.google.com/");
        }
    }
}