﻿using AnhDuyCompany.ManagerCompany.Validation;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.Login
{
    public class EmailActivationModel
    {
        private string _emailAddress;

        public bool IsEmailActivationDisabled { get; set; }

        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                _emailAddress = value;
                SetEmailActivationButtonStatus();
            }
        }

        private void SetEmailActivationButtonStatus()
        {
            IsEmailActivationDisabled = !ValidationHelper.IsEmail(EmailAddress);
        }
    }
}
