using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main.Interface;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author : IAuthor
    {
        public string Name { get; set; }
        public string Website { get; set; }
        public string ContactInformation { get; set; }
    }
}
