using System;

public class ItemNamer
{

    //  Variables
    private Random rand = new Random();
    public Item.Manufacturers Manufacturer;

    public Words Words = new Words();

    private Weapon W = new Weapon();
    private Armor A = new Armor();
    private static Item I = new Item();

    private string item_descriptor;
    private string item_class;


    public ItemNamer(Item i, Weapon w, Armor a)
    {
        I = i;
        W = w;
        A = a;
    }

    //  Logic Code

    public string CreateName()
    {
        var m = Item.Manufacturers.NULL;

        if ( I.ItemType == Item.ItemTypes.Weapon )
        {
            m = W.Manufacturer;

            if ( W.Type == Weapon.WeaponTypes.Melee )
            {
                item_class = W.Melee.ToString();
            }
            else if ( W.Type == Weapon.WeaponTypes.Ranged )
            {
                item_class = W.Ranged.ToString();
            }
            else if ( W.Type == Weapon.WeaponTypes.Thrown )
            {
                item_class = W.Thrown.ToString();
            }
            
        }
        else if ( I.ItemType == Item.ItemTypes.Armor )
        {
            m = A.Manufacturer;
            item_class = A.Location.ToString();
        }

        switch ( item_class )
        {
            case "Slash": item_descriptor = Words.Slashers[rand.Next(Words.Slashers.Count)]; break;
            case "Bash": item_descriptor = Words.Bashers[rand.Next(Words.Bashers.Count)]; break;
            case "Smash": item_descriptor = Words.Smashers[rand.Next(Words.Smashers.Count)]; break;
            case "Chop": item_descriptor = Words.Choppers[rand.Next(Words.Choppers.Count)]; break;
            case "Poke": item_descriptor = Words.Pokers[rand.Next(Words.Pokers.Count)]; break;
            case "Slice": item_descriptor = Words.Slicers[rand.Next(Words.Slicers.Count)]; break;

            case "Pistol": item_descriptor = Words.Pistols[rand.Next(Words.Pistols.Count)]; break;
            case "SMG": item_descriptor = Words.SMGs[rand.Next(Words.SMGs.Count)]; break;
            case "Shotgun": item_descriptor = Words.Shotguns[rand.Next(Words.Shotguns.Count)]; break;
            case "LMG": item_descriptor = Words.LMGs[rand.Next(Words.LMGs.Count)]; break;
            case "Sniper": item_descriptor = Words.Snipers[rand.Next(Words.Snipers.Count)]; break;
            case "Launcher": item_descriptor = Words.Launchers[rand.Next(Words.Launchers.Count)]; break;

            case "Head": item_descriptor = Words.Head[rand.Next(Words.Head.Count)]; break;
            case "Face": item_descriptor = Words.Face[rand.Next(Words.Face.Count)]; break;
            case "Neck": item_descriptor = Words.Neck[rand.Next(Words.Neck.Count)]; break;
            case "Back": item_descriptor = Words.Back[rand.Next(Words.Back.Count)]; break;
            case "Chest": item_descriptor = Words.Chest[rand.Next(Words.Chest.Count)]; break;
            case "Waist": item_descriptor = Words.Waist[rand.Next(Words.Waist.Count)]; break;
            case "Shoulders": item_descriptor = Words.Shoulders[rand.Next(Words.Shoulders.Count)]; break;
            case "Arms": item_descriptor = Words.Arms[rand.Next(Words.Arms.Count)]; break;
            case "Wrists": item_descriptor = Words.Wrists[rand.Next(Words.Wrists.Count)]; break;
            case "Hands": item_descriptor = Words.Hands[rand.Next(Words.Hands.Count)]; break;
            case "Legs": item_descriptor = Words.Legs[rand.Next(Words.Legs.Count)]; break;
            case "Feet": item_descriptor = Words.Feet[rand.Next(Words.Feet.Count)]; break;
            default: item_descriptor = "FAILURE"; break;
        }

        var num = 0;

        if ( m == Item.Manufacturers.MobySickDesigns )
        { num = rand.Next(1,3); }
        else if ( m == Item.Manufacturers.ArchCraftCreations )
        { num = rand.Next(3,5); }
        else if ( m == Item.Manufacturers.ChronicChaosCompany )
        { num = rand.Next(5,7); }
        else if ( m == Item.Manufacturers.FriendlyFireIndustries )
        { num = rand.Next(7,9);}
        else if ( m == Item.Manufacturers.SlapCrapManufacturing )
        { num = rand.Next(9,11); }

        switch ( num )
        {
            case 1: return ThingOfTheLastThing();
            case 2: return NameSursThingOfTrueFeelings();
            case 3: return PreSurColorThing();
            case 4: return NamesThingForTheThingVerbers();
            case 5: return VerbTheColorThingWithFeelings();
            case 6: return VerbTheThingPre();
            case 7: return ProColorThingOfPlaceOrTime();
            case 8: return FeelingIsAThingInTimeOrPlace();
            case 9: return ColorNameAdjThings();
            case 10: return PreSurAdjThingThing();
            default: return "FAILED";
        }
        
    }
        private string ThingOfTheLastThing()
    {
        var thing = Words.Things[rand.Next(Words.Things.Count)];
        var color = Words.Colors[rand.Next(Words.Colors.Count)];

        var ofthe = "";

        //SlapCrap
        var num = rand.Next(1,31);
        if ( num < 9 ) { ofthe = "Last"; }
        else if ( num > 22 ) { ofthe = "Second"; }
        else if ( num == 9 || num == 13 || num == 18 || num == 22 ) { ofthe = "Great"; }
        else { ofthe = "First"; }

        var full = item_descriptor + " Of The " + ofthe + " " + color + " " + thing;

        Console.WriteLine(full);
        return full;
    }

