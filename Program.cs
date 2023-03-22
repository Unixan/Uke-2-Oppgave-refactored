using Uke_2_Oppgave_refactored;
using Console = System.Console;

internal class Program
{
    public static Students students = new();

    public static void Main()
    {
        students.AddStudent(new Student("Heibert", 42, "Radiobilkjøring"));
        students.AddStudent(new Student("Bjarne", 32, "Radiobilkjøring"));
        students.AddStudent(new Student("Anne", 25, "Radiobilkjøring"));
        students.AddStudent(new Student("Kathrine", 52, "Fallskjermhopping"));
        students.AddStudent(new Student("Helene", 46, "Droneflyging"));
        Menu();
    }

    public static void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("************ Meny ************\n\n1: Se alle elever\n2: Filtrere elever etter kurs\n3: Avslutt\n\nSkriv et tall fra menyen og trykk enter");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Elever: \n");
                    students.ListNames();
                    Console.WriteLine();
                    Common.Pause();
                    continue;
                case "2":
                    Filter.FilterMenu(students);
                    break;
                case "3":
                    break;
                default:
                    Common.Pause("Du må velge et tall fra listen");
                    continue;
            }

            break;
        }
    }
}








