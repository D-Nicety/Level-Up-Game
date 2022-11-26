namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        public Character? character { get; set; }
        public GameMap? gameMap { get; set; }

        GameStatus status = new();

        public record struct GameStatus(
            // TODO: Add other status data, like gameStatus for WHAMMIE, BIG BUCKS
            String characterName,
            Position currentPosition,
            int moveCount
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place until you figure out who should initialize
            status.currentPosition = new Position(-1, -1);
            status.moveCount = 0;
        }

        public Character CreateCharacter(String name)
        {
            Character character;
            
            if (!string.IsNullOrEmpty(name))
            {
                character = new Character(name);
            }
            else
            {                
                character = new Character(DEFAULT_CHARACTER_NAME);
            }
            status.characterName = name;
            return character;
        }

        public void StartGame()
        {
            gameMap = new GameMap();
            character ??= CreateCharacter(DEFAULT_CHARACTER_NAME);
            character.EnterMap(gameMap);
            this.status.characterName = character.Name;
            this.status.currentPosition = character.Position;
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            character.Move(directionToMove);
            this.status.currentPosition = character.Position;
            this.status.moveCount = character.moveCount;
        }

        public void SetCharacterPosition(int x, int y)
        {
            character.Position = new Position(x, y);
            this.status.currentPosition = character.Position;
        }

        public void SetMoveCount(int moveCount)
        {
            character.moveCount = moveCount;
            this.status.moveCount = character.moveCount;
        }

        //public override string ToString()
        //{
        //    if (character != null && character.Name != null)
        //    {
        //        return character.Name;
        //    }            
        //}
    }
}