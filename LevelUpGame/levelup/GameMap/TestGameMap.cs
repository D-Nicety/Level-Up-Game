using System.Drawing;

namespace levelup
{
    public class TestGameMap
    {
        Position position;
        int numPositions = 100;
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }
        public TestGameMap()
        {

        }

        public Position getPositions()
        {
            return position;
        }
        public void calculatePosition(Position startingPosition,DIRECTION direction)
        {

        }
        public bool isPositionValid(Point positionCoordinates)
        {

        }

        public int getTotalPositions()
        {
            return 0;
        }
    }
}