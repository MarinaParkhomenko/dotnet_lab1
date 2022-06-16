using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Specialty
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Specialty(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString() => $"Name: {Name}, code: {Code}";
    }
}
