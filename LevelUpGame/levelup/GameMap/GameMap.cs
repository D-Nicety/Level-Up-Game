using System.Drawing;

namespace levelup
{
    public class GameMap
    {
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }
       public Position position
       {
        get;
        set;
       }
       public int XCoordinates{
        get;
        set;
       }
       public int YCoordinates
       {
        get;
        set;
       }
        int numPositions = 100;
        public GameMap()
        {
            position = new Position(10,20);
            this.XCoordinates = 10;
            this.YCoordinates = 20;
   
                        
            
        }

      /*  public Position getPositions()
        {
            return new Position(10,20);
        } */
        public void calculatePosition(Position startingPosition,DIRECTION direction)
        {

        }
        public bool isPositionValid(Point positionCoordinates)
        {
            return true;
        }

        public int getTotalPositions()
        {
            return 0;
        }
    }
}