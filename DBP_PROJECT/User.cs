using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_PROJECT
{
    class User
    {
        private static User instance;
        public static User GetInstance()
        {
            if (instance == null)
                instance = new User();
            return instance;
        }
        public string ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
