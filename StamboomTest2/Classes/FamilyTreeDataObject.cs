using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StamboomTest2.Classes
{
    internal class FamilyTreeDataObject
    {
        public List<Person> Persons = new List<Person>();
        public FamilyTreeDataObject(List<Person> p)
        {
            Persons = p;
        }
    }
}
