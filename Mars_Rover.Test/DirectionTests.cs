using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using Mars_Rover.Base;
using Mars_Rover.Base.Direction;
using Mars_Rover.Base.Interface_Defn;

namespace Mars_Rover.Test
{
    public class DirectionTests
    {
        
        IPlateau _plateau;

        [SetUp]
        public void Setup()
        {
            _plateau = new plateau(5);
        }

        [Test]
        public void When_North_And_Turn_Left_Should_Be_West()
        {
            var direction = new North(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<West>());
        }

        [Test]
        public void When_North_And_Turn_Right_Should_Be_East()
        {
            var direction = new North(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<East>());
        }

        [Test]
        public void When_East_And_Turn_Left_Should_Be_North()
        {
            var direction = new East(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<North>());
        }

        [Test]
        public void When_East_And_Turn_Right_Should_Be_South()
        {
            var direction = new East(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<South>());
        }

        [Test]
        public void When_South_And_Turn_Left_Should_Be_East()
        {
            var direction = new South(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<East>());
        }

        [Test]
        public void When_South_And_Turn_Right_Should_Be_West()
        {
            var direction = new South(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<West>());
        }

        [Test]
        public void When_West_And_Turn_Left_Should_Be_South()
        {
            var direction = new West(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<South>());
        }

        [Test]
        public void When_West_And_Turn_Right_Should_Be_North()
        {
            var direction = new West(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<North>());
        }      
    }
}