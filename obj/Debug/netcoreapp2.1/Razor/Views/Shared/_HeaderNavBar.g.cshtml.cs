#pragma checksum "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f94d7172ac8f2d4701b3b4209ceb5c66d4ca91"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f94d7172ac8f2d4701b3b4209ceb5c66d4ca91", @"/Views/Shared/_HeaderNavBar.cshtml")]
    public class Views_Shared__HeaderNavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
  
    var user = (string) ViewData["User"];

#line default
#line hidden
            BeginContext(50, 51, true);
            WriteLiteral("<nav>\r\n    <div>\r\n         <ul>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 101, "\'", 135, 1);
#line 7 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 108, Url.Action("Index","Home"), 108, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(136, 39, true);
            WriteLiteral(">Principal</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 175, "\'", 217, 2);
#line 8 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 182, Url.Action("Index","Home"), 182, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 209, "#Produto", 209, 8, true);
            EndWriteAttribute();
            BeginContext(218, 45, true);
            WriteLiteral(">Planos e Preços</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 263, "\'", 307, 2);
#line 9 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 270, Url.Action("Index","Home"), 270, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 297, "#QuemSomos", 297, 10, true);
            EndWriteAttribute();
            BeginContext(308, 40, true);
            WriteLiteral(">Quem Somos</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 348, "\'", 386, 2);
#line 10 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 355, Url.Action("Index","Home"), 355, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 382, "#Sac", 382, 4, true);
            EndWriteAttribute();
            BeginContext(387, 16, true);
            WriteLiteral(">Sac </a></li>\r\n");
            EndContext();
#line 11 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
             if (string.IsNullOrEmpty(user))
            {

#line default
#line hidden
            BeginContext(464, 18, true);
            WriteLiteral("            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 482, "\'", 519, 1);
#line 13 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
WriteAttributeValue("", 489, Url.Action("Login","Usuario"), 489, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(520, 26, true);
            WriteLiteral(">Login/Cadastro</a></li>\r\n");
            EndContext();
#line 14 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
            }else{

#line default
#line hidden
            BeginContext(566, 100, true);
            WriteLiteral("                <li><a id=\"bt_Logout\" asp-controller=\"Usuario\" asp-action=\"Logout\">Logout</a></li>\r\n");
            EndContext();
#line 16 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Shared\_HeaderNavBar.cshtml"
            }

#line default
#line hidden
            BeginContext(681, 67, true);
            WriteLiteral("             \r\n\r\n            \r\n         </ul>\r\n    </div>\r\n</nav>\r\n");
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
