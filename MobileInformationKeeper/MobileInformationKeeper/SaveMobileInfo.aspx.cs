using MobileInformationKeeper.BLL;
using MobileInformationKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileInformationKeeper
{
    public partial class SaveMobileInfo : System.Web.UI.Page
    {
        MobileManager mobileManager = new MobileManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string modelName = modelId.Value;
            string imei = imeiId.Value;
            int price = Int32.Parse(priceId.Value);

            Mobile mobile = new Mobile(modelName,imei,price);
            
            saveButtonLabel.Text = mobileManager.storeMobileInfo(mobile);
        }
    }
}