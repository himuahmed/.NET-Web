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
    public partial class SearchByPriceRange : System.Web.UI.Page
    {
        MobileManager mobileManager = new MobileManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            showAllMobileInfo();
           
        }

        private void showAllMobileInfo()
        {
            Mobile mobile = new Mobile();
            MobileGrirdView.DataSource = mobileManager.getMobile();
            MobileGrirdView.DataBind();
        }

        protected void searchButtonId_Click(object sender, EventArgs e)
        {
            int price1 = Int32.Parse(price1Id.Value);
            int price2 = Int32.Parse(price2Id.Value);

            Mobile mobile = new Mobile(price1, price2);
            showAllMobileInfoByPrice(mobile);

        }

        private void showAllMobileInfoByPrice(Mobile mobile)
        {
            //Mobile mobile = new Mobile();
            MobileGrirdView.DataSource = mobileManager.getAllMobileByPrice(mobile);
            MobileGrirdView.DataBind();
        }
    }
}