#pragma checksum "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f5b7d2e5be72b6b65783eebcbf2b95790dc5fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Frontend.Pages.Pacientes.Pages_Pacientes_Index), @"mvc.1.0.razor-page", @"/Pages/Pacientes/Index.cshtml")]
namespace HospiEnCasa.App.Frontend.Pages.Pacientes
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
#line 1 "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f5b7d2e5be72b6b65783eebcbf2b95790dc5fff", @"/Pages/Pacientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29c1093da579e7f24923c861712d3287de7427a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listado de pacientes</h1>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Apellidos</th>
            <th scope=""col"">Telefono</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 15 "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Index.cshtml"
         foreach (var paciente in Model.pacientes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 18 "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Index.cshtml"
               Write(paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Index.cshtml"
               Write(paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Index.cshtml"
               Write(paciente.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Usuario\OneDrive\Documentos\Misión Tic 2022\1-Code\ciclo-3\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.Frontend\Pages\Pacientes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.Frontend.Pages.Pacientes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.Pacientes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Frontend.Pages.Pacientes.IndexModel>)PageContext?.ViewData;
        public HospiEnCasa.App.Frontend.Pages.Pacientes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591