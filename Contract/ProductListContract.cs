using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Model.Models;

namespace WinFormMVP練習.Contract
{
    interface IProductListView
    {
        void ProductListResponse(List<ProductSaleRecord> products);
    }
    interface IProductListPresenter
    {
        void GetProductList(string ProductName);
    }

}
