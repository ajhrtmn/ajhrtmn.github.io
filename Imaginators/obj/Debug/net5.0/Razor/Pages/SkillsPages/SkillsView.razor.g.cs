#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89e4763895f495c2dc152243df553bbb5243ba57"
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
    public partial class SkillsView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "skills_wrapper");
            __builder.AddAttribute(2, "b-vbvcf91e30");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "b-vbvcf91e30");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tab_nav");
            __builder.AddAttribute(7, "b-vbvcf91e30");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "nav_list font_rubik");
            __builder.AddAttribute(10, "b-vbvcf91e30");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "nav_list_item");
            __builder.AddAttribute(13, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Stats")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "b-vbvcf91e30");
            __builder.AddContent(15, "Stats");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav_list_item");
            __builder.AddAttribute(19, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Elemental")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "b-vbvcf91e30");
            __builder.AddContent(21, "Elements");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav_list_item");
            __builder.AddAttribute(25, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Combat")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "b-vbvcf91e30");
            __builder.AddContent(27, "Combat");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "nav_list_item");
            __builder.AddAttribute(31, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Utility")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "b-vbvcf91e30");
            __builder.AddContent(33, "Utility");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "nav_list_item");
            __builder.AddAttribute(37, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Armor")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "b-vbvcf91e30");
            __builder.AddContent(39, "Armor");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav_list_item");
            __builder.AddAttribute(43, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Ranged")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "b-vbvcf91e30");
            __builder.AddContent(45, "Ranged");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "nav_list_item");
            __builder.AddAttribute(49, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                          e => ClickedMenu(e, "Melee")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "b-vbvcf91e30");
            __builder.AddContent(51, "Melee");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "skills_content_bin");
            __builder.AddAttribute(55, "b-vbvcf91e30");
            __builder.AddContent(56, 
#nullable restore
#line 18 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
          content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
       
    private RenderFragment content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Stats>(57);
            __builder2.CloseComponent();
        }
#nullable restore
#line 25 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                      ;

    private void ClickedMenu(MouseEventArgs e, String s)
    {
        switch ( s )
        {
            case "Stats": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Stats>(58);
            __builder2.CloseComponent();
        }
#nullable restore
#line 31 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                     ; break;
            case "Elemental": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Elemental>(59);
            __builder2.CloseComponent();
        }
#nullable restore
#line 32 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                             ; break;
            case "Combat": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Combat>(60);
            __builder2.CloseComponent();
        }
#nullable restore
#line 33 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                       ; break;
            case "Utility": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Utility>(61);
            __builder2.CloseComponent();
        }
#nullable restore
#line 34 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                         ; break;
            case "Armor": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Armor>(62);
            __builder2.CloseComponent();
        }
#nullable restore
#line 35 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                     ; break;
            case "Ranged": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Ranged>(63);
            __builder2.CloseComponent();
        }
#nullable restore
#line 36 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                       ; break;
            case "Melee": content = 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Imaginators.Pages.SkillsPages.Skills_Melee>(64);
            __builder2.CloseComponent();
        }
#nullable restore
#line 37 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/SkillsPages/SkillsView.razor"
                                                     ; break;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
