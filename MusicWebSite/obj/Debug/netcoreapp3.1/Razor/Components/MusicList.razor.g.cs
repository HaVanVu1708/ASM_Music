#pragma checksum "G:\Web Form\MusicWebSite\Components\MusicList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796604d3f49af2bfa55c35fc979bfe1cc99a168d"
// <auto-generated/>
#pragma warning disable 1591
namespace MusicWebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
using MusicWebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
using MusicWebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class MusicList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 8 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
     foreach (var music in MusicService.GetMusics())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:url(\'" + (
#nullable restore
#line 11 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                                                music.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 13 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                        music.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.AddContent(20, "        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-footer");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "small");
            __builder.AddAttribute(25, "class", "text-muted");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                  (e=>SelectMusic(music.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "data-toggle", "modal");
            __builder.AddAttribute(30, "data-target", "#productModal");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddContent(32, "More Info");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 22 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
#nullable restore
#line 25 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
 if (selectedMusic != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal fade");
            __builder.AddAttribute(40, "id", "productModal");
            __builder.AddAttribute(41, "tabindex", "-1");
            __builder.AddAttribute(42, "role", "dialog");
            __builder.AddAttribute(43, "aria-labelledby", "productTitle");
            __builder.AddAttribute(44, "aria-hidden", "true");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(48, "role", "document");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "modal-content");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-header");
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "h5");
            __builder.AddAttribute(57, "class", "modal-title");
            __builder.AddAttribute(58, "id", "productTitle");
            __builder.AddContent(59, 
#nullable restore
#line 31 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                                               selectedMusic.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.AddMarkupContent(61, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "modal-body");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "card");
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "card-img");
            __builder.AddAttribute(71, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 38 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                                                             selectedMusic.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "card-body");
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "class", "card-text");
            __builder.AddContent(79, 
#nullable restore
#line 41 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                                  selectedMusic.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "modal-footer");
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 46 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                        ");
            __builder.AddMarkupContent(88, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 49 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "                        ");
            __builder.OpenElement(90, "span");
            __builder.AddContent(91, 
#nullable restore
#line 52 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                               voteCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " ");
            __builder.AddContent(93, 
#nullable restore
#line 52 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                          voteLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 53 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                     for (int i = 1; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenElement(96, "span");
            __builder.AddAttribute(97, "class", "fa fa-star checked");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                                                       (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 60 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                            ");
            __builder.OpenElement(101, "span");
            __builder.AddAttribute(102, "class", "fa fa-star");
            __builder.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                                                               (e => SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 64 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 70 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "G:\Web Form\MusicWebSite\Components\MusicList.razor"
 
    Music selectedMusic;
    string selectedMusicId;

    void SelectMusic(string musicId)
    {
        selectedMusicId = musicId;
        selectedMusic = MusicService.GetMusics().First(x => x.Id == musicId);
        GetCurrentRating();
    }

    int currentRating = 0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectedMusic.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectedMusic.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectedMusic.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectedMusic.Id}: {currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating received for {selectedMusic.Id}: {rating}");
        MusicService.AddRating(selectedMusicId, rating);
        SelectMusic(selectedMusicId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileMusicServices MusicService { get; set; }
    }
}
#pragma warning restore 1591
