using AnhDuyCompany.ManagerCompany.Core.Dependency;
using AnhDuyCompany.ManagerCompany.Mobile.MAUI.Services.UI;

namespace AnhDuyCompany.ManagerCompany.Mobile.MAUI.Shared
{
    public abstract class ModalBase : ManagerCompanyComponentBase
    {
        protected ModalManagerService ModalManager { get; set; }

        public abstract string ModalId { get; }

        public ModalBase()
        {
            ModalManager = DependencyResolver.Resolve<ModalManagerService>();
        }

        public virtual async Task Show()
        {
            await ModalManager.Show(JS, ModalId);
            StateHasChanged();
        }

        public virtual async Task Hide()
        {
            await ModalManager.Hide(JS, ModalId);
        }
    }
}
