#pragma checksum "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf38207da1a1b701e51b9debedc10ece283c811e"
// <auto-generated/>
#pragma warning disable 1591
namespace SistemaBancario.Pages.Login
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pin/{Id:int}")]
    public partial class Pin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid mt-5");
            __builder.AddMarkupContent(2, "<div class=\"row\" style=\"height:100px;\"></div>\r\n\t");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-4\"></div>\r\n\t\t ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card col-4");
            __builder.AddMarkupContent(8, "<div class=\"card-header text-center\"><h3>Ingrese Pin</h3></div>\r\n\t\t");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor"
                             numerotrjeta

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "credit-card-div");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row justify-content-center ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "m-4");
                __builder2.OpenElement(19, "textarea");
                __builder2.AddAttribute(20, "id", "textarea");
                __builder2.AddAttribute(21, "readonly");
                __builder2.AddAttribute(22, "style", "resize:none;");
#nullable restore
#line 15 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor"
__builder2.AddContent(23, numerotrjeta);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\t\t\t\t\t\t");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row justify-content-center");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-12");
                __builder2.OpenComponent<SistemaBancario.Pages.Pad.PadNumerico>(29);
                __builder2.AddAttribute(30, "numerotarjeta", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 20 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor"
                                                                                            obtener

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\t\t\t\t\t   ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "row justify-content-center m-3");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "mr-2");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "class", "btn btn-success");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor"
                                                                              Ingresar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(39, " Ingresar ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(41, "div");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "class", "btn btn-danger");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor"
                                                                              cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(45, " Limpiar ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\t\t\t\t\t\t\t");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "ml-2");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "class", "btn btn-danger");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\nestigarribia\Desktop\Cajero\SistemaBancario\Pages\Login\Pin.razor"
                                                                              Salir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(52, " Salir ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\t\t<div class=\"col-4\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
