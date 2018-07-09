using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCalories
{
    class User
    {
        private string login;
        private string password;
        private int age;
        private int height;
        private int lifeStyle;
        private string allergens;

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int LifeStyle
        {
            get { return this.lifeStyle; }
            set { this.lifeStyle = value; }
        }

        public string Allergens
        {
            get { return this.allergens; }
            set { this.allergens = value; }
        }

        public User(string login, string passwd, int age, int height, int lifeStyle, string allergens )
        {
            this.Login = login;
            this.Password = passwd;
            this.Age = age;
            this.Height = height;
            this.LifeStyle = lifeStyle;
            this.Allergens = allergens;
        }
    }
}
