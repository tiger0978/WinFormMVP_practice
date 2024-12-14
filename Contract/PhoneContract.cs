using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormMVP練習.Model;

namespace WinFormMVP練習.Contract
{
    interface IPhoneView
    {
        void PhoneResponse(Phone phone);
    }

    interface IPhonePresenter
    {
        void GetPhone(string phoneName);
    }
}
