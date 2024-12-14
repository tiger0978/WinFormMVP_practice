using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMVP練習.Model.Models
{
    public class ProductSaleRecord
    {
        public string name { get; set; }
        public int amount { get; set; }
        public int price { get; set; }
        public DateTime datetime { get; set; }
    }
}
