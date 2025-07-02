using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_class_5.Crud
{
    internal class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDay { get; set; }

        public List<Roles> userRoles { get; set; } = new List<Roles>();

    }
}
