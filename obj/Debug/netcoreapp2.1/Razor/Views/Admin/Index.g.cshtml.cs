#pragma checksum "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "280851013a29e8917377d2c1d6229409157e664a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"280851013a29e8917377d2c1d6229409157e664a", @"/Views/Admin/Index.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Admin\Index.cshtml"
  
    Html.RenderPartial("_HeaderNavBar");
     Layout = "_Layout";

#line default
#line hidden
            BeginContext(75, 4, true);
            WriteLiteral("\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 79, "\'", 123, 1);
#line 6 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Admin\Index.cshtml"
WriteAttributeValue("", 86, Url.Action("ListarUsuarios","Admin"), 86, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(124, 24, true);
            WriteLiteral(">Listar Usuarios</a>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 148, "\'", 195, 1);
#line 7 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Admin\Index.cshtml"
WriteAttributeValue("", 155, Url.Action("ListarComentarios","Admin"), 155, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(196, 23, true);
            WriteLiteral(">Listar Comentários</a>");
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
