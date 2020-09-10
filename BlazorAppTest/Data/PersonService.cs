using Bogus;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTest.Data
{
    public class PersonService
    {
        public Task<Person[]> GetPersonDataAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Person("en", rng.Next(-50, 50))).ToArray());
        }
    }
}
