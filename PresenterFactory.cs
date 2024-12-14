using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMVP練習
{
    public class PresenterFactory : IPresenterFactory
    {
        public TPresenter CreatePresneter<TPresenter, TView>(TView view)
            where TPresenter : class
            where TView : class
        {
            var constructor = typeof(TPresenter).GetConstructor(new Type[] { typeof(TView) });
            if (constructor == null)
            {
                throw new InvalidOperationException($"Presenter {typeof(TPresenter).Name} 必須有一個接受 {typeof(TView).Name} 的建構函式。");
            }
            var presenter = (TPresenter)constructor.Invoke(new object[] { view });
            return presenter;
        }
    }
}
