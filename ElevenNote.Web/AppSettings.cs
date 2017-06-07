using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ElevenNote.Web
{
    public static class AppSettings
    {
        public static bool LoginEnabled = bool.Parse(ConfigurationManager.AppSettings["Site.Authentication.LoginEnabled"]);

        public static int PasswordRequiredLength =
            int.Parse(ConfigurationManager.AppSettings["Site.Authentication.PasswordSettings.RequiredLength"]);

        public static bool PasswordRequireNonLetterOrDigit = 
            bool.Parse(ConfigurationManager.AppSettings["Site.Authentication.PasswordSettings.RequireNonLetterOrDigit"]);

        public static bool PasswordRequireDigit = 
            bool.Parse(ConfigurationManager.AppSettings["Site.Authentication.PasswordSettings.RequireDigit"]);

        public static bool PasswordRequireLowercase = 
            bool.Parse(ConfigurationManager.AppSettings["Site.Authentication.PasswordSettings.RequireLowercase"]);

        public static bool PasswordRequireUppercase = 
            bool.Parse(ConfigurationManager.AppSettings["Site.Authentication.PasswordSettings.RequireUppercase"]);
    }
}