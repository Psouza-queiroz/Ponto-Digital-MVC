#pragma checksum "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4758684177613b0e86d6f31d616a3cd04a969f25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4758684177613b0e86d6f31d616a3cd04a969f25", @"/Views/Usuario/Login.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 70, true);
            WriteLiteral(" <header>\r\n        <!-- <partial name=\"_HeaderNavBar\"></partial> -->\r\n");
            EndContext();
#line 3 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Usuario\Login.cshtml"
          
            Html.RenderPartial("_HeaderNavBar", ViewData["User"]);
            Layout = "_Layout";
        

#line default
#line hidden
            BeginContext(194, 192, true);
            WriteLiteral("        <link href=\"/css/cadastro.css\"/>\r\n        <link href=\"/css/style.css\"/>\r\n        <hgroup>\r\n            <h1>PontoDigital</h1>\r\n        </hgroup>\r\n    </header>\r\n    <main>\r\n        <h2>");
            EndContext();
            BeginContext(387, 14, false);
#line 14 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Usuario\Login.cshtml"
       Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(401, 34, true);
            WriteLiteral("</h2>\r\n        <form method=\"POST\"");
            EndContext();
            BeginWriteAttribute("action", " action=\'", 435, "\'", 474, 1);
#line 15 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Usuario\Login.cshtml"
WriteAttributeValue("", 444, Url.Action("Login","Usuario"), 444, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(475, 555, true);
            WriteLiteral(@">
            <div>
                <label for=""email"">E-mail</label>
                <br />
                <input id=""email"" type=""email"" minlength=""3"" name=""email"" />
            </div>
            
            <div>
                <label for=""senha"">Senha</label>
                <br />
                <input id=""senha"" type=""password"" maxlength=""20"" minlength=""3"" name=""senha"" />
            </div>
            
            <input type=""submit"" value=""Acessar minha conta"" />

            <div id=""link-cadastro"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1030, "\'", 1069, 1);
#line 31 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Usuario\Login.cshtml"
WriteAttributeValue("", 1037, Url.Action("Index", "Cadastro"), 1037, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1070, 74, true);
            WriteLiteral(">Quero me cadastrar!</a>\r\n            </div>\r\n        </form>\r\n    </main>");
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
