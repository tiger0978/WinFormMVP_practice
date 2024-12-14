using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Contract;
using WinFormMVP練習.Model;
using WinFormMVP練習.Model.Repository;

namespace WinFormMVP練習.Presenter
{
    internal class PhonePresenter : IPhonePresenter
    {
        IPhoneView view;
        public PhonePresenter(IPhoneView view) {
            this.view = view;
        }
        public void GetPhone(string phoneName)
        {
            var repo = new PhoneRespsitory();
            Phone phone = repo.GetProduct(phoneName);
            this.view.PhoneResponse(phone);
        }
    }
}
