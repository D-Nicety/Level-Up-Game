using System.Drawing;

namespace levelup
{
    public class Position
    {
        Point currentPosition {get; set;}

        public Position (int xCoordinates, int yCoordinates) {
            currentPosition.xCoordinates = xCoordinates;
            currentPosition.yCoordinates = yCoordinates;
        }

    }
}