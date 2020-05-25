using System;
using System.Collections;
using System.Collections.Generic;
namespace Zadani_5
{
    class Program
    {
        public class Student
        {
            public string id;
            public string fio;
            public string group;
            public string birthDate;
        }

        static List<Student> studentList = new List<Student>();

        static void AddStudent(string id, string fio, string group, string birthDate)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        static void DelStudent(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        static void ChangeStudent(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].birthDate = birthDate;
                    studentList[i].group = group;
                }
            }

        }

        static void ShowStudent()
        {

            foreach (var e in studentList)
            {
                Console.WriteLine(e.id + " - " + e.fio + " - " + e.birthDate + " - " + e.group);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student first = new Student();

            AddStudent("1567", "Лорд Геннадий Байрон", "11.08.2000", "ISIP");
            AddStudent("1668", "Салтыков Дмитрий Гюгов", "23.11.1999", "ASAP");
            AddStudent("2208", "Лермонтов Степан Халтурин", "07.02.1999", "ACAB");
            ShowStudent();
            ChangeStudent("1668", "Платон Оруэлл Гёте", "23.11.1999", "ASAP");
            ShowStudent();
            DelStudent("1567");
            ShowStudent();
        }
    }
}
