#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f615d274203e1a991ff1641f4cb3355b704698"
// <auto-generated/>
#pragma warning disable 1591
namespace Imaginators.Pages.ItemsPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.GameObjects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.SkillsPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.HUDPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.ZonePages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.PopoverPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.UIPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.QuestPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.MapPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.PackPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.CombatPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.ItemsPages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/loot")]
    public partial class LootItemView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
 if(lg.Item.ItemType == Item.ItemTypes.Weapon)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "weapon_name font_gst");
            __builder.AddAttribute(2, "b-q9vp5k72yi");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "b-q9vp5k72yi");
            __builder.AddContent(5, "Name: ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                     w.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if( w.IsLucky != false )
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<div b-q9vp5k72yi>Is Lucky</div>\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "b-q9vp5k72yi");
            __builder.AddContent(10, "Icon 1: ");
            __builder.AddContent(11, 
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                           w.LuckyIconID_01

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "b-q9vp5k72yi");
            __builder.AddContent(15, "Icon 2: ");
            __builder.AddContent(16, 
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                           w.LuckyIconID_02

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "b-q9vp5k72yi");
            __builder.AddContent(20, "Icon 3: ");
            __builder.AddContent(21, 
#nullable restore
#line 12 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                           w.LuckyIconID_03

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if( w.IsErratic != false )
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<div b-q9vp5k72yi>Is Erractic</div>");
#nullable restore
#line 17 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "b-q9vp5k72yi");
            __builder.AddContent(25, "Width: ");
            __builder.AddContent(26, 
#nullable restore
#line 18 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                      w.Width

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "b-q9vp5k72yi");
            __builder.AddContent(30, "Height: ");
            __builder.AddContent(31, 
#nullable restore
#line 19 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                       w.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "b-q9vp5k72yi");
            __builder.AddContent(35, "Manufacture: ");
            __builder.AddContent(36, 
#nullable restore
#line 20 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                            w.Manufacturer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "b-q9vp5k72yi");
            __builder.AddContent(40, "Rarity: ");
            __builder.AddContent(41, 
#nullable restore
#line 21 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                       w.Rarity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "b-q9vp5k72yi");
            __builder.AddContent(45, "Quality: ");
            __builder.AddContent(46, 
#nullable restore
#line 22 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                        w.Quality

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "b-q9vp5k72yi");
            __builder.AddContent(50, "Type: ");
            __builder.AddContent(51, 
#nullable restore
#line 23 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                     w.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if ( w.IsExplosive == true ) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "b-q9vp5k72yi");
            __builder.AddContent(54, "Explosion Rate: ");
            __builder.AddContent(55, 
#nullable restore
#line 24 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                               w.ExplosionRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 24 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if ( w.Type == Weapon.WeaponTypes.Melee ) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "b-q9vp5k72yi");
            __builder.AddContent(58, "Subtype: ");
            __builder.AddContent(59, 
#nullable restore
#line 25 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                     w.Melee

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if ( w.Type == Weapon.WeaponTypes.Ranged ) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "b-q9vp5k72yi");
            __builder.AddContent(62, "Subtype: ");
            __builder.AddContent(63, 
#nullable restore
#line 26 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                      w.Ranged

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 26 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if ( w.Type == Weapon.WeaponTypes.Thrown ) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "b-q9vp5k72yi");
            __builder.AddContent(66, "Subtype: ");
            __builder.AddContent(67, 
#nullable restore
#line 27 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                      w.Thrown

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                                                                      }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "b-q9vp5k72yi");
            __builder.AddContent(70, 
#nullable restore
#line 28 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
               w.CapacityType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " Size: ");
            __builder.AddContent(72, 
#nullable restore
#line 28 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                       w.Capacity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "b-q9vp5k72yi");
            __builder.AddContent(76, 
#nullable restore
#line 29 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
               w.UseType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " Cost: ");
            __builder.AddContent(78, 
#nullable restore
#line 29 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                  w.DicePerAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "b-q9vp5k72yi");
            __builder.AddContent(82, 
#nullable restore
#line 30 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
               w.CooldownType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(83, " Rate: ");
            __builder.AddContent(84, 
#nullable restore
#line 30 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                       w.ReplenishRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "b-q9vp5k72yi");
            __builder.AddContent(88, "Damage Per Hit: ");
            __builder.AddContent(89, 
#nullable restore
#line 31 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                               w.Damage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "b-q9vp5k72yi");
            __builder.AddContent(93, "Total Potential Damage: ");
            __builder.AddContent(94, 
#nullable restore
#line 32 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                       w.Damage * w.DicePerAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n        ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "b-q9vp5k72yi");
            __builder.AddContent(98, "Damage Type: ");
            __builder.AddContent(99, 
#nullable restore
#line 33 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                            w.DamageType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n        ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "b-q9vp5k72yi");
            __builder.AddContent(103, "Accuracy: ");
            __builder.AddContent(104, 
#nullable restore
#line 34 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                         w.MinAccuracy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(105, "% - ");
            __builder.AddContent(106, 
#nullable restore
#line 34 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                             w.MaxAccuracy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(107, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n        ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "b-q9vp5k72yi");
            __builder.AddContent(111, "Range: ");
            __builder.AddContent(112, 
#nullable restore
#line 35 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                      w.MinRange

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(113, " - ");
            __builder.AddContent(114, 
#nullable restore
#line 35 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                      w.MaxRange

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "b-q9vp5k72yi");
            __builder.AddContent(118, "Movement Penalty: ");
            __builder.AddContent(119, 
#nullable restore
#line 36 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                 w.MovementPenalty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\n        ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "b-q9vp5k72yi");
            __builder.AddContent(123, "Standard Penalty: ");
            __builder.AddContent(124, 
#nullable restore
#line 37 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                 w.StandardPentaly

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
 if(lg.Item.ItemType == Item.ItemTypes.Armor)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "weapon_name font_gst");
            __builder.AddAttribute(127, "b-q9vp5k72yi");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "b-q9vp5k72yi");
            __builder.AddContent(130, "Name: ");
            __builder.AddContent(131, 
#nullable restore
#line 44 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                     a.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\n        ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "b-q9vp5k72yi");
            __builder.AddContent(135, "HP: ");
            __builder.AddContent(136, 
#nullable restore
#line 45 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                   a.HP

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if( a.IsLucky != false )
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(137, "<div b-q9vp5k72yi>Is Lucky</div>");
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
         if( a.IsErratic != false )
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(138, "<div b-q9vp5k72yi>Is Erractic</div>");
#nullable restore
#line 53 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "b-q9vp5k72yi");
            __builder.AddContent(141, "Has Regen: ");
            __builder.AddContent(142, 
#nullable restore
#line 54 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                          a.HasRegen

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\n        ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "b-q9vp5k72yi");
            __builder.AddContent(146, "Regen Rate: ");
            __builder.AddContent(147, 
#nullable restore
#line 55 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                           a.RegenRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\n        ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "b-q9vp5k72yi");
            __builder.AddContent(151, "Location: ");
            __builder.AddContent(152, 
#nullable restore
#line 56 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                         a.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n        ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "b-q9vp5k72yi");
            __builder.AddContent(156, "Width: ");
            __builder.AddContent(157, 
#nullable restore
#line 57 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                      a.Width

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\n        ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "b-q9vp5k72yi");
            __builder.AddContent(161, "Height: ");
            __builder.AddContent(162, 
#nullable restore
#line 58 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                       a.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\n        ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "b-q9vp5k72yi");
            __builder.AddContent(166, "Manufacture: ");
            __builder.AddContent(167, 
#nullable restore
#line 59 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                            a.Manufacturer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\n        ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "b-q9vp5k72yi");
            __builder.AddContent(171, "Rarity: ");
            __builder.AddContent(172, 
#nullable restore
#line 60 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                       a.Rarity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\n        ");
            __builder.OpenElement(174, "div");
            __builder.AddAttribute(175, "b-q9vp5k72yi");
            __builder.AddContent(176, "Quality: ");
            __builder.AddContent(177, 
#nullable restore
#line 61 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                        a.Quality

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\n        ");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "b-q9vp5k72yi");
            __builder.AddContent(181, "Max Armor: ");
            __builder.AddContent(182, 
#nullable restore
#line 62 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                          a.MaxArmor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\n        ");
            __builder.OpenElement(184, "div");
            __builder.AddAttribute(185, "b-q9vp5k72yi");
            __builder.AddContent(186, "Recharge Rate: ");
            __builder.AddContent(187, 
#nullable restore
#line 63 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                              a.RechargeRate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\n        ");
            __builder.OpenElement(189, "div");
            __builder.AddAttribute(190, "b-q9vp5k72yi");
            __builder.AddContent(191, "Movement Penalty: ");
            __builder.AddContent(192, 
#nullable restore
#line 64 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                 a.MovementPenalty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\n        ");
            __builder.OpenElement(194, "div");
            __builder.AddAttribute(195, "b-q9vp5k72yi");
            __builder.AddContent(196, "Standard Penalty: ");
            __builder.AddContent(197, 
#nullable restore
#line 65 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                                 a.StandardPentaly

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\n        ");
            __builder.OpenElement(199, "div");
            __builder.AddAttribute(200, "b-q9vp5k72yi");
            __builder.AddContent(201, "Movement Bonus: ");
            __builder.AddContent(202, 
#nullable restore
#line 66 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                               a.MovementBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\n        ");
            __builder.OpenElement(204, "div");
            __builder.AddAttribute(205, "b-q9vp5k72yi");
            __builder.AddContent(206, "Standard Bonus: ");
            __builder.AddContent(207, 
#nullable restore
#line 67 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
                               a.StandardBonus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ItemsPages/LootItemView.razor"
       

    private LootGenerator lg = new LootGenerator();
    private PlayerChar pc = new PlayerChar();
    private Weapon w = new Weapon();
    private Armor a = new Armor();


    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            pc.SetStartingSkills();
            lg.GenerateLoot(pc);
            w = lg.Weapon;
            a = lg.Armor;
            StateHasChanged();
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
