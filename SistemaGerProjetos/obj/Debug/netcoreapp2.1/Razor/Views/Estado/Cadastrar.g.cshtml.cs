#pragma checksum "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292de0437492e79d1949cfbc9c0411453be4fc1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estado_Cadastrar), @"mvc.1.0.view", @"/Views/Estado/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estado/Cadastrar.cshtml", typeof(AspNetCore.Views_Estado_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292de0437492e79d1949cfbc9c0411453be4fc1b", @"/Views/Estado/Cadastrar.cshtml")]
    public class Views_Estado_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Estado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastro de Estados";

#line default
#line hidden
            BeginContext(127, 91, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 218, "\"", 235, 1);
#line 12 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
WriteAttributeValue("", 226, Model.Id, 226, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(236, 131, true);
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label for=\"nome\">Nome</label>\r\n            <input type=\"text\" name=\"nomeestado\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 367, "\"", 392, 1);
#line 15 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
WriteAttributeValue("", 375, Model.NomeEstado, 375, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(393, 84, true);
            WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o nome do estado\">\r\n            ");
            EndContext();
            BeginContext(478, 30, false);
#line 16 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(508, 147, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"sigla\">Sigla</label>\r\n            <input type=\"text\" name=\"siglaestado\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 655, "\"", 681, 1);
#line 20 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
WriteAttributeValue("", 663, Model.SiglaEstado, 663, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 86, true);
            WriteLiteral(" class=\"form-control\" id=\"sigla\" placeholder=\"Digite a sigla do estado\">\r\n            ");
            EndContext();
            BeginContext(769, 31, false);
#line 21 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
       Write(Html.ValidationMessage("sigla"));

#line default
#line hidden
            EndContext();
            BeginContext(800, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n    ");
            EndContext();
            BeginContext(907, 16, false);
#line 25 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Estado\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(923, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Estado> Html { get; private set; }
    }
}
#pragma warning restore 1591
