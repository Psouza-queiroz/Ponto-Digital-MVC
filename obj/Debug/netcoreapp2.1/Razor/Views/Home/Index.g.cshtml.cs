#pragma checksum "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca3656addda0f43dab6f873aa07698e2059fd10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca3656addda0f43dab6f873aa07698e2059fd10", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\38128442813\Documents\2019\ProjetoFinal.MVC\Ponto-Digital-MVC\Ponto-Digital-MVC\Views\Home\Index.cshtml"
      
        Html.RenderPartial("_HeaderNavBar");
        Layout = "_Layout";
    

#line default
#line hidden
            BeginContext(94, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(98, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd9dcb0fcb81485ab4820f43ff67496d", async() => {
                BeginContext(104, 130, true);
                WriteLiteral("\r\n        <meta charset=\"UTF-8\">\r\n        <link rel=\"stylesheet\" href=\"/css/style.css\">\r\n        <title>Poto Digital</title>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 2894, true);
            WriteLiteral(@"

    <header>
        <div id=""logo_area"">
            <!--DivLogo-->
            <img src=""imagens/logo.png"" height=""200px"" width=""200px"" alt=""logo ponto digital"">
        </div>

        <!-- <div class=""redes-sociais"">
            <h2>Redes sociais</h2>
            <img src=""imagens/facebook.png"" height=""60px"" width=""60px"" alt=""Logo facebook""> <br>
            <img src=""imagens/twitter.png"" height=""60px"" width=""60px"" alt=""Logo twitter"">
        </div> -->

        <div class=""produto"">
            <h2>Planos e Preços</h2>

            <h3>Plano de Teste</h3>
            <p>R$ 00.00</p>
            <p>Um mês grátis, e um usuário do plano</p>
            <h3>Plano 1</h3>
            <p>Um mês grátis, e 10 usuários do plano</p>
            <p>R$ 29.90</p>
            <h3>Plano 2</h3>
            <p>Um mês grátis, e um 20 do usuários plano</p>
            <p>R$ 149,90</p>
            <h3>Plano 3</h3>
            <p>Um mês grátis, e um 50 usuários do plano</p>
            <p>R$ 299,");
            WriteLiteral(@"90</p>
            <h3>plano 4</h3>
            <p>Um mês grátis, e um 100 usuários do plano</p>
            <p>R$ A definir</p>
        </div>

        
        <section id=""QuemSomos"">
            <div>
                <h2>Quemsomos</h2>
                <p>Lorem ipsum dolor sit amet consectetur.</p>
            </div>
        </section>
        <section id=""sac"">
            <h2>Sac</h2>
            <div>
                <label for=""nome"">Nome Completo</label>
                <input id=""nome"" type=""text"" maxlength=""50"" minlength=""3"" name=""nome"" />
                <br>
                <label for=""Email"">Email</label>
                <input id=""email"" type=""text"" name=""email"">
                <br>
                <label for=""digite"">Escreva sua Duvida/Reclamação</label>
                <input  id=""digite"" type=""text"" maxlength=""140"" minlength=""2"" name=""digite"">
                <input type=""submit"" value=""Enviar"">
            </div>
        </section>
    </header>
    <!--fim da ho");
            WriteLiteral(@"me-->
<section id=""local"">
            <!-- TODO:Colocar o mapa do Google! -->
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3657.8869961505543!2d-46.648477085071065!3d-23.53656648469522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce5843deade6e3%3A0x124f377d06c7e71f!2sAlameda+Bar%C3%A3o+de+Limeira%2C+539+-+Campos+El%C3%ADseos%2C+S%C3%A3o+Paulo+-+SP%2C+01202-001!5e0!3m2!1sen!2sbr!4v1550223658410""
                width=""1902"" height=""350"" frameborder=""0"" style=""border:0"" allowfullscreen></iframe>
        </section>
    <footer id=""Rodape"">
        <address>
            Avenida Barão de Limeira, 539 - Campos Elíseos - SP
            <br />
            PontoDigital@Gmail.com
            <br />
            11 1234 6789
        </address>
        </section>
    </footer>


</html>");
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
