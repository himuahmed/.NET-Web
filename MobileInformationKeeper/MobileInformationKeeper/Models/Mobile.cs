using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileInformationKeeper.Models
{
    public class Mobile
    {
        public int  MobileId {set;get;}
        public string ModelName { set; get; }
        public string Imei { set; get; }
        public int Price { set; get; }

        public int Price1 { set; get; }
        public int Price2 { set; get; }

        public Mobile()
        {
        }
        public Mobile(string modelName, string imei, int price)
        {
            ModelName = modelName;
            Imei = imei;
            Price = price;
        }

        public Mobile(int price1, int price2)
        {
            Price1 = price1;
            Price2 = price2;
        }

        public Mobile(string imei)
        {
            Imei = imei;
        }
    }
}