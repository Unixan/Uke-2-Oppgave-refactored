using Uke_2_Oppgave_refactored;

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
                            Common.Pause();
                            Menu();
                            break;
                        }
                    case "2":
                        {
                            new FilterMenu(students);
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






}