namespace Uke_2_Oppgave_refactored
{
    internal class FilterMenu
    {
        public FilterMenu(Students students)
        {
            Console.WriteLine();
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
            MakeFilterChoice(filterChoice, filter);

            void MakeFilterChoice(string userChoice, string[] filterList)
            {
                for (var i = 0; i < filterList.Length; i++)
                {
                    var option = filterList[i];
                    var userIndex = GetUserIndexStr(i);
                    if (userChoice == userIndex)
                    {
                        Console.Clear();
                        students.GetFilterCourse(option);
                        Common.Pause();
                        ReloadFilterMenu();
                        break;
                    }
                    if (userChoice == "0")
                    {
                        Program.Main();
                        break;
                    }
                    if (i == filterList.Length - 1)
                    {
                        Common.Pause("Ugyldig valg!");
                        ReloadFilterMenu();
                        break;
                    }
                }

            }
            void ReloadFilterMenu()
            {
                new FilterMenu(students);
            }

        }
        private string GetUserIndexStr(int i)
        {
            var userIndex = i + 1;
            return userIndex.ToString();
        }


    }


}
