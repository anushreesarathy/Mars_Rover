using System;
using System.Collections.Generic;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base.Instructions
{
    public static class Avail_Instructions
    {
        public static Dictionary<string, Iinstruct> List
        {
            get
            {
                var commands = new Dictionary<string, Iinstruct>
                    {
                        {"M", new forward()},
                        {"L", new turn_left()},
                        {"R", new turn_right()}
                    };
                return commands;
            }
        }
    }
}