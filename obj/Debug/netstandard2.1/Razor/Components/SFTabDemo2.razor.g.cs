#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f8044758f7fe75d12933e27fff889e26888c48"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMSMSPWA.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using LCMSMSPWA.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sftabsdemo2")]
    public partial class SFTabDemo2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>SFTabDemo2</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfTab>(1);
            __builder.AddAttribute(2, "Height", "400px");
            __builder.AddAttribute(3, "CssClass", "tab-adaptive tab-header");
            __builder.AddAttribute(4, "OverflowMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.OverflowMode>(
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                      OverflowMode.Scrollable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "HeaderPlacement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.HeaderPosition>(
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                         HeaderPosition.Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.TabItems>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(11);
                    __builder3.AddAttribute(12, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                           Content0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(14, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(15);
                        __builder4.AddAttribute(16, "Text", "Profile");
                        __builder4.AddAttribute(17, "IconCss", "orphan-icon");
                        __builder4.AddAttribute(18, "IconPosition", "Left");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(19, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(21);
                    __builder3.AddAttribute(22, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                           Content1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(25);
                        __builder4.AddAttribute(26, "Text", "Academics");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(27, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(29);
                    __builder3.AddAttribute(30, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                           Content2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(32, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(33);
                        __builder4.AddAttribute(34, "Text", "Narrations");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(37);
                    __builder3.AddAttribute(38, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                           Content3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(40, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(41);
                        __builder4.AddAttribute(42, "Text", "Guardians");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(43, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(45);
                    __builder3.AddAttribute(46, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                           Content4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(48, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(49);
                        __builder4.AddAttribute(50, "Text", "Sponsors");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(51, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(53);
                    __builder3.AddAttribute(54, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
                           Content5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(56, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(57);
                        __builder4.AddAttribute(58, "Text", "Pictures");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n            ");
                    }
                    ));
                    __builder3.AddAttribute(60, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(61, "\r\n                ");
                        __builder4.OpenComponent<LCMSMSPWA.Components.Test>(62);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(63, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(67, @"<style>  
 
    .e-content .e-item {
        font-size: 12px;
        padding: 20px;
        text-align: justify;
        background: #ffffff;
    }
    
    .tab-header {
        font-size: 24px;
    }
    
     /*.header {*/
     /*    width: 50%;*/
     /*    float: left;*/
     /*    min-height: 1px;*/
     /*    padding-right: 15px;*/
     /*    padding-left: 15px;*/
     /*    font-size: 32px;*/
     /*}*/     
 
    
    @media screen and (max-width: 425px) {
        .tab-adaptive {
            overflow: hidden;
        }

        .tab-adaptive .e-content {
            height: inherit !important;
        }

        .tab-adaptive .e-item.e-active {
            overflow: scroll;
        }
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\SFTabDemo2.razor"
      
    public string Content0 = "HyperText Markup Language, commonly referred to as HTML, is the standard markup language used to create webpages.Along with CSS, and JavaScript, HTML is a cornerstone technology, used by most websites to create visuallyengaging web pages, user interfaces for web applications, and user interfaces for many mobile applications.[1] Webbrowsers can read HTML files and render them into visible or audible web pages.HTML describes the structure of awebsite semantically along with cues for presentation, making it a markup language, rather than a programming language.";
    public string Content1 = "C# is intended to be a simple, modern, general-purpose, object-oriented programming language. Its developmentteam is led by Anders Hejlsberg.The most recent version is C# 5.0, which was released on August 15, 2012.";
    public string Content2 = "Java is a set of computer software and specifications developed by Sun Microsystems, later acquired by OracleCorporation, that provides a system for developing application software and deploying it in a cross - platform computingenvironment.Java is used in a wide variety of computing platforms from embedded devices and mobile phones toenterprise servers and supercomputers.While less common, Java applets run in secure, sandboxed environments toprovide many features of native applications and can be embedded in HTML pages.";
    public string Content3 = "The command-line compiler, VBC.EXE, is installed as part of the freeware .NET Framework SDK. Mono alsoincludes a command - line VB.NET compiler.The most recent version is VB 2012, which was released on August 15, 2012.";
    public string Content4 = "Xamarin is a San Francisco, California based software company created in May 2011[3] by the engineers that created Mono,[4] Monofor Android and MonoTouch that are cross-platform implementations of the Common Language Infrastructure (CLI) and Common LanguageSpecifications (often called Microsoft .NET). With a C#-shared codebase, developers can use Xamarin tools to write native Android,iOS, and Windows apps with native user interfaces and share code across multiple platforms.[5] Xamarin has over 1 million developersin more than 120 countries around the World as of May 2015.";
    public string Content5 = "ASP.NET is an open-source server-side web application framework designed for web development to producedynamic web pages.It was developed by Microsoft to allow programmers to build dynamic web sites, web applicationsand web services.It was first released in January 2002 with version 1.0 of the.NET Framework, and is the successorto Microsoft Active Server Pages(ASP) technology.ASP.NET is built on the Common Language Runtime(CLR), allowingprogrammers to write ASP.NET code using any supported .NET language. The ASP.NET SOAP extension framework allowsASP.NET components to process SOAP messages.";
    public string Content6 = "The ASP.NET MVC is a web application framework developed by Microsoft, which implements themodel–view–controller(MVC) pattern.It is open - source software, apart from the ASP.NET Web Forms component which isproprietary.In the later versions of ASP.NET, ASP.NET MVC, ASP.NET Web API, and ASP.NET Web Pages(a platform usingonly Razor pages) will merge into a unified MVC 6.The project is called ASP.NET Next.";
    public string Content7 = "JavaScript (JS) is an interpreted computer programming language. It was originally implemented as part ofweb browsers so that client - side scripts could interact with the user, control the browser, communicateasynchronously, and alter the document content that was displayed.[5] More recently, however, it has become common inboth game development and the creation of desktop applications.";

    public OverflowMode Mode { get; set; } = OverflowMode.Scrollable;
    public HeaderPosition Header { get; set; } = HeaderPosition.Top;

    public string ModeValue { get; set; } = "Scrollable";
    public string HeaderValue { get; set; } = "Top";
    public class DropdownFields
    {
        public string ID { get; set; }
        public string Text { get; set; }
    }
    List<DropdownFields> TabModeData = new List<DropdownFields> {
        new DropdownFields() { ID= "Scrollable", Text= "Scrollable" },
        new DropdownFields() { ID= "Popup", Text= "Popup" },
     };
    List<DropdownFields> OrientationData = new List<DropdownFields> {
        new DropdownFields() { ID= "Top", Text= "Top" },
        new DropdownFields() { ID= "Bottom", Text= "Bottom" },
        new DropdownFields() { ID= "Left", Text= "Left" },
        new DropdownFields() { ID= "Right", Text= "Right" }
    };

    public void OnChangeMode(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {

        Mode = (OverflowMode)Enum.Parse(typeof(OverflowMode), (args.Value as string));
    }
    public void OnChangeHeaderPosition()
    {

       // Header = (HeaderPosition)Enum.Parse(typeof(HeaderPosition), (args.Value as string));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591