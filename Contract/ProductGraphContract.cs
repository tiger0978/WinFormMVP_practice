using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Model.Models;

namespace WinFormMVP練習.Contract
{
    interface IProductGraphView
    {
        void ProductGraphResponse(List<ProductSaleRecord> productSaleRecords);
    }
    interface IProductGraphPresenter
    {
        void GetProductGraph(string productName);

    }
}
