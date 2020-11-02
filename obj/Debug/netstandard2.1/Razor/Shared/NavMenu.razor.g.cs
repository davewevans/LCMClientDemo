#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be32a22e2f1ed091a669dbe4a347cb34ec71c1ec"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMSMSPWA.Shared
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
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, ":class", "sidebarOpen ? \'translate-x-0 ease-out\' : \'-translate-x-full ease-in\'");
            __builder.AddAttribute(2, "class", "fixed z-30 inset-y-0 left-0 w-64 transition duration-300 transform bg-blue-900 overflow-y-auto lg:translate-x-0 lg:static lg:inset-0");
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(4, @"<div class=""flex items-center justify-center mt-8"">
        <div class=""flex items-center bg-white"">
            <img class src=""images/LMCSMS_Icon_88x88.png"" alt=""Life for Children Ministry"">
            <span class=""text-blue-800 text-2xl font-semibold mr-2"">LCM SMS</span>
        </div>
    </div>
    

    ");
            __builder.OpenElement(5, "nav");
            __builder.AddAttribute(6, "class", "mt-10");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            __builder.AddAttribute(9, "class", "flex items-center mt-4 py-2 px-6 border-l-4 border-gray-900 text-gray-500 hover:bg-gray-600 hover:bg-opacity-25 hover:text-gray-100");
            __builder.AddAttribute(10, "href", "");
            __builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Shared\NavMenu.razor"
                                                                                                                                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.AddMarkupContent(14, @"<svg class=""h-5 w-5"" viewBox=""0 0 20 20"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                <path d=""M2 10C2 5.58172 5.58172 2 10 2V10H18C18 14.4183 14.4183 18 10 18C5.58172 18 2 14.4183 2 10Z"" fill=""currentColor""></path>
                <path d=""M12 2.25195C14.8113 2.97552 17.0245 5.18877 17.748 8.00004H12V2.25195Z"" fill=""currentColor""></path>
            </svg>
            ");
                __builder2.AddMarkupContent(15, "<span class=\"mx-4\">Dashboard</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "class", "flex items-center mt-4 py-2 px-6 border-l-4 border-gray-900 text-gray-500 hover:bg-gray-600 hover:bg-opacity-25 hover:text-gray-100");
            __builder.AddAttribute(19, "href", "admin");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n          <?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n          ");
                __builder2.AddMarkupContent(22, @"<svg class=""h-6 w-6"" version=""1.1"" x=""0px"" y=""0px"" viewBox=""3.721 0 58.512 67.158"" enable-background=""new 0 0 66 66"" xmlns=""http://www.w3.org/2000/svg"">
            <path d=""M30.1,8.1c0,3.9-3.2,7.1-7.1,7.1c-3.9,0-7.1-3.2-7.1-7.1S19,1,22.9,1C26.9,1,30.1,4.2,30.1,8.1z"" fill=""currentColor""></path>
            <path d=""M57.8,54.1h-5.4v-1.7h1.7c0.6,0,1-0.4,1-1c0-0.5-0.4-1-1-1h-1.7V39.6c4.3-1.3,7.2-5.5,6.8-10.2c-0.4-4.6-4-8.2-8.5-8.7   c-5.7-0.6-10.8,3.8-10.8,9.6c0,4.3,2.8,8,6.9,9.3v22.6c0,1.6,1.3,2.8,2.8,2.8c1.5,0,2.8-1.3,2.8-2.8v-2.5h2.9c0.6,0,1-0.5,1-1   s-0.4-1-1-1h-2.9v-1.7h5.4c0.6,0,1-0.5,1-1C58.8,54.5,58.4,54.1,57.8,54.1z M49.6,34.8c-2.5,0-4.5-2-4.5-4.5c0-2.5,2-4.5,4.5-4.5   c2.5,0,4.5,2,4.5,4.5C54.1,32.8,52.1,34.8,49.6,34.8z"" fill=""currentColor""></path>
            <path d=""M42.8,20.9c-1.8,1.3-3.3,3.1-4.1,5.3c-0.4,0-0.7-0.2-1-0.4L33.8,22c-0.3-0.3-0.7-0.3-1.1-0.2c-0.4,0.2-0.6,0.5-0.6,0.9     v37.8c0,1.6-1.3,2.9-2.9,2.9h-5.4v-18c0-0.5-0.5-1-1-1s-1,0.5-1,1v18h-5.4c-1.6,0-2.9-1.3-2.9-2.9V33.3h6.2c2.1,0,3.8-2,3.4-4.2     c-0.3-1.6-1.8-2.7-3.5-2.7h-6.1v-6.9c0-0.5-0.5-1-1-1s-1,0.5-1,1v7.9c0,0.5,0.5,1,1,1c0,0,0,0,0,0h7.1c0.8,0,1.5,0.6,1.6,1.4     c0,0.8-0.6,1.5-1.4,1.5H9.6c-1.6,0-2.9-1.3-2.9-2.9v-6.6c0-3.6,2.9-6.4,6.4-6.4H18c0.5,0,1,0.3,1.2,0.7l2.8,5.4     c0.2,0.3,0.5,0.5,0.9,0.5c0.4,0,0.7-0.2,0.9-0.5l2.8-5.4c0.2-0.4,0.7-0.7,1.2-0.7h2.5c3.3,0,4.9,1.5,6.8,3.4     c0.6,0.6,1.3,1.3,2.1,1.9c0.2,0.1,0.4,0.2,0.6,0.2H42.8z"" fill=""currentColor""></path>
          </svg>
            ");
                __builder2.AddMarkupContent(23, "<span class=\"mx-4\">Admin</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n        \r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "class", "flex items-center mt-4 py-2 px-6 border-l-4 border-gray-900 text-gray-500 hover:bg-gray-600 hover:bg-opacity-25 hover:text-gray-100");
            __builder.AddAttribute(27, "href", "orphans");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n          \r\n                ");
                __builder2.AddMarkupContent(30, "<svg class=\"h-6 w-6\" xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 100 100\" enable-background=\"new 0 0 100 100\">\r\n                    <path d=\"M26.679,29.132c4.542,0,8.221-3.68,8.221-8.218c0-4.539-3.679-8.219-8.221-8.219c-4.537,0-8.219,3.681-8.219,8.219  S22.142,29.132,26.679,29.132z\" fill=\"currentColor\"></path>\r\n                    <path d=\"M46.615,20.217c-1.5-0.686-3.276-0.027-3.963,1.474c-0.203,0.45-3.28,6.589-8.484,10.623  c-2.099-1.048-4.568-1.673-7.489-1.673c-2.918,0-5.388,0.625-7.486,1.673c-5.205-4.033-8.28-10.172-8.484-10.623  c-0.688-1.501-2.462-2.16-3.962-1.474c-1.501,0.687-2.162,2.46-1.474,3.962c2.101,4.595,6.421,11.773,12.369,16.125V60.77  l1.291,25.268c0.034,0.701,0.632,1.27,1.333,1.27h2.888c0.7,0,1.298-0.568,1.334-1.27l1.289-25.268h1.808l1.29,25.268  c0.034,0.701,0.635,1.27,1.334,1.27h2.887c0.702,0,1.3-0.568,1.334-1.27l1.289-25.268V40.304  c5.948-4.352,10.269-11.53,12.371-16.125C48.776,22.677,48.115,20.903,46.615,20.217z\" fill=\"currentColor\"></path>\r\n                    <circle cx=\"73.419\" cy=\"20.915\" r=\"8.219\" fill=\"currentColor\"></circle>\r\n                    <path d=\"M94.825,23.747c0.556-1.554-0.255-3.264-1.808-3.82c-1.557-0.554-3.268,0.256-3.822,1.81  c-0.039,0.116-2.891,6.417-8.41,10.499c-2.135-0.999-4.572-1.594-7.366-1.594c-2.793,0-5.233,0.595-7.369,1.594  c-5.521-4.081-8.37-10.383-8.409-10.499c-0.557-1.554-2.271-2.364-3.82-1.81c-1.555,0.557-2.364,2.267-1.811,3.82  c1.786,5.001,6.17,11.895,12.815,15.995v9.481l-6.269,15.667c-0.255,0.642,0.098,1.16,0.787,1.16h5.598l1.021,19.986  c0.037,0.701,0.636,1.27,1.336,1.27h2.94c0.701,0,1.301-0.568,1.338-1.27l1.02-19.986h1.646l1.022,19.986  c0.033,0.701,0.631,1.27,1.332,1.27h2.941c0.704,0,1.3-0.568,1.334-1.27l1.021-19.986h5.601c0.69,0,1.042-0.519,0.784-1.16  L82.01,49.223v-9.481C88.654,35.642,93.04,28.748,94.825,23.747z\" fill=\"currentColor\"></path>\r\n                </svg>\r\n            ");
                __builder2.AddMarkupContent(31, "<span class=\"mx-4\">Orphans</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "flex items-center mt-4 py-2 px-6 border-l-4 border-gray-900 text-gray-500 hover:bg-gray-600 hover:bg-opacity-25 hover:text-gray-100");
            __builder.AddAttribute(35, "href", "guardians");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(37, "\r\n           <?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n           ");
                __builder2.AddMarkupContent(38, @"<svg class=""h-6 w-6"" version=""1.1"" x=""0px"" y=""0px"" viewBox=""0 0 20.333 28.225"" style=""enable-background:new 0 0 20.333 27;"" xmlns=""http://www.w3.org/2000/svg"">
             <path d=""M4.333,22v4c0,0.553,0.447,1,1,1h3c0.553,0,1-0.447,1-1v-4h4v-0.624l-0.165-0.31c-0.376-0.394-0.648-0.886-0.766-1.437   l-3.069-5.755v-3.03l3,5.195V16c0-0.976,0.476-1.836,1.199-2.384c-0.119-0.353-0.199-0.724-0.199-1.116   c0-0.212,0.026-0.417,0.062-0.618L10.237,6.41C9.411,7.375,8.2,8,6.833,8c-1.426,0-2.684-0.68-3.51-1.718   C2.733,6.63,2.333,7.266,2.333,8v7c0,0.571,0.242,1.084,0.627,1.448L0,22H4.333z"" fill=""currentColor""></path>
             <circle cx=""6.833"" cy=""3.5"" r=""3.5"" fill=""currentColor""></circle>
             <path d=""M16.833,16c-1.173,0-2.207-0.585-2.843-1.474c-0.401,0.366-0.657,0.888-0.657,1.474v2v1c0,0.738,0.404,1.376,1,1.723V26   c0,0.553,0.447,1,1,1h3c0.553,0,1-0.447,1-1v-5.277c0.596-0.347,1-0.984,1-1.723v-1v-2c0-0.586-0.256-1.107-0.657-1.474   C19.04,15.415,18.006,16,16.833,16z"" fill=""currentColor""></path>
             <circle cx=""16.833"" cy=""12.5"" r=""2.5"" fill=""currentColor""></circle>
           </svg>
            ");
                __builder2.AddMarkupContent(39, "<span class=\"mx-4\">Guardians</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "flex items-center mt-4 py-2 px-6 border-l-4 border-gray-900 text-gray-500 hover:bg-gray-600 hover:bg-opacity-25 hover:text-gray-100");
            __builder.AddAttribute(43, "href", "sponsors");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n          <?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n          ");
                __builder2.AddMarkupContent(46, "<svg class=\"h-6 w-6\" version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 66 65.366\" enable-background=\"new 0 0 66 66\" xmlns=\"http://www.w3.org/2000/svg\">\r\n            <path d=\"M57.2,19.9H45.4c-3.8,0-6.9,3.6-6.9,8v20.7c0,0.4,0.3,0.7,0.7,0.7h4.4V37c0-0.4,0.3-0.7,0.7-0.7c0.4,0,0.7,0.3,0.7,0.7   v24.1c0,0.9,0.7,1.6,1.6,1.6h3.9V49.2c0-0.4,0.3-0.7,0.7-0.7c0.4,0,0.7,0.3,0.7,0.7v13.6h3.9c0.9,0,1.6-0.7,1.6-1.6V37   c0-0.4,0.3-0.7,0.7-0.7c0.4,0,0.7,0.3,0.7,0.7v12.2h4.4c0.4,0,0.7-0.3,0.7-0.7V27.9C64.1,23.4,61,19.9,57.2,19.9z\" fill=\"currentColor\"></path>\r\n            <path d=\"M51.3,17.5c4.2,0,7.7-3.5,7.7-7.9c0-4.3-3.4-7.9-7.7-7.9c-4.2,0-7.7,3.5-7.7,7.9C43.6,13.9,47.1,17.5,51.3,17.5z\" fill=\"currentColor\"></path>\r\n            <path d=\"M12.7,51.4c3.1,0,5.7-2.6,5.7-5.8c0-3.2-2.5-5.8-5.7-5.8c-3.1,0-5.7,2.6-5.7,5.8C7,48.8,9.6,51.4,12.7,51.4z\" fill=\"currentColor\"></path>\r\n            <path d=\"M17.6,53.4H7.8c-2.8,0-5.1,2.7-5.1,5.9v4.2c0,0.4,0.3,0.7,0.7,0.7H22c0.4,0,0.7-0.3,0.7-0.7v-4.2   C22.8,56,20.5,53.4,17.6,53.4z\" fill=\"currentColor\"></path>\r\n            <path d=\"M21.1,21.2v2.6c0.5,0,0.8-0.2,1.1-0.4c0.3-0.2,0.4-0.5,0.4-0.8c0-0.3-0.1-0.6-0.3-0.8C22.1,21.5,21.7,21.3,21.1,21.2z\" fill=\"currentColor\"></path>\r\n            <path d=\"M18.8,17.8c0,0.3,0.1,0.6,0.3,0.8c0.2,0.2,0.6,0.4,1.1,0.5v-2.5c-0.4,0-0.8,0.2-1,0.4C18.9,17.2,18.8,17.5,18.8,17.8z\" fill=\"currentColor\"></path>\r\n            <path d=\"M20.5,11.8c-4.7,0-8.5,3.8-8.5,8.5c0,4.7,3.8,8.5,8.5,8.5c4.7,0,8.5-3.8,8.5-8.5C29.1,15.6,25.2,11.8,20.5,11.8z    M23.5,24.5c-0.6,0.5-1.4,0.8-2.4,0.9v1h-0.9v-1.1c-1.3-0.1-2.5-0.7-3.6-1.6l1.1-1.3c0.8,0.7,1.7,1.1,2.5,1.3v-2.8   c-1.1-0.3-1.9-0.6-2.4-1c-0.5-0.4-0.8-1.1-0.8-1.9s0.3-1.5,0.9-2.1c0.6-0.5,1.3-0.8,2.3-0.9v-0.7h0.9v0.7c1.1,0.1,2.1,0.4,3,1.1   l-0.9,1.3c-0.6-0.5-1.3-0.7-2.1-0.8v2.7h0c1.1,0.3,1.9,0.6,2.5,1.1c0.5,0.4,0.8,1.1,0.8,1.9C24.4,23.2,24.1,23.9,23.5,24.5z\" fill=\"currentColor\"></path>\r\n            <path d=\"M38.5,22.7c0.4,0,0.6-0.4,0.6-0.7v-3.2c0-0.4-0.3-0.7-0.6-0.7l-3.9-0.5c-0.4-1.8-1.1-3.6-2.1-5.1l2.5-3.1   c0.2-0.3,0.2-0.7-0.1-1l-2.3-2.3c-0.3-0.3-0.7-0.3-1,0l-3.1,2.5c-1.6-1-3.3-1.8-5.2-2.1l-0.5-3.9c0-0.4-0.4-0.6-0.7-0.6h-3.2   c-0.4,0-0.7,0.3-0.7,0.6l-0.5,3.9c-1.9,0.4-3.6,1.1-5.2,2.1L9.5,6c-0.3-0.2-0.7-0.2-1,0.1L6.2,8.3C6,8.6,5.9,9,6.2,9.3l2.5,3.1   c-1,1.6-1.8,3.3-2.1,5.2L2.6,18c-0.4,0-0.6,0.4-0.6,0.7v3.2c0,0.4,0.3,0.7,0.6,0.7l3.9,0.5c0.4,1.8,1.1,3.6,2.1,5.1l-2.5,3.1   c-0.2,0.3-0.2,0.7,0.1,1l2.3,2.3c0.3,0.3,0.7,0.3,1,0.1l3.1-2.5c1.6,1,3.3,1.8,5.1,2.1l0.5,3.9c0,0.4,0.4,0.6,0.7,0.6h3.2   c0.4,0,0.7-0.3,0.7-0.6l0.5-3.9c1.8-0.4,3.6-1.1,5.1-2.1l3.1,2.5c0.3,0.2,0.7,0.2,1-0.1l2.3-2.3c0.3-0.3,0.3-0.7,0.1-1l-2.5-3.1   c1-1.5,1.8-3.3,2.1-5.1L38.5,22.7z M20.5,30.3c-5.5,0-10-4.5-10-10c0-5.5,4.5-10,10-10c5.5,0,10,4.5,10,10   C30.5,25.9,26,30.3,20.5,30.3z\" fill=\"currentColor\"></path>\r\n          </svg>\r\n            ");
                __builder2.AddMarkupContent(47, "<span class=\"mx-4\">Sponsors</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "  \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
