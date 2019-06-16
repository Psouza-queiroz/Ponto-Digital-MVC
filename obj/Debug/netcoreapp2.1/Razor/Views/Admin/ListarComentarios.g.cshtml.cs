#pragma checksum "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fec0841c0a1c371ec8547de1febd75c6b78939a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListarComentarios), @"mvc.1.0.view", @"/Views/Admin/ListarComentarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ListarComentarios.cshtml", typeof(AspNetCore.Views_Admin_ListarComentarios))]
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
#line 1 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
using Ponto_Digital_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fec0841c0a1c371ec8547de1febd75c6b78939a", @"/Views/Admin/ListarComentarios.cshtml")]
    public class Views_Admin_ListarComentarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
  
var lista = ViewData["comentarios"] as List<Comentarios>;
    

#line default
#line hidden
            BeginContext(104, 222, true);
            WriteLiteral("\r\n    <table>\r\n        <thead>\r\n            <th>ID</th>\r\n            <th>Nome</th>\r\n            <th>Comentario</th>\r\n            <th>Data do comentário</th>\r\n            <th>Estado</th>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 15 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
             foreach(var item in lista){

#line default
#line hidden
            BeginContext(368, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(407, 7, false);
#line 17 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(414, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(442, 9, false);
#line 18 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(451, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(479, 15, false);
#line 19 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
               Write(item.Comentario);

#line default
#line hidden
            EndContext();
            BeginContext(494, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(522, 39, false);
#line 20 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
               Write(item.DataComentario.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(561, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(589, 11, false);
#line 21 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
               Write(item.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(600, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 629, "\'", 688, 3);
#line 22 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
WriteAttributeValue("", 636, Url.Action("AprovarComentario","Admin"), 636, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 676, "?id=", 676, 4, true);
#line 22 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
WriteAttributeValue("", 680, item.Id, 680, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(689, 41, true);
            WriteLiteral(">Aprovar</a></td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 730, "\'", 790, 3);
#line 23 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
WriteAttributeValue("", 737, Url.Action("ReprovarComentario","Admin"), 737, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 778, "?id=", 778, 4, true);
#line 23 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
WriteAttributeValue("", 782, item.Id, 782, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 41, true);
            WriteLiteral(">Reprovar</a></td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 26 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarComentarios.cshtml"
            }

#line default
#line hidden
            BeginContext(847, 30, true);
            WriteLiteral("        </tbody>\r\n    </table>");
            EndContext();
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