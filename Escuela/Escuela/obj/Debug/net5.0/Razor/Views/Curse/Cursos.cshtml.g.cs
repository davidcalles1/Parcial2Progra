#pragma checksum "C:\Users\nelso\OneDrive\Documentos\GitHub\Parcial2Progra\Escuela\Escuela\Views\Curse\Cursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d1fe454d7d31fee96aa8b266713dc1605d2bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curse_Cursos), @"mvc.1.0.view", @"/Views/Curse/Cursos.cshtml")]
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
#line 1 "C:\Users\nelso\OneDrive\Documentos\GitHub\Parcial2Progra\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nelso\OneDrive\Documentos\GitHub\Parcial2Progra\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d1fe454d7d31fee96aa8b266713dc1605d2bb7", @"/Views/Curse/Cursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Curse_Cursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nelso\OneDrive\Documentos\GitHub\Parcial2Progra\Escuela\Escuela\Views\Curse\Cursos.cshtml"
  
    ViewData["Title"] = "VerCursos";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Cursos</h1>
<table id=""mitabla"" class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th>
                Course ID
            </th>
            <th>
                Title
            </th>
            <th>
                Credits
            </th>
        </tr>
    </thead>
</table>

");
#nullable restore
#line 24 "C:\Users\nelso\OneDrive\Documentos\GitHub\Parcial2Progra\Escuela\Escuela\Views\Curse\Cursos.cshtml"
Write(Html.ActionLink("Ir a vistas", "Vistas", "Home", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\nelso\OneDrive\Documentos\GitHub\Parcial2Progra\Escuela\Escuela\Views\Curse\Cursos.cshtml"
Write(Html.ActionLink("Registrar cursos nuevos", "Registrar", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js""></script>
    <script>
        $(document).ready(function () {

            var tabla = $('#mitabla').DataTable({
                ""ajax"": {
                    ""url"": '/Home/GetAll',
                    ""type"": ""get"",
                    ""datatype"": ""json""
                },
                ""columns"": [
                    { ""data"": ""couserId"", ""name"": ""couserId"", ""autoWidth"": true },
                    { ""data"": ""title"", ""name"": ""title"", ""autoWidth"": true },
                    { ""data"": ""credits"", ""name"": ""credits"", ""autoWidth"": true }
                ]
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
