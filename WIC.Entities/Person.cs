using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIC.Entities
{
    /// <summary>
    /// Base class for all program participants.
    /// </summary>
    public abstract class Person
    {
        public Guid ID { private set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { set; get; }

        public Person(string firstName, string lastName, DateTime dob, string gender)
        {
            ID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateOfBirth;
            Gender = gender;
        }
        
    }
}
