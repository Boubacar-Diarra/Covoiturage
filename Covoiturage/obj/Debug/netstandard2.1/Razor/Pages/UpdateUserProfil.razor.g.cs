#pragma checksum "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90935eb69c1eca559ae5d4ba78720f86abe420bf"
// <auto-generated/>
#pragma warning disable 1591
namespace Covoiturage.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Covoiturage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\_Imports.razor"
using Covoiturage.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
using Covoiturage.Payloads.Request;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateuser")]
    public partial class UpdateUserProfil : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "class", "col-sm-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-group");
            __builder.AddMarkupContent(4, "<label>Username</label>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
                                                 _registerRequest.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _registerRequest.username = __value, _registerRequest.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddMarkupContent(12, "<label>Nom</label>\r\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
                                                 _registerRequest.nom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _registerRequest.nom = __value, _registerRequest.nom));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group");
            __builder.AddMarkupContent(20, "<label>Téléphone</label>\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
                                                 _registerRequest.telephone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _registerRequest.telephone = __value, _registerRequest.telephone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group");
            __builder.AddMarkupContent(28, "<label>Email</label>\r\n        ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
                                                 _registerRequest.email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _registerRequest.email = __value, _registerRequest.email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group");
            __builder.AddMarkupContent(36, "<label>Description</label>\r\n        ");
            __builder.OpenElement(37, "textarea");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
                                              _registerRequest.description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _registerRequest.description = __value, _registerRequest.description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
                                                                () => Update()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "Mettre à jour");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\UpdateUserProfil.razor"
       
    private RegisterRequest _registerRequest = new RegisterRequest();
    //private string userId;
    protected override async Task OnInitializedAsync()
    {
        var userId = await Js.InvokeAsync<string>("getItemLs", new object[] { "id" });
        Console.WriteLine(userId);
        Console.WriteLine(555);

        var res = await HttpClient.GetAsync("http://localhost:8080/api/auth/"+userId);
        if (res.IsSuccessStatusCode)
        {
            _registerRequest = await res.Content.ReadFromJsonAsync<RegisterRequest>();
            //Console.WriteLine(_registerRequest.username);
            StateHasChanged();
        }
    }

    private async void Update()
    {
        var res = await HttpClient.PutAsJsonAsync("http://localhost:8080/api/auth/update", _registerRequest);
        if (res.IsSuccessStatusCode)
        {
            await Js.InvokeVoidAsync("showToast", "succes", "Mise à jour effectuée avec succès");
        }
        else
        {
            await Js.InvokeVoidAsync("showToast", "error", "Mise à jour échouée");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
