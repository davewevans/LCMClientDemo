#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationStatisticsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e204ad15c9665841783493e9f6fa584ef8e02c33"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationStatisticsComponent.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationStatisticsComponent.razor"
using LegendPosition = Syncfusion.Blazor.Charts.LegendPosition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationStatisticsComponent.razor"
using LabelPosition = Syncfusion.Blazor.Charts.LabelPosition;

#line default
#line hidden
#nullable disable
    public partial class NarrationStatisticsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationStatisticsComponent.razor"
       
    
    NarrationStatistics narrationStatistics = null;
    bool hideLoadingAnimation = false;
    bool hideChart = true;
    
    public List<BarChartData> BarData { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        narrationStatistics = await DashboardRepository.GetNarrationStatistics();
        
        BarData =  new List<BarChartData>
        {
            new BarChartData { x= "Orphans",  y= (double)narrationStatistics.OrphanNarrationCount , y1= (double)narrationStatistics.OrphanLast6MoCount },
            new BarChartData { x= "Guardians", y= (double)narrationStatistics.GuardianNarrationCount , y1= (double)narrationStatistics.GuardianLast6MoCount },
            //
            // TODO remove hardcode values. For demo only
            //
            //new BarChartData { x= "Orphans",  y= 421 , y1= 206 },
           //new BarChartData { x= "Guardians", y= 230 , y1= 85 },
        };

    }
    
    public class BarChartData
    {
        public string x { get; set; }
        public double y { get; set; }
        public double y1 { get; set; }
    }
  
    string CurrentUri;
    void ChartLoad(ILoadedEventArgs Args)
    {
        CurrentUri = NavigationManager.Uri;
        if (CurrentUri.IndexOf("material") > -1)
        {
            Args.Theme = ChartTheme.Material;
        }
        else if (CurrentUri.IndexOf("fabric") > -1)
        {
            Args.Theme = ChartTheme.Fabric;
        }
        else if (CurrentUri.IndexOf("bootstrap") > -1)
        {
            Args.Theme = ChartTheme.Bootstrap;
        }
        else if (CurrentUri.IndexOf("highcontrast") > -1)
        {
            Args.Theme = ChartTheme.HighContrast;
        }
        else
        {
            Args.Theme = ChartTheme.Bootstrap4;
        }
        
        hideChart = false;
        hideLoadingAnimation = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDashboardRepository DashboardRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591