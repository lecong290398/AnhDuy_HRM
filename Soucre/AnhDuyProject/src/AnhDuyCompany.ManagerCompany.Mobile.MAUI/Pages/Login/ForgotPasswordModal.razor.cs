using Microsoft.AspNetCore.Components;
using AnhDuyCompany.ManagerCompany.Authorization.Accounts;
using AnhDuyCompany.ManagerCompany.Authorization.Accounts.Dto;
using AnhDuyCompany.ManagerCompany.Core.Dependency;
using AnhDuyCompany.ManagerCompany.Core.Threading;
using AnhDuyCompany.ManagerCompany.Mobile.MAUI.Models.Login;
using AnhDuyCompany.ManagerCompany.Mobile.MAUI.Shared;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Pages.Login
{
    public partial class ForgotPasswordModal : ModalBase
    {
        public override string ModalId => "forgot-password-modal";
       
        [Parameter] public EventCallback OnSave { get; set; }
        
        public ForgotPasswordModel forgotPasswordModel { get; set; } = new ForgotPasswordModel();

        private readonly IAccountAppService _accountAppService;

        public ForgotPasswordModal()
        {
            _accountAppService = DependencyResolver.Resolve<IAccountAppService>();
        }

        protected virtual async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                async () =>
                    await _accountAppService.SendPasswordResetCode(new SendPasswordResetCodeInput { EmailAddress = forgotPasswordModel.EmailAddress }),
                    async () =>
                    {
                        await OnSave.InvokeAsync();
                    }
                );
            });
        }

        protected virtual async Task Cancel()
        {
            await Hide();
        }
    }
}
