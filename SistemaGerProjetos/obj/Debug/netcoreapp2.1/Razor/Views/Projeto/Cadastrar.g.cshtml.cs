#pragma checksum "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e246f45f0274a0f5bc355ca6a31c277cbcd7431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projeto_Cadastrar), @"mvc.1.0.view", @"/Views/Projeto/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projeto/Cadastrar.cshtml", typeof(AspNetCore.Views_Projeto_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e246f45f0274a0f5bc355ca6a31c277cbcd7431", @"/Views/Projeto/Cadastrar.cshtml")]
    public class Views_Projeto_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Projeto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastro de Projetos";

#line default
#line hidden
            BeginContext(129, 91, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 220, "\"", 237, 1);
#line 12 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
WriteAttributeValue("", 228, Model.Id, 228, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(238, 139, true);
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label for=\"nomeprojeto\">Nome</label>\r\n            <input type=\"text\" name=\"nomeprojeto\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 377, "\"", 403, 1);
#line 15 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
WriteAttributeValue("", 385, Model.NomeProjeto, 385, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(404, 92, true);
            WriteLiteral(" class=\"form-control\" id=\"nomeprojeto\" placeholder=\"Digite o nome do projeto\">\r\n            ");
            EndContext();
            BeginContext(497, 37, false);
#line 16 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nomeprojeto"));

#line default
#line hidden
            EndContext();
            BeginContext(534, 285, true);
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <label for=""nomeclienteprojeto"">Nome do Cliente</label>
            <select name=""nomeclienteprojeto"" class=""form-control"">
                <option disabled=""disabled"" selected=""selected"">Selecione um cliente</option>
");
            EndContext();
#line 22 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                 if (ViewBag.AtualizarClienteProjeto != null)
                {
                    

#line default
#line hidden
#line 24 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                     foreach (var atualizar in ViewBag.AtualizarClienteProjeto)
                    {

#line default
#line hidden
            BeginContext(1005, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1036, "\"", 1054, 1);
#line 26 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
WriteAttributeValue("", 1044, atualizar, 1044, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1055, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(1066, 9, false);
#line 26 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                                                       Write(atualizar);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 27 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                    }

#line default
#line hidden
#line 27 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1128, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                 foreach (var cliente in ViewBag.Cliente)
                {

#line default
#line hidden
            BeginContext(1208, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1235, "\"", 1256, 1);
#line 32 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
WriteAttributeValue("", 1243, cliente.Nome, 1243, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1257, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1259, 12, false);
#line 32 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                                             Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 33 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
                }

#line default
#line hidden
            BeginContext(1301, 197, true);
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"datacriacao\">Data de Criação do Projeto</label>\r\n            <input type=\"date\" name=\"datacriacao\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1498, "\"", 1524, 1);
#line 39 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
WriteAttributeValue("", 1506, Model.DataCriacao, 1506, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1525, 53, true);
            WriteLiteral(" class=\"form-control\" id=\"datacriacao\">\r\n            ");
            EndContext();
            BeginContext(1579, 37, false);
#line 40 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
       Write(Html.ValidationMessage("datacriacao"));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 186, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"datafinalizacao\">Data de Finalização do Projeto</label>\r\n            <input type=\"date\" name=\"datafinalizacao\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1802, "\"", 1832, 1);
#line 44 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
WriteAttributeValue("", 1810, Model.DataFinalizacao, 1810, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1833, 57, true);
            WriteLiteral(" class=\"form-control\" id=\"datafinalizacao\">\r\n            ");
            EndContext();
            BeginContext(1891, 41, false);
#line 45 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
       Write(Html.ValidationMessage("datafinalizacao"));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n    ");
            EndContext();
            BeginContext(2039, 16, false);
#line 49 "C:\Users\User\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Projeto\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(2055, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Projeto> Html { get; private set; }
    }
}
#pragma warning restore 1591
