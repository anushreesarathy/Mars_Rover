using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mars_Rover.Base.Interface_Defn
{
    public interface IPlateau
    {
        int XCoordinate { get; }
        int YCoordinate { get; }

        void XMoveForward();
        void XMoveBackward();
        void YMoveForward();
        void YMoveBackward();
    }
}