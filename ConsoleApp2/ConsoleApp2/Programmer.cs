using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Programmer : Human
    {

        public string Speciality;
        private double _experience;

        public double Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0)
                {
                    this._experience = value;
                }
            }
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"{Name} -> {Surname} -> {Age} -> {Speciality} -> {Experience}");
        }

        public string GetFullInfo()
        {
            return $"name:{Name} , surname:{Surname} , age:{Age} , speciality:{Speciality} , experience: {Experience}";
        }
    }
}
