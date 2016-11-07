using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebXmlService
{
    public class XmlServiseRepository:IRepository
    {
        public IEnumerable<Rate> GetDataRate()
        {
            string html = string.Empty;
            string url = @"http://www.nbrb.by/API/ExRates/Rates?onDate=2016-7-6&Periodicity=0";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            List<Rate> desializeObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Rate>>(html);

            return desializeObject;
        }


        public IEnumerable<Currency> GetDataCurrency()
        {
            string html = string.Empty;
            string url = @"http://www.nbrb.by/API/ExRates/Currencies";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            List<Currency> desializeObject = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Currency>>(html);

            return desializeObject;
        }
    }
}