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
         int startX, startY, endX, endY, moveStart, moveEnd;
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

        [Given(@"starts at MoveCount(.*)")]
        public void givenMoveCount(int moveStart)
        {
            this.moveStart = moveStart;            
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
            testObj.CreateCharacter("Dennis");
            testObj.SetCharacterPosition(this.startX,this.startY);
            testObj.Move(this.direction);
            GameController.GameStatus status = testObj.GetStatus();
           // this.currentPosition = status.currentPosition;
            this.moveEnd = this.moveStart + 1;
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
         [Then(@"MoveCount (.*)")]
         public void ThenMoveCount(int moveEnd)
         {
            Assert.NotNull(this.moveEnd,"Expected move count not null");
            Assert.AreEqual(moveEnd,this.moveEnd);
         }

    }
}