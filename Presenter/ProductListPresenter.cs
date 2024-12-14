using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Contract;
using WinFormMVP練習.Model.Repository;

namespace WinFormMVP練習.Presenter
{
    internal class ProductListPresenter : IProductListPresenter
    {
        IProductListView _prodcutListView;
        public ProductListPresenter(IProductListView prodcutListView) 
        {
            _prodcutListView = prodcutListView;
        }


        public void GetProductList(string productName)
        {
            var resp = new PhoneRespsitory();
            var productRecords = resp.GetProductSaleRecord(productName);
            _prodcutListView.ProductListResponse(productRecords);
        }

    }
}
