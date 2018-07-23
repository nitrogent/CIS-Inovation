using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CIS.SDPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TOKEN {0}", getToken());
            Console.ReadKey();
        }


        private static string getToken()
        {
            string strValue = "";
            string strBody = "";
            string BaseUrl = Common.GetBaseUrl() + "login";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BaseUrl);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers.Add("api-key", Common.GetAPIKey());
                strBody = "{\n\"email\":\"" + Common.GetEmail() + "\"\n,\"password\":\"" + Common.GetPassword() + "\"\n}";
                request.ContentLength = strBody.Length;


                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(strBody);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var temp = reader.ReadLine();
                    var jobj = JObject.Parse(temp);
                    strValue = jobj["api-token"].ToString();

                    Console.WriteLine("TOKEN : {0}", strValue);

                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            return strValue;
        }
    }
}
