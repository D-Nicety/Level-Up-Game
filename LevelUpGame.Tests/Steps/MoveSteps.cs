using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;
using System.Drawing;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
         GameController testObj = new GameController();
         int startX, startY, endX, endY;
         GameController.DIRECTION direction;
         Point currentPosition;

        [Given(@"the character starts at the Position with XCoordinates(.*)")]
        public void GivenTheCharacterStartsAtX(int startX)
        {
            this.startX = startX;
        }

        [Given(@"starts at YCoordinates(.*)")]
        public void givenTheCharacterStartsAtY(int startY)
        {
            this.startY = startY;
        }

        [Given(@"the player choses to move in(.*)")]
        public void givenPlayerChoosesDirection(String direction)
        {
            this.direction = (GameController.DIRECTION)
            Enum.Parse(typeof(GameController.DIRECTION),direction);
        }

        [When(@"the character moves")]
        public void whenTheCharacterMoves()
        {
            testObj.SetCharacterPosition(new Point(this.startX,this.startY));
            testObj.Move(this.direction);
            GameController.GameStatus status = testObj.GetStatus();
            this.currentPosition = status.currentPosition;
        }

        [Then(@"the character is now at Position with XCoordinates(.*)")]
        public void checkXCoordinates(int endX)
        {
            Assert.NotNull(this.currentPosition,"Expected position not null");
            Assert.AreEqual(endX,this.currentPosition.X);
        }

        [Then(@"YCoordinates (.*)")]
        public void checkYCoordinates(int endY)
        {
             Assert.NotNull(this.currentPosition,"Expected position not null");
            Assert.AreEqual(endY,this.currentPosition.Y);
        }
    }
}