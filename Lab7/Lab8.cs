using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    using System;

    class UserLoginArray : GenericArray<string> 
    {
        public UserLoginArray(int size) : base(size) 
        {
        }

        public void RegisterUser(string login) 
        {
            Add(login); 
        }
    }

    class UserPasswordArray : GenericArray<string> 
    {
        public UserPasswordArray(int size) : base(size) 
        {
        }

        public void SetPassword(int index, string password) 
        {
            if (index >= 0 && index < GetLength())
            {
                array[index] = password;
            }
            else
            {
                //throw new IndexOutOfRangeException("Индекс находится вне диапазона");
            }
        }
    }

    class Lab8
    {
        static void Main()
        {
            UserLoginArray loginArray = new UserLoginArray(5); 
            loginArray.RegisterUser("Лол");
            loginArray.RegisterUser("Лилпоп");

            UserPasswordArray passwordArray = new UserPasswordArray(5); 
            passwordArray.SetPassword(0, "123456789");
            passwordArray.SetPassword(1, "987654321");
            //Console.WriteLine("8lab");
        }
    }

}
