using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor_class_5.Crud
{
    internal class Operations
    {
        public (string _name, string _surname, string _password, int _age,
                            DateTime _birthday, string _email, string _phonenumber) GetUserInfo()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Birthday: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            string phonenumber = Console.ReadLine();

            return (email, password, surname, age, birthday, phonenumber, name);
        }

        public string RegisterUser(string _name, string _surname, string _password, int _age,
                            DateTime _birthday, string _email, string _phonenumber)
        {
            foreach (var item in Database.Users)
            {
                if (item.Email == _email)
                {
                    throw new Exception("This email using from another person");
                }
            }

            User usr = new User();
            usr.Name = _name;
            usr.Surname = _surname;
            usr.Username = $"{usr.Name}{usr.Surname}";
            usr.Email = _email;
            usr.Password = _password;
            usr.Age = _age;
            usr.PhoneNumber = _phonenumber;
            usr.BirthDay = _birthday;

            Roles Write = new Roles();
            Write.Name = "write";
            Roles Read = new Roles();
            Read.Name = "read";

            usr.userRoles.Add(Write);
            usr.userRoles.Add(Read);

            return "REgistration is successfuly";
        }
    }
}
