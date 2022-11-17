using System.Drawing;

namespace levelup
{
    public class Position
    {
        Point Position {get; set;}

        public Position (int xCoordinates, int yCoordinates) {
            Position.xCoordinates = xCoordinates;
            Position.yCoordinates = yCoordinates;
        }

    }
}