#pragma checksum "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c3f9d70eb21de3502ae5524ce8a854a5b38d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Cadastrar), @"mvc.1.0.view", @"/Views/Categoria/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoria/Cadastrar.cshtml", typeof(AspNetCore.Views_Categoria_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c3f9d70eb21de3502ae5524ce8a854a5b38d3b", @"/Views/Categoria/Cadastrar.cshtml")]
    public class Views_Categoria_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Categoria>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastro de Categorias";

#line default
#line hidden
            BeginContext(133, 91, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 224, "\"", 241, 1);
#line 12 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml"
WriteAttributeValue("", 232, Model.Id, 232, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(242, 156, true);
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label for=\"nomecategoria\">Nome da Categoria</label>\r\n            <input type=\"text\" name=\"nomecategoria\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 398, "\"", 426, 1);
#line 15 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml"
WriteAttributeValue("", 406, Model.NomeCategoria, 406, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(427, 96, true);
            WriteLiteral(" class=\"form-control\" id=\"nomecategoria\" placeholder=\"Digite o nome da categoria\">\r\n            ");
            EndContext();
            BeginContext(524, 39, false);
#line 16 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nomecategoria"));

#line default
#line hidden
            EndContext();
            BeginContext(563, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n    ");
            EndContext();
            BeginContext(670, 16, false);
#line 20 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(686, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
