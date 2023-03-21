namespace Uke_2_Oppgave_refactored
{
    internal class Student
    {
        private string _name;
        private int _age;
        private string _course;

        public Student(string name, int age, string course)
        {
            _name = name;
            _age = age;
            _course = course;
        }

        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public string GetCourse()
        {
            return _course;
        }

        public void WriteCourse()
        {
            Console.WriteLine($"Navn: {_name}\nAlder: {_age}\nKurs: {_course}\n\n");
        }
    }
}
