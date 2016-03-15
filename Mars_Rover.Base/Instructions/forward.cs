using System;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base.Instructions
{
    public class forward : Iinstruct
    {
        public void start(IRover rover)
        {
            rover.Forward();
        }
    }
}