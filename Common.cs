namespace Uke_2_Oppgave_refactored
{
    internal class Common
    {
        public static void Pause()
        {

            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.ReadLine();
        }
        public static void Pause(string msg)
        {

            Console.WriteLine(msg + "\nTrykk en tast for å fortsette ...");
            Console.ReadLine();
        }
    }
}
