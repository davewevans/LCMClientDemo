#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanProfilePhotoEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "020c06bd82d6ee6b12385dfcc82528d64859e780"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanProfilePhotoEdit.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanProfilePhotoEdit.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class OrphanProfilePhotoEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMSMSPWA\Components\OrphanProfilePhotoEdit.razor"
       
    
    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }
    
    [Parameter]
    public EventCallback<OrphanDetailsModel> HandleProfilePhotoChanged{ get; set; }

    string status = "";
    string statusClass = "";
    bool uploadFailed = false;
    int maxFileSizeMb = 10;

    readonly string[] allowedContentTypes = { "image/jpeg", "image/png", "image/gif" };
    
    ElementReference inputReference;

    private int? progress;

    private async Task HandleFileUpload()
    {
        int countSize = 0;
        uploadFailed = false;
        status = "";

        // Read the file
        var file = (await FileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file != null)
        {
            var fileInfo = await file.ReadFileInfoAsync();

            if (!IsValidFile(fileInfo.Type, fileInfo.Size)) return;

            byte[] fileBytes;
            await using (var ms = new MemoryStream())
            {
                await using (var fs = await file.OpenReadAsync())
                {
                    var bufferSize = 4096;
                    var buffer = new byte[bufferSize];
                    int count;
                    while ((count = await fs.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        ms.Write(buffer, 0, count);
                        countSize += count;
                        progress = (int)(((decimal)countSize / fileInfo.Size) * 97);
                        StateHasChanged();
                    }
                
                    fileBytes = ms.ToArray();
                }
            }  
        
            var picCreation = new PictureCreation
            {
                PictureFileName = fileInfo.Name,
                SetAsProfilePic = true,
                ContentType = fileInfo.Type,
                OrphanID = Orphan.OrphanID
            };
        
            string result = await PicHttpRepository.UploadImageAsync(picCreation, fileBytes);

            if (!string.IsNullOrWhiteSpace(result))
            {
                Orphan.ProfilePicUrl = result;
                await HandleProfilePhotoChanged.InvokeAsync(Orphan);
            }
            ShowStatus(result);
        }
    }

    private void ShowStatus(string result)
    {
        if (string.IsNullOrWhiteSpace(result))
        {
            status = "Something went wrong :(";
            statusClass = "text-red-600 text-2xl";
            uploadFailed = true;
        }
        else
        {
            progress = 100;
            status = "Upload Success!";
            statusClass = "text-green-600 text-2xl";
        }
    }

    private bool IsValidFile(string type, long size)
    {
        if (!allowedContentTypes.Contains(type))
        {
            uploadFailed = true;
            status = "Please select a .png, .jpg, or .gif file.";
            statusClass = "text-red-600 text-2xl";
            return false;
        }

        if (size > maxFileSizeMb * 1024 * 1024)
        {
            uploadFailed = true;
            status = $"Max file size: {maxFileSizeMb}MB";
            statusClass = "text-red-600 text-2xl";
            return false;
        }

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPictureRepository PicHttpRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService FileReader { get; set; }
    }
}
#pragma warning restore 1591
