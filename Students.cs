﻿namespace Uke_2_Oppgave_refactored
{
    internal class Students
    {
        private readonly List<Student> _students;

        public Students()
        {
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void ListNames()
        {
            foreach (var student in _students)
            {
                student.GetName();
            }
        }
        public string[] GetFilterList()
        {
            var temp = new List<string>();
            foreach (var student in _students.Where(student => !temp.Contains(student.GetCourse())))
            {
                temp.Add(student.GetCourse());
            }
            return temp.ToArray();
        }

        public void GetFilterCourse(string selection)
        {
            foreach (var student in _students.Where(student => student.GetCourse() == selection))
            {
                student.WriteCourse();
            }
        }

       
    }
    
}
