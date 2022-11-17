using System.Drawing;

namespace levelup
{
    public class GameMap
    {
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }
        Position position;
        int numPositions = 100;
        public TestGameMap()
        {
            position = new Position();
            
            
            
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