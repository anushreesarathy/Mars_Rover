using System;
using Mars_Rover.Base.Interface_Defn;
using Mars_Rover.Base.Direction;
using Mars_Rover.Base.Instructions;

namespace Mars_Rover.Base
{
    public class Rover : IRover
    {

        private readonly IPlateau _plateau;

        public IDirection Direction { get; private set; }

        public Rover(IPlateau plateau)
        {
            _plateau = plateau;
            Direction = new North(_plateau);
        }
        public void TurnLeft() { Direction = Direction.TurnLeft(); }
        public void TurnRight() { Direction = Direction.TurnRight(); }
        public void Forward() { Direction.Move(); }

        public int XCoordinate
        {
            get { return _plateau.XCoordinate; }
        }

        public int YCoordinate
        {
            get { return _plateau.YCoordinate; }
        }

        public override string ToString()
        {
            return string.Format("X : {0}, Y : {1}, Direction : {2}", XCoordinate, YCoordinate, Direction);
        }


        public void ExecuteCommands(string commandString)
        {
            var commands = Avail_Instructions.List;
            var commandParser = new Instruction_parser(commands);

            for (int index = 0; index < commandString.Length; index++)
            {
                var command = commandString[index].ToString();
                var commandToExecute = commandParser.ParseCommand(command);
                commandToExecute.start(this);
            }
        }
    }
}