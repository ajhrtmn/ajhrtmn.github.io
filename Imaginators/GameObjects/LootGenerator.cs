using System;

public class LootGenerator
{
    public ItemNamer ItemNamer = new ItemNamer();
    public Item Item = new Item();
    public Weapon Weapon = new Weapon();
    public Armor Armor = new Armor();


    private void SetAttributes(Item item)
    {
        var i =  item.ItemType;
        var rand = new Random();
        var num = rand.Next();

        if ( i == Item.ItemTypes.Consumeable )
        {
            Item.Width = 2;
            Item.Height = 2;
        }
        else if ( i == Item.ItemTypes.Weapon )
        {
            var w = Weapon.Type;
            if ( w == Weapon.WeaponTypes.Melee )
            {
                var t = Weapon.Melee;
                if ( t == Weapon.MeleeTypes.Slash )
                {
                    num = rand.Next(1,3);
                    Item.Width = num;
                    num = rand.Next(2,7);
                    Item.Height = num;

                    Item.MaxSize = 12;

                    Weapon.BaseDamage = rand.Next(100,201);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,2);
                    Weapon.StandardPentaly = rand.Next(0,2);

                    Weapon.BaseCapacity = rand.Next(3,8);
                    Weapon.BaseReplenishRate = rand.Next(3,8);
                    Weapon.BaseDicePerAttack = rand.Next(1,4);

                    Weapon.BaseMinAccuracy = rand.Next(40,51);
                    Weapon.BaseMaxAccuracy = rand.Next(70,81);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,1);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.MeleeTypes.Bash )
                {
                    num = rand.Next(1,3);
                    Item.Width = num;
                    num = rand.Next(2,6);
                    Item.Height = num;

                    Item.MaxSize = 10;

                    Weapon.BaseDamage = rand.Next(40,61);
                    Weapon.DamageType = Weapon.DamageTypes.Breaking;

                    Weapon.MovementPenalty = rand.Next(0,2);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(3,11);
                    Weapon.BaseReplenishRate = rand.Next(3,8);
                    Weapon.BaseDicePerAttack = rand.Next(3,6);

                    Weapon.BaseMinAccuracy = rand.Next(25,36);
                    Weapon.BaseMaxAccuracy = rand.Next(60,71);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,1);

                    if ( rand.Next(1, 1001) < 75 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(5,76) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.MeleeTypes.Smash )
                {
                    num = rand.Next(2,4);
                    Item.Width = num;
                    num = rand.Next(3,7);
                    Item.Height = num;

                    Item.MaxSize = 18;

                    Weapon.BaseDamage = rand.Next(325,451);
                    Weapon.DamageType = Weapon.DamageTypes.Concuss;

                    Weapon.MovementPenalty = rand.Next(1,3);
                    Weapon.StandardPentaly = rand.Next(0,3);

                    Weapon.BaseCapacity = rand.Next(1,4);
                    Weapon.BaseReplenishRate = rand.Next(1,4);
                    Weapon.BaseDicePerAttack = rand.Next(1,3);

                    Weapon.BaseMinAccuracy = rand.Next(5,16);
                    Weapon.BaseMaxAccuracy = rand.Next(50,61);
                    Weapon.MinRange = 1;
                    Weapon.MaxRange = rand.Next(1,3);

                    if ( rand.Next(1, 1001) < 135 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(25,51) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.MeleeTypes.Chop )
                {
                    num = rand.Next(1,4);
                    Item.Width = num;
                    num = rand.Next(3,7);
                    Item.Height = num;

                    Item.MaxSize = 18;

                    Weapon.BaseDamage = rand.Next(160,241);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(1,3);
                    Weapon.StandardPentaly = rand.Next(0,2);

                    Weapon.BaseCapacity = rand.Next(2,6);
                    Weapon.BaseReplenishRate = rand.Next(1,4);
                    Weapon.BaseDicePerAttack = rand.Next(1,3);

                    Weapon.BaseMinAccuracy = rand.Next(10,21);
                    Weapon.BaseMaxAccuracy = rand.Next(60,71);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(1,3);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.MeleeTypes.Poke )
                {
                    num = rand.Next(1,2);
                    Item.Width = num;
                    num = rand.Next(4,7);
                    Item.Height = num;

                    Item.MaxSize = 6;

                    Weapon.BaseDamage = rand.Next(130,231);
                    Weapon.DamageType = Weapon.DamageTypes.Piercing;

                    Weapon.MovementPenalty = rand.Next(0,3);
                    Weapon.StandardPentaly = rand.Next(1,3);

                    Weapon.BaseCapacity = rand.Next(2,7);
                    Weapon.BaseReplenishRate = rand.Next(2,5);
                    Weapon.BaseDicePerAttack = rand.Next(2,4);

                    Weapon.BaseMinAccuracy = rand.Next(25,36);
                    Weapon.BaseMaxAccuracy = rand.Next(60,71);
                    Weapon.MinRange = 1;
                    Weapon.MaxRange = rand.Next(1,4);

                    if ( Weapon.MaxRange == 3 ) { Weapon.MaxRange = rand.Next(2,4); }

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.MeleeTypes.Slice )
                {
                    num = rand.Next(1,2);
                    Item.Width = num;
                    num = rand.Next(2,4);
                    Item.Height = num;

                    Item.MaxSize = 3;

                    Weapon.BaseDamage = rand.Next(25,61);
                    Weapon.DamageType = Weapon.DamageTypes.Bleed;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(9,17);
                    Weapon.BaseReplenishRate = rand.Next(5,10);
                    Weapon.BaseDicePerAttack = rand.Next(4,9);

                    Weapon.BaseMinAccuracy = rand.Next(45,56);
                    Weapon.BaseMaxAccuracy = rand.Next(75,86);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
            }
            if ( w == Weapon.WeaponTypes.Ranged )
            {
                var t = Weapon.Ranged;
                if ( t == Weapon.RangedTypes.Pistol )
                {
                    num = rand.Next(2,3);
                    Item.Width = num;
                    num = rand.Next(2,4);
                    Item.Height = num;

                    Item.MaxSize = 6;

                    Weapon.BaseDamage = rand.Next(60,80);;
                    Weapon.DamageType = Weapon.DamageTypes.Piercing;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(9,21);
                    Weapon.BaseReplenishRate = rand.Next(4,10);
                    Weapon.BaseDicePerAttack = rand.Next(3,7);

                    Weapon.BaseMinAccuracy = rand.Next(45,56);
                    Weapon.BaseMaxAccuracy = rand.Next(70,81);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(1,4);

                    if ( rand.Next(1, 1001) < 123 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(33,51) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.RangedTypes.SMG )
                {
                    num = rand.Next(2,4);
                    Item.Width = num;
                    num = rand.Next(2,4);
                    Item.Height = num;

                    Item.MaxSize = 9;

                    Weapon.BaseDamage = rand.Next(45,75);;
                    Weapon.DamageType = Weapon.DamageTypes.Piercing;

                    Weapon.MovementPenalty = rand.Next(0,3);
                    Weapon.StandardPentaly = rand.Next(0,2);

                    if ( Weapon.StandardPentaly == 1 ) { Weapon.StandardPentaly = rand.Next(0,2); }

                    Weapon.BaseCapacity = rand.Next(11,19);
                    Weapon.BaseReplenishRate = rand.Next(6,12);
                    Weapon.BaseDicePerAttack = rand.Next(3,8);

                    Weapon.BaseMinAccuracy = rand.Next(20,31);
                    Weapon.BaseMaxAccuracy = rand.Next(40,56);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,4);

                    if ( Weapon.MaxRange == 3 ) { Weapon.MaxRange = rand.Next(1,4); }

                    if ( rand.Next(1, 1001) < 45 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(1,19) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.RangedTypes.Shotgun )
                {
                    num = rand.Next(2,3);
                    Item.Width = num;
                    num = rand.Next(3,6);
                    Item.Height = num;

                    Item.MaxSize = 10;

                    Weapon.BaseDamage = rand.Next(35,66);;
                    Weapon.DamageType = Weapon.DamageTypes.Shrapnel;

                    Weapon.MovementPenalty = rand.Next(0,2);
                    Weapon.StandardPentaly = rand.Next(1,3);

                    Weapon.BaseCapacity = rand.Next(16,33);
                    Weapon.BaseReplenishRate = rand.Next(6,13);
                    Weapon.BaseDicePerAttack = rand.Next(3,14);

                    Weapon.BaseMinAccuracy = rand.Next(10,21);
                    Weapon.BaseMaxAccuracy = rand.Next(55,71);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,3);

                    if ( rand.Next(1, 1001) < 234 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(18,46) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.RangedTypes.LMG )
                {
                    num = rand.Next(2,4);
                    Item.Width = num;
                    num = rand.Next(4,7);
                    Item.Height = num;

                    Item.MaxSize = 18;

                    Weapon.BaseDamage = rand.Next(3,8);;
                    Weapon.DamageType = Weapon.DamageTypes.Bleed;

                    Weapon.MovementPenalty = rand.Next(1,3);
                    Weapon.StandardPentaly = rand.Next(1,3);

                    Weapon.BaseCapacity = rand.Next(24,42);
                    Weapon.BaseReplenishRate = rand.Next(14,29);
                    Weapon.BaseDicePerAttack = rand.Next(16,25);

                    Weapon.BaseMinAccuracy = rand.Next(5,21);
                    Weapon.BaseMaxAccuracy = rand.Next(30,46);
                    Weapon.MinRange = 1;
                    Weapon.MaxRange = rand.Next(1,5);

                    if ( Weapon.MaxRange == 4 ) { Weapon.MaxRange = rand.Next(2,5); }

                    if ( rand.Next(1, 1001) < 12 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(3,16) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.RangedTypes.Sniper )
                {
                    num = rand.Next(2,3);
                    Item.Width = num;
                    num = rand.Next(5,7);
                    Item.Height = num;

                    Item.MaxSize = 12;

                    Weapon.BaseDamage = rand.Next(265,326);;
                    Weapon.DamageType = Weapon.DamageTypes.Piercing;

                    Weapon.MovementPenalty = rand.Next(0,3);
                    Weapon.StandardPentaly = rand.Next(0,3);

                    Weapon.BaseCapacity = rand.Next(3,8);
                    Weapon.BaseReplenishRate = rand.Next(3,5);
                    Weapon.BaseDicePerAttack = rand.Next(1,4);

                    if ( Weapon.BaseDicePerAttack >= 2 ) { Weapon.BaseDicePerAttack = rand.Next(1,4); }
                    if ( Weapon.BaseDicePerAttack == 3 ) { Weapon.BaseDicePerAttack = rand.Next(1,4); }
                    if ( Weapon.BaseDicePerAttack == 3 ) { Weapon.BaseDicePerAttack = rand.Next(2,4); }

                    Weapon.BaseMinAccuracy = rand.Next(45,51);
                    Weapon.BaseMaxAccuracy = rand.Next(75,86);
                    Weapon.MinRange = 1;
                    Weapon.MaxRange = rand.Next(2,7);

                    if ( Weapon.MaxRange >= 3 ) { Weapon.MaxRange = rand.Next(3,7); }
                    if ( Weapon.MaxRange >= 5 ) { Weapon.MaxRange = rand.Next(4,7); }
                    if ( Weapon.MaxRange > 5 ) { Weapon.MaxRange = rand.Next(5,7); }
                    if ( Weapon.MaxRange == 6 ) { Weapon.MaxRange = rand.Next(5,7); }

                    if ( rand.Next(1, 1001) < 345 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(22,67) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.RangedTypes.Launcher )
                {
                    num = rand.Next(2,4);
                    Item.Width = num;
                    num = rand.Next(4,7);
                    Item.Height = num;

                    Item.MaxSize = 18;

                    Weapon.BaseDamage = rand.Next(250,501);;
                    Weapon.DamageType = Weapon.DamageTypes.Concuss;

                    Weapon.MovementPenalty = rand.Next(1,4);
                    Weapon.StandardPentaly = rand.Next(1,3);

                    Weapon.BaseCapacity = rand.Next(1,5);
                    Weapon.BaseReplenishRate = rand.Next(1,3);
                    Weapon.BaseDicePerAttack = rand.Next(1,5);

                    Weapon.BaseMinAccuracy = rand.Next(1,11);
                    Weapon.BaseMaxAccuracy = rand.Next(75,81);
                    Weapon.MinRange = rand.Next(1,3);;
                    Weapon.MaxRange = rand.Next(2,7);

                    if ( Weapon.MaxRange < 4 ) { Weapon.MaxRange = rand.Next(2,7); }
                    if ( Weapon.MaxRange < 3 ) { Weapon.MaxRange = rand.Next(2,7); }
                    if ( Weapon.MaxRange == 6 ) { Weapon.MaxRange = rand.Next(4,7); }
                    if ( Weapon.MaxRange == 6 ) { Weapon.MaxRange = rand.Next(4,7); }
                    if ( Weapon.MaxRange == 6 ) { Weapon.MaxRange = rand.Next(5,7); }

                    if ( rand.Next(1, 1001) < 700 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = 1; } else { Weapon.ExplosionRate = 0; }
                }
            }
            if ( w == Weapon.WeaponTypes.Thrown )
            {
                Weapon.ReplenishRate = 0;
                var t = Weapon.Thrown;
                if ( t == Weapon.ThrownTypes.Boomerang )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.ThrownTypes.Dart )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.ThrownTypes.Grenade )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.ThrownTypes.Javalin )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.ThrownTypes.NinjaStar )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.ThrownTypes.ThrowingKnife )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
                else if ( t == Weapon.ThrownTypes.Tomahawk )
                {
                    num = rand.Next(0,0);
                    Item.Width = num;
                    num = rand.Next(0,0);
                    Item.Height = num;

                    Item.MaxSize = 0;

                    Weapon.BaseDamage = rand.Next(0,0);
                    Weapon.DamageType = Weapon.DamageTypes.Cut;

                    Weapon.MovementPenalty = rand.Next(0,0);
                    Weapon.StandardPentaly = rand.Next(0,0);

                    Weapon.BaseCapacity = rand.Next(0,0);
                    Weapon.BaseReplenishRate = rand.Next(0,0);
                    Weapon.BaseDicePerAttack = rand.Next(0,0);

                    Weapon.BaseMinAccuracy = rand.Next(0,0);
                    Weapon.BaseMaxAccuracy = rand.Next(0,0);
                    Weapon.MinRange = 0;
                    Weapon.MaxRange = rand.Next(0,0);

                    if ( rand.Next(1, 1001) < 1 ) { Weapon.IsExplosive = true; } else { Weapon.IsExplosive = false; }
                    if ( Weapon.IsExplosive == true ) { Weapon.ExplosionRate = rand.Next(0,0) / 100 ; } else { Weapon.ExplosionRate = 0; }
                }
            }

