#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/HUDPages/HUD_QuestDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "266072278715ab4478ed4895b4f555a78d1e4f7f"
// <auto-generated/>
#pragma warning disable 1591
namespace Imaginators.Pages.HUDPages
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
    public partial class HUD_QuestDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "HUD quest_details noselect");
            __builder.AddAttribute(2, "b-mvv7q31hwi");
            __builder.AddMarkupContent(3, "<img class=\"round\" src=\"/Media/Images/round.png\" b-mvv7q31hwi>\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "round_count font_gst");
            __builder.AddAttribute(6, "b-mvv7q31hwi");
            __builder.AddContent(7, 
#nullable restore
#line 3 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/HUDPages/HUD_QuestDetails.razor"
                                        round

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "quest_title font_gst");
            __builder.AddAttribute(11, "b-mvv7q31hwi");
            __builder.AddContent(12, 
#nullable restore
#line 4 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/HUDPages/HUD_QuestDetails.razor"
                                        title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "difficulty font_rubik");
            __builder.AddAttribute(16, "b-mvv7q31hwi");
            __builder.AddContent(17, "Tier ");
            __builder.AddContent(18, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/HUDPages/HUD_QuestDetails.razor"
                                              diff_tier

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " - Level ");
            __builder.AddContent(20, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/HUDPages/HUD_QuestDetails.razor"
                                                                   diff_lvl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.AddMarkupContent(22, "<div class=\"quest_time font_gst\" b-mvv7q31hwi>00:01:23</div>\n    ");
            __builder.AddMarkupContent(23, "<div class=\"turn_order_label font_gst\" b-mvv7q31hwi>Turn Order:</div>\n    ");
            __builder.AddMarkupContent(24, "<ul class=\"turn_order_list\" b-mvv7q31hwi><li b-mvv7q31hwi></li>\n        <li b-mvv7q31hwi></li>\n        <li b-mvv7q31hwi></li>\n        <li b-mvv7q31hwi></li>\n        <li b-mvv7q31hwi></li></ul>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/HUDPages/HUD_QuestDetails.razor"
       
    private double round = 25;
    private string title = "The Long Night";
    private double diff_tier = 1;
    private double diff_lvl = 1;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
