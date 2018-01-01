using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace TorrentDownloader
{
    class HttpClient
    {
        HttpWebRequest wReq;
        HttpWebResponse wRes;

        public HttpClient() { }

        public String GetHttpResponse(String url, String cookie)
        {
            try
            {
                Uri uri = new Uri(url);
                wReq = (HttpWebRequest)WebRequest.Create(uri);
                wReq.Method = "GET";
                wReq.CookieContainer = new CookieContainer();
                wReq.CookieContainer.SetCookies(uri, cookie);

                String resResult;

                using (wRes = (HttpWebResponse)wReq.GetResponse())
                {
                    Stream respPostStream = wRes.GetResponseStream();
                    StreamReader readerPost = new StreamReader(respPostStream, Encoding.GetEncoding("UTF-8"), true);

                    resResult = readerPost.ReadToEnd();
                }

                return resResult;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                {
                    HttpWebResponse resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }

                return null;
            }
        }

        public String PostHttpRequest(String url, String cookie, String data)
        {
            try
            {
                Uri uri = new Uri(url);
                wReq = (HttpWebRequest)WebRequest.Create(uri);
                wReq.Method = "POST";
                wReq.CookieContainer = new CookieContainer();
                wReq.CookieContainer.SetCookies(uri, cookie);

                byte[] byteArr = Encoding.UTF8.GetBytes(data);

                using (Stream dataStream = wReq.GetRequestStream()) {
                    dataStream.Write(byteArr, 0, byteArr.Length);
                }
                
                String resResult;

                using (wRes = (HttpWebResponse)wReq.GetResponse())
                {
                    Stream respPostStream = wRes.GetResponseStream();
                    StreamReader readerPost = new StreamReader(respPostStream, Encoding.GetEncoding("UTF-8"), true);

                    resResult = readerPost.ReadToEnd();
                }

                return resResult;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                {
                    HttpWebResponse resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }

                return null;
            }
        }
    }
}
