using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mars_Rover.Base.Interface_Defn
{
    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();

        void Move();
    }
}