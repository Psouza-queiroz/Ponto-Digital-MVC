#pragma checksum "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d7f0292961f89e38d7879f75040b5a7b1ed69f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListarUsuarios), @"mvc.1.0.view", @"/Views/Admin/ListarUsuarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ListarUsuarios.cshtml", typeof(AspNetCore.Views_Admin_ListarUsuarios))]
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
#line 1 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
using Ponto_Digital_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d7f0292961f89e38d7879f75040b5a7b1ed69f5", @"/Views/Admin/ListarUsuarios.cshtml")]
    public class Views_Admin_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
  
var lista = ViewData["cadastros"] as List<CadastroModels>;
    

#line default
#line hidden
            BeginContext(105, 247, true);
            WriteLiteral("\r\n    <table>\r\n        <thead>\r\n            <th>ID</th>\r\n            <th>Nome</th>\r\n            <th>Email</th>\r\n            <th>Senha</th>\r\n            <th>Telefone</th>\r\n            <th>Data de nascimento</th>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 16 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
             foreach(var item in lista){

#line default
#line hidden
            BeginContext(394, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(433, 7, false);
#line 18 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(440, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(468, 9, false);
#line 19 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(477, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(505, 10, false);
#line 20 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(515, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(543, 10, false);
#line 21 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
               Write(item.Senha);

#line default
#line hidden
            EndContext();
            BeginContext(553, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(581, 13, false);
#line 22 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
               Write(item.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(594, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(622, 41, false);
#line 23 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
               Write(item.DatadeNascimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(663, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "f:\Projetos_Git\Pedrão\Ponto-Digital-MVC\Views\Admin\ListarUsuarios.cshtml"
            }

#line default
#line hidden
            BeginContext(704, 30, true);
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