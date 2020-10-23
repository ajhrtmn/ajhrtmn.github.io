public class Actor
{
    public string Name { get; set; }
    public double LVL { get; set; }

    public double Row { get; set; }
    public double Column { get; set; }

    public HP hp = new HP();
    public Armor armor = new Armor();
    public Actions actions = new Actions();
    public Status status = new Status();

    
    public class HP
    {
        public HP(){}
        public HP(double c, double m)
        { this.Current = c; this.Max = c; }

        public double Current { get; set; }
        public double Max { get; set; }
    }

    public class Armor
    {
        public Armor(){}
        public Armor(double c, double m)
        { this.Current = c; this.Max = c; }
        public double Current { get; set; }
        public double Max { get; set; }
    }

    public class Actions
    {
        public Actions(){}
        public Movement movement = new Movement();
        public Standard standard = new Standard();
        
        public class Movement
        {
            public Movement(){}
            public Movement(double c, double m)
            { this.Current = c; this.Max = c; }
            
            public double Current { get; set; }
            public double Max { get; set; }
        }
        public class Standard
        {
            public Standard(){}
            public Standard(double c, double m)
            { this.Current = c; this.Max = c; }
            
            public double Current { get; set; }
            public double Max { get; set; }
        }
    }
    public class Status
    {
        public Status(){}
        public Effect effect = new Effect();
        public Buff buff = new Buff();
        public Debuff debuff = new Debuff();
        public class Effect
        {
            public Effect(){}
            public Effect(string n, double p, double d)
            { this.Name = n; this.Power = p; this.Duration = d; }
            
            public string Name { get; set; }
            public double Power { get; set; }
            public double Duration { get; set; }
        }
        public class Buff
        {
            public Buff(){}
            public Buff(string n, double p, double d)
            { this.Name = n; this.Power = p; this.Duration = d; }

            public string Name { get; set; }
            public double Power { get; set; }
            public double Duration { get; set; }
        }
        public class Debuff
        {
            public Debuff(){}
            public Debuff(string n, double p, double d)
            { this.Name = n; this.Power = p; this.Duration = d; }

            public string Name { get; set; }
            public double Power { get; set; }
            public double Duration { get; set; }
        }
    }
}