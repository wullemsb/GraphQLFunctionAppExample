using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLFunctionApp
{
    public class Query
    {
        public Person GetPerson() => new Person("Luke Skywalker");
    }

    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

}
