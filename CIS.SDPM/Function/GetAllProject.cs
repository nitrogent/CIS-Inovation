using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace CIS.SDPM.Function
{
    class GetAllProject
    {
        public static string GetAllProjects(string apiToken)
        {
            string result = "";
            string BaseUrl = Common.GetBaseUrl() + "projects?fields=all";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BaseUrl);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers.Add("api-key", Common.GetAPIKey());
                request.Headers.Add("api-token", apiToken);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var temp = reader.ReadLine();
                    //Untuk mengambil data yang bersifat Array jika hasil dari Postman terdapat [{...}]
                    var jobj = JArray.Parse(temp);
                    /*
                     * Ambil lebih spesifikasinya, jika Array maka gunakan looping
                     * Untuk mengambil data pertama harus variable[index][Column], 
                     * jika ingin mengambil lebih jauh seperti ambil description / comments contoh =  jObj[0]["description"][0] dst
                    */
                    result = jobj[0]["title"].ToString();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            return result;
        }
    }
}
