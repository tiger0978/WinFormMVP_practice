using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Contract;
using WinFormMVP練習.Model.Repository;

namespace WinFormMVP練習.Presenter
{
    internal class ProductChartPresenter : IProductGraphPresenter
    {
        IProductGraphView _prodcutGraphView;
        public ProductChartPresenter(IProductGraphView prodcutGraphView) 
        {
            _prodcutGraphView = prodcutGraphView;
        }

        public void GetProductGraph(string productName)
        {
            var resp = new PhoneRespsitory();
            var productSaleRecords = resp.GetProductSaleRecord(productName);
            _prodcutGraphView.ProductGraphResponse(productSaleRecords);
        }
    }
}
