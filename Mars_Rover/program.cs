using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Threading.Tasks;
using Mars_Rover.Base;

namespace Mars_Rover
{
    public class program
    {
        static void Main(string[] args)
        {
            Help();
            var plateau = new plateau(5);
            var rover = new Rover(plateau);
            Console.WriteLine(rover.ToString());
            string commandsToExecute = string.Empty;
            while (commandsToExecute != "E")
            {
                Console.Write("Enter Commands: ");
                commandsToExecute = Console.ReadLine().ToUpper();
                rover.ExecuteCommands(commandsToExecute);
                Console.WriteLine();
                Console.WriteLine(string.Format("Current Rover Position Heading: {0}", rover.ToString()));
            }
        }

        private static void Help()
        {
            Console.WriteLine("Valid Commands are:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("F - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Enter to execute commands");
        }
    }
}