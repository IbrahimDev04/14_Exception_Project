using _14_Exception_Project.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exception_Project.Models
{
    internal class Person
    {
        private string _name;

        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set
            {
                if(CheckName(value)==true)
                {
                    _name = value;
                }
                
            }
        }

        public Person(string name)
        {
            Name = name.ToCapitalize();
        }

        public bool CheckName(string name)
        {
            if(name.Length<3 || name.Length > 25)
            {
                throw new WrongTypeException("Wrong size");
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    throw new WrongTypeException("Wrong name structure");
                }
            }
            return true;
        }
    }
}
