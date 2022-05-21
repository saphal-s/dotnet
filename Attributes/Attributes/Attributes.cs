using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class AuthorAttribute: Attribute
    {
        private string _name;
        public AuthorAttribute(string name) 
        {
            _name = name;
        }
        public String Name => _name;
    }
}
