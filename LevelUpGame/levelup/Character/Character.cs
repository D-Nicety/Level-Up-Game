namespace levelup
{
    public class Character {
    string DEFAULT_CHARACTER_NAME = "Zelda";
    public string Name {get; set;}

    public Character()
    {
        Name = DEFAULT_CHARACTER_NAME;
    }
    public Character(string name)
    {
        //Name = name;
    }
    public void enterMap(GameMap map) 
    {
        //TODO
    }

    public Position getPosition() 
    {
        //TODO
    }
}
}