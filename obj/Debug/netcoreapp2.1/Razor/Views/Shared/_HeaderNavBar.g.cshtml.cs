#pragma checksum "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8bfddbab45677ebbd40b8e89836d29c97167a79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderNavBar), @"mvc.1.0.view", @"/Views/Shared/_HeaderNavBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeaderNavBar.cshtml", typeof(AspNetCore.Views_Shared__HeaderNavBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8bfddbab45677ebbd40b8e89836d29c97167a79", @"/Views/Shared/_HeaderNavBar.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
  
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(84, 100, true);
            WriteLiteral("<link href=\"/css/style.css\"> \r\n\r\n<nav class=\"NavBar\">\r\n    <div >\r\n         <ul>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 184, "\'", 218, 1);
#line 13 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 191, Url.Action("Index","Home"), 191, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(219, 39, true);
            WriteLiteral(">Principal</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 258, "\'", 300, 2);
#line 14 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 265, Url.Action("Index","Home"), 265, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 292, "#Produto", 292, 8, true);
            EndWriteAttribute();
            BeginContext(301, 45, true);
            WriteLiteral(">Planos e Preços</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 346, "\'", 390, 2);
#line 15 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 353, Url.Action("Index","Home"), 353, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 380, "#QuemSomos", 380, 10, true);
            EndWriteAttribute();
            BeginContext(391, 40, true);
            WriteLiteral(">Quem Somos</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 431, "\'", 469, 2);
#line 16 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 438, Url.Action("Index","Home"), 438, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 465, "#Sac", 465, 4, true);
            EndWriteAttribute();
            BeginContext(470, 16, true);
            WriteLiteral(">Sac </a></li>\r\n");
            EndContext();
#line 17 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
             if (string.IsNullOrEmpty(user))
            {

#line default
#line hidden
            BeginContext(547, 18, true);
            WriteLiteral("            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 565, "\'", 602, 1);
#line 19 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 572, Url.Action("Login","Usuario"), 572, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(603, 26, true);
            WriteLiteral(">Login/Cadastro</a></li>\r\n");
            EndContext();
#line 20 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
            }else{

#line default
#line hidden
            BeginContext(649, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 671, "\'", 709, 1);
#line 21 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 678, Url.Action("Logout","Usuario"), 678, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(710, 18, true);
            WriteLiteral(">Logout</a></li>\r\n");
            EndContext();
            BeginContext(746, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 768, "\'", 809, 1);
#line 23 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 775, Url.Action("Index","Comentarios"), 775, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(810, 23, true);
            WriteLiteral(">Comentarios</a></li>\r\n");
            EndContext();
#line 24 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
            }       

#line default
#line hidden
            BeginContext(855, 36, true);
            WriteLiteral("         </ul>\r\n    </div>\r\n</nav>\r\n");
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
