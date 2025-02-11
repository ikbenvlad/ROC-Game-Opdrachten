using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class User
    {
        public string name;
        public string age;
        public string address;
        public User(string aName, string anAge, string anAddress)
        {
            name = aName;
            age = anAge;
            address = anAddress;
        }
    }
}