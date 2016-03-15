using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mars_Rover.Base;
using NUnit.Framework;

namespace Mars_Rover.Test
{
    [TestFixture]
    public class PlateauTests
    {
        [Test]
        public void Create_The_Landscape_That_Rover_Position_Will_Be_0_0()
        {
            var plateau = new plateau(5);
            Assert.That(plateau.XCoordinate, Is.EqualTo(0));
            Assert.That(plateau.YCoordinate, Is.EqualTo(0));
        }

    }
}