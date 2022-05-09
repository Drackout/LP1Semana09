public class Bee : Animal, ICanFly
{
    public int NumberOfWings{get { return 4;}}
    public override string Sound()
    {
        return "Bee sound";
    }
}