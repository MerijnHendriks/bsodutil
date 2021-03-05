using BsodLib;

namespace BsodTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WinApi.TriggerBSOD();
        }
    }
}
