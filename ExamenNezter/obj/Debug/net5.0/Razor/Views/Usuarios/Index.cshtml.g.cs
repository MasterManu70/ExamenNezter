#pragma checksum "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3959fc4f3a3fdb24bf730e6175145a9be21c07b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\_ViewImports.cshtml"
using ExamenNezter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\_ViewImports.cshtml"
using ExamenNezter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3959fc4f3a3fdb24bf730e6175145a9be21c07b", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4904a428ffceacb19ff30f9951d66a2f70e8c2ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExamenNezter.Models.UsuariosModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Guardar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";

    ExamenNezter.Datos.CiudadesData dataCiudades = new ExamenNezter.Datos.CiudadesData();
    IEnumerable<CiudadesModel> modeloCiudades;

    modeloCiudades = dataCiudades.Consultar();

    ExamenNezter.Datos.TipoUsuarioData dataTipoUsuario = new ExamenNezter.Datos.TipoUsuarioData();
    IEnumerable<TipoUsuarioModel> modeloTipoUsuario;

    modeloTipoUsuario = dataTipoUsuario.Consultar();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Usuarios</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3959fc4f3a3fdb24bf730e6175145a9be21c07b4083", async() => {
                WriteLiteral("Nuevo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Usuario</th>
            <th>Nombre</th>
            <th>Dirección</th>
            <th>Teléfono</th>
            <th>CP</th>
            <th>Ciudad</th>
            <th>Tipo</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 58 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
                 foreach (var ciudad in modeloCiudades)
                {
                    if (ciudad.Id == item.Id_ciudad)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
                   Write(ciudad.Ciudad);

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
                                      
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 67 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
                 foreach (var tipousuario in modeloTipoUsuario)
                {
                    if (tipousuario.Id == item.Id_ciudad)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
                   Write(tipousuario.Tipo_usuario);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
                                                 
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Editar", "Guardar", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 77 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Eliminar", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "D:\Projects\C#\ASP.NET\ExamenNezter\ExamenNezter\Views\Usuarios\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExamenNezter.Models.UsuariosModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591