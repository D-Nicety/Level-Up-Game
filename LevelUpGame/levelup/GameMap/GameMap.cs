namespace levelup
{
    public class GameMap
    {
        public Position[,]? Positions { get; set; }
        public Position? StartingPosition { get; set; }

        public GameMap()
        {
            CreatePositions();
        }

        private void CreatePositions()
        {
            Positions = new Position[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Position pos = new Position(x, y);
                    Positions[x, y] = pos;
                }
            }
            StartingPosition = Positions[0, 0];
        }

        public virtual Position CalculateNewPosition(Position currentPosition, GameController.DIRECTION direction)
        {
            Position newPos = new Position(-1, -1);
            if (direction == GameController.DIRECTION.EAST)
            {
                newPos = new Position(currentPosition.X + 1, currentPosition.Y);
            }
            else if (direction == GameController.DIRECTION.WEST)
            {
                newPos = new Position(currentPosition.X - 1, currentPosition.Y);
            }
            else if (direction == GameController.DIRECTION.NORTH)
            {
                newPos = new Position(currentPosition.X, currentPosition.Y + 1);
            }
            else if (direction == GameController.DIRECTION.SOUTH)
            {
                newPos = new Position(currentPosition.X, currentPosition.Y - 1);
            }

            if (IsPositionValid(newPos))
            {
                return newPos;
            }
            else
            {
                return currentPosition;
            }
        }

        public static bool IsPositionValid(Position pos)
        {
            return (pos.X >= 0 && pos.X < 10 && pos.Y >= 0 && pos.Y < 10);
        }
    }
}