using System;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base.Instructions
{
    public class turn_left : Iinstruct
    {
        public void start(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}