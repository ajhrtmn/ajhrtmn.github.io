using System;
public class DoorType
{
    public string Cls { get; set; }
    public DoorType()
    {
        Cls = GetCls();
    }

    private string GetCls()
    {
        var rand = new Random();
        var num = rand.Next(1,801);
        var cls = "";

        if ( num < 700 )
        {
            cls ="Normal";
        }
        else
        {
            cls = "Security";
        }

        return GetVisual(cls);

    }

    private string GetVisual(string s)
    {
        var rand = new Random();
        
        if ( s == "Normal")
        {
            var num = rand.Next(1,501);
            var t1 = num <= 100;
            var t2 = num > 100 && num <= 200;
            var t3 = num > 200 && num <= 300;
            var t4 = num > 300 && num <= 400;
            var t5 = num > 400;

            if ( t1 == true )
            {
                return "Locked";
            }
            if ( t2 == true )
            {
                return "Unlocked";
            }
            if ( t3 == true )
            {
                return "Jammed";
            }
            if ( t4 == true )
            {
                return "Barricade";
            }
            if ( t5 == true )
            {
                return "Broken";
            }
        }

        if ( s == "Security")
        {
            var num = rand.Next(1,301);
            var t1 = num <= 100;
            var t2 = num > 100 && num <= 200;
            var t3 = num > 200 && num <= 300;
            

            if ( t1 == true )
            {
                return "Barred";
            }
            if ( t2 == true )
            {
                return "Scanner";
            }
            if ( t3 == true )
            {
                return "Vault";
            }
        }

        return s;
    }
}