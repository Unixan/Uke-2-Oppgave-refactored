namespace Uke_2_Oppgave_refactored
{
    internal class Common
    {
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Trykk en tast for å fortsette ...");
            Console.Read();
        }
        public static void Pause(string msg)
        {
            Console.WriteLine();
            Console.WriteLine(msg + "\nTrykk en tast for å fortsette ...");
            Console.Read();
        }
    }
}
