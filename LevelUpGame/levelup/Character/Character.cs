namespace levelup
{
    public class Character
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public GameMap gameMap { get; set; }

        public int MoveCount { get; set; }

        public Character(string name)
        {
            Name = name;           
            MoveCount = 0;
        }

        public void EnterMap(GameMap map)
        {
            this.gameMap = map;
            this.Position = map.StartingPosition;
        }

        public virtual void Move(GameController.DIRECTION direction)
        {
            if (this.gameMap != null)
            {
                this.Position = gameMap.CalculateNewPosition(this.Position, direction);
                this.MoveCount += 1;
            }
            else
            {
                this.Position = null;
            }
        }
    }
}