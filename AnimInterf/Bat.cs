public class Bat : Animal, IMammal, ICanFly
{
    public int NumberOfNipples{get {return 26;}}
    public int NumberOfWings{get {return 2;}}
    public override string Sound()
    {
        return "Bat sound";
    }
}