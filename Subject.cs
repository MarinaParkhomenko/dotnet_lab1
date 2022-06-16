using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Subject
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string FormOfControl { get; set; }
        public decimal Hours { get; set; }
        public int CodeOfSp { get; set; }
        public int Course { get; set; }

        public Subject(string name, string teacher, string formofcontrol, decimal hours, int codeofsp, int course)
        {
            Name = name;
            Teacher = teacher;
            FormOfControl = formofcontrol;
            Hours = hours;
            CodeOfSp = codeofsp;
            Course = course;
        }

        public override string ToString() => $"Name: {Name}, teacher: {Teacher}, form of control: {FormOfControl}," +
            $"hours: {Hours}, code of specialty: {CodeOfSp}, course: {Course}";

    }
}
