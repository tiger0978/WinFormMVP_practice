using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Contract;
using WinFormMVP練習.Model.Repository;

namespace WinFormMVP練習.Presenter
{
    internal class ProductSearchPresenter : IProductSearchPresenter
    {
        IProdcutSearchView _prodcutSearchView;


        public ProductSearchPresenter(IProdcutSearchView prodcutSearchView)
        {
            _prodcutSearchView = prodcutSearchView;
        }


        public void GetProductSerach()
        {
            var resp = new PhoneRespsitory();
            var productSerachs = resp.GetProductSerach();
            _prodcutSearchView.ProductResponse(productSerachs);
        }
    }
}
