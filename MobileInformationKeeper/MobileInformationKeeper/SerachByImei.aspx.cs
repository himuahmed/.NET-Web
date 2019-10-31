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
    public partial class SerachByImei : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton2Id_Click(object sender, EventArgs e)
        {
            string imeiID1 = ImeiId1.Value;

            Mobile mobile = new Mobile(imeiID1);
            MobileManager mobileManager = new MobileManager();
            Mobile newMobile =  mobileManager.getMobileImei(mobile);

            NameLabel.Text = newMobile.ModelName;
            ImeiLabelLabel2.Text = newMobile.Imei;
            PriceLabel.Text = newMobile.Price.ToString();

        }
    }
}