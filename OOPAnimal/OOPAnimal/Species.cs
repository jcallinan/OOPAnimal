using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    enum EyeColor
    {
        yellow, redBrown, blue
    }
    class Species : Genus
    {
        public string binomialName;
        public int numberOfLegs;
        public List<EyeColor> eyeColors;
        public Species()
        {
            Name = "No name";
        }
        public Species(string _name)
        {

            if (_name is null || _name.Length < 1)
            {
                Name = "No name";
            } else { 
            Name = _name.Replace(";","");
            }
            Console.WriteLine("Creating: " + _name + " at " + DateTime.Now.ToString("yyyy-MM-dd"));

        }
        public Species(string _name, string _binomialName) : this(_name)
        {
            if (_binomialName is null || _binomialName.Length < 1)
            {
                binomialName = "No name";
            }
            else
            {
                binomialName = _binomialName.Replace(";", "");
            }
            
        }
        public Species(string _name, int _numberOfLegs) : this(_name)
        {
            numberOfLegs = _numberOfLegs;
            
        }

    }
}
