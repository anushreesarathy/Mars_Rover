using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base
{
    public class plateau : IPlateau
    {
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }
        
        private readonly int _gridSize;

        public plateau(int gridSize)
        {
            XCoordinate = 0; YCoordinate = 0;
            _gridSize = gridSize;
        }

        public void XMoveForward()
        {
            if (XCoordinate < _gridSize)
                XCoordinate++;
        }

        public void XMoveBackward()
        {
            if (XCoordinate > 0)
                XCoordinate--;
        }

        public void YMoveForward()
        {
            if (YCoordinate < _gridSize)
                YCoordinate++;
        }

        public void YMoveBackward()
        {
            if (YCoordinate > 0)
                YCoordinate--;
        }
    }
}