using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Models
{
    internal class Test
    {
        private string[] Arr {  get;}
        public int Lenght => Arr.Length;
        
        public string this[int i]
        {
            get
            {
                return Arr[i];
            }
            set
            {
                if(value.Length<3 || value.Length>25) 
                {
                    throw new LenghtException("Sözün ölçüsü yanlışdır");
                }
                if(i >= Lenght)
                {
                    throw new IndexOutOfRangeException();
                }
                Arr[i] = value;
            }
        }

        public Test()
        {
            Arr = new string[5];
        }
    }
}
