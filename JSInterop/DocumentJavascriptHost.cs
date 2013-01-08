using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JSInterop
{
    [ComVisible(true)]
    [Guid("b376301b-3542-4d25-9e2e-96c919b16767")]
    public class DocumentJavascriptHost : JavascriptHost, IDocument
    {
        public DocumentJavascriptHost(HtmlDocument document)
            : base(document)
        {
        }

        public delegate void OnJSEventHandler(Object o);
        public event OnJSEventHandler OnJSEvent;

        #region IDocument Members

        public void OnEvent(object o)
        {
            InvokeEvent(OnJSEvent, o);
        }

        public void JSFunction(string s)
        {
            InvokeScript("jsFunction", s);
        }

        #endregion
    }
}
