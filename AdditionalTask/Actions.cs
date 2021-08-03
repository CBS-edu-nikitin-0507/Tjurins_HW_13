using System;

namespace AdditionalTask
{
    public class Actions
    {
        public void PrintUserInfo(User user)
        {
           Console.Write("User name: "+user.Name);
           Console.Write("\nUser surname: "+user.Surname);
           Console.Write("\nUser age: "+user.Age);
           Console.Write("\nUser login: "+user.Login);
           Console.Write("\nBlank creation time: "+user.CreationDate);
        }
    }
}