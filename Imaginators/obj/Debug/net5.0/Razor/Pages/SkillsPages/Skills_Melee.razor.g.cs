#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/Skills_Melee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71dee69512ee75a4db749eca8c1943d51a89d981"
// <auto-generated/>
#pragma warning disable 1591
namespace Imaginators.Pages.SkillsPages
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
    public partial class Skills_Melee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"skills_container\" b-5niuquqkjv><div class=\"skills_quad q1\" b-5niuquqkjv><div class=\"quad_container\" b-5niuquqkjv><div class=\"quad_stat\" b-5niuquqkjv>\n                Combo - Prestiging will improve the capacity of new melee weapons.\n            </div>\n\n            <div class=\"quad_content\" b-5niuquqkjv><ul class=\"quad_skills_and_perks\" b-5niuquqkjv><li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Hard Strike: Increase damage of succesful melee hits.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Knife Proficiency: Increase damage dealt by knife.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Swift Flow: Increase hit count of all ranged weapons.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Sword Proficiency: Increase damage dealt by swords.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Dead Eye: Increase accuracy of all thrown weapons.\n                        </div></li></ul></div></div></div>\n    <div class=\"skills_quad q2\" b-5niuquqkjv><div class=\"quad_container\" b-5niuquqkjv><div class=\"quad_stat\" b-5niuquqkjv>\n                Strike - Prestiging will increse the strike count of new melee weapons.\n            </div>\n\n            <div class=\"quad_content\" b-5niuquqkjv><ul class=\"quad_skills_and_perks\" b-5niuquqkjv><li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Street Fighter: Increase combo of all melee weapons.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Axe Proficiency: Increase damage dealt by axes.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Adrenal Spike: Increase number of strikes returned by refreshing.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Hammers Proficiency: Increase damage dealt by hammers.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Fannypack: Increase count of all thrown weapons.\n                        </div></li></ul></div></div></div>\n    <div class=\"skills_quad q3\" b-5niuquqkjv><div class=\"quad_container\" b-5niuquqkjv><div class=\"quad_stat\" b-5niuquqkjv>\n                Damage - Prestiging will increase the damage of new melee weapons.\n            </div>\n\n            <div class=\"quad_content\" b-5niuquqkjv><ul class=\"quad_skills_and_perks\" b-5niuquqkjv><li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Hand to hand: Increase damage of all close range melee attacks.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Blunt Strike Proficiency: Increase damage dealt by bladeless melee weapons.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Lost Ways: Increase damage of elemental attacks.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Whip Proficiency: Increase damage dealt by whips.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Fastball: Increase damage of thrown attacks.\n                        </div></li></ul></div></div></div>\n    <div class=\"skills_quad q4\" b-5niuquqkjv><div class=\"quad_container\" b-5niuquqkjv><div class=\"quad_stat\" b-5niuquqkjv>\n                Accuracy - Prestiging will improve the accuracy of new melee weapons.\n            </div>\n\n            <div class=\"quad_content\" b-5niuquqkjv><ul class=\"quad_skills_and_perks\" b-5niuquqkjv><li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Hail Mary: Increase range of all thrown attacks.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Lance Proficiency: Increase damage dealt by lances.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Firm Footing: Increase accuracy of short melee attacks.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Skill - Thrown Accurracy: Increase accuracy of all thrown weapons.\n                        </div></li>\n                    <li class=\"quad_skills\" b-5niuquqkjv><div class=\"node_div\" b-5niuquqkjv>\n                            Perk - Cold Focus: Increase accuracy of all melee and thrown attacks.\n                        </div></li></ul></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591