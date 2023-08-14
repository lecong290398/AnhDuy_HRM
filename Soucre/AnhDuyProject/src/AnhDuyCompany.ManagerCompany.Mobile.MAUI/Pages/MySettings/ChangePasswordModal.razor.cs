using Microsoft.AspNetCore.Components;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Profile;
using AnhDuyCompany.ManagerCompany.Authorization.Users.Profile.Dto;
using AnhDuyCompany.ManagerCompany.Core.Dependency;
using AnhDuyCompany.ManagerCompany.Core.Threading;
using AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.Settings;
using AnhDuyCompany.ManagerCompany.Mobile.MAUI.Shared;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Pages.MySettings
{
    public partial class ChangePasswordModal : ModalBase
    {
        [Parameter] public EventCallback OnSave { get; set; }

        public override string ModalId => "change-password";

        public ChangePasswordModel ChangePasswordModel { get; set; } = new ChangePasswordModel();

        private readonly IProfileAppService _profileAppService;

        public ChangePasswordModal()
        {
            _profileAppService = DependencyResolver.Resolve<IProfileAppService>();
        }

        protected virtual async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(async () =>
                {
                    await _profileAppService.ChangePassword(new ChangePasswordInput
                    {
                        CurrentPassword = ChangePasswordModel.CurrentPassword,
                        NewPassword = ChangePasswordModel.NewPassword
                    });

                }, async () =>
                {
                    if (ChangePasswordModel.IsChangePasswordDisabled)
                    {
                        return;
                    }

                    await OnSave.InvokeAsync();
                });
            });
        }

        protected virtual async Task Cancel()
        {
            await Hide();
        }
    }
}
