using System;
using System.Collections.Generic;
using System.Text;

namespace XenonBrowser
{
    class UrlUtils
    {
        public static string ConvertUrlToRequest(string url)
        {
            string req = "";
            int startReqPos = 0;

            for (int i = 0; i < url.Length; i++)
            {
                if (url[i] == '=')
                {
                    startReqPos = i + 1;
                    break;
                }
            }

            if (startReqPos == 0)
                return url;

            for (int i = startReqPos; i < url.Length; i++)
            {
                if (url[i] == '+')
                    req = string.Concat(req, ' ');
                else
                    req = string.Concat(req, url[i]);
            }

            return req;
        }
        
        public static string ConvertRequestToUrl(string req)
        {
            string url = BrowserSettings.defaultSearchEngine + "search?q=";

            for (int i = 0; i < req.Length; i++)
            {
                if (char.IsWhiteSpace(req[i]))
                    url = string.Concat(url, "+");
                else
                    url = string.Concat(url, req[i]);
            }

            return url;
        }
    }

    static class BrowserSettings
    {
        public static string defaultSearchEngine = "https://www.google.ru/";    
    }


}
