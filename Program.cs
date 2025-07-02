using Mentor_class_5.Crud;
using System;

namespace Mentor_class_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            var info = operations.GetUserInfo();

            try
            {
                var successMessage = operations.RegisterUser(info._name, info._surname, info._password, info._age, info._birthday, info._email, info._phonenumber);
                Console.WriteLine(successMessage);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
