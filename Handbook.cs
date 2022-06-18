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

        public void Display(IEnumerable<object> obj)
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
        public void DisplaySubByAmHours()
        {
            Display(subjects.OrderBy(elem => elem.Hours));
        }
        public void DisplaySubByCourse()
        {
            Display(subjects.OrderBy(elem => elem.Course));
        }
        public void FindSubByTeachName(string teach)
        {
            Display(subjects.Where(elem => elem.Teacher == teach));
        }
        public void FindSubBySpecCode(int spec)
        {
            Display(subjects.Where(elem => elem.CodeOfSp == spec));
        }

        public void FindSubInRangeHours(int min, int max)
        {
            Display(subjects.Where(elem => elem.Hours >= min && elem.Hours <= max).OrderBy(elem => elem.Hours));
        }
        public void FindSubByCouese(int course)
        {
            Display(subjects.Where(elem => elem.Course == course));
        }
        public void FindSubBySkipping(int hours)
        {
            Display(subjects.OrderBy(elem => elem.Hours).SkipWhile(elem => (elem.Hours <= hours)));
        }
        public void SubectTeacherColl()
        {
            Display(
                from sub in subjects
                join teach in teachers
                on sub.Teacher equals teach.Name
                select new
                {
                    SubjectName = sub.Name, 
                    TeacherName = teach.Name
                }
                ) ;
        }
        public void SubectTeacherSpColl()
        {
            Display(
                from sub in subjects
                join teach in teachers
                on sub.Teacher equals teach.Name
                join sp in specialties
                on sub.CodeOfSp equals sp.Code
                select new
                {
                    SubjectName = sub.Name,
                    TeacherName = teach.Name,
                    SpecailtyName = sp.Name
                }
                );
        }

        public void DisplayGroup(IEnumerable<IGrouping<object, Subject>> group)
        {
            foreach (IGrouping<object, Subject> gr in group)
            {
                Console.WriteLine(gr.Key);
                foreach (var item in gr)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }

        public void GroupByTeacher()
        {
            DisplayGroup
                (
                from elem in subjects
                orderby elem.Name
                group elem by elem.Teacher
                );
        }

        public void GroupByFormOfCon()
        {
            DisplayGroup
                (
                from elem in subjects
                orderby elem.Name
                group elem by elem.FormOfControl
                );
        }
    }
}
