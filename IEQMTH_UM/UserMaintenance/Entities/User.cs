using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _fullName;

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
            
        }

        public User( string firstName, string lastName, string fullName)
        {
            ID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            _fullName = fullName;
        }
    }
}
