using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Mars_Rover.Base.Interface_Defn
{
    public interface Iinstructfactory 
    {

        string instructname { get; }
        string description { get; }

        Iinstruct MakeInstructions(string[] arguments);
    }
}