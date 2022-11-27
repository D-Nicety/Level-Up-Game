using System.Runtime.CompilerServices;

namespace levelup
{
    public class GameMap
    {
        public const int NUM_WHAMMIES = 2;
        public const int NUM_CASH = 10;

        public Position[,]? Positions { get; set; }
        public Position? StartingPosition { get; set; }

        public List<Position> WhammiePositions { get; set; }
        public List<Position> CashPositions { get; set; }

        public GameMap()
        {
            CreatePositions();
            CashPositions = CreateCash();
            WhammiePositions = CreateWhammies();
        }
        private List<Position> CreateWhammies()
        {
            List<Position> whammiePositions = new List<Position>();
            Random r = new();
            for (int i = 0; i < NUM_CASH; i++)
            {
                //Position whammiePosition = new Position(r.Next(0, 9), r.Next(0, 9));
                Position whammiePosition = new Position(1, 1);
                whammiePositions.Add(whammiePosition);
            }
            return whammiePositions;
        }

        private List<Position> CreateCash()
        {
            List<Position> cashPositions = new List<Position>();
            Random r = new();
            for (int i = 0; i < NUM_CASH; i++)
            {
                Position cashPosition = new Position(r.Next(0,9), r.Next(0,9));
                cashPositions.Add(cashPosition);
            }
            return cashPositions;
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

        public bool IsPositionValid(Position position)
        {
            return (position.X >= 0 && position.X < 10 && position.Y >= 0 && position.Y < 10);
        }

        public bool IsPositionWhammie(Position position)
        {
            return WhammiePositions.Exists(p => p.X == position.X && p.Y == position.Y);
        }

        public bool IsPositionCash(Position position)
        {
            return CashPositions.Exists(p => p.X == position.X && p.Y == position.Y);
        }
    }
}