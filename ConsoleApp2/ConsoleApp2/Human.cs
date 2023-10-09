using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Human 
    {

        public string Name;
        public string Surname;
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    this._age= value;
                }
            }
        }

    }
}
