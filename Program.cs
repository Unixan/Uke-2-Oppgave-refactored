using Uke_2_Oppgave_refactored;

internal class Program
{
    public static void Main(string[] args)
    {
        var students = new Students();
        students.AddStudent(new Student("Heibert", 42, "Radiobilkjøring"));
        students.AddStudent(new Student("Bjarne", 32, "Radiobilkjøring"));
        students.AddStudent(new Student("Anne", 25, "Radiobilkjøring"));
        students.AddStudent(new Student("Kathrine", 52, "Fallskjermhopping"));
        students.AddStudent(new Student("Helene", 46, "Droneflyging"));
        Menu();

        void Menu()
        {
            Console.Clear();
            Console.WriteLine("************ Meny ************\n\n1: Se alle elever\n2: Filtrere elever etter kurs\n3: Avslutt\n\nSkriv et tall fra menyen og trykk enter");
            string choice = Console.ReadLine();
            MakeChoice(choice);

            void MakeChoice(string choice)
            {
                switch (choice)
                {


                    case "1":
                        {
                            Console.Clear();
                            students.ListNames();
                            Pause();
                            Menu();
                            break;
                        }
                    case "2":
                        {
                            FilterMenu(students);
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    default:
                        {
                            Menu();
                            break;
                        }
                }
            }
        }
    }

    private static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Trykk en tast for å fortsette ...");
        Console.Read();
    }

    private static void FilterMenu(Students students)
    {
        var filter = students.GetFilterList();
        Console.Clear();
        Console.WriteLine("Tilgjengelige filtre:");
        Console.WriteLine();
        for (var i = 0; i < filter.Length; i++)
        {
            var topic = filter[i];
            var userIndex = GetUserIndexStr(i);
            Console.WriteLine(userIndex + ": " + topic);
        }
        Console.WriteLine("0: Tilbake til hovedmeny");
        Console.WriteLine();
        Console.WriteLine("Velg ønsket filter og trykk Enter ...");
        var filterChoice = Console.ReadLine();
        GetFilteredList(filterChoice, filter);
    }

    private static string GetUserIndexStr(int i)
    {
        var userIndex = i + 1;
        return userIndex.ToString();
    }
}