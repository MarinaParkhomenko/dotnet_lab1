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
                    FormOfControl[random.Next(0,2)], random.Next(1,5), 
                    Specialties_code[random.Next(0,2)], random.Next(1,4)));
            }

            string teach;
            int spec;
            int key = 1;
            while(key != 0)
            {
                Console.Clear();
                Console.Write("Menu:\n" +
                    "1. Show teachers\n" +
                    "2. Show specialties\n" +
                    "3. Show subjects\n" +
                    "4. Sort subjects by name\n" +
                    "5. Search subject by teacher's name\n" +
                    "6. Search subject by specialty code\n"
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
                        Console.WriteLine("Please input teacher's name:");
                        teach = Console.ReadLine();
                        handbook.FindSubByTeachName(teach);
                        break;
                    case 6:
                        Console.WriteLine("Please input specialty code:");
                        spec = Convert.ToInt32(Console.ReadLine());
                        handbook.FindSubBySpecCode(spec);
                        break;
                }
                Console.ReadKey();  









            }
        }
    }















}
