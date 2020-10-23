using System;
public class DieRoll
{
    public Die ThisDie;

    public enum Face { Hit, Miss }
    public enum Icon { One, Two }

    public DieRoll()
    {
        var rand = new Random();
        var face = new Face();
        var icon = new Icon();

        var num = rand.Next(1,101);
        if ( num > 50 ) { face = Face.Hit; } else { face = Face.Miss; }

        num = rand.Next(1,151);
        if ( num > 50 ) { icon = Icon.One; } else { icon = Icon.Two; }
        
        ThisDie = new Die(face, icon);
    }
    public class Die
    {
        public Face Face { get; set; }
        public Icon Icon { get; set; }
        public Die(Face f, Icon i)
        {
            Face = f;
            Icon = i;
        }
    }
}