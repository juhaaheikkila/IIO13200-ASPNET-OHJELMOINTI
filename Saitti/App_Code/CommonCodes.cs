using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAMK.IT.CommonCodes

{

    public static class CommonCodes
    {

        public static string AppSetting(string rstrSettingName)
        {
            string settingsValue = System.Configuration.ConfigurationManager.AppSettings[rstrSettingName];
            return settingsValue;
        }


    }

    public class Username
    {
        public string Name { get; set; }
        public Username()
        {
            //
            // TODO: Add constructor logic here
            //
            this.Name = CommonCodes.AppSetting("Username");

        }
    }

}