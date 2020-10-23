using System;

public class CreateFoe
{
    private Words Words = new Words();
    private Random rand = new Random();

    public Foe Foe = new Foe();
    public Foe.HP hp = new Foe.HP();

    public Foe.Armor armor = new Foe.Armor();

    private Factions Faction = new Factions();

    private Type aliens = typeof(Factions.Aliens);
    private Type ancients = typeof(Factions.AncientTimes);
    private Type dinosaurs = typeof(Factions.Dinosaurs);
    private Type fantasy = typeof(Factions.Fantasy);
    private Type giantbugs = typeof(Factions.GiantBugs);
    private Type monsters = typeof(Factions.Monsters);
    private Type mutants = typeof(Factions.MutantForrestCreatures);
    private Type mythics = typeof(Factions.Mythics);
    private Type noir = typeof(Factions.Noir);
    private Type robots = typeof(Factions.Robots);
    private Type sports = typeof(Factions.Sports);
    private Type wildwest = typeof(Factions.WildWest);
    private Type zombies = typeof(Factions.Zombies);


    public void CreateFoeVitals(PlayerChar pc, bool is_boss = false)
    {
        
        Console.WriteLine(pc.LVL);

        var name = Words.Names[rand.Next(Words.Names.Count)];
        var pre = Words.Prefixes[rand.Next(Words.Prefixes.Count)];
        var sur = Words.Surnames[rand.Next(Words.Surnames.Count)];
        var num = rand.Next(1,14);
        var mob = "";
        var mod = 0.0;

        if ( num == 1 )
        {
            Foe.Faction = "Aliens";
            var values = aliens.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }
        else if ( num == 2 )
        {
            Foe.Faction = "Ancients";
            var values = ancients.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }
        else if ( num == 3 )
        {
            Foe.Faction = "Dinosaurs";
            var values = dinosaurs.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }
        else if ( num == 4 )
        {
            Foe.Faction = "Fantasy";
            var values = fantasy.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
            if ( mob == "DungeonMaster") { mob = "Dungeon Master"; }
        }
        else if ( num == 5 )
        {
            Foe.Faction = "Giant Bugs";
            var values = giantbugs.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = "Giant " + values.GetValue(num).ToString();
        }
        else if ( num == 6 )
        {
            Foe.Faction = "Monsters";
            var values = monsters.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
            if ( mob == "TheCreatureFrankenstein") { mob = "Frankenstein Creature"; }
            else if ( mob == "SwampMan") { mob = "Swamp Man"; }
            else if ( mob == "TranslucentMan") { mob = "Translucent Man"; }
            //Bosses: Dracula, Imhotep
        }
        else if ( num == 7 )
        {
            Foe.Faction = "Mutant Forest Creatures";
            var values = mutants.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = "Mutant " + values.GetValue(num).ToString();
        }
        else if ( num == 8 )
        {
            Foe.Faction = "Mythics";
            var values = mythics.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }
        else if ( num == 9 )
        {
            Foe.Faction = "Noir";
            var values = noir.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
            if ( mob == "FemmeFatale") { mob = "Femme Fatale"; }
            else if ( mob == "DoubleCrosser") { mob = "Double Crosser"; }
            else if ( mob == "PlotDevice") { mob = "Plot Device"; }
        }
        else if ( num == 10 )
        {
            Foe.Faction = "Robots";
            var values = robots.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }
        else if ( num == 11 )
        {
            Foe.Faction = "Sports";
            var values = sports.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
            if ( mob == "Golf") { mob = "Golfer"; }
            else if ( mob == "Wrestling") { mob = "Wrestler"; }
            else { mob = mob + "Player"; }
        }
        else if ( num == 12 )
        {
            Foe.Faction = "Wild West";
            var values = wildwest.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }
        else if ( num == 13 )
        {
            Foe.Faction = "Zombies";
            var values = zombies.GetEnumValues();
            num = rand.Next(values.Length);
            mod = ( num / 13 ) + 1;
            mob = values.GetValue(num).ToString();
        }

        Foe.Range_Low = rand.Next(0,1);
        Foe.Range_High = rand.Next(1,4);
        if ( Foe.Range_High == 3) { Foe.Range_High = rand.Next(1,4); }
        if ( Foe.Range_High == 3) { Foe.Range_High = rand.Next(2,4); }
        
        Foe.Damage = ( rand.Next(75,126) * mod ) + ( rand.Next(4,7) * ( pc.LVL - 1 ) );
        Foe.Accuracy = rand.Next(45,51) + pc.LVL - 1;

        Foe.DicePerAttack = rand.Next(4,7) + pc.LVL - 1;
        hp.Max = ( rand.Next(2250,2750) * mod ) + ( rand.Next(3250,3750) * ( pc.LVL - 1 ) );

        if ( pc.LVL > 25 )
        {
            Foe.Range_Low = rand.Next(0,1);
            if ( Foe.Range_Low == 1) { Foe.Range_Low = rand.Next(0,1); }
            if ( Foe.Range_Low == 1) { Foe.Range_Low = rand.Next(0,1); }
            Foe.Range_High = rand.Next(1,4);
            if ( Foe.Range_High == 3) { Foe.Range_High = rand.Next(2,5); }
            if ( Foe.Range_High == 4) { Foe.Range_High = rand.Next(3,6); }

            Foe.DicePerAttack = rand.Next(4,12) + pc.LVL - 1;
            if ( Foe.DicePerAttack > 40 ) { Foe.DicePerAttack = rand.Next(40,49); }

            Foe.Accuracy = rand.Next(50,61) + pc.LVL - 1;

            if ( pc.LVL > 48 )
            {
                Foe.Range_Low = 0;
                Foe.Range_High = rand.Next(2,4);
                if ( Foe.Range_High > 3) { Foe.Range_High = rand.Next(3,6); }
                if ( Foe.Range_High > 4) { Foe.Range_High = rand.Next(4,7); }

                Foe.Accuracy = rand.Next(55,66) + pc.LVL - 23;

                Foe.Damage = ( rand.Next(75,126) * mod ) + ( rand.Next(7,13) * ( pc.LVL - 1 ) );

                hp.Max = ( rand.Next(2250,2750) * mod ) + ( rand.Next(4750,5250) * ( pc.LVL - 1 ) );

                if ( Foe.Accuracy > 85 )
                {
                    Foe.Accuracy = 85;
                }
            }
            else
            {
                if ( Foe.Accuracy > 75 )
                {
                    Foe.Accuracy = 75;
                }
            }
        }
        

        if ( is_boss != true )
        {
            Foe.Is_Boss = false;

            num = rand.Next(1,1001);
            if ( num > 876 )
            {
                hp.Max = hp.Max * ( ( ( rand.Next(15,31) / 100 ) + 1 ) );
                Foe.Is_Elite = true;
                name = pre + " " + name;
            }
        }
        else
        {
            Foe.Is_Boss = true;


        }
        
        armor.Max = rand.Next(500,1500) + ( 100 * pc.LVL );
        Foe.Health_Regen = rand.Next(15,85) + hp.Max / 10;
        Foe.Armor_Recharge = rand.Next(15,85) + armor.Max / rand.Next(8,14);
        Foe.Movement = rand.Next(1,6);
        Foe.Standard = rand.Next(1,6);

        hp.Current = hp.Max;
        armor.Current = armor.Max;

        Foe.Name = name + " The " + mob;
    }

}