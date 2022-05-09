public class Dog : Animal, IMammal
{
    public int NumberOfNipples{get{return 7;}}

    public override string Sound()
    {
        return "Woof!";
    }
}