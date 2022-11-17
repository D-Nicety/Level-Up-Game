using System.Drawing;

namespace levelup
{
    public class Position
    {
        Point currentPosition {get; set;}

        public Position (int xCoordinates, int yCoordinates) {
            currentPosition.X = xCoordinates;
            currentPosition.Y = yCoordinates;
        }

    }
}