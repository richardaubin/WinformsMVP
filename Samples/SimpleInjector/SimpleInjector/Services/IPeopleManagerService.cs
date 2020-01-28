using System.Collections.Generic;

namespace SimpleInjector.Services
{
    public interface IPeopleManagerService : IDisposable
    {
        IEnumerable<Person> GetPeople();
    }
}
