#pragma checksum "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\ErrorView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13aee9c6cae1c58bb71cd8e3bc9e543cc416cdc2"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaBancario.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using SistemaBancario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using SistemaBancario.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Error/{mensaje}")]
    public partial class ErrorView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Error</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger");
#nullable restore
#line 4 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\ErrorView.razor"
__builder.AddContent(3, mensaje);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\ErrorView.razor"
       

    [Parameter]
    public string mensaje { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
