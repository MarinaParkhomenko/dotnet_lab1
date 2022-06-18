using System;
using System.Collections.Generic;

namespace lab1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Handbook handbook = new Handbook();
            Random random = new Random();

            //creating teachers
            List<string> Teachers = new List<string>()
            {
                "Proskura",
                "Novikova",
                "Halus",
                "Bogdanova"
            };

            foreach (string teacher in Teachers)
            {
                handbook.AddTeacher(new Teacher(teacher));
            }

            //creating specialties
            List<string> Specialties_name = new List<string>()
            {
                "software development",
                "information systems"
            };

            List<int> Specialties_code = new List<int>()
            {
                121,
                126
            };
            for(int i = 0; i < Specialties_name.Count; i++)
            {
                handbook.AddSpecialty(new Specialty(Specialties_name[i], Specialties_code[i]));
            }

            //creating subjects
            List<string> Subjects_name = new List<string>()
            {
                ".net",
                "web",
                "ipz",
                "pis",
                "bd",
                "algebra"
            };

            List<string> FormOfControl = new List<string>()
            {
                "exam",
                "not exam"
            };

            foreach(string subject in Subjects_name)
            {
                handbook.AddSubject(new Subject(subject, Teachers[random.Next(0,4)], 
                    FormOfControl[random.Next(0,2)], random.Next(10, 45), 
                    Specialties_code[random.Next(0,2)], random.Next(1,4)));
            }

            string teach;
            int spec, min, max, course, hours;
            int key = 1;
            while(key != 0)
            {
                Console.Clear();
                Console.Write("Menu:\n" +
                    "1. Show teachers\n" +
                    "2. Show specialties\n" +
                    "3. Show subjects\n" +
                    "4. Sort subjects by name\n" +
                    "5. Sort subjects by amount of hours\n" +
                    "6. Sort subjects by course\n" +
                    "7. Search subject by teacher's name\n" +
                    "8. Search subject by specialty code\n" +
                    "9. Search subjects in range of hours\n" +
                    "10. Search subjects by course\n" +
                    "11. Search subjects by hours and skip that are less\n" +
                    "12. Group by teacher\n" +
                    "13. Group by specialty\n" +
                    "14. Subject-teacher collection\n" +
                    "15. Subject-teacher-speailty colection\n"
                    );
                key = Convert.ToInt32(Console.ReadLine());

                switch(key)
                {
                    case 1:
                        handbook.DisplayTeacher();
                        break;
                    case 2:
                        handbook.DisplaySpecialty();
                        break;
                    case 3:
                        handbook.DisplaySubject();
                        break;
                    case 4:
                        handbook.DisplaySubByName();
                        break;
                    case 5:
                        handbook.DisplaySubByAmHours();
                        break;
                    case 6:
                        handbook.DisplaySubByCourse();
                        break;
                    case 7:
                        Console.WriteLine("Please input teacher's name:");
                        teach = Console.ReadLine();
                        handbook.FindSubByTeachName(teach);
                        break;
                    case 8:
                        Console.WriteLine("Please input specialty code:");
                        spec = Convert.ToInt32(Console.ReadLine());
                        handbook.FindSubBySpecCode(spec);
                        break;
                    case 9:
                        Console.WriteLine("Please input min value: ");
                        min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please input max value: ");
                        max = Convert.ToInt32(Console.ReadLine());
                        if (min > 0 && max < 100) handbook.FindSubInRangeHours(min, max);
                        else Console.WriteLine("Invalid input");
                        break;
                    case 10:
                        Console.WriteLine("Please input the number of the course: ");
                        course = Convert.ToInt32(Console.ReadLine());
                        if (course >= 1 && course <= 4) handbook.FindSubByCouese(course);
                        else Console.WriteLine("Invalid input");
                        break;
                    case 11:
                        Console.WriteLine("Please input the number of hours: ");
                        hours = Convert.ToInt32(Console.ReadLine());
                        if (hours > 0 && hours < 100) handbook.FindSubBySkipping(hours);
                        else Console.WriteLine("Invalid input");
                        break;
                    case 12:
                        handbook.GroupByTeacher();
                        break;
                    case 13:
                        handbook.GroupByFormOfCon();
                        break;
                    case 14:
                        handbook.SubectTeacherColl();
                        break;
                    case 15:
                        handbook.SubectTeacherSpColl();
                        break;
                }
                Console.ReadKey();  









            }
        }
    }















}
