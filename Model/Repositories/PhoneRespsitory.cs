using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Model.Models;

namespace WinFormMVP練習.Model.Repository
{
    public class PhoneRespsitory
    {
        public Phone GetProduct(string Name)
        {
            switch (Name) 
            {
                case "IPhone":
                    return new Phone("IPhone", 25000, "iphone16");
                case "Samsung":
                    return new Phone("Samsung", 18000, "Samsung16");
                case "小米":
                    return new Phone("Rice", 18000, "RiceX");
            }
            return null;
        }
        public List<KeyValue> GetProductSerach()
        {
            var prodcutSerachs = new List<KeyValue>()
            {
                new KeyValue()
                {
                    Key= "IPhone",
                    Value = Guid.NewGuid()
                },
                new KeyValue()
                {
                    Key = "Samsung",
                    Value = Guid.NewGuid()
                },
                new KeyValue()
                {
                    Key = "小米",
                    Value = Guid.NewGuid()
                }
            };
            return prodcutSerachs;
        }
        public List<ProductSaleRecord> GetProductSaleRecord(string name)
        {
            switch (name)
            {
                case "IPhone":
                    return new List<ProductSaleRecord>()
                    {
                        new ProductSaleRecord()
                        {
                            name = "IPhone",
                            amount = 1,
                            price = 25000,
                            datetime = DateTime.Now
                        },
                        new ProductSaleRecord()
                        {
                            name = "IPhone",
                            amount = 2,
                            price = 50000,
                            datetime = DateTime.Now
                        },
                    };
                case "Samsung":
                    return new List<ProductSaleRecord>()
                    {
                        new ProductSaleRecord()
                        {
                            name = "Samsung",
                            amount = 1,
                            price = 18000,
                            datetime = DateTime.Now
                        },
                        new ProductSaleRecord()
                        {
                            name = "Samsung",
                            amount = 3,
                            price = 54000,
                            datetime = DateTime.Now
                        },
                    };
                case "小米":
                    return new List<ProductSaleRecord>()
                    {
                        new ProductSaleRecord()
                        {
                            name = "小米",
                            amount = 1,
                            price = 15000,
                            datetime = DateTime.Now
                        },
                        new ProductSaleRecord()
                        {
                            name = "小米",
                            amount = 2,
                            price = 30000,
                            datetime = DateTime.Now
                        },
                    };
            }
            return null;
        }
    }
}
