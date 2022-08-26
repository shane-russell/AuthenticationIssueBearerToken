using NewAuth.Api.Domain;
using System.Collections.Generic;

namespace NewAuth.Api.Repository
{
    public interface INewAuthRepository
    {
        void AddExampleDomainClass(ExampleDomainClass exampleDomainClass);
        IList<ExampleDomainClass> GetAllExampleDomainClasses();
    }
}
