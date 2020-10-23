using System;

public class Weapon : Item
{
    //   Create Instance of Weapon
    // public Weapon ThisWeapon = new Weapon();

     // Variables - Enums at Bottom
    public WeaponTypes Type { get; set; }
    public MeleeTypes Melee { get; set; }
    public RangedTypes Ranged { get; set; }
    public ThrownTypes Thrown { get; set; }

    public CapacityTypes CapacityType { get; set; }
    public UseTypes UseType { get; set; }
    public CooldownTypes CooldownType { get; set; }

    public bool IsExplosive { get; set; }
    public double ExplosionRate { get; set; }

    
    public double Damage { get; set; }
    public double BaseDamage { get; set; }
    public DamageTypes DamageType { get; set; }

    public double MinAccuracy { get; set; }
    public double BaseMinAccuracy { get; set; }
    public double MaxAccuracy { get; set; }
    public double BaseMaxAccuracy { get; set; }

    public double MinRange { get; set; }
    public double MaxRange { get; set; }
    
    public double MaxRangePenalty { get; set; }
    public double MinRangePentaly { get; set; }
    public double MovementPenalty { get; set; }
    public double StandardPentaly { get; set; }
    

    public double Capacity { get; set; }
    public double BaseCapacity { get; set; }

    public double ReplenishRate { get; set; }
    public double BaseReplenishRate { get; set; }

    public double DicePerAttack { get; set; }
    public double BaseDicePerAttack { get; set; }

    public double LuckyIconID_01 { get; set; }
    public double LuckyIconID_02 { get; set; }
    public double LuckyIconID_03 { get; set; }

    

    public double ElementPower { get; set; }
    public double ElementDuration { get; set; }
    public double ElementChance { get; set; }
    public string ElementEffect { get; set; }

    //  Other Code Here

    public void SetUITerms(Weapon w)
    {
        if ( w.Type == Weapon.WeaponTypes.Melee )
        {
            w.CapacityType = CapacityTypes.Combo;
            w.UseType = UseTypes.Strike;
            w.CooldownType = CooldownTypes.Refresh;
        }
        if ( w.Type == Weapon.WeaponTypes.Ranged )
        {
            w.CapacityType = CapacityTypes.Clip;
            w.UseType = UseTypes.Ammo;
            w.CooldownType = CooldownTypes.Reload;
        }
        if ( w.Type == Weapon.WeaponTypes.Thrown )
        {
            w.CapacityType = CapacityTypes.Bando;
            w.UseType = UseTypes.Throw;
            w.CooldownType = CooldownTypes.Refill;
        }
        
    }
   
    //  Constructors - Enums Below
    public Weapon() {

    }

    // Enums
    public enum WeaponTypes { NULL, Melee, Ranged, Thrown }
    public enum CapacityTypes { NULL, Clip, Combo, Bando }
    public enum UseTypes { NULL, Ammo, Strike, Throw }
    public enum CooldownTypes { NULL, Reload, Refresh, Refill }

    public enum MeleeTypes { NULL, Slash, Bash, Smash, Chop, Poke, Slice }

    public enum RangedTypes { NULL, Pistol, SMG, LMG, Shotgun, Sniper, Launcher }

    public enum ThrownTypes { NULL, Boomerang, NinjaStar, Dart, ThrowingKnife,
    Tomahawk, Grenade, Javalin, MajorKong }

    public enum DamageTypes { NULL, Cut, Piercing, Concuss, Burn, Shrapnel, Bleed, Breaking }

}