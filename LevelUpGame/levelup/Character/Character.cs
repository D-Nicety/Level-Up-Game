namespace levelup
{
    public class Character
    {
        public string Name { get; set; }
        public Position position { get; set; }
        public GameMap gameMap { get; set; }

        public int MoveCount { get; set; }

        public int WhammieCount { get; set; } = 0;
        public int CashBalance { get; set; } = 0;

        public Character(string name)
        {
            Name = name;           
            MoveCount = 0;
            gameMap = new GameMap();
            position = new(0,0);
        }

        public void EnterMap(GameMap map)
        {
            gameMap = map;
            if (map.StartingPosition == null)
            {
                map.StartingPosition = position;
            }
            else
            {
                position = map.StartingPosition;
            }            
        }

        public virtual void Move(GameController.DIRECTION direction)
        {
            if (gameMap != null)
            {
                position = gameMap.CalculateNewPosition(position, direction);
                MoveCount += 1;
            }
        }
    }
}