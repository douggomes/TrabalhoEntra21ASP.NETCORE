#pragma checksum "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d599d262fa9670fc1a6b20ec2dcd48943203648"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastro), @"mvc.1.0.view", @"/Views/Usuario/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastro.cshtml", typeof(AspNetCore.Views_Usuario_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d599d262fa9670fc1a6b20ec2dcd48943203648", @"/Views/Usuario/Cadastro.cshtml")]
    public class Views_Usuario_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
  
    ViewBag.Title = "Cadastrar-se";

#line default
#line hidden
            BeginContext(121, 267, true);
            WriteLiteral(@"
<div class=""container"">
    <form method=""post"">
        <div class=""form-group"">
            <label for=""nome"">Nome</label>
            <input type=""text"" name=""nomeusuario"" value="""" class=""form-control"" id=""nome"" placeholder=""Digite o seu nome"">
            ");
            EndContext();
            BeginContext(389, 30, false);
#line 15 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
       Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(419, 252, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"login\">Nome de usuário</label>\r\n            <input type=\"text\" name=\"login\" value=\"\" class=\"form-control\" id=\"login\" placeholder=\"Digite o seu nome de usuário\">\r\n            ");
            EndContext();
            BeginContext(672, 31, false);
#line 21 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
       Write(Html.ValidationMessage("login"));

#line default
#line hidden
            EndContext();
            BeginContext(703, 236, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label for=\"senha\">Senha</label>\r\n            <input type=\"password\" name=\"senha\" value=\"\" class=\"form-control\" id=\"senha\" placeholder=\"Digite a sua senha\">\r\n            ");
            EndContext();
            BeginContext(940, 31, false);
#line 27 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
       Write(Html.ValidationMessage("senha"));

#line default
#line hidden
            EndContext();
            BeginContext(971, 106, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n\r\n");
            EndContext();
#line 33 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
     if (ViewBag.MensagemErro != null)
    {
        

#line default
#line hidden
            BeginContext(1133, 20, false);
#line 35 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
   Write(ViewBag.MensagemErro);

#line default
#line hidden
            EndContext();
#line 35 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Usuario\Cadastro.cshtml"
                             
    }

#line default
#line hidden
            BeginContext(1162, 8, true);
            WriteLiteral("\r\n</div>");
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
