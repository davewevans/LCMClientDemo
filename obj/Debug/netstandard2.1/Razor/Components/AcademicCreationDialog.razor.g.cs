#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74368979f0387e7f2b2d8c25ddba75fb5cc7584"
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
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    public partial class AcademicCreationDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "400px");
            __builder.AddAttribute(2, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                        IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(8);
                __builder2.AddAttribute(9, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\r\n            ");
                    __builder3.AddMarkupContent(11, "<h3 class=\"text-3xl font-semibold\">Add New Academic Record</h3>\r\n        ");
                }
                ));
                __builder2.AddAttribute(12, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "w-full m-6 text-gray-600 text-xl");
                    __builder3.AddMarkupContent(16, "\r\n                New academic record for <br>");
                    __builder3.AddContent(17, 
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                             Orphan.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "w-full m-6");
                    __builder3.AddMarkupContent(22, "\r\n                ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
                    __builder3.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                 academicCreation

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(26, "class", "w-full max-w-lg");
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(28, "\r\n                    ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(29);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(31, "div");
                        __builder4.AddAttribute(32, "class", "w-1/2 px-3 mb-6");
                        __builder4.AddMarkupContent(33, "\r\n                        ");
                        __builder4.AddMarkupContent(34, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"grade\">\r\n                            Grade\r\n                        </label>\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                        __builder4.AddAttribute(36, "id", "grade");
                        __builder4.AddAttribute(37, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                                                                                                                                                                                                         academicCreation.Grade

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => academicCreation.Grade = __value, academicCreation.Grade))));
                        __builder4.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => academicCreation.Grade));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                        ");
                        __Blazor.LCMSMSPWA.Components.AcademicCreationDialog.TypeInference.CreateValidationMessage_0(__builder4, 42, 43, 
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                  () => academicCreation.Grade

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(44, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(45, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(46, "div");
                        __builder4.AddAttribute(47, "class", "w-3/4 px-3 mb-6");
                        __builder4.AddMarkupContent(48, "\r\n                        ");
                        __builder4.AddMarkupContent(49, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"school\">\r\n                            School\r\n                        </label>\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                        __builder4.AddAttribute(51, "id", "school");
                        __builder4.AddAttribute(52, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                                                                                                                                                                                                          academicCreation.School

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => academicCreation.School = __value, academicCreation.School))));
                        __builder4.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => academicCreation.School));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n                        ");
                        __Blazor.LCMSMSPWA.Components.AcademicCreationDialog.TypeInference.CreateValidationMessage_1(__builder4, 57, 58, 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                  () => academicCreation.School

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(59, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(60, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(61, "div");
                        __builder4.AddAttribute(62, "class", "w-1/2 px-3 mb-6");
                        __builder4.AddMarkupContent(63, "\r\n                        ");
                        __builder4.AddMarkupContent(64, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"KCPE\">\r\n                            KCPE\r\n                        </label>\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(65);
                        __builder4.AddAttribute(66, "id", "KCPE");
                        __builder4.AddAttribute(67, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(68, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                                                                                                                                                                                                        academicCreation.KCPE

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => academicCreation.KCPE = __value, academicCreation.KCPE))));
                        __builder4.AddAttribute(70, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => academicCreation.KCPE));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(71, "\r\n                        ");
                        __Blazor.LCMSMSPWA.Components.AcademicCreationDialog.TypeInference.CreateValidationMessage_2(__builder4, 72, 73, 
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                  () => academicCreation.KCPE

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(74, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(76, "div");
                        __builder4.AddAttribute(77, "class", "w-1/2 px-3 mb-6");
                        __builder4.AddMarkupContent(78, "\r\n                        ");
                        __builder4.AddMarkupContent(79, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"KCSE\">\r\n                            KCSE\r\n                        </label>\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                        __builder4.AddAttribute(81, "id", "KCSE");
                        __builder4.AddAttribute(82, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                                                                                                                                                                                                        academicCreation.KCSE

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => academicCreation.KCSE = __value, academicCreation.KCSE))));
                        __builder4.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => academicCreation.KCSE));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n                        ");
                        __Blazor.LCMSMSPWA.Components.AcademicCreationDialog.TypeInference.CreateValidationMessage_3(__builder4, 87, 88, 
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                  () => academicCreation.KCSE

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(89, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(90, "\r\n\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(94);
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(96, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(97);
                    __builder3.AddAttribute(98, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(100, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(101);
                        __builder4.AddAttribute(102, "Content", "Save");
                        __builder4.AddAttribute(103, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(104, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(105, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(106);
                    __builder3.AddAttribute(107, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
                                OnCancelBtnClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(109, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(110);
                        __builder4.AddAttribute(111, "Content", "Cancel");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(112, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(113, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(114, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(115, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(116, @"<style>
    .e-btn.e-flat.e-primary, .e-btn.e-flat.e-primary:focus {
        background-color: #317ab9;
        border-color: #265f91;
        color: #fff;
    }

    .e-btn.e-flat.e-primary:hover, .e-btn.e-flat.e-primary:active {
        background-color: #21527d;
        border-color: #163854;
        color: #fff;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\AcademicCreationDialog.razor"
       
    
    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; } 
    
    [Parameter]
    public EventCallback<bool> OnAddNewComplete { get; set; }

    [Inject]
    public IAcademicRepository AcademicRepository { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    private AcademicCreation academicCreation = new AcademicCreation();

    [Inject]
    protected IMatToaster Toaster { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // Focus the element
            await JSRuntime.FocusInput("grade");
        }
    }

    private async Task HandleValidSubmit()
    {
        if (Orphan == null)
        {
            Toaster.Add($" No Orphan record found.", MatToastType.Danger);
            return;
        }
        academicCreation.OrphanID = Orphan.OrphanID;
        academicCreation.EntryDate = DateTime.Now;
        await AcademicRepository.AddAcademicAsync(academicCreation);
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(true);
        StateHasChanged();
        Toaster.Add($" Academic record added.", MatToastType.Success);
    }

    private async Task OnCancelBtnClick()
    {
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(false);
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.LCMSMSPWA.Components.AcademicCreationDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
