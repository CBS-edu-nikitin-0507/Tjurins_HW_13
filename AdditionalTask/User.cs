using System;

namespace AdditionalTask
{
    public class User
    {
        private string _login;
        private string _name;
        private string _surname;
        private int _age;
        private string _creationDate;

        public string Login
        {
            get { return _login;}
            set { _login = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string CreationDate => _creationDate;
        public User()
        {
            this._creationDate = Convert.ToString(DateTime.Now);
        }
    }
}