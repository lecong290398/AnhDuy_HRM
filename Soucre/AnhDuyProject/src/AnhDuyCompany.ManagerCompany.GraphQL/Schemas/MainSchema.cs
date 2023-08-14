using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using AnhDuyCompany.ManagerCompany.Queries.Container;
using System;

namespace AnhDuyCompany.ManagerCompany.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}