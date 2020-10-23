public class Foe : Actor
{
    public string Faction { get; set; }
    public bool Is_Elite { get; set; }
    public bool Is_Boss { get; set; }



    public double Armor_Recharge { get; set; }
    public double Health_Regen { get; set; }

    public double Movement { get; set; }
    public double Standard { get; set; }

    public double Range_High { get; set; }
    public double Range_Low { get; set; }

    public double Accuracy { get; set; }

    public double Damage { get; set; }
    public double DicePerAttack { get; set; }

    public string Elemental_Resistance { get; set; }
    public string Element_Weakness { get; set; }
    public string Weapon_Resistance { get; set; }
    public string Weapon_Weakness { get; set; }
    public string Armor_Advantage { get; set; }
    public string Armor_Disadvantage { get; set; }

    public string Buff { get; set; }
    public double Buff_Duration { get; set; }
    public string Debuff { get; set; }
    public double Debuff_Duration { get; set; }
    
    public string Effect { get; set; }
    public string Effect_Chance { get; set; }
    public string Effect_Duration_High { get; set; }
    public string Effect_Duration_Low { get; set; }
}