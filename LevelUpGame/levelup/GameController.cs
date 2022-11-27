using static System.Net.Mime.MediaTypeNames;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        public Character? character { get; set; }
        public GameMap? gameMap { get; set; }

        GameStatus status = new();

        public struct GameStatus {
            // TODO: Add other status data, like gameStatus for WHAMMIE, BIG BUCKS
            public String characterName;
            public Position currentPosition;
            public int moveCount;

               public override string ToString() =>
                    $"Character Name: {characterName}; Position: X = {currentPosition.X} Y = {currentPosition.Y}; Moves: {moveCount}";
        };

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
            character.position = new Position(0, 0);
            character.EnterMap(gameMap);
            this.status.characterName = character.Name;
            this.status.currentPosition = character.position;
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            if (character != null) { 
                character.Move(directionToMove);
                status.currentPosition = character.position;
                status.moveCount = character.MoveCount;
            }
        }

        public void SetCharacterPosition(int x, int y)
        {
            if (character != null)
            {
                character.position = new Position(x, y);
                status.currentPosition = character.position;
            }
        }

        public void SetMoveCount(int moveCount)
        {
            if (character != null)
            {
                character.MoveCount = moveCount;
                status.moveCount = character.MoveCount;
            }
        }
    }
}