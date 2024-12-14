using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMVP練習
{
    internal interface IPresenterFactory
    {
        TPresenter CreatePresneter<TPresenter, TView>(TView view) 
            where TPresenter:class 
            where TView : class;
    }
}
