#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df0d7f30f64d8e97e5cfffb79c501b34f7dee0b8"
// <auto-generated/>
#pragma warning disable 1591
namespace Imaginators.Pages.ZonePages
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
    public partial class Zone_Actors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Imaginators.Pages.ZonePages.Zone_Actors.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 1 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                       this

#line default
#line hidden
#nullable disable
            , 2, (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "popover_section" + " popover_left" + " font_gst" + " " + (
#nullable restore
#line 4 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                                                   show_lists

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "b-zw3e58mypl");
                __builder2.AddMarkupContent(6, "<div class=\"popover_heading\" b-zw3e58mypl>Friendlies</div>\n    <div class=\"popover_content actor_container\" b-zw3e58mypl></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\n\n");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "popover_section" + " popover_right" + " font_gst" + " " + (
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                                                    show_lists

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "b-zw3e58mypl");
                __builder2.AddMarkupContent(11, "<div class=\"popover_heading\" b-zw3e58mypl>Foes</div>\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "popover_content actor_container");
                __builder2.AddAttribute(14, "b-zw3e58mypl");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "foes");
                __builder2.AddAttribute(17, "b-zw3e58mypl");
                __builder2.OpenElement(18, "ul");
                __builder2.AddAttribute(19, "class", "foe_list");
                __builder2.AddAttribute(20, "b-zw3e58mypl");
#nullable restore
#line 17 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                 for (var f = 0; f <= Foes.Count - 1; f++)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Imaginators.Pages.Actors_Foe>(21);
                __builder2.AddAttribute(22, "FoeID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                                         f

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 20 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n\n\n\n\n");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "popover_section" + " popover_full" + " font_gst" + " " + (
#nullable restore
#line 29 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
                                                   show_combat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "b-zw3e58mypl");
                __builder2.AddMarkupContent(27, "<div class=\"popover_heading\" b-zw3e58mypl>Roll For Damage!</div>\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "popover_content");
                __builder2.AddAttribute(30, "b-zw3e58mypl");
                __builder2.OpenComponent<Imaginators.Pages.CombatPages.Combat>(31);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/ZonePages/Zone_Actors.razor"
       

    public string show_lists = "";
    public string show_combat = " unloaded";

    public IList<Foe> Foes = new List<Foe>();

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            Foes.Add(new Foe{   
                Name = "Velociraptor",
                Faction = "Dinosaurs",
                hp = new Foe.HP(200,200),
                armor = new Foe.Armor(200,200)
            });
        }
    }
    public Foe Enemy_Combatant = new Foe();

    public void StartCombat(string n)
    {
        show_lists = " unloaded";
        show_combat = "";
        Enemy_Combatant.Name = n;
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Imaginators.Pages.ZonePages.Zone_Actors
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591