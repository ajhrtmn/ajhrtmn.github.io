#pragma checksum "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff81b950e08d257e722f2d9be762ea82d1a1d9ce"
// <auto-generated/>
#pragma warning disable 1591
namespace Imaginators.Pages.MapPages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
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
#nullable restore
#line 1 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    public partial class MapView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "map_viewport");
            __builder.AddEventPreventDefaultAttribute(2, "onmousedown", true);
            __builder.AddEventPreventDefaultAttribute(3, "onclick", true);
            __builder.AddAttribute(4, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                            StartMapDrag

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                        MapDrag

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                             ResetMapDrag

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-jht3lopo4m");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "map_container");
            __builder.AddAttribute(10, "b-jht3lopo4m");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "margin-top:" + (
#nullable restore
#line 7 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                 map_y*2

#line default
#line hidden
#nullable disable
            ) + "px;margin-left:" + (
#nullable restore
#line 7 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                          map_x*2

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.AddAttribute(13, "class", "zone_container");
            __builder.AddAttribute(14, "b-jht3lopo4m");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "zone_wrap");
            __builder.AddAttribute(17, "b-jht3lopo4m");
#nullable restore
#line 10 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                     foreach ( Zone zone in explored_zones )
                    {
                        xco = zone.Column * zone_size_px;
                        yco = zone.Row * zone_size_px;

                        var n_unloaded = "";
                        var s_unloaded = "";
                        var e_unloaded = "";
                        var w_unloaded = "";

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if ( zone.North.WallType == "Open" ) { n_unloaded = ""; } else { n_unloaded = "unloaded"; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if ( zone.South.WallType == "Open" ) { s_unloaded = ""; } else { s_unloaded = "unloaded"; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if ( zone.East.WallType == "Open" ) { e_unloaded = ""; } else { e_unloaded = "unloaded"; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if ( zone.West.WallType == "Open" ) { w_unloaded = ""; } else { w_unloaded = "unloaded"; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                   

                        current_zone = "";

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if ( zone.JustSpawned == true ) { new_zone = "new_zone"; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if ( zone.JustSpawned == false ) { new_zone = ""; }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "zone_bin" + "  " + (
#nullable restore
#line 30 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                new_zone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", "left:" + (
#nullable restore
#line 30 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                         xco

#line default
#line hidden
#nullable disable
            ) + "px;top:" + (
#nullable restore
#line 30 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                      yco

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.AddAttribute(21, "b-jht3lopo4m");
#nullable restore
#line 32 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                             if ( char_list[current_player].Row == zone.Row )
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                 if ( char_list[current_player].Column == zone.Column )
                                {
                                    current_zone = "current_zone";
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "zone_back" + " " + (
#nullable restore
#line 40 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                    current_zone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "b-jht3lopo4m");
            __builder.OpenComponent<Imaginators.Pages.MapPages.Map_Zone>(25);
            __builder.AddAttribute(26, "EnteredFrom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                         zone.EnteredFrom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "NorthType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                         zone.North.WallType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "SouthType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                            zone.South.WallType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "EastType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                              zone.East.WallType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "WestType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                                                               zone.West.WallType

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         if(current_zone == "current_zone")
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "left:" + (
#nullable restore
#line 47 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                               xco + 165

#line default
#line hidden
#nullable disable
            ) + "px;top:" + (
#nullable restore
#line 47 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                  yco - 55

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.AddAttribute(33, "class", "control_box" + " north_box" + " " + (
#nullable restore
#line 47 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                               new_zone

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 47 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                           n_unloaded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                      e => MoveChar(e, "north", char_list[current_player].Row, char_list[current_player].Column)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "b-jht3lopo4m");
            __builder.CloseElement();
#nullable restore
#line 47 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                                                                                                                         ;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "left:" + (
#nullable restore
#line 48 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                               xco + 165

#line default
#line hidden
#nullable disable
            ) + "px;top:" + (
#nullable restore
#line 48 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                  yco + 425

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.AddAttribute(38, "class", "control_box" + " south_box" + " " + (
#nullable restore
#line 48 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                new_zone

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 48 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                            s_unloaded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                       e => MoveChar(e, "south", char_list[current_player].Row, char_list[current_player].Column)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "b-jht3lopo4m");
            __builder.CloseElement();
#nullable restore
#line 48 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                                                                                                                          ;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "left:" + (
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                               xco + 425

#line default
#line hidden
#nullable disable
            ) + "px;top:" + (
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                  yco + 165

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.AddAttribute(43, "class", "control_box" + " east_box" + " " + (
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                               new_zone

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                           e_unloaded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                      e => MoveChar(e, "east", char_list[current_player].Row, char_list[current_player].Column)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "b-jht3lopo4m");
            __builder.CloseElement();
#nullable restore
#line 49 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                                                                                                                        ;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "style", "left:" + (
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                               xco - 55

#line default
#line hidden
#nullable disable
            ) + "px;top:" + (
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                 yco + 165

#line default
#line hidden
#nullable disable
            ) + "px;");
            __builder.AddAttribute(48, "class", "control_box" + " west_box" + " " + (
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                              new_zone

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                          w_unloaded

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                     e => MoveChar(e, "west", char_list[current_player].Row, char_list[current_player].Column)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "b-jht3lopo4m");
            __builder.CloseElement();
#nullable restore
#line 50 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                                                                                                                                                                                                                                                       ;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
                         
                    }                

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/Volumes/Wall Screen/Imaginators Assets/Code/Imaginators/Pages/MapPages/MapView.razor"
      
    [Parameter] public int Player_Count { get; set; }

    private IList<Zone> explored_zones = new List<Zone>();
    private IList<Actor> char_list = new List<Actor>();
    
    private int Zone_Count = 0;
    private int Wall_Count = 0;

    private int current_player = 0;
    private string current_zone = "";
    private string new_zone = "";
    private bool explored = false;



    
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            var open_wall = new Wall();
            open_wall.WallType ="Open";

            Player_Count = 1;

            Zone_Count++;

            explored_zones.Add(new Zone {
                Row = 0,
                Column = 0,
                EnteredFrom = "",
                North = open_wall,
                South = open_wall,
                East = open_wall,
                West = open_wall
                });

            for (double i = 0; i < Player_Count; i++)
            {
                char_list.Add(new Actor { Row = 0, Column = 0 });
            }
        }

    }

    private void ExploreTile(Double row, Double col, string ent)
    {
        var open_wall = new Wall();
        open_wall.WallType ="Open";

        var has_teleport = false;

        var n_surround = 0;
        var s_surround = 0;
        var e_surround = 0;
        var w_surround = 0;

        var north_wall = new Wall();
        var south_wall = new Wall();
        var east_wall = new Wall();
        var west_wall = new Wall();

        Zone_Count++;

        foreach ( Zone zone in explored_zones )
        {
            if ( zone.Column == col )
            {
                if ( zone.Row == ( row + 1 ) )
                {
                    south_wall = zone.North;
                    n_surround++;
                }
                if ( zone.Row == ( row - 1 ) )
                {
                    north_wall = zone.South;
                    s_surround++;
                    
                }
            }
            if ( zone.Row == row )
            {
                if ( zone.Column == ( col + 1 ) )
                {
                    east_wall = zone.West;
                    e_surround++;
                }
                if ( zone.Column == ( col - 1 ) )
                {
                    west_wall = zone.East;
                    w_surround++;
                }
            }
        }


    if ( north_wall.WallType != "Open" ) { Wall_Count++; }
    if ( south_wall.WallType != "Open" ) { Wall_Count++; }
    if ( east_wall.WallType != "Open" ) { Wall_Count++; }
    if ( west_wall.WallType != "Open" ) { Wall_Count++; }

    
    if ( Wall_Count >= ( Zone_Count * 2 ) )
    {
        if ( n_surround != 1 ) { north_wall = open_wall; Wall_Count--; }
        if ( s_surround != 1 ) { south_wall = open_wall; Wall_Count--; }
        if ( e_surround != 1 ) { east_wall = open_wall; Wall_Count--; }
        if ( w_surround != 1 ) { west_wall = open_wall; Wall_Count--; }
        Console.WriteLine("Surounds");
        Console.WriteLine(n_surround + s_surround + e_surround + w_surround);
    }
    


        Console.WriteLine("WallCount");
        Console.WriteLine(Wall_Count);
        Console.WriteLine("ZoneCount * 2");
        Console.WriteLine(Zone_Count * 2 );
        

        explored_zones.Add(new Zone
        {
            JustSpawned = true,
            Row = row, Column = col,
            EnteredFrom = ent,
            North = north_wall,
            South = south_wall,
            East = east_wall,
            West = west_wall,
            has_Teleport = has_teleport
        });
    }

    
    private async void MoveChar(MouseEventArgs e, String direction, Double char_row, Double char_col)
    {
        if ( shift_is_down != true )
        {
            double new_row = char_row;
            double new_col = char_col;
            var ent = "";

            explored = false;

            if ( direction == "north" ) { ent = "South"; new_row = char_row - 1; }
            if ( direction == "south" ) { ent = "North"; new_row = char_row + 1; }
            if ( direction == "east" ) { ent = "West"; new_col = char_col + 1; }
            if ( direction == "west" ) { ent = "East"; new_col = char_col - 1; }

            foreach ( Zone zone in explored_zones )
            {
                if ( zone.Row == new_row )
                {
                    if ( zone.Column == new_col ) { explored = true; break; }
                }
            }

            if ( explored == false ) { new_zone = ""; ExploreTile(new_row, new_col, ent); }

            MoveActor(current_player, "char", new_row, new_col);

            var moving = 0;
            var rate = 4;
            while ( moving < 90 )
            {
                if ( moving > 30 && moving < 51 ) { rate = 6; }
                if ( moving > 50 && moving < 66 ) { rate = 8; }
                if ( moving > 65 && moving < 76 ) { rate = 12; }
                if ( moving > 75 ) { rate = 16; }


                await Task.Delay(rate);
                if ( direction == "north" ) { map_y += 5; }
                if ( direction == "south" ) { map_y += -5; }
                if ( direction == "east" ) { map_x += -5; }
                if ( direction == "west" ) { map_x += 5; }
                StateHasChanged();
                moving++;
            }
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
    }
}
#pragma warning restore 1591
