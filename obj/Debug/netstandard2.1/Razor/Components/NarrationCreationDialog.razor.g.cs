#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c331d5518c78b1aeb8cdc223291e3137a24d4d22"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    public partial class NarrationCreationDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "400px");
            __builder.AddAttribute(2, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
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
                    __builder3.AddMarkupContent(11, "<h3 class=\"text-3xl font-semibold\">Add New Narration Record</h3>\r\n        ");
                }
                ));
                __builder2.AddAttribute(12, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "w-full m-6 text-gray-600 text-xl");
                    __builder3.AddMarkupContent(16, "\r\n                New narration record for <br>");
                    __builder3.AddContent(17, 
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
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
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                 narrationCreation

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
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
                        __builder4.AddAttribute(32, "class", "w-11/12 px-3 mb-6");
                        __builder4.AddMarkupContent(33, "\r\n                        ");
                        __builder4.AddMarkupContent(34, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"subject\">\r\n                            Subject\r\n                        </label>\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                        __builder4.AddAttribute(36, "id", "subject");
                        __builder4.AddAttribute(37, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                                                                                                                                                                                                           narrationCreation.Subject

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => narrationCreation.Subject = __value, narrationCreation.Subject))));
                        __builder4.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => narrationCreation.Subject));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n                        ");
                        __Blazor.LCMSMSPWA.Components.NarrationCreationDialog.TypeInference.CreateValidationMessage_0(__builder4, 42, 43, 
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                  () => narrationCreation.Subject

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(44, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(45, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(46, "div");
                        __builder4.AddAttribute(47, "style", "height:400px;");
                        __builder4.AddMarkupContent(48, "\r\n                        ");
                        __builder4.OpenElement(49, "div");
                        __builder4.AddAttribute(50, "class", "w-11/12 h-full px-3 mb-6");
                        __builder4.AddMarkupContent(51, "\r\n                            ");
                        __builder4.AddMarkupContent(52, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"note\">\r\n                                Note\r\n                            </label>\r\n                            ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(53);
                        __builder4.AddAttribute(54, "id", "note");
                        __builder4.AddAttribute(55, "class", "appearance-none block w-full h-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                                                                                                                                                                                                                       narrationCreation.Note

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => narrationCreation.Note = __value, narrationCreation.Note))));
                        __builder4.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => narrationCreation.Note));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n                            ");
                        __Blazor.LCMSMSPWA.Components.NarrationCreationDialog.TypeInference.CreateValidationMessage_1(__builder4, 60, 61, 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                      () => narrationCreation.Note

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(62, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(63, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(64, "\r\n\r\n\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(68);
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(71);
                    __builder3.AddAttribute(72, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(74, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(75);
                        __builder4.AddAttribute(76, "Content", "Save");
                        __builder4.AddAttribute(77, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(78, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(80);
                    __builder3.AddAttribute(81, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
                                OnCancelBtnClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(83, "\r\n            ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(84);
                        __builder4.AddAttribute(85, "Content", "Cancel");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(90, @"<style>
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
#line 67 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\NarrationCreationDialog.razor"
       

    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }

    [Parameter]
    public EventCallback<bool> OnAddNewComplete { get; set; }

    [Inject]
    public INarrationRepository NarrationRepository { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    private NarrationCreation narrationCreation = new NarrationCreation();

    [Inject]
    protected IMatToaster Toaster { get; set; }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
    // Focus the element
            await JSRuntime.FocusInput("subject");
        }
    }

    private async Task HandleValidSubmit()
    {
        if (Orphan == null)
        {
            Toaster.Add($" No Orphan record found.", MatToastType.Danger);
            return;
        }
        narrationCreation.OrphanID = Orphan.OrphanID;
        narrationCreation.EntryDate = DateTime.Now;

        await NarrationRepository.AddNarrationAsync(narrationCreation);
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(true);
        StateHasChanged();
        Toaster.Add($" Narration record added.", MatToastType.Success);
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
namespace __Blazor.LCMSMSPWA.Components.NarrationCreationDialog
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
    }
}
#pragma warning restore 1591
