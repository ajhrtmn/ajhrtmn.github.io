public class Door
{
    public double ID { get; set; }
    public DoorType DoorType { get; set; }
    public bool HasArmor { get; set; }
    public double CurrentArmor { get; set; }
    public double MaxArmor { get; set; }
    public double CurrentHP { get; set; }
    public double MaxHP { get; set; }
    public double Difficulty { get; set; }

    public Door()
    {
        DoorType = new DoorType();

        Difficulty = 2;
        MaxHP = 200;
        MaxArmor = 0;

        if ( DoorType.Cls == "Barred" || DoorType.Cls == "Vault"){ HasArmor = true; }
        else
        {
            if ( DoorType.Cls == "Scanner" ) { MaxHP = 0; Difficulty = Difficulty * 2; }
        }

        if ( HasArmor == true ) { MaxArmor = 200; }

        CurrentArmor = MaxArmor;
        CurrentHP = MaxHP;
        
    }

}