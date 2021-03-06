using System;
using Windows.ApplicationModel.Calls;

namespace Lotz.Xam.Messaging
{
    internal class PhoneCallTask : IPhoneCallTask
    {
        public PhoneCallTask()
        {
        }

        #region IPhoneCallTask Members

        public bool CanMakePhoneCall
        {
            get { return true; }
        }

        public void MakePhoneCall(string number, string name = null)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentNullException("number");

            if (CanMakePhoneCall)
                PhoneCallManager.ShowPhoneCallUI(number, name ?? "");
        }

        #endregion
    }
}