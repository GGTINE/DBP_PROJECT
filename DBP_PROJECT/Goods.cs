using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBP_PROJECT
{
    class Goods
    {
        private static Goods instance;
        public static Goods GetInstance()
        {
            if (instance == null)
                instance = new Goods();
            return instance;
        }
        public string name { get; set; }
        public string price { get; set; }
    }
}
