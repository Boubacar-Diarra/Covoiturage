// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
