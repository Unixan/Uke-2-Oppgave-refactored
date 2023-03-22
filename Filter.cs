namespace Uke_2_Oppgave_refactored
{
    internal class Filter
    {
        public static void FilterMenu(Students students)
        {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Tilgjengelige filtre:");
            Console.WriteLine();
            var filterList = students.GetFilterList();
            WriteFilterMenu(filterList);
            Console.WriteLine("Velg ønsket filter og trykk Enter ...");
            var filterChoice = Console.ReadLine();
            Console.WriteLine(filterChoice);
            MakeFilterChoice(filterChoice, filterList, students);
        }
        private static void WriteFilterMenu(string[] filterList)
        {
            for (var i = 0; i < filterList.Length; i++)
            {
                var topic = filterList[i];
                var userIndex = GetUserIndexStr(i);
                Console.WriteLine(userIndex + ": " + topic);
            }
            Console.WriteLine("0: Tilbake til hovedmeny");
            Console.WriteLine();
           
        }
        private static void MakeFilterChoice(string userChoice, string[] filterList, Students students)
        {
            for (
                var i = 0; i < filterList.Length; i++)
            {
                var option = filterList[i];
                var userIndex = GetUserIndexStr(i);
                if (userChoice == userIndex)
                {
                    Console.Clear();
                    students.GetFilterCourse(option);
                    Common.Pause();
                    FilterMenu(students);
                    break;
                }
                if (userChoice == "0")
                {
                    Program.Menu();
                    break;
                }
                if (i == filterList.Length - 1)
                {
                    Common.Pause("Ugyldig valg!");
                    FilterMenu(students);
                    break;
                }

            }

        }
        private static string GetUserIndexStr(int i)
        {
            var userIndex = i + 1;
            return userIndex.ToString();
        }


    }


}
