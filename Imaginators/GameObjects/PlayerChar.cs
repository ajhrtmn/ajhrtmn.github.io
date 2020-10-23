using System;

public class PlayerChar : Actor
{
    public double EXP { get; set; }

    public Skills.Melee.Damage MeleeDamage = new Skills.Melee.Damage();
    public Skills.Melee.Strike MeleeStrike = new Skills.Melee.Strike();
    public Skills.Melee.Combo MeleeCombo = new Skills.Melee.Combo();
    public Skills.Melee.Accuracy MeleeAccuracy = new Skills.Melee.Accuracy();

    public Skills.Ranged.Damage RangedDamage = new Skills.Ranged.Damage();
    public Skills.Ranged.Accuracy RangedAccuracy = new Skills.Ranged.Accuracy();
    public Skills.Ranged.Ammo RangedAmmo = new Skills.Ranged.Ammo();
    public Skills.Ranged.Reload RangedReload = new Skills.Ranged.Reload();

    public Skills.Armor.Location ArmorLocation = new Skills.Armor.Location();
    public Skills.Armor.Brawn ArmorBrawn = new Skills.Armor.Brawn();
    public Skills.Armor.Capacity ArmorCapacity = new Skills.Armor.Capacity();
    public Skills.Armor.Recharge ArmorRecharge = new Skills.Armor.Recharge();

    public Skills.Combat.Power CombatPower = new Skills.Combat.Power();
    public Skills.Combat.Cooldown CombatCooldown = new Skills.Combat.Cooldown();
    public Skills.Combat.Loadout CombatLoadout = new Skills.Combat.Loadout();
    public Skills.Combat.Mastery CombatMastery = new Skills.Combat.Mastery();

    public Skills.Stats.Movement StatsMovement = new Skills.Stats.Movement();
    public Skills.Stats.Standard StatsStandard = new Skills.Stats.Standard();
    public Skills.Stats.Constitution StatsConstitution = new Skills.Stats.Constitution();
    public Skills.Stats.Stamina StatsStamina = new Skills.Stats.Stamina();

    public Skills.Elements.Calm ElementsCalm = new Skills.Elements.Calm();
    public Skills.Elements.Chaos ElementsChaos = new Skills.Elements.Chaos();
    public Skills.Elements.Quantum ElementsQuantum = new Skills.Elements.Quantum();
    public Skills.Elements.Chemic ElementsChemic = new Skills.Elements.Chemic();

    public Skills.Utility.Nimbleness UtilityNimbleness = new Skills.Utility.Nimbleness();
    public Skills.Utility.Karma UtilityKarma = new Skills.Utility.Karma();
    public Skills.Utility.Insight UtilityInsight = new Skills.Utility.Insight();
    public Skills.Utility.Intellect UtilityIntellect = new Skills.Utility.Intellect();


    public void SetStartingSkills()
    {
        MeleeDamage.LVL = 1.0;
        MeleeStrike.LVL = 1.0;
        MeleeCombo.LVL = 1.0;
        MeleeAccuracy.LVL = 1.0;

        RangedDamage.LVL = 1.0;
        RangedAccuracy.LVL = 1.0;
        RangedAmmo.LVL = 1.0;
        RangedReload.LVL = 1.0;

        ArmorLocation.LVL = 1.0;
        ArmorBrawn.LVL = 1.0;
        ArmorCapacity.LVL = 1.0;
        ArmorRecharge.LVL = 1.0;

        CombatPower.LVL = 1.0;
        CombatCooldown.LVL = 1.0;
        CombatLoadout.LVL = 1.0;
        CombatMastery.LVL = 1.0;

        StatsMovement.LVL = 1.0;
        StatsStandard.LVL = 1.0;
        StatsConstitution.LVL = 1.0;
        StatsStamina.LVL = 1.0;

        ElementsCalm.LVL = 1.0;
        ElementsChaos.LVL = 1.0;
        ElementsQuantum.LVL = 1.0;
        ElementsChemic.LVL = 1.0;

        UtilityNimbleness.LVL = 1.0;
        UtilityKarma.LVL = 1.0;
        UtilityInsight.LVL = 1.0;
        UtilityIntellect.LVL = 1.0;

        SetNewLVL();
    }

    public void SetNewLVL()
    {
        LVL =  MeleeDamage.LVL;
        LVL +=  MeleeStrike.LVL;
        LVL +=  MeleeCombo.LVL;
        LVL +=  MeleeAccuracy.LVL;

        LVL +=  RangedDamage.LVL;
        LVL +=  RangedAccuracy.LVL;
        LVL +=  RangedAmmo.LVL;
        LVL +=  RangedReload.LVL;

        LVL +=  ArmorLocation.LVL;
        LVL +=  ArmorBrawn.LVL;
        LVL +=  ArmorCapacity.LVL;
        LVL +=  ArmorRecharge.LVL;

        LVL +=  CombatPower.LVL;
        LVL +=  CombatCooldown.LVL;
        LVL +=  CombatLoadout.LVL;
        LVL +=  CombatMastery.LVL;

        LVL +=  StatsMovement.LVL;
        LVL +=  StatsStandard.LVL;
        LVL +=  StatsConstitution.LVL;
        LVL +=  StatsStamina.LVL;

        LVL +=  ElementsCalm.LVL;
        LVL +=  ElementsChaos.LVL;
        LVL +=  ElementsQuantum.LVL;
        LVL +=  ElementsChemic.LVL;

        LVL +=  UtilityNimbleness.LVL;
        LVL +=  UtilityKarma.LVL;
        LVL +=  UtilityInsight.LVL;
        LVL +=  UtilityIntellect.LVL;

        LVL = Math.Ceiling( LVL / 7 ) - 3; 
    }

    public double Pack_Unlocked_Rows;
    public double Pack_Unlocked_Cols;

}