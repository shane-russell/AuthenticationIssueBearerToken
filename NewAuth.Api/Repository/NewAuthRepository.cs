using NewAuth.Api.Domain;
using System.Collections.Generic;
using System.Linq;

namespace NewAuth.Api.Repository
{
    public class NewAuthRepository : INewAuthRepository
    {
        private readonly NewAuthDbcontext _dbcontext;

        public NewAuthRepository(NewAuthDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        void INewAuthRepository.AddExampleDomainClass(ExampleDomainClass exampleDomainClass)
        {
            _dbcontext.Add(exampleDomainClass);
        }

        IList<ExampleDomainClass> INewAuthRepository.GetAllExampleDomainClasses()
        {
            return _dbcontext.ExampleDomainClasses.ToList();
        }
    }
}
