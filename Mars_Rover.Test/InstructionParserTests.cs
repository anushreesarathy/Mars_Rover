using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using Mars_Rover.Base.Instructions;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Test
{
    public class InstructionParserTests
    {

        private Dictionary<string, Iinstruct> _availableCommands;

        [SetUp]
        public void Setup()
        {
            _availableCommands = Avail_Instructions.List;
        }

        [Test]
        public void Get_Correct_Command_To_Move_Forward()
        {
            var commandParser = new Instruction_parser(_availableCommands);
            var command = commandParser.ParseCommand("M");
            Assert.That(command, Is.TypeOf<forward>());
        }

        [Test]
        public void Get_Correct_Command_To_Turn_Left()
        {
            var commandParser = new Instruction_parser(_availableCommands);
            var command = commandParser.ParseCommand("L");
            Assert.That(command, Is.TypeOf<turn_left>());
        }

        [Test]
        public void Get_Correct_Command_To_Turn_Right()
        {
            var commandParser = new Instruction_parser(_availableCommands);
            var command = commandParser.ParseCommand("R");
            Assert.That(command, Is.TypeOf<turn_right>());
        }

        [Test]
        public void Get_NullCommand_With_Invalid_Command()
        {
            var commandParser = new Instruction_parser(_availableCommands);
            var command = commandParser.ParseCommand("G");
            Assert.That(command, Is.TypeOf<not_found>());
        }

    }
}