// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using Imaginators.Pages.Skills;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.HUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.Zone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.Popover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.Quest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.Pack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/_Imports.razor"
using Imaginators.Pages.Combat;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tester")]
    public partial class MapView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapView.razor"
      
    
    [Parameter] public int Player_Count { get; set; }


    private IList<ExploredZone> explored_zones = new List<ExploredZone>();
    private IList<Actor> char_list = new List<Actor>();

    private int current_player = 0;
    private string current_zone = "";
    private double expander_x = 450;
    private double expander_y = 450;


    
    protected override void OnInitialized()
    {
        
        Player_Count = 1;

        explored_zones.Add(new ExploredZone { Row = 0, Column = 0 });

        for (double i = 0; i < Player_Count; i++)
        {
            char_list.Add(new Actor { Row = 0, Column = 0 });
        }

    }

    private string is_loading = "unloaded";
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            win_w = await JSRuntime.InvokeAsync<double>("GetWinW");
            win_h = await JSRuntime.InvokeAsync<double>("GetWinH");
            map_x = 0;
            map_y = 0;
            is_loading = "";
            StateHasChanged();
        }   
    }


    


    private double win_w;
    private double win_h;


    private void ExploreTile(Double row, Double col)
    {
        explored_zones.Add(new ExploredZone { Row = row, Column = col} );
    }

    private double mod_x = 0;
    private double mod_y = 0;

    private void MoveChar(MouseEventArgs e, String direction, Double char_row, Double char_col)
    {
        if ( shift_is_down != true )
        {
            double new_row = char_row;
            double new_col = char_col;

            bool explored = false;

            if ( direction == "north" ) { new_row = char_row - 1; map_y = new_row * -450; }
            if ( direction == "south" ) { new_row = char_row + 1; map_y = new_row * -450; }
            if ( direction == "east" ) { new_col = char_col + 1; map_x = new_col * -450; }
            if ( direction == "west" ) { new_col = char_col - 1; map_x = new_col * -450; }

            foreach ( ExploredZone zone in explored_zones )
            {
                if ( zone.Row == new_row )
                {
                    if ( zone.Column == new_col ) { explored = true; break; }
                }
            }

            if ( explored == false ) { ExploreTile(new_row, new_col); }

            MoveActor(current_player, "char", new_row, new_col);
        }
    }

    

    private void MoveActor(int current_id, String actor_type, Double new_row, Double new_col)
    {
        if ( actor_type == "char" )
        {
            char_list[current_id].Row = new_row;
            char_list[current_id].Column = new_col;
        }
    }




    private double map_x;
    private double map_y;
    private double xco = 0;
    private double yco = 0;
    private static int zone_size_px = 450;

    private bool mouse_is_down = false;
    private bool shift_is_down = false;

    private double mxs;
    private double mys;
    private double max_xy = -4750;
    private double min_xy = 4750;

    private void StartMapDrag(MouseEventArgs e)
    {
        mxs = e.ClientX;
        mys = e.ClientY;
        mouse_is_down = true;
        if ( e.ShiftKey == true ) { shift_is_down = true; }

    }
    private void MapDrag(MouseEventArgs e)
    {
        if ( shift_is_down == true )
        {
            if (mouse_is_down == true)
            {
                map_x += e.ClientX - mxs;
                mxs = e.ClientX;
                map_y += e.ClientY - mys;
                mys = e.ClientY;
            }
        }
        
    }    
    private void ResetMapDrag(MouseEventArgs e)
    {
        mouse_is_down = false;
        shift_is_down = false;

        if ( map_x < max_xy ) { map_x = max_xy; }
        if ( map_x > min_xy ) { map_x = min_xy; }
        if ( map_y < max_xy ) { map_y = max_xy; }
        if ( map_y > min_xy ) { map_y = min_xy; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
