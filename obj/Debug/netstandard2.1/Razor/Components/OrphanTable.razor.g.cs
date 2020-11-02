#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17937b1de520fa54ac18cb547fa576a6153422ba"
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
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    public partial class OrphanTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>OrphanTable</h3>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
 if (Orphans.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.AddMarkupContent(5, @"<thead>
            <tr>
                <th scope=""col""></th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Gender</th>
                <th scope=""col"">Birth Date</th>
                <th scope=""col"">LCM Status</th>
                <th scope=""col"">Profile Number</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
         foreach (var orphan in Orphans)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "            ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                               orphan.ProfilePicUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                                                           orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "img-thumbnail custom-thumbnail");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "align-middle");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddContent(22, 
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                     orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "class", "align-middle");
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.AddContent(28, 
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                     orphan.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "class", "align-middle");
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.AddContent(34, 
#nullable restore
#line 31 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                     orphan.DateOfBirth?.ToString("MM/dd/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "class", "align-middle");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.AddContent(40, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                     orphan.LCMStatus

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "class", "align-middle");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.AddContent(46, 
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                     orphan.ProfileNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "class", "align-middle");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                                                    () => ViewDetails(orphan.OrphanID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "btn btn-info");
            __builder.AddContent(56, "Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "   <img src=\"images/Spinner-1s-200px.gif\" height=\"150\" width=\"150\">\r\n");
#nullable restore
#line 50 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n<br><br><br>\r\n");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanTable.razor"
                                NavigateToHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "class", "btn btn-info");
            __builder.AddContent(69, "GO Home!");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591