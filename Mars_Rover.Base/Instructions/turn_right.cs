using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base.Instructions
{
    public class turn_right : Iinstruct
    {
        public void start(IRover rover)
        {
            rover.TurnRight();
        }
    }
}