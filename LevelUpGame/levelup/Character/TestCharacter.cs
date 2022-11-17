namespace levelup
{
    public class Character {
    string DEFAULT_CHARACTER_NAME = "Zelda";
    public string Name {get; set;}

    public TestCharacter()
    {
        Name = DEFAULT_CHARACTER_NAME;
    }
    public TestCharacter(string name)
    {
        //Name = name;
    }
    public void enterMap(GameMap map) 
    {
        //TODO
    }

    public Position getPosition() 
    {
        //new
    }
}