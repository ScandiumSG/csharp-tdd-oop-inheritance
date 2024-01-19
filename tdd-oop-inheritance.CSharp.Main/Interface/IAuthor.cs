using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main.Interface
{
    public interface IAuthor
    {
        string Name { get; set; }

        string Website { get; set; }

        string ContactInformation { get; set; }
    }
}
