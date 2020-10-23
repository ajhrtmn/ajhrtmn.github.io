using System;
public class Wall
{
    public double ID { get; set; }
    public string Direction { get; set; }
    public string WallType { get; set; }
    public string WallVisual { get; set; }
    public Doorway Doorway { get; set; }


    public Wall()
    {
        var rand = new Random();
        var next = rand.Next(1, 301);
        if ( next <= 100 )
        {
            WallType = "Doorway";
        }
        if ( next > 200 )
        {
            WallType = "Open";
        }
        if ( next > 100 && next <= 200 )
        {
            WallType = "Solid";
        }
        
        switch ( WallType )
        {
            case "Doorway": Doorway = new Doorway(); break;
            case "Open": WallVisual = GetVisual("Open"); break;
            case "Solid": WallVisual = GetVisual("Solid"); break;
        }
    }

    private string GetVisual(string s)
    {
        var rand = new Random();
        if ( s == "Open")
        {
            var num = rand.Next(1,301);
            var t1 = num <= 100;
            var t2 = num > 100 && num <= 200;
            var t3 = num > 200;

            if ( t1 == true )
            {
                return "Bare";
            }
            if ( t2 == true )
            {
                return "Broken";
            }
            if ( t3 == true )
            {
                return "Decorative";
            }
        }
        
        if ( s == "Solid")
        {
            var num = rand.Next(1,501);
            var t1 = num <= 100;
            var t2 = num > 100 && num <= 200;
            var t3 = num > 200 && num <= 300;
            var t4 = num > 300 && num <= 400;
            var t5 = num > 400;

            if ( t1 == true )
            {
                return "Wooden";
            }
            if ( t2 == true )
            {
                return "Metalic";
            }
            if ( t3 == true )
            {
                return "Block";
            }
            if ( t4 == true )
            {
                return "Reinforced";
            }
            if ( t5 == true )
            {
                return "Leaden";
            }
        }

        return s;
    }


}