#pragma checksum "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b43b2baa426b6eb0cc8cc44b53e4c5776d0e894"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Cadastrar), @"mvc.1.0.view", @"/Views/Clientes/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Cadastrar.cshtml", typeof(AspNetCore.Views_Clientes_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b43b2baa426b6eb0cc8cc44b53e4c5776d0e894", @"/Views/Clientes/Cadastrar.cshtml")]
    public class Views_Clientes_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastro de Clientes";

#line default
#line hidden
            BeginContext(129, 91, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 220, "\"", 237, 1);
#line 12 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 228, Model.Id, 228, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(238, 125, true);
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label for=\"nome\">Nome</label>\r\n            <input type=\"text\" name=\"nome\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 363, "\"", 382, 1);
#line 15 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 371, Model.Nome, 371, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(383, 85, true);
            WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o nome do cliente\">\r\n            ");
            EndContext();
            BeginContext(469, 30, false);
#line 16 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(499, 135, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"cpf\">CPF</label>\r\n            <input type=\"text\" name=\"cpf\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 634, "\"", 652, 1);
#line 20 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 642, Model.Cpf, 642, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(653, 72, true);
            WriteLiteral(" class=\"form-control\" id=\"cpf\" placeholder=\"Digite o CPF\">\r\n            ");
            EndContext();
            BeginContext(726, 29, false);
#line 21 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("cpf"));

#line default
#line hidden
            EndContext();
            BeginContext(755, 172, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"dataNascimento\">Data de Nascimento</label>\r\n            <input type=\"text\" name=\"dataNascimento\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 927, "\"", 956, 1);
#line 25 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 935, Model.DataNascimento, 935, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(957, 41, true);
            WriteLiteral(" class=\"form-control\" id=\"dataNascimento\"");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 998, "\"", 1068, 5);
#line 25 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 1012, DateTime.Now.Day, 1012, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1029, "/", 1029, 1, true);
#line 25 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 1030, DateTime.Now.Month, 1030, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1049, "/", 1049, 1, true);
#line 25 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 1050, DateTime.Now.Year, 1050, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1069, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1085, 40, false);
#line 26 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("dataNascimento"));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 144, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"numero\">Número</label>\r\n            <input type=\"text\" name=\"numero\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1269, "\"", 1290, 1);
#line 30 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 1277, Model.Numero, 1277, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1291, 78, true);
            WriteLiteral(" class=\"form-control\" id=\"numero\" placeholder=\"Digite o número\">\r\n            ");
            EndContext();
            BeginContext(1370, 32, false);
#line 31 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("numero"));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 159, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"complemento\">Complemento</label>\r\n            <input type=\"text\" name=\"complemento\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1561, "\"", 1587, 1);
#line 35 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 1569, Model.Complemento, 1569, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1588, 89, true);
            WriteLiteral(" class=\"form-control\" id=\"complemento\" placeholder=\"Informe o complemento\">\r\n            ");
            EndContext();
            BeginContext(1678, 37, false);
#line 36 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("complemento"));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 156, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"logradouro\">Logradouro</label>\r\n            <input type=\"text\" name=\"logradouro\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1871, "\"", 1896, 1);
#line 40 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 1879, Model.Logradouro, 1879, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1897, 87, true);
            WriteLiteral(" class=\"form-control\" id=\"logradouro\" placeholder=\"Informe o logradouro\">\r\n            ");
            EndContext();
            BeginContext(1985, 36, false);
#line 41 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("logradouro"));

#line default
#line hidden
            EndContext();
            BeginContext(2021, 135, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"cep\">CEP</label>\r\n            <input type=\"text\" name=\"cep\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2156, "\"", 2174, 1);
#line 45 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
WriteAttributeValue("", 2164, Model.Cep, 2164, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2175, 72, true);
            WriteLiteral(" class=\"form-control\" id=\"cep\" placeholder=\"Digite o CEP\">\r\n            ");
            EndContext();
            BeginContext(2248, 29, false);
#line 46 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
       Write(Html.ValidationMessage("cep"));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n    ");
            EndContext();
            BeginContext(2384, 16, false);
#line 50 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(2400, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
