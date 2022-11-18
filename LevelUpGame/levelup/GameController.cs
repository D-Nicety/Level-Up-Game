
using System.Drawing;

namespace levelup
{
    public class GameController
    {
        // TODO: If your stakeholder wants to call this CHARACTER, change var name for
        // low representational gap
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        public Character? character { get; set; }
        public GameMap? gameMap { get; set; }

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Point currentPosition
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place
            status.currentPosition = new Point(-1,-1);
            status.moveCount = 0;
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
        }

        public void StartGame()
        {
            gameMap = new GameMap();
            if (character == null)
            {
                CreateCharacter("");
            }
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
    public void SetCharacterPosition(Point coordinates)
    {
        //TODO : IMPLEMENT THIS TO SET CHARACTER CURRENT POSITION - exists to be testable
    }



    }
}