    private string NameSursThingOfTrueFeelings()
    {
        var name = Words.Names[rand.Next(Words.Names.Count)];
        var sur = Words.Surnames[rand.Next(Words.Surnames.Count)];
        var feelings = Words.Feelings[rand.Next(Words.Feelings.Count)];


        //SlapCrap
        var full = name + " " + sur + "'s " + item_descriptor + " Of True " + feelings;


        Console.WriteLine(full);
        return full;
    }
    private string PreSurColorThing()
    {
        var pre = Words.Prefixes[rand.Next(Words.Prefixes.Count)];
        var sur = Words.Surnames[rand.Next(Words.Surnames.Count)];
        var color = Words.Colors[rand.Next(Words.Colors.Count)];

        //MobySick

        var full = pre + " " + sur + "'s " + color + " " + item_descriptor;
        

        Console.WriteLine(full);
        return full;
    }


    private string NamesThingForTheThingVerbers()
    {
        var name = Words.Names[rand.Next(Words.Names.Count)];
        var verbers = Words.Verbs[rand.Next(Words.Verbs.Count)];
        var thing = Words.Things[rand.Next(Words.Things.Count)];

        if ( W.Type == Weapon.WeaponTypes.Melee )
        {
            verbers = item_class;
            if ( verbers == "Chop" ) { verbers = "Chopp"; }
            else if ( verbers == "Poke" ) { verbers = "Pok"; }
            else if ( verbers == "Slice" ) { verbers = "Slic"; }
        }


        //MobySick
        var full = name + "'s " + item_descriptor + " For " + thing + " " + verbers + "ers";


        Console.WriteLine(full);
        return full;
    }

    private string VerbTheColorThingWithFeelings()
    {
        var feelings = Words.Feelings[rand.Next(Words.Feelings.Count)];
        var color = Words.Colors[rand.Next(Words.Colors.Count)];
        var verb = Words.Verbs[rand.Next(Words.Verbs.Count)];

        //ChronicChaos
        var full = verb + " The " + color + " " + item_descriptor + " With " + feelings;


        Console.WriteLine(full);
        return full;
    }

    private string VerbTheThingPre()
    {
        var verb = Words.Verbs[rand.Next(Words.Verbs.Count)];
        var place = Words.Places[rand.Next(Words.Places.Count)];
        var pro = Words.Pronouns[rand.Next(Words.Pronouns.Count)];

        var full = place + " Will " + verb + " At " + pro + " " + item_descriptor;
        

        //ChronicChaos
        
        


        Console.WriteLine(full);
        return full;
    }

    private string ProColorThingOfPlaceOrTime()
    {
        var pro = Words.Pronouns[rand.Next(Words.Pronouns.Count)];
        var color = Words.Colors[rand.Next(Words.Colors.Count)];

        var full =  "";

        var something = "";

        if (rand.Next(1,101) > 50 )
        {
            something = Words.Places[rand.Next(Words.Places.Count)];
        }
        else
        {
            something = Words.Times[rand.Next(Words.Times.Count)];
        }

        //ArchCraft
        full = pro + " " + color + " " + item_descriptor + " Of " + something;


        Console.WriteLine(full);
        return full;
    }

    private string FeelingIsAThingInTimeOrPlace()
    {
        var num = rand.Next(1,101);
        var feeling = Words.Feelings[rand.Next(Words.Feelings.Count)];

        //ArchCraft
        var full = feeling + " Is A " + item_descriptor + " For ";

        if ( num < 50 )
        {
            var place = Words.Places[rand.Next(Words.Places.Count)];
            full = full + place;
        }
        else
        {
            var time = Words.Times[rand.Next(Words.Times.Count)];
            full = full + time;
        }


        Console.WriteLine(full);
        return full;
    }

    private string ColorNameAdjThings()
    {
        var pre = Words.Prefixes[rand.Next(Words.Prefixes.Count)];
        var name = Words.Names[rand.Next(Words.Names.Count)];
        var verbs = Words.Verbs[rand.Next(Words.Verbs.Count)];
        var adj = Words.Adjectives[rand.Next(Words.Adjectives.Count)];

        //FriendlyFire
        var full = pre + " " + name + " Can " + verbs + " " + adj + " " + item_descriptor + "s";


        Console.WriteLine(full);
        return full;
    }
    private string PreSurAdjThingThing()
    {
        var pre = Words.Prefixes[rand.Next(Words.Prefixes.Count)];
        var sur = Words.Surnames[rand.Next(Words.Surnames.Count)];
        var adj = Words.Adjectives[rand.Next(Words.Adjectives.Count)];

        var full = pre + " " + sur + "'s " + adj + " " + item_descriptor;

        //FriendlyFire
        Console.WriteLine(full);
        return full;
    }



    //Constructors
    public ItemNamer()
    {

    }


}