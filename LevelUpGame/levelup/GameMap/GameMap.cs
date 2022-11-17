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
        public GameMap()
        {
            position = new Position(10,20);
                        
            
        }

        public Position getPositions()
        {
            return new Position(10,20);
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