using System.Drawing;

namespace levelup
{
    public class Position
    {
        public Point currentPosition {get; set;}

        public Position (int xCoordinates, int yCoordinates) {
            currentPosition = new Point(xCoordinates,yCoordinates);
        }
    }
}