using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Base.Direction
{
  
    public class East : IDirection
    {
        private readonly IPlateau _plateau;

        public East(IPlateau plateau)
        {
            _plateau =  plateau;
        }

        public IDirection TurnLeft()
        {
            return new North(_plateau);
        }

        public IDirection TurnRight()
        {
            return new South(_plateau);
        }

        public void Move()
        {
            _plateau.XMoveForward();
        }

        public override string ToString()
        {
            return "East";
        }
    }
    public class South : IDirection
    {
        private readonly IPlateau _plateau;

        public South(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public IDirection TurnLeft()
        {
            return new East(_plateau);
        }

        public IDirection TurnRight()
        {
            return new West(_plateau);
        }

        public void Move()
        {
            _plateau.YMoveBackward();
        }

        public override string ToString()
        {
            return "South";
        }
    }
    public class West : IDirection
    {
        private readonly IPlateau _plateau;

        public West(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public IDirection TurnLeft()
        {
            return new South(_plateau);
        }

        public IDirection TurnRight()
        {
            return new North(_plateau);
        }

        public void Move()
        {
            _plateau.XMoveBackward();
        }

        public override string ToString()
        {
            return "West";
        }
    }
    public class North : IDirection
    {

        private readonly IPlateau _plateau;

        public North(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public IDirection TurnLeft()
        {
            return new West(_plateau);
        }

        public IDirection TurnRight()
        {
            return new East(_plateau);
        }

        public void Move()
        {
            _plateau.YMoveForward();
        }

        public override string ToString()
        {
            return "North";
        }

    }

   
}