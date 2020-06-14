using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class AlienUsername
    {

        static void isAlienUsername(string username)
        {
            Match matcher = new Regex(@"[_\.]\d+[a-zA-Z]+_?$").Match(username);

            if (matcher.Success)
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }

        static void Main(string[] args)
        {
            isAlienUsername("_0898989811abced_"); // VALID
            isAlienUsername("_abce"); // INVALID
            isAlienUsername("_09090909abcD0"); // INVALID
        }
    }
}
