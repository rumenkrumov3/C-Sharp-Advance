using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class Family
    {


        public Family()
        {
            Familyy = new List<Person>();
        }

        public List<Person> Familyy { get; set; }
        

        public void AddMember(Person person)
        {
            Familyy.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldestPerson = Familyy.OrderByDescending(x => x.Age).First();

            return oldestPerson;
        }
    }
}
