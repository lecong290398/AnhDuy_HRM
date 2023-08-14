using AnhDuyCompany.ManagerCompany.Auditing;
using AnhDuyCompany.ManagerCompany.Test.Base;
using Shouldly;
using Xunit;

namespace AnhDuyCompany.ManagerCompany.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("AnhDuyCompany.ManagerCompany.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("AnhDuyCompany.ManagerCompany.Auditing.GenericEntityService`1[[AnhDuyCompany.ManagerCompany.Storage.BinaryObject, AnhDuyCompany.ManagerCompany.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("AnhDuyCompany.ManagerCompany.Auditing.XEntityService`1[AnhDuyCompany.ManagerCompany.Auditing.AService`5[[AnhDuyCompany.ManagerCompany.Storage.BinaryObject, AnhDuyCompany.ManagerCompany.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[AnhDuyCompany.ManagerCompany.Storage.TestObject, AnhDuyCompany.ManagerCompany.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
