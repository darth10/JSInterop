using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JSInterop
{
    public partial class BrowserForm : Form
    {
        DocumentJavascriptHost _javascriptHost = null;

        public BrowserForm()
        {
            InitializeComponent();
            InitializeCustomComponent();
        }

        void InitializeCustomComponent()
        {
            ToogleSendUI(false);

            _btnInvoke.Click += new EventHandler(_btnInvoke_Click);
            Load += new EventHandler(BrowserForm_Load);
        }

        void ToogleSendUI(bool toEnable)
        {
            _btnInvoke.Enabled = toEnable;
            _txtToSend.Enabled = toEnable;
        }

        void BrowserForm_Load(object sender, EventArgs e)
        {
            // write file to temp location
            var documentContent = Properties.Resources.Document;
            var tempFile = Path.Combine(Path.GetTempPath(), "Document.html");
            File.WriteAllText(tempFile, documentContent);

            // open document
            _browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(_browser_DocumentCompleted);
            _browser.Navigate(tempFile);
        }

        void _btnInvoke_Click(object sender, EventArgs e)
        {
            _javascriptHost.JSFunction("Javascript function called from C#");
        }

        void _browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            _javascriptHost = new DocumentJavascriptHost(_browser.Document);
            _javascriptHost.OnJSEvent += new DocumentJavascriptHost.OnJSEventHandler(_javascriptHost_OnJSEvent);

            _browser.ObjectForScripting = _javascriptHost;

            // enable UI once page has loaded
            ToogleSendUI(true);

        }

        void _javascriptHost_OnJSEvent(object o)
        {
            MessageBox.Show("C# funtion called from from Javascript object: " + o.ToString());
        }
    }
}
