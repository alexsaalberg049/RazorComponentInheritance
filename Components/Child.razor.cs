using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorComponentInheritance.Components
{
    public partial class Child : Parent
    {
        public void Exclame()
        {
            Word = Word + "!";
        }
    }
}
