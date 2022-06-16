using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Handbook
    {
        private List<Specialty> specialties;
        private List<Teacher> teachers;
        private List<Subject> subjects;

        public Handbook()
        {
            specialties = new List<Specialty>();
            teachers = new List<Teacher>();
            subjects = new List<Subject>();
        }

        // adding specialties
        public void AddSpecialty(Specialty specialty)
        {
            specialties.Add(specialty);
        }

        // adding teachers
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        // adding subjects
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        private void Display(IEnumerable<object> obj)
        {
            foreach (object objItem in obj) Console.WriteLine(objItem);
        }
        
        public void DisplaySpecialty()
        {
            Display(specialties);
        }

        public void DisplayTeacher()
        {
            Display(teachers);
        }

        public void DisplaySubject()
        {
            Display(subjects);
        }
        public void DisplaySubByName()
        {
            Display(subjects.OrderBy(elem=>elem.Name));
        }
        public void FindSubByTeachName(string teach)
        {
            Display(subjects.Where(elem => elem.Teacher == teach));
        }
        public void FindSubBySpecCode(int spec)
        {
            Display(subjects.Where(elem => elem.CodeOfSp == spec));
        }
    }
}
