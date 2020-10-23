public class Zone
{
    public double Row { get; set; }
    public double Column { get; set; }

    public Wall North { get; set; }
    public Wall South { get; set; }
    public Wall East { get; set; }
    public Wall West { get; set; }

    public bool JustSpawned { get; set; }

    public string EnteredFrom { get; set; }

    public bool has_Teleport { get; set; }
    public bool has_Spawn { get; set; }
    public bool has_Loot { get; set; }
    public bool has_Trap { get; set; }
    public bool has_Objective { get; set; }

    public Zone()
    {
        North = new Wall();
        South = new Wall();
        East = new Wall();
        West = new Wall();
    }

    public Zone(Wall n, Wall s, Wall e, Wall w)
    {
        North = n;
        South = s;
        East = e;
        West = w;
    }

}