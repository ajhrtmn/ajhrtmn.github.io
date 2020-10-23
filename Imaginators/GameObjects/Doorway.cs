public class Doorway
{
    public double ID { get; set; }
    public Door Door { get; set; }
    public Doorway()
    {
        Door = new Door();
    }
}