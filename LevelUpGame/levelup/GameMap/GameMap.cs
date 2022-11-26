namespace levelup
{
    public class GameMap
    {
        public Position[,]? positions { get; set; }
        public Position? startingPosition { get; set; }

        public GameMap()
        {
            CreatePositions();
        }

        private void CreatePositions()
        {
            positions = new Position[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Position pos = new Position(x, y);
                    positions[x, y] = pos;
                }
            }
            startingPosition = positions[0, 0];
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

        public bool IsPositionValid(Position pos)
        {
            return (pos.X >= 0 && pos.X < 10 && pos.Y >= 0 && pos.Y < 10);
        }
    }
}