using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Services.Services
{
    public class ExampleService : IExampleService
    {
        public string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
