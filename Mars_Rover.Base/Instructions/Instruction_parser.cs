using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base.Instructions
{
    public class Instruction_parser
    {
        private readonly Dictionary<string, Iinstruct> _commands;

        public Instruction_parser(Dictionary<string, Iinstruct> commands)
        {
            _commands = commands;
        }

        public Iinstruct ParseCommand(string command)
        {
            if (_commands.ContainsKey(command))
                return _commands[command];
            return new not_found();
        }
    }
}