#pragma checksum "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab625d5bc0de491e0dfa4660a7f2c15099911d3c"
// <auto-generated/>
#pragma warning disable 1591
namespace TestApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using TestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rickd\source\repos\TestApp\TestApp\_Imports.razor"
using TestApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
using TestApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/collegas")]
    public partial class Collegas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Collegas</h3>\r\nAls het goed is kom je op deze pagina\r\n\r\n");
            __builder.OpenElement(1, "body");
            __builder.AddAttribute(2, "onbeforeunload", "TestDataTablesRemove(\'#example\')");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 10 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
     if (collegas == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddAttribute(9, "id", "example");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<thead>\r\n                <tr>\r\n                    <th>Naam</th>\r\n                    <th>Email</th>\r\n                    <th>Telefoon</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 25 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
                 foreach (var collega in collegas)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
                             collega.Naam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
                             collega.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 30 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
                             collega.TelefoonNummer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 32 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 35 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"


    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\rickd\source\repos\TestApp\TestApp\Pages\Collegas.razor"
       
    private Collega[] collegas;

    protected override async Task OnInitializedAsync()
    {
        collegas = await collegaService.GetCollega();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CollegaServices collegaService { get; set; }
    }
}
#pragma warning restore 1591
