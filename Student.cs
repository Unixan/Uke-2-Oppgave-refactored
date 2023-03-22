namespace Uke_2_Oppgave_refactored
{
    internal class Student
    {
        private readonly string _name;
        private readonly int _age;
        private readonly string _course;

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
