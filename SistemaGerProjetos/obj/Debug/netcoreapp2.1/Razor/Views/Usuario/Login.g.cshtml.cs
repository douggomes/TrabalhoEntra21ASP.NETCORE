#pragma checksum "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "013d87b285cc7c39c4b94e118614dafc780e5756"
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
#line 1 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"013d87b285cc7c39c4b94e118614dafc780e5756", @"/Views/Usuario/Login.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
  
    ViewBag.Title = "Login";

#line default
#line hidden
            BeginContext(151, 265, true);
            WriteLiteral(@"
<div class=""container"">
    <form method=""post"">
        <div class=""form-group"">
            <label for=""login"">Login</label>
            <input type=""text"" name=""login"" value="""" class=""form-control"" id=""login"" placeholder=""Digite o seu login"">
            ");
            EndContext();
            BeginContext(417, 31, false);
#line 17 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
       Write(Html.ValidationMessage("login"));

#line default
#line hidden
            EndContext();
            BeginContext(448, 236, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"senha\">Senha</label>\r\n            <input type=\"password\" name=\"senha\" value=\"\" class=\"form-control\" id=\"senha\" placeholder=\"Digite a sua senha\">\r\n            ");
            EndContext();
            BeginContext(685, 31, false);
#line 23 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
       Write(Html.ValidationMessage("senha"));

#line default
#line hidden
            EndContext();
            BeginContext(716, 104, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Entrar</button>\r\n    </form>\r\n\r\n");
            EndContext();
#line 28 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
     if (ViewBag.MensagemErro != null)
    {
        

#line default
#line hidden
            BeginContext(876, 20, false);
#line 30 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
   Write(ViewBag.MensagemErro);

#line default
#line hidden
            EndContext();
#line 30 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Login.cshtml"
                             
    }

#line default
#line hidden
            BeginContext(905, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
