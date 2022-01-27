using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace XenonBrowser
{
    public class LifespanHandler : ILifeSpanHandler
    {
        //event that receive url popup
        public event Action<string> popup_request;


        bool ILifeSpanHandler.OnBeforePopup(IWebBrowser browserControl,
             IBrowser browser, IFrame frame, string targetUrl,
             string targetFrameName, WindowOpenDisposition targetDisposition,
             bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo,
             IBrowserSettings browserSettings, ref bool noJavascriptAccess,
             out IWebBrowser newBrowser)
        {
            // Get url popup
            popup_request?.Invoke(targetUrl);

            Console.WriteLine("OnBeforePopup");

            Program.form.Invoke(new MethodInvoker(delegate
            {
                Program.form.OpenNewTab(targetUrl);
            }));

            // Stop open popup
            newBrowser = null;
            return true;
        }

        bool ILifeSpanHandler.DoClose(IWebBrowser browserControl, IBrowser browser)
        { return false; }

        void ILifeSpanHandler.OnBeforeClose(IWebBrowser browserControl, IBrowser browser) { }

        void ILifeSpanHandler.OnAfterCreated(IWebBrowser browserControl, IBrowser browser) { }
    }

}
