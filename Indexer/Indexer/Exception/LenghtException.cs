using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class LenghtException: Exception
    {
        public LenghtException(string message) : base(message) 
        { 
        }
    }
}
