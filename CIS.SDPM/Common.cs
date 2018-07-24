using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CIS.SDPM
{
    class Common
    {
        public static String ApiToken = "";

        public static string GetConnectionString()
        {
            string value = "";
            try
            {
                value = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            }
            catch (Exception ex)
            {
                value = ex.Message;
            }

            return value;
        }

        public static string GetBaseUrl()
        {
            string value = "";
            try
            {
                value = ConfigurationManager.AppSettings.Get("urlBase");
            }
            catch (Exception ex)
            {
                value = ex.Message;
            }

            return value;
        }

        public static string GetEmail()
        {
            string value = "";
            try
            {
                value = ConfigurationManager.AppSettings.Get("email");
            }
            catch (Exception ex)
            {
                value = ex.Message;
            }

            return value;
        }

        public static string GetPassword()
        {
            string value = "";
            try
            {
                value = ConfigurationManager.AppSettings.Get("password");
            }
            catch (Exception ex)
            {
                value = ex.Message;
            }

            return value;
        }

        public static string GetAPIKey()
        {
            string value = "";
            try
            {
                value = ConfigurationManager.AppSettings.Get("apiKey");
            }
            catch (Exception ex)
            {
                value = ex.Message;
            }

            return value;
        }

    }
}
