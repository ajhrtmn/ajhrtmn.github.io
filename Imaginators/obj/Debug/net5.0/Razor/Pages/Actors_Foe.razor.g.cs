#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae7b3bc7d3989add1adfc06a1841e8dcf9ea73d"
// <auto-generated/>
#pragma warning disable 1591
namespace Imaginators.Pages
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
    public partial class Actors_Foe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "class", "foe_pod");
            __builder.AddAttribute(2, "b-9nneqbj10j");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "foe_avatar");
            __builder.AddAttribute(5, "b-9nneqbj10j");
            __builder.AddMarkupContent(6, "<img b-9nneqbj10j>\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                       StartCombat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "combat_button avatar_buttons");
            __builder.AddAttribute(10, "b-9nneqbj10j");
            __builder.AddMarkupContent(11, "<img src=\"/Media/Images/ATK_Sil.png\" b-9nneqbj10j>");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddMarkupContent(13, "<div class=\"debuff_button avatar_buttons\" b-9nneqbj10j><img src=\"/Media/Images/DBF_Sil.png\" b-9nneqbj10j></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "foe_details");
            __builder.AddAttribute(17, "b-9nneqbj10j");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "foe_header font_gst");
            __builder.AddAttribute(20, "b-9nneqbj10j");
            __builder.OpenElement(21, "ul");
            __builder.AddAttribute(22, "b-9nneqbj10j");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "b-9nneqbj10j");
            __builder.AddContent(25, "HP: ");
            __builder.AddContent(26, 
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                         this_foe.hp.Current

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " / ");
            __builder.AddContent(28, 
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                                                this_foe.hp.Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "b-9nneqbj10j");
            __builder.AddContent(32, "Armor: ");
            __builder.AddContent(33, 
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                            this_foe.armor.Current

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " / ");
            __builder.AddContent(35, 
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                                                      this_foe.armor.Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "b-9nneqbj10j");
            __builder.AddContent(39, "Faction: ");
            __builder.AddContent(40, 
#nullable restore
#line 12 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                              this_foe.Faction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n        ");
            __builder.AddMarkupContent(42, @"<div class=""foe_body font_rubik"" b-9nneqbj10j><ul b-9nneqbj10j><li b-9nneqbj10j><ul class=""foe_body_list"" b-9nneqbj10j><li b-9nneqbj10j>Speed:</li>
                        <li b-9nneqbj10j>Range:</li>
                        <li b-9nneqbj10j>Damage:</li>
                        <li b-9nneqbj10j>Hits:</li>
                        <li b-9nneqbj10j>AOE:</li></ul></li>
                <li b-9nneqbj10j><ul class=""foe_body_list second_list"" b-9nneqbj10j><li b-9nneqbj10j>Effect:</li>
                        <li b-9nneqbj10j><br b-9nneqbj10j></li>
                        <li b-9nneqbj10j>Status:</li>
                        <li b-9nneqbj10j>Active Buff:</li>
                        <li b-9nneqbj10j>Active Debuff:</li></ul></li></ul></div>
        ");
            __builder.AddMarkupContent(43, "<div class=\"view_foe font_gst\" b-9nneqbj10j>\n            View Foe\n        </div>\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "foe_name font_gst");
            __builder.AddAttribute(46, "b-9nneqbj10j");
            __builder.AddContent(47, 
#nullable restore
#line 40 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                                        this_foe.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
       
    [CascadingParameter] Zone_Actors Foe_Control { get; set; }
    [Parameter] public int FoeID { get; set; }
    private Foe this_foe = new Foe();

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            this_foe = Foe_Control.Foes[FoeID];
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/Actors_Foe.razor"
                                        
        }
    }

    private void StartCombat(MouseEventArgs e)
    {
        Foe_Control.StartCombat( this_foe.Name );
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591