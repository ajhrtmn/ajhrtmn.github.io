#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70a50d538e88df9fabffcaf4375eecca1824030"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/foeview")]
    public partial class FoeView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "font_gst");
            __builder.AddAttribute(2, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(3, "Name: ");
            __builder.AddContent(4, 
#nullable restore
#line 3 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                      cf.Foe.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "font_gst");
            __builder.AddAttribute(8, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(9, "Faction: ");
            __builder.AddContent(10, 
#nullable restore
#line 4 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                         cf.Foe.Faction

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "font_gst");
            __builder.AddAttribute(14, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(15, "HP: ");
            __builder.AddContent(16, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                    cf.hp.Current

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " / ");
            __builder.AddContent(18, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                                       cf.hp.Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "font_gst");
            __builder.AddAttribute(22, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(23, "Armor: ");
            __builder.AddContent(24, 
#nullable restore
#line 6 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                       cf.armor.Current

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " / ");
            __builder.AddContent(26, 
#nullable restore
#line 6 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                                             cf.armor.Max

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "font_gst");
            __builder.AddAttribute(30, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(31, "Damage Per Hit: ");
            __builder.AddContent(32, 
#nullable restore
#line 7 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                                cf.Foe.Damage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "font_gst");
            __builder.AddAttribute(36, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(37, "Dice Per Attack: ");
            __builder.AddContent(38, 
#nullable restore
#line 8 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                                 cf.Foe.DicePerAttack

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "font_gst");
            __builder.AddAttribute(42, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(43, "Accuracy: ");
            __builder.AddContent(44, 
#nullable restore
#line 9 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                          cf.Foe.Accuracy

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(45, "% ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "font_gst");
            __builder.AddAttribute(49, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(50, "Range: ");
            __builder.AddContent(51, 
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                       cf.Foe.Range_Low

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " - ");
            __builder.AddContent(53, 
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                                             cf.Foe.Range_High

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "font_gst");
            __builder.AddAttribute(57, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(58, "Movement: ");
            __builder.AddContent(59, 
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                          cf.Foe.Movement

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "font_gst");
            __builder.AddAttribute(63, "style", "color: white; font-size: 1.5em;");
            __builder.AddContent(64, "Standard: ");
            __builder.AddContent(65, 
#nullable restore
#line 12 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
                                                                          cf.Foe.Standard

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/FoeView.razor"
      

    public PlayerChar pc = new PlayerChar();
    public CreateFoe cf = new CreateFoe();

    protected override void OnAfterRender(bool firstRender)
    {
        if ( firstRender )
        {
            pc.SetStartingSkills();
            cf.CreateFoeVitals(pc);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
