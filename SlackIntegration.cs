using System.Net;
using System.IO;

namespace SlackIntegration
{
    public class SlackBot
    {
        public int Send(string url, string data)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write("{\"text\":\"" + data + "\"}");
            }

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

            return (int)httpResponse.StatusCode;
        }
    }
}