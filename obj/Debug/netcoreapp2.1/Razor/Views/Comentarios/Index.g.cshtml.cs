#pragma checksum "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Comentarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c93d0ccf35e698bcd34b6234ffc91cb3029d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentarios_Index), @"mvc.1.0.view", @"/Views/Comentarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentarios/Index.cshtml", typeof(AspNetCore.Views_Comentarios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c93d0ccf35e698bcd34b6234ffc91cb3029d16", @"/Views/Comentarios/Index.cshtml")]
    public class Views_Comentarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Views\Comentarios\Index.cshtml"
  
    Html.RenderPartial("_HeaderNavBar");
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(74, 566, true);
            WriteLiteral(@"<h2>Bem Vindo, Fale para nos, o que achou do site</h2>
<main>
    <form method=""POST"" action=""Comentarios/Comentarios"">
        <div>
            <label for=""nome""> Digite seu Nome</label>
            <input id=""nome"" type=""text"" name=""nome"" required >

            <label for=""comentario"">Fale para nós, o que voce achou do site? E o que poderia melhorar</label>
            <input  id=""comentario"" type=""text"" maxlength=""140"" minlength=""1"" name=""comentario"" required>

           <input type=""submit"" value=""Enviar"">
        </div>
    </form>
</main>");
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