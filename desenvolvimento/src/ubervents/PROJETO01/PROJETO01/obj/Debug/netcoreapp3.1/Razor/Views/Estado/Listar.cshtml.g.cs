#pragma checksum "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "558805b09e895d58f6ec76ad71f059c722b362b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estado_Listar), @"mvc.1.0.view", @"/Views/Estado/Listar.cshtml")]
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
#line 1 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\_ViewImports.cshtml"
using PROJETO01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"558805b09e895d58f6ec76ad71f059c722b362b3", @"/Views/Estado/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a24eea2b15d20d16798ed9e4b0c9c93903b076", @"/Views/_ViewImports.cshtml")]
    public class Views_Estado_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PROJETO01.Modelos.Estado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3>
    CADASTRO DE ESTADOS 
    <a class=""btn btn-sm btn-primary float-right"" href=""/Estado/Adicionar"">
        + ADICIONAR
    </a>
</h3>

<table class=""table table-hover "">
    <thead>
        <tr>
            <th>UF</th>
            <th>Nome</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml"
               Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 558, "\"", 591, 2);
            WriteAttributeValue("", 565, "/Estado/Editar?uf=", 565, 18, true);
#nullable restore
#line 25 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml"
WriteAttributeValue("", 583, item.UF, 583, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-warning\">\r\n                        Editar\r\n                    </a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 706, "\"", 740, 2);
            WriteAttributeValue("", 713, "/Estado/Excluir?uf=", 713, 19, true);
#nullable restore
#line 28 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml"
WriteAttributeValue("", 732, item.UF, 732, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                        Excluir\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\lojs\Downloads\PROJETO01_61-637738205477483209\PROJETO01\PROJETO01\Views\Estado\Listar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PROJETO01.Modelos.Estado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