            Weapon.MaxRangePenalty = 0;
            Weapon.MinRangePentaly = 0;

            Weapon.Width = Item.Width;
            Weapon.Height = Item.Height;
            Weapon.MaxSize = Item.MaxSize;

            if ( Weapon.BaseCapacity < Weapon.ReplenishRate ) { Weapon.BaseReplenishRate = Weapon.BaseCapacity; }
            if ( Weapon.BaseCapacity < Weapon.DicePerAttack ) { Weapon.BaseDicePerAttack = Weapon.BaseCapacity; }

            if ( Weapon.BaseMaxAccuracy <= Weapon.BaseMinAccuracy ) { Weapon.BaseMinAccuracy -= 15; }
            if ( Weapon.MaxRange < Weapon.MinRange ) { Weapon.MinRange = Weapon.MaxRange; }

        }
        else if ( i == Item.ItemTypes.Armor )
        {
            var a = Armor.Location;
            if ( a == Armor.Locations.Head )
            {
                num = rand.Next(2,3);
                Item.Width = num;
                num = rand.Next(2,3);
                Item.Height = num;

                Item.MaxSize = 4;

                Armor.HP = 50;

                Armor.LocationCount = 1;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,0);

                Armor.BaseMaxArmor = rand.Next(10,21);
                Armor.BaseRechargeRate = rand.Next(10,21);

                if ( rand.Next(1,1001) <= rand.Next(100,176) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(3,9); }
            }
            else if ( a == Armor.Locations.Face )
            {
                num = rand.Next(1,2);
                Item.Width = num;
                num = rand.Next(1,3);
                Item.Height = num;

                Item.MaxSize = 2;

                Armor.HP = 20;

                Armor.LocationCount = 1;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,0);

                Armor.MovementBonus = rand.Next(0,2);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(10,21);
                Armor.BaseRechargeRate = rand.Next(10,21);

                if ( rand.Next(1,1001) <= rand.Next(45,76) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(9,17); }
            }
            else if ( a == Armor.Locations.Neck )
            {
                num = rand.Next(1,4);
                Item.Width = num;
                num = rand.Next(1,3);
                Item.Height = num;

                Item.MaxSize = 6;

                Armor.HP = 33;

                Armor.LocationCount = 2;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(18,33);
                Armor.BaseRechargeRate = rand.Next(13,28);

                if ( rand.Next(1,1001) <= rand.Next(175,226) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(4,9); }
            }
            else if ( a == Armor.Locations.Back )
            {
                num = rand.Next(2,4);
                Item.Width = num;
                num = rand.Next(3,6);
                Item.Height = num;

                Item.MaxSize = 15;

                Armor.HP = 50;

                Armor.LocationCount = 1;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,2);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(85,126);
                Armor.BaseRechargeRate = rand.Next(50,75);

                if ( rand.Next(1,1001) <= rand.Next(45,95) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(4,14); }
            }
            else if ( a == Armor.Locations.Chest )
            {
                num = rand.Next(2,5);
                Item.Width = num;
                num = rand.Next(3,7);
                Item.Height = num;

                Item.MaxSize = 24;

                Armor.HP = 100;

                Armor.LocationCount = 1;

                Armor.MovementPenalty = rand.Next(0,2);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,3);

                Armor.BaseMaxArmor = rand.Next(225,376);
                Armor.BaseRechargeRate = rand.Next(155,226);

                if ( rand.Next(1,1001) <= rand.Next(95,176) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(1,11); }
            }
            else if ( a == Armor.Locations.Waist )
            {
                num = rand.Next(3,4);
                Item.Width = num;
                num = rand.Next(1,2);
                Item.Height = num;

                Item.MaxSize = 3;

                Armor.HP = 22;

                Armor.LocationCount = 3;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,0);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,3);

                Armor.BaseMaxArmor = rand.Next(5,21);
                Armor.BaseRechargeRate = rand.Next(3,8);

                if ( rand.Next(1,1001) <= 150 ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(4,12); }
            }
            else if ( a == Armor.Locations.Shoulders )
            {
                num = rand.Next(2,4);
                Item.Width = num;
                num = rand.Next(2,5);
                Item.Height = num;

                Item.MaxSize = 12;

                Armor.HP = 25;

                Armor.LocationCount = 1;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,2);
                Armor.StandardBonus = rand.Next(0,3);

                Armor.BaseMaxArmor = rand.Next(75,126);
                Armor.BaseRechargeRate = rand.Next(65,86);

                if ( rand.Next(1,1001) <= rand.Next(120,181) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(3,13); }
            }
            else if ( a == Armor.Locations.Arms )
            {
                num = rand.Next(1,2);
                Item.Width = num;
                num = rand.Next(2,5);
                Item.Height = num;

                Armor.HP = 15;

                Item.MaxSize = 4;

                Armor.LocationCount = 2;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,2);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(35,66);
                Armor.BaseRechargeRate = rand.Next(25,45);

                if ( rand.Next(1,1001) <= rand.Next(5,16) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(2,17); }
            }
            else if ( a == Armor.Locations.Wrists )
            {
                num = rand.Next(1,2);
                Item.Width = num;
                num = rand.Next(1,3);
                Item.Height = num;

                Item.MaxSize = 2;

                Armor.HP = 10;

                Armor.LocationCount = 4;

                Armor.MovementPenalty = rand.Next(0,2);
                Armor.StandardPentaly = rand.Next(0,0);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(5,16);
                Armor.BaseRechargeRate = rand.Next(3,10);

                if ( rand.Next(1,1001) <= rand.Next(13,26) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(2,8); }
            }
            else if ( a == Armor.Locations.Hands )
            {
                num = rand.Next(1,2);
                Item.Width = num;
                num = rand.Next(1,2);
                Item.Height = num;

                Item.MaxSize = 1;

                Armor.HP = 5;

                Armor.LocationCount = 6;

                Armor.MovementPenalty = rand.Next(0,3);
                Armor.StandardPentaly = rand.Next(0,3);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,3);

                Armor.BaseMaxArmor = rand.Next(3,11);
                Armor.BaseRechargeRate = rand.Next(3,6);

                if ( rand.Next(1,1001) <= rand.Next(10,31) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(3,18); }
            }
            else if ( a == Armor.Locations.Legs )
            {
                num = rand.Next(1,3);
                Item.Width = num;
                num = rand.Next(2,5);
                Item.Height = num;

                Item.MaxSize = 8;

                Armor.HP = 22;

                Armor.LocationCount = 4;

                Armor.MovementPenalty = rand.Next(0,2);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(75,126);
                Armor.BaseRechargeRate = rand.Next(25,76);

                if ( rand.Next(1,1001) <= rand.Next(15,55) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(2,15); }
            }
            else if ( a == Armor.Locations.Feet )
            {
                num = rand.Next(1,3);
                Item.Width = num;
                num = rand.Next(2,4);
                Item.Height = num;

                Item.MaxSize = 6;

                Armor.HP = 25;

                Armor.LocationCount = 2;

                Armor.MovementPenalty = rand.Next(0,0);
                Armor.StandardPentaly = rand.Next(0,2);

                Armor.MovementBonus = rand.Next(0,3);
                Armor.StandardBonus = rand.Next(0,2);

                Armor.BaseMaxArmor = rand.Next(20,31);
                Armor.BaseRechargeRate = rand.Next(10,18);

                if ( rand.Next(1,1001) <= rand.Next(120,230) ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
                if ( Armor.HasRegen == true ) { Armor.BaseRegenRate = rand.Next(3,8); }
            }
            
            
            
            Armor.Width = Item.Width;
            Armor.Height = Item.Height;
            Armor.MaxSize = Item.MaxSize;
        }
    }

    private void SetSubtype(Item item)
    {
        var rand = new Random();
        
        var i =  item.ItemType;

        var num = rand.Next(1,100001);

        if ( i == Item.ItemTypes.Consumeable )
        {
            Item.Height = 2;
            Item.Width = 2;
        }
        else if ( i == Item.ItemTypes.Weapon )
        {
            num = rand.Next(1,100001);
            if ( num < 50001 ) // 40000
            {
                Weapon.Type = Weapon.WeaponTypes.Melee;
                Weapon.Thrown = Weapon.ThrownTypes.NULL;
                Weapon.Ranged = Weapon.RangedTypes.NULL;

                num = rand.Next(1,7);
                if ( num == 1 ) { Weapon.Melee = Weapon.MeleeTypes.Slash; }
                else if ( num == 2 ) { Weapon.Melee = Weapon.MeleeTypes.Bash; }
                else if ( num == 3 ) { Weapon.Melee = Weapon.MeleeTypes.Smash; }
                else if ( num == 4 ) { Weapon.Melee = Weapon.MeleeTypes.Chop; }
                else if ( num == 5 ) { Weapon.Melee = Weapon.MeleeTypes.Poke; }
                else if ( num == 6 ) { Weapon.Melee = Weapon.MeleeTypes.Slice; }

            }
            else if ( num > 50000 ) // 60000
            {
                Weapon.Type = Weapon.WeaponTypes.Ranged;
                Weapon.Melee = Weapon.MeleeTypes.NULL;
                Weapon.Thrown = Weapon.ThrownTypes.NULL;

                num = rand.Next(1,7);
                if ( num == 1 ) { Weapon.Ranged = Weapon.RangedTypes.Pistol; }
                else if ( num == 2 ) { Weapon.Ranged = Weapon.RangedTypes.SMG; }
                else if ( num == 3 ) { Weapon.Ranged = Weapon.RangedTypes.Shotgun; }
                else if ( num == 4 ) { Weapon.Ranged = Weapon.RangedTypes.LMG; }
                else if ( num == 5 ) { Weapon.Ranged = Weapon.RangedTypes.Sniper; }
                else if ( num == 6 ) { Weapon.Ranged = Weapon.RangedTypes.Launcher; }
            }
            else
            {
                Weapon.Type = Weapon.WeaponTypes.Thrown;
                Weapon.Melee = Weapon.MeleeTypes.NULL;
                Weapon.Ranged = Weapon.RangedTypes.NULL;

                num = rand.Next(1,8);
                if ( num == 1 ) { Weapon.Thrown = Weapon.ThrownTypes.Boomerang; }
                else if ( num == 2 ) { Weapon.Thrown = Weapon.ThrownTypes.NinjaStar; }
                else if ( num == 3 ) { Weapon.Thrown = Weapon.ThrownTypes.Dart; }
                else if ( num == 4 ) { Weapon.Thrown = Weapon.ThrownTypes.ThrowingKnife; }
                else if ( num == 5 ) { Weapon.Thrown = Weapon.ThrownTypes.Tomahawk; }
                else if ( num == 6 ) { Weapon.Thrown = Weapon.ThrownTypes.Grenade; }
                else if ( num == 7 ) { Weapon.Thrown = Weapon.ThrownTypes.Javalin; }
            }

            Weapon.Name = Item.Name;
            Weapon.IsLucky = Item.IsLucky;
            Weapon.IsErratic = Item.IsErratic;
            Weapon.Rarity = Item.Rarity;
            Weapon.Quality = Item.Quality;
            Weapon.Manufacturer = Item.Manufacturer;
            Weapon.IsElemental = Item.IsElemental;
            Weapon.Element = Item.Element;
            
        }
        else if ( i == Item.ItemTypes.Armor )
        {

            num = rand.Next(1,13);
            if ( num == 1 ) { Armor.Location = Armor.Locations.Head; }
            else if ( num == 2 ) { Armor.Location = Armor.Locations.Face; }
            else if ( num == 3 ) { Armor.Location = Armor.Locations.Neck; }
            else if ( num == 4 ) { Armor.Location = Armor.Locations.Back; }
            else if ( num == 5 ) { Armor.Location = Armor.Locations.Chest; }
            else if ( num == 6 ) { Armor.Location = Armor.Locations.Waist; }
            else if ( num == 7 ) { Armor.Location = Armor.Locations.Shoulders; }
            else if ( num == 8 ) { Armor.Location = Armor.Locations.Arms; }
            else if ( num == 9 ) { Armor.Location = Armor.Locations.Wrists; }
            else if ( num == 10 ) { Armor.Location = Armor.Locations.Hands; }
            else if ( num == 11 ) { Armor.Location = Armor.Locations.Legs; }
            else if ( num == 12 ) { Armor.Location = Armor.Locations.Feet; }

            Armor.Name = Item.Name;
            Armor.IsLucky = Item.IsLucky;
            Armor.IsErratic = Item.IsErratic;
            Armor.Rarity = Item.Rarity;
            Armor.Quality = Item.Quality;
            Armor.Manufacturer = Item.Manufacturer;
            Armor.IsElemental = Item.IsElemental;
            Armor.Element = Item.Element;
        }
    }
    public void GenerateLoot(PlayerChar pc, double specify_type = 0)
    {
        var rand = new Random();
        var num = rand.Next(1,101);
        var numd = 0.0;
        var qr_bonus = 1.0;

        pc.SetNewLVL();

        if ( num < 37 ) { Item.ItemType = Item.ItemTypes.Weapon; }
        else if ( num > 64 ) { Item.ItemType = Item.ItemTypes.Armor; }
        else { Item.ItemType = Item.ItemTypes.Weapon; }

        if ( specify_type != 0 )
        {
            if ( specify_type == 1 )
            {
                Item.ItemType = Item.ItemTypes.Weapon;
            }
            else if ( specify_type == 2 )
            {
                Item.ItemType = Item.ItemTypes.Armor;
            }
        }

        num = rand.Next(1,100001);
        numd = num + (159.0 * pc.UtilityInsight.LVL);
        if ( numd < 50001 ) { Item.Rarity = Item.Rarities.Common; qr_bonus = 1; }
        else if ( numd > 50000 && num < 75001 ) { Item.Rarity = Item.Rarities.Uncommon; qr_bonus = 1.35; }
        else if ( numd > 75000 && num < 87501 ) { Item.Rarity = Item.Rarities.Rare; qr_bonus = 1.65; }
        else if ( numd > 87500 && num < 93751 ) { Item.Rarity = Item.Rarities.Artifact; qr_bonus = 2.25; }
        else if ( numd > 93750 && num < 97500 ) { Item.Rarity = Item.Rarities.Relic; qr_bonus = 3; }
        else if ( numd > 97501 && num < 100001 ) { Item.Rarity = Item.Rarities.Legend; qr_bonus = 3.75; }

        num = rand.Next(1,100001);
        numd = num + (159.0 * pc.UtilityIntellect.LVL);
        if ( numd < 50001 ) { Item.Quality = Item.Qualities.Rubish; }
        else if ( numd > 50000 && num < 75001 ) { Item.Quality = Item.Qualities.Used; qr_bonus = qr_bonus + .75; }
        else if ( numd > 75000 && num < 87501 ) { Item.Quality = Item.Qualities.Refurbished; qr_bonus = qr_bonus + 1.5; }
        else if ( numd > 87500 && num < 93751 ) { Item.Quality = Item.Qualities.OpenBox; qr_bonus = qr_bonus + 2.5; }
        else if ( numd > 93750 && num < 97500 ) { Item.Quality = Item.Qualities.Pristine; qr_bonus = qr_bonus + 2.75; }
        else if ( numd > 97501 && num < 100001 ) { Item.Quality = Item.Qualities.Mint; qr_bonus = qr_bonus + 3.5; }


        num = rand.Next(1,100001);
        if ( num < 20001 ) { Item.Manufacturer = Item.Manufacturers.MobySickDesigns; }
        else if ( num > 20000 && num < 40001 ) { Item.Manufacturer = Item.Manufacturers.ArchCraftCreations; }
        else if ( num > 40000 && num < 60001 ) { Item.Manufacturer = Item.Manufacturers.ChronicChaosCompany; }
        else if ( num > 60000 && num < 80001 ) { Item.Manufacturer = Item.Manufacturers.FriendlyFireIndustries; }
        else if ( num > 80000 && num < 100001 ) { Item.Manufacturer = Item.Manufacturers.SlapCrapManufacturing; }

        num = rand.Next(1,100001);

        if ( Item.IsElemental != true )
        {
            Item.Element = Item.ElementalTypes.NULL;
        }
        else
        {
            if ( num < 50001 ) { Item.Element = Item.ElementalTypes.Earth; }
            else if ( num > 50000 && num < 75001 ) { Item.Element = Item.ElementalTypes.Fire; }
            else if ( num > 75000 && num < 87501 ) { Item.Element = Item.ElementalTypes.Water; }
            else if ( num > 87500 && num < 93751 ) { Item.Element = Item.ElementalTypes.Wind; }
            else if ( num > 93750 && num < 97500 ) { Item.Element = Item.ElementalTypes.Cosmic; }
            else if ( num > 97501 && num < 100001 ) { Item.Element = Item.ElementalTypes.Atomic; }
            else if ( num > 97501 && num < 100001 ) { Item.Element = Item.ElementalTypes.Plasma; }
            else if ( num > 97501 && num < 100001 ) { Item.Element = Item.ElementalTypes.Ice; }
            else if ( num > 97501 && num < 100001 ) { Item.Element = Item.ElementalTypes.Storm; }
            else if ( num > 97501 && num < 100001 ) { Item.Element = Item.ElementalTypes.Chaos; }
        }

        

        num = rand.Next(1,10001);
        Item.IsLucky = ( num > 8765 ) ? true : false;
        var lucky_bonus = ( Item.IsLucky != false ) ? ( rand.Next(1,1001) / 1000.0 ) + 1.0 : 1.0;


        num = rand.Next(1,10001);
        Item.IsErratic = ( num > 9876 ) ? true : false;

        SetSubtype(Item);
        SetAttributes(Item);

        if ( Item.ItemType == Item.ItemTypes.Weapon )
        {

            Weapon.SetUITerms(Weapon);

            var wx = Weapon.Height;
            var wy = Weapon.Width;
            var ms = Weapon.MaxSize;
            var opt_size = ( wx * wy ) / ms;
            
            
            var type_bonus = 1.0;
            var acc_bonus = 1.0;

            if ( Weapon.Type == Weapon.WeaponTypes.Melee )
            {
                type_bonus = pc.MeleeDamage.LVL;
                acc_bonus = pc.MeleeAccuracy.LVL;
            }
            else if ( Weapon.Type == Weapon.WeaponTypes.Ranged )
            {
                type_bonus = pc.RangedDamage.LVL;
                acc_bonus = pc.RangedAccuracy.LVL;
            }
            else if ( Weapon.Type == Weapon.WeaponTypes.Thrown )
            {
                type_bonus = pc.RangedDamage.LVL;
                acc_bonus = pc.MeleeAccuracy.LVL;
            }

            var bonus_comp = (opt_size * lucky_bonus * qr_bonus) + 1;

            Weapon.Damage = Math.Ceiling( ( Weapon.BaseDamage + ( pc.LVL * pc.CombatPower.LVL * type_bonus ) ) * bonus_comp );
            
            Weapon.MinAccuracy = Math.Ceiling( ( Weapon.BaseMinAccuracy + acc_bonus + pc.CombatMastery.LVL + pc.LVL * ( ( bonus_comp % 2 ) + 1 ) ) );
            Weapon.MaxAccuracy = Math.Ceiling( ( Weapon.BaseMaxAccuracy + pc.LVL * ( ( bonus_comp % 2 ) + 1 ) ) );


            if ( Weapon.MinAccuracy > 85 ) { Weapon.MinAccuracy = 85; } 
            if ( Weapon.MaxAccuracy > 95 ) { Weapon.MaxAccuracy = 95; } 

            var wep_cap = 0.0;
            var wep_rep = 0.0;
            var wep_die = 0.0;
            if ( Weapon.Type == Weapon.WeaponTypes.Melee )
            {
                wep_cap = pc.MeleeCombo.LVL;
                wep_rep = pc.MeleeStrike.LVL;
                wep_die = pc.MeleeDamage.LVL;
            }
            if ( Weapon.Type == Weapon.WeaponTypes.Ranged )
            {
                wep_cap = pc.RangedAmmo.LVL;
                wep_rep = pc.RangedReload.LVL;
                wep_die = pc.RangedDamage.LVL;
            }
            if ( Weapon.Type == Weapon.WeaponTypes.Thrown )
            {
                wep_cap = pc.MeleeCombo.LVL;
                wep_rep = pc.RangedReload.LVL;
                wep_die = pc.CombatPower.LVL;
            }

            Weapon.Capacity = Math.Ceiling( ( Weapon.BaseCapacity + ( ( pc.LVL + wep_cap + pc.CombatLoadout.LVL ) / 3 ) * bonus_comp ) );
            Weapon.ReplenishRate = Math.Ceiling( ( Weapon.BaseReplenishRate + ( ( pc.LVL + wep_rep + pc.CombatCooldown.LVL ) / 3 )  * bonus_comp ) );
            Weapon.DicePerAttack = Math.Ceiling( ( Weapon.BaseDicePerAttack + rand.Next(0,2) * wep_die ) * bonus_comp );

            if ( Weapon.DicePerAttack > 48 ) { Weapon.DicePerAttack = 48; }

            if ( Weapon.IsLucky != false )
            {
                if ( Weapon.Type == Weapon.WeaponTypes.Melee )
                {
                    Weapon.LuckyIconID_01 = rand.Next(1, 4);
                    Weapon.LuckyIconID_02 = rand.Next(1, 4);
                    Weapon.LuckyIconID_03 = rand.Next(1, 4);
                }
                else if ( Weapon.Type == Weapon.WeaponTypes.Ranged )
                {
                    Weapon.LuckyIconID_01 = rand.Next(3, 6);
                    Weapon.LuckyIconID_02 = rand.Next(3, 6);
                    Weapon.LuckyIconID_03 = rand.Next(3, 6);
                }
                else if ( Weapon.Type == Weapon.WeaponTypes.Thrown )
                {
                    Weapon.LuckyIconID_01 = rand.Next(5, 8);
                    Weapon.LuckyIconID_02 = rand.Next(5, 8);
                    Weapon.LuckyIconID_03 = rand.Next(5, 8);
                }
            }
            var item_namer = new ItemNamer(Item,Weapon,Armor);
            Item.Name = item_namer.CreateName();
            Weapon.Name = Item.Name;

            if ( Weapon.Manufacturer == Item.Manufacturers.MobySickDesigns )
            {
                Weapon.Damage += rand.Next(5, 33);
                Weapon.MinAccuracy += rand.Next(1, 11);
                Weapon.MaxAccuracy -= rand.Next(1, 11);
                if ( Weapon.MinAccuracy > 65 ) { Weapon.MinAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy < 40 ) { Weapon.MaxAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy <= Weapon.MinAccuracy + 5 )
                {
                    Weapon.MaxAccuracy = Weapon.MinAccuracy + rand.Next(4, 7);
                    Weapon.MinAccuracy = Weapon.MaxAccuracy - rand.Next(10, 21);
                }
                if ( Weapon.MinAccuracy < 3 ) { Weapon.MinAccuracy = 3; }
                if ( Weapon.MaxAccuracy > 97 ) { Weapon.MaxAccuracy = 97; }


                Weapon.MovementPenalty += rand.Next(0, 3);
                Weapon.StandardPentaly -= rand.Next(0, 3);
                if ( Weapon.StandardPentaly < 0 ) { Weapon.StandardPentaly = 0; }

                Weapon.ReplenishRate += rand.Next(0, 6);
                Weapon.DicePerAttack += rand.Next(0, 6);
                if ( Weapon.DicePerAttack > 48 ) { Weapon.DicePerAttack = 48; }
            }
            else if ( Weapon.Manufacturer == Item.Manufacturers.ArchCraftCreations )
            {
                Weapon.Damage -= rand.Next(5, 33);
                Weapon.MinAccuracy -= rand.Next(1, 11);
                Weapon.MaxAccuracy += rand.Next(1, 11);
                if ( Weapon.Damage < 3 ) { Weapon.Damage = 3; }
                if ( Weapon.MinAccuracy > 65 ) { Weapon.MinAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy < 40 ) { Weapon.MaxAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy <= Weapon.MinAccuracy + 5 )
                {
                    Weapon.MaxAccuracy = Weapon.MinAccuracy + rand.Next(4, 7);
                    Weapon.MinAccuracy = Weapon.MaxAccuracy - rand.Next(10, 21);
                }
                if ( Weapon.MinAccuracy < 3 ) { Weapon.MinAccuracy = 3; }
                if ( Weapon.MaxAccuracy > 97 ) { Weapon.MaxAccuracy = 97; }


                Weapon.MovementPenalty -= rand.Next(0, 3);
                Weapon.StandardPentaly += rand.Next(0, 3);
                if ( Weapon.MovementPenalty < 0 ) { Weapon.MovementPenalty = 0; }

            }
            else if ( Weapon.Manufacturer == Item.Manufacturers.ChronicChaosCompany )
            {
                Weapon.Damage += rand.Next(5, 99);
                Weapon.MinAccuracy += rand.Next(1, 5);
                Weapon.MaxAccuracy += rand.Next(1, 5);
                if ( Weapon.Damage < 3 ) { Weapon.Damage = 3; }
                if ( Weapon.MinAccuracy > 65 ) { Weapon.MinAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy < 40 ) { Weapon.MaxAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy <= Weapon.MinAccuracy + 5 )
                {
                    Weapon.MaxAccuracy = Weapon.MinAccuracy + rand.Next(4, 7);
                    Weapon.MinAccuracy = Weapon.MaxAccuracy - rand.Next(10, 21);
                }
                if ( Weapon.MinAccuracy < 3 ) { Weapon.MinAccuracy = 3; }
                if ( Weapon.MaxAccuracy > 97 ) { Weapon.MaxAccuracy = 97; }


                Weapon.MovementPenalty += rand.Next(0, 3);
                Weapon.StandardPentaly += rand.Next(0, 3);
                if ( Weapon.MovementPenalty < 0 ) { Weapon.MovementPenalty = 0; }

                Weapon.ReplenishRate += rand.Next(0, 22);
                Weapon.DicePerAttack += rand.Next(0, 22);
                if ( Weapon.DicePerAttack > 8 ) { Weapon.DicePerAttack = 48; }
            }
            else if ( Weapon.Manufacturer == Item.Manufacturers.FriendlyFireIndustries )
            {
                Weapon.Damage += rand.Next(45, 99);
                Weapon.MinAccuracy -= rand.Next(1, 15);
                Weapon.MaxAccuracy -= rand.Next(1, 25);
                if ( Weapon.Damage < 3 ) { Weapon.Damage = 3; }
                if ( Weapon.MinAccuracy > 65 ) { Weapon.MinAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy < 40 ) { Weapon.MaxAccuracy = rand.Next(50, 66); }
                if ( Weapon.MaxAccuracy <= Weapon.MinAccuracy + 5 )
                {
                    Weapon.MaxAccuracy = Weapon.MinAccuracy + rand.Next(4, 7);
                    Weapon.MinAccuracy = Weapon.MaxAccuracy - rand.Next(10, 21);
                }
                if ( Weapon.MinAccuracy < 3 ) { Weapon.MinAccuracy = 3; }
                if ( Weapon.MaxAccuracy > 97 ) { Weapon.MaxAccuracy = 97; }

                Weapon.Capacity += rand.Next(0, 123);
                Weapon.ReplenishRate += rand.Next(0, 12);
                Weapon.DicePerAttack += rand.Next(0, 6);
                if ( Weapon.DicePerAttack > 32 ) { Weapon.DicePerAttack = rand.Next(28, 43); }
                if ( Weapon.ReplenishRate > 24 ) { Weapon.ReplenishRate = rand.Next(18, 33); }
            }
            else if ( Weapon.Manufacturer == Item.Manufacturers.SlapCrapManufacturing )
            {
                var counter = rand.Next(1,11);
                if ( counter > 5 )
                {
                    Weapon.Damage += rand.Next(5, 25);
                    Weapon.MinAccuracy -= rand.Next(1, 15);
                    Weapon.MaxAccuracy += rand.Next(1, 15);
                    
                    if ( Weapon.MinAccuracy > 65 ) { Weapon.MinAccuracy = rand.Next(50, 66); }
                    if ( Weapon.MaxAccuracy < 40 ) { Weapon.MaxAccuracy = rand.Next(50, 66); }
                    if ( Weapon.MaxAccuracy <= Weapon.MinAccuracy + 5 )
                    {
                        Weapon.MaxAccuracy = Weapon.MinAccuracy + rand.Next(4, 7);
                        Weapon.MinAccuracy = Weapon.MaxAccuracy - rand.Next(10, 21);
                    }
                    if ( Weapon.MinAccuracy < 23 ) { Weapon.MinAccuracy = 23; }
                    if ( Weapon.MaxAccuracy > 85 ) { Weapon.MaxAccuracy = 85; }
                }
                else
                {
                    Weapon.Damage -= rand.Next(15, 45);
                    Weapon.MinAccuracy += rand.Next(1, 15);
                    Weapon.MaxAccuracy -= rand.Next(1, 15);
                    if ( Weapon.Damage < 3 ) { Weapon.Damage = 3; }
                    if ( Weapon.MinAccuracy > 65 ) { Weapon.MinAccuracy = rand.Next(50, 66); }
                    if ( Weapon.MaxAccuracy < 40 ) { Weapon.MaxAccuracy = rand.Next(50, 66); }
                    if ( Weapon.MaxAccuracy <= Weapon.MinAccuracy + 5 )
                    {
                        Weapon.MaxAccuracy = Weapon.MinAccuracy + rand.Next(7, 17);
                        Weapon.MinAccuracy = Weapon.MaxAccuracy - rand.Next(6, 32);
                    }
                    if ( Weapon.MinAccuracy < 2 ) { Weapon.MinAccuracy = 2; }
                    if ( Weapon.MaxAccuracy > 99 ) { Weapon.MaxAccuracy = 99; }
                }
            }
            if ( Weapon.ReplenishRate > Weapon.Capacity ) { Weapon.ReplenishRate = Weapon.Capacity; }
            if ( Weapon.DicePerAttack > Weapon.Capacity ) { Weapon.DicePerAttack = Weapon.Capacity; }
        }

        if ( Item.ItemType == Item.ItemTypes.Armor )
        {
            var wx = Armor.Height;
            var wy = Armor.Width;
            var ms = Armor.MaxSize;
            var opt_size = ( wx * wy ) / ms;

            var bonus_comp = (qr_bonus * lucky_bonus * opt_size) + 1;

            num = rand.Next(1,1001);

            Console.WriteLine("pc.StatsConstitution.LVL: " + pc.StatsConstitution.LVL);
            Console.WriteLine("pc.LVL: " + pc.LVL);
            Console.WriteLine("qr_bonus: " + qr_bonus);

            Armor.HP = Math.Ceiling( Armor.HP * ( ( ( pc.StatsConstitution.LVL * pc.LVL ) + qr_bonus ) / 2 ) ); 

            if ( num < ( 123 * bonus_comp ) + pc.UtilityKarma.LVL ) { Armor.HasRegen = true; } else { Armor.HasRegen = false; }
            if ( Armor.HasRegen != false ) { Armor.RegenRate = Math.Ceiling( ( Armor.BaseRegenRate + pc.UtilityKarma.LVL ) * bonus_comp ); } else { Armor.RegenRate = 0; }

            Armor.MaxArmor = Math.Ceiling( ( Armor.BaseMaxArmor + pc.ArmorCapacity.LVL ) * bonus_comp );
            Armor.RechargeRate = Math.Ceiling( ( Armor.BaseRechargeRate + pc.ArmorRecharge.LVL ) * bonus_comp );

            Armor.MovementBonus += Math.Ceiling( ( pc.UtilityNimbleness.LVL + pc.StatsMovement.LVL + pc.LVL ) / 3 );
            Armor.StandardBonus += Math.Ceiling( ( pc.StatsStandard.LVL + pc.LVL ) / 2 );

            if ( Armor.MovementBonus > Armor.MovementPenalty )
            { Armor.MovementBonus -= Armor.MovementPenalty; Armor.MovementPenalty = 0; }
            if ( Armor.MovementBonus < Armor.MovementPenalty )
            { Armor.MovementPenalty -= Armor.MovementBonus; Armor.MovementBonus = 0; }
            if ( Armor.MovementBonus == Armor.MovementPenalty )
            { Armor.MovementPenalty = 0; Armor.MovementBonus = 0; }

            if ( Armor.StandardBonus > Armor.StandardPentaly )
            { Armor.StandardBonus -= Armor.StandardPentaly; Armor.StandardPentaly = 0; }
            else if ( Armor.StandardBonus < Armor.StandardPentaly )
            { Armor.StandardPentaly -= Armor.StandardBonus; Armor.StandardBonus = 0; }
            else if ( Armor.StandardBonus == Armor.StandardPentaly )
            { Armor.StandardPentaly = 0; Armor.StandardBonus = 0; }


            var item_namer = new ItemNamer(Item,Weapon,Armor);
            Item.Name = item_namer.CreateName();
            Armor.Name = Item.Name;

            if ( Armor.Manufacturer == Item.Manufacturers.MobySickDesigns )
            { 
                Armor.MaxArmor += rand.Next(0,66);
                Armor.RechargeRate -= rand.Next(0,33);
                if ( Armor.RechargeRate < 3 ) { Armor.RechargeRate = 3; }
                Armor.HP += rand.Next(5,123);

                Armor.MovementPenalty += rand.Next(0,5);
                Armor.StandardPentaly += rand.Next(0,5);
                Armor.MovementBonus -= rand.Next(0,5);
                Armor.StandardBonus -= rand.Next(0,5);

                if ( Armor.MovementBonus > Armor.MovementPenalty )
                    { Armor.MovementBonus -= Armor.MovementPenalty; Armor.MovementPenalty = 0; }
                if ( Armor.StandardBonus > Armor.StandardPentaly )
                    { Armor.StandardBonus -= Armor.StandardPentaly; Armor.StandardPentaly = 0; }

                if ( Armor.MovementBonus < 0 ) { Armor.MovementBonus = 0; }
                if ( Armor.StandardBonus < 0 ) { Armor.StandardBonus = 0; }
                
            }
            else if ( Armor.Manufacturer == Item.Manufacturers.ArchCraftCreations )
            {
                Armor.MaxArmor += rand.Next(0,33);
                Armor.RechargeRate += rand.Next(0,33);
                Armor.HP -= rand.Next(0,22);
                if ( Armor.HP < 3 ) { Armor.HP = 3; }

                Armor.MovementPenalty += rand.Next(0,2);
                Armor.StandardPentaly += rand.Next(0,2);
                Armor.MovementBonus -= rand.Next(0,2);
                Armor.StandardBonus -= rand.Next(0,2);

                if ( Armor.MovementBonus > Armor.MovementPenalty )
                    { Armor.MovementBonus -= Armor.MovementPenalty; Armor.MovementPenalty = 0; }
                if ( Armor.StandardBonus > Armor.StandardPentaly )
                    { Armor.StandardBonus -= Armor.StandardPentaly; Armor.StandardPentaly = 0; }
                    
                if ( Armor.MovementBonus < 0 ) { Armor.MovementBonus = 0; }
                if ( Armor.StandardBonus < 0 ) { Armor.StandardBonus = 0; }
            }
            else if ( Armor.Manufacturer == Item.Manufacturers.ChronicChaosCompany )
            {
                Armor.MaxArmor += rand.Next(0,33);
                Armor.RechargeRate += rand.Next(0,33);
                Armor.HP += rand.Next(0,22);
            }
            else if ( Armor.Manufacturer == Item.Manufacturers.FriendlyFireIndustries )
            {
                Armor.MovementPenalty -= rand.Next(0,2);
                Armor.StandardPentaly -= rand.Next(0,2);
                Armor.MovementBonus += rand.Next(0,3);
                Armor.StandardBonus += rand.Next(0,3);

                if ( Armor.MovementBonus > Armor.MovementPenalty )
                    { Armor.MovementBonus -= Armor.MovementPenalty; Armor.MovementPenalty = 0; }
                if ( Armor.StandardBonus > Armor.StandardPentaly )
                    { Armor.StandardBonus -= Armor.StandardPentaly; Armor.StandardPentaly = 0; }
                    
                if ( Armor.MovementPenalty < 0 ) { Armor.MovementPenalty = 0; }
                if ( Armor.StandardPentaly < 0 ) { Armor.StandardPentaly = 0; }
            }
            else if ( Armor.Manufacturer == Item.Manufacturers.SlapCrapManufacturing )
            {
                Armor.MaxArmor -= rand.Next(0,33);
                Armor.RechargeRate -= rand.Next(0,33);
                Armor.HP += rand.Next(0,255);
                if ( Armor.MaxArmor < 5 ) { Armor.MaxArmor = 5; }
                if ( Armor.RechargeRate < 1 ) { Armor.RechargeRate = 1; }
                if ( Armor.HP < 45 ) { Armor.HP = 45; }

                Armor.MovementPenalty += rand.Next(1,3);
                Armor.StandardPentaly += rand.Next(1,3);
                Armor.MovementBonus += rand.Next(0,5);
                Armor.StandardBonus += rand.Next(0,5);

                if ( Armor.MovementBonus > Armor.MovementPenalty )
                    { Armor.MovementBonus -= Armor.MovementPenalty; Armor.MovementPenalty = 0; }
                if ( Armor.StandardBonus > Armor.StandardPentaly )
                    { Armor.StandardBonus -= Armor.StandardPentaly; Armor.StandardPentaly = 0; }
                    
                if ( Armor.MovementBonus < 0 ) { Armor.MovementBonus = 0; }
                if ( Armor.StandardBonus < 0 ) { Armor.StandardBonus = 0; }
            }
            if ( Armor.RechargeRate > Armor.MaxArmor ) { Armor.RechargeRate = Armor.MaxArmor; }
        }
    }

    public LootGenerator()
    {
        
    }

    public LootGenerator(PlayerChar pc, double id = 0)
    {
        GenerateLoot(pc, id);
    }
}

