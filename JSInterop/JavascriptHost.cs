using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JSInterop
{
    /// <summary>
    /// Handles JS events.
    /// The ObjectForScripting property of a WebBrowser instance should be set to an instance of this object.
    /// 
    /// To fire events, use the following snippet in the hosted Javascript code.
    /// 
    /// try 
    /// {
    /// 	window.external.TextSelected(startPos, endPos);
    /// } 
    /// catch(e) 
    /// {
    /// }
    /// 
    /// Also, make sure the following attributes are added to the deriving class.
    /// 
    /// [ComVisible(true)]
    /// [Guid(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)]
    /// 
    /// </summary>
    [ComVisible(true)]
    public class JavascriptHost
    {
        HtmlDocument _document;

        /// <summary>
        /// Creates an instance of JavascriptHost
        /// </summary>
        public JavascriptHost(HtmlDocument document)
        {
            _document = document;
        }

        /// <summary>
        /// Gets the HTML document for the javascript host
        /// </summary>
        public HtmlDocument Document
        {
            get { return _document; }
        }

        /// <summary>
        /// Invokes a Javascript function/script
        /// </summary>
        /// <param name="functionName">Name of function/script to invoke</param>
        /// <param name="args">Parameters to pass to the function/script</param>
        /// <returns>Return value of invoked function</returns>
        public object InvokeScript(String functionName, params object[] args)
        {
            object retVal = null;
            if (args.Length == 0)
            {
                retVal = _document.InvokeScript(functionName);
            }
            else
            {
                retVal = _document.InvokeScript(functionName, args);
            }

            return retVal;
        }

        /// <summary>
        /// Invokes a .NET event
        /// </summary>
        /// <param name="handler">Event to be invoked</param>
        /// <param name="args">Paramters to pass to the event</param>
        public void InvokeEvent(Delegate handler, params object[] args)
        {
            if (handler != null)
            {
                handler.DynamicInvoke(args);
            }
        }
    }
}
