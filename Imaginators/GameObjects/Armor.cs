using System;

public class Armor : Item
{

    // Variables - Enums at Bottom

    public double MaxArmor { get; set; }
    public double BaseMaxArmor { get; set; }
    public double RechargeRate { get; set; }
    public double BaseRechargeRate { get; set; }

    public double HP { get; set; }

    public bool HasRegen { get; set; }
    public double RegenRate { get; set; }
     public double BaseRegenRate { get; set; }

    public Locations Location { get; set; }
    public double LocationCount { get; set; }
    public ArmorTypes Type { get; set; }

    public double MovementPenalty { get; set; }
    public double StandardPentaly { get; set; }

    public double MovementBonus { get; set; }
    public double StandardBonus { get; set; }



    //  Constructors
    public Armor()
    {

        //  Item Inherited
        Name = null;
        Width = 1;
        Height = 1;
        Rarity = Rarities.NULL;
        Quality = Qualities.NULL;
        Manufacturer = Manufacturers.NULL;
        IsElemental = false;
        Element = ElementalTypes.NULL;
    }

    public Armor(ArmorTypes t)
    {
        //  Item Inherited
        Name = null;
        Width = 1;
        Height = 1;
        Rarity = Rarities.NULL;
        Quality = Qualities.NULL;
        Manufacturer = Manufacturers.NULL;
        IsElemental = false;
        Element = ElementalTypes.NULL;
        Type = t;

        // Armor Specific
        
    }

    public enum Locations { NULL, Head, Face, Neck, Shoulders,
     Arms, Wrists, Hands, Chest, Back, Waist, Feet, Legs }

    public enum ArmorTypes { NULL, Hat, Hood, Helmet, Mask, Goggles, Greaves,
    ShoulderBraces, Necklace, Chaps, ElbowGuards, Bracers, Bracelet,
    Gloves, Rings, Shirt, Pants, Chainmail, Platemail, Forcefield, Sheild,
    KneePads, Boots, Shoes, Belt, Scarf, Cape, Cloak, ShinGuards, Glasses }
}