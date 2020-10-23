using System;
using Microsoft.AspNetCore.Components.Web;
public class Item
{
    //   Create Instance of Armor
    // public Item ThisItem = new Item();
    
    //  Variables - Enums at Bottom

    public double ID { get; set; }
    public string Name { get; set;}
    public bool IsLucky { get; set; }
    public bool IsErratic { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double MaxSize { get; set; }

    public ItemTypes ItemType { get; set; }
    public Rarities Rarity { get; set; }
    public Qualities Quality { get; set; }

    public Manufacturers Manufacturer { get; set; }
    public bool IsElemental { get; set; }
    public ElementalTypes Element { get; set; }



    // Vars for Pack Logic, should probably move
    public bool Rotated { get; set; }

    public double Anchor_Row { get; set; }
    public double Anchor_Col { get; set; }

    public double X { get; set; }
    public double Y { get; set; }

    
    
    //  Code (Rotate is for Pack Logic, should likely move)
    public void Rotate(MouseEventArgs e)
    {
        var w = Width;
        var h = Height;
        Width = h;
        Height = w;
        Rotated = !Rotated;
    }

    //  Constructors
    public Item()
    {
        Rotated = false;
        // Name = ItemNamer.CreateName();
    }

    //  Enums
    public enum ElementalTypes { NULL, Earth, Fire, Water,
    Wind, Cosmic, Atomic, Plasma, Ice, Storm, Chaos }

    public enum Rarities { NULL, Common, Uncommon, Rare, Artifact, Relic, Legend }

    public enum Qualities { NULL, Rubish, Used, Refurbished, OpenBox, Pristine, Mint }

    public enum ItemTypes { NULL, Weapon, Consumeable, Armor }

    public enum Manufacturers { NULL, MobySickDesigns, ArchCraftCreations,
    ChronicChaosCompany, FriendlyFireIndustries, SlapCrapManufacturing }
    // Biotics, Electronics, Sonics, Blastotics, Mentonics, Forcotics

}