#pragma checksum "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea5512e82d81d2e671984ad6f196436b09a79de0"
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
#line 2 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
using Covoiturage.Payloads.Request;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recherche")]
    public partial class Recherche : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "form");
            __builder.AddAttribute(3, "class", "col-sm-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "<label>Prix</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
                                                                 rechercheRequest.prix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rechercheRequest.prix = __value, rechercheRequest.prix));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Lieu de depart</label>\r\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
                                                                 rechercheRequest.lieuDepart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rechercheRequest.lieuDepart = __value, rechercheRequest.lieuDepart));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "<label>Lieu d\'arrivée</label>\r\n            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
                                                                 rechercheRequest.lieuArrivee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rechercheRequest.lieuArrivee = __value, rechercheRequest.lieuArrivee));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "<label>Date de depart</label>\r\n            ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "date");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
                                                                 rechercheRequest.dateDepart

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rechercheRequest.dateDepart = __value, rechercheRequest.dateDepart, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddMarkupContent(42, "<label>Type voiture</label>\r\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
                                                                 rechercheRequest.typeVoiture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rechercheRequest.typeVoiture = __value, rechercheRequest.typeVoiture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.AddMarkupContent(49, "<div class=\"form-group\"><button type=\"button\" class=\"btn btn-primary\">lancer la recherche</button></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.AddMarkupContent(51, "<div class=\"col\"><p class=\"bg-dark\">ff</p></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\diarr\source\repos\Covoiturage\Covoiturage\Pages\Recherche.razor"
       
    private RechercheRequest rechercheRequest = new RechercheRequest();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
