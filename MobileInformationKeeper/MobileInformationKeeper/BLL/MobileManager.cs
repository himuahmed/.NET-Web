using MobileInformationKeeper.DAL;
using MobileInformationKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileInformationKeeper.BLL
{
    public class MobileManager
    {
        MobileGateway mobileGateway = new MobileGateway();
        public string storeMobileInfo(Mobile mobile)
        {
            Mobile aMobile = mobileGateway.getExistsMobile(mobile);
            if (aMobile != null)
            {
                return "Mobile already exists. Please enter unique Imei no";
            }

            bool isSaved = mobileGateway.saveMobile(mobile);

            if (isSaved)
            {
                return "Mobile Info saved successfully";
            }
            else
            {
                return "Save failed";
            }

        }

        public List<Mobile> getAllMobileByPrice(Mobile mobile)
        {
            return mobileGateway.getMobileByPrice(mobile);
        }
        public List<Mobile> getMobile()
        {
            return mobileGateway.getMobile();
        }
        public Mobile getMobileImei(Mobile mobile)
        {
            return mobileGateway.getMobileByImei(mobile);
        }
            

    }
}