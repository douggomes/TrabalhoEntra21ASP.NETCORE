#pragma checksum "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87da114669ddbc008bbaf3624fb93bdc2bea7f17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Cadastrar), @"mvc.1.0.view", @"/Views/Tarefa/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Cadastrar.cshtml", typeof(AspNetCore.Views_Tarefa_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87da114669ddbc008bbaf3624fb93bdc2bea7f17", @"/Views/Tarefa/Cadastrar.cshtml")]
    public class Views_Tarefa_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Tarefa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastro de Tarefas";

#line default
#line hidden
            BeginContext(127, 91, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 218, "\"", 235, 1);
#line 12 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 226, Model.Id, 226, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(236, 153, true);
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label for=\"titulotarefa\">Título da tarefa</label>\r\n            <input type=\"text\" name=\"titulotarefa\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 389, "\"", 416, 1);
#line 15 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 397, Model.TituloTarefa, 397, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(417, 94, true);
            WriteLiteral(" class=\"form-control\" id=\"titulotarefa\" placeholder=\"Digite o título da tarefa\">\r\n            ");
            EndContext();
            BeginContext(512, 38, false);
#line 16 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
       Write(Html.ValidationMessage("titulotarefa"));

#line default
#line hidden
            EndContext();
            BeginContext(550, 286, true);
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <label for=""nomecategoriatarefa"">Categoria</label>
            <select name=""nomecategoriatarefa"" class=""form-control"">
                <option disabled=""disabled"" selected=""selected"">Selecione uma categoria</option>

");
            EndContext();
#line 23 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                 if (ViewBag.NomeEstadoDB != null)
                {

                    

#line default
#line hidden
#line 26 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                     foreach (var NomeCategoria in ViewBag.NomeCategoriaDB)
                    {

#line default
#line hidden
            BeginContext(1009, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1040, "\"", 1062, 1);
#line 28 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 1048, NomeCategoria, 1048, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1063, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(1074, 13, false);
#line 28 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                                                           Write(NomeCategoria);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 29 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                    }

#line default
#line hidden
#line 29 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                     

                }

#line default
#line hidden
            BeginContext(1142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                 foreach (var categoria in ViewBag.Categoria)
                {

#line default
#line hidden
            BeginContext(1226, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1253, "\"", 1285, 1);
#line 35 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 1261, categoria.NomeCategoria, 1261, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1286, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1288, 23, false);
#line 35 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                                                        Write(categoria.NomeCategoria);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 36 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                }

#line default
#line hidden
            BeginContext(1341, 37, true);
            WriteLiteral("\r\n            </select>\r\n            ");
            EndContext();
            BeginContext(1379, 45, false);
#line 39 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nomecategoriatarefa"));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 277, true);
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <label for=""nomeprojetotarefa"">Projeto</label>
            <select name=""nomeprojetotarefa"" class=""form-control"">
                <option disabled=""disabled"" selected=""selected"">Selecione um projeto</option>

");
            EndContext();
#line 46 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                 if (ViewBag.NomeProjetoDB != null)
                {

                    

#line default
#line hidden
#line 49 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                     foreach (var NomeProjeto in ViewBag.NomeProjetoDB)
                    {

#line default
#line hidden
            BeginContext(1871, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1902, "\"", 1922, 1);
#line 51 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 1910, NomeProjeto, 1910, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1923, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(1934, 11, false);
#line 51 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                                                         Write(NomeProjeto);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 52 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                    }

#line default
#line hidden
#line 52 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                     

                }

#line default
#line hidden
            BeginContext(2000, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                 foreach (var projeto in ViewBag.Projeto)
                {

#line default
#line hidden
            BeginContext(2080, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2107, "\"", 2135, 1);
#line 58 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 2115, projeto.NomeProjeto, 2115, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2136, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2138, 19, false);
#line 58 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                                                    Write(projeto.NomeProjeto);

#line default
#line hidden
            EndContext();
            BeginContext(2157, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 59 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                }

#line default
#line hidden
            BeginContext(2187, 37, true);
            WriteLiteral("\r\n            </select>\r\n            ");
            EndContext();
            BeginContext(2225, 43, false);
#line 62 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nomeprojetotarefa"));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 294, true);
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <label for=""nomeusuarioresponsavel"">Responsável</label>
            <select name=""nomeusuarioresponsavel"" class=""form-control"">
                <option disabled=""disabled"" selected=""selected"">Selecione o responsável</option>

");
            EndContext();
#line 69 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                 if (ViewBag.NomeUsuarioDB != null)
                {

                    

#line default
#line hidden
#line 72 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                     foreach (var NomeUsuario in ViewBag.NomeUsuarioDB)
                    {

#line default
#line hidden
            BeginContext(2732, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2763, "\"", 2783, 1);
#line 74 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 2771, NomeUsuario, 2771, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2784, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(2795, 11, false);
#line 74 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                                                         Write(NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(2806, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 75 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                    }

#line default
#line hidden
#line 75 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                     

                }

#line default
#line hidden
            BeginContext(2861, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                 foreach (var usuario in ViewBag.Usuario)
                {

#line default
#line hidden
            BeginContext(2941, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2968, "\"", 2996, 1);
#line 81 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 2976, usuario.NomeUsuario, 2976, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2997, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2999, 19, false);
#line 81 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                                                    Write(usuario.NomeUsuario);

#line default
#line hidden
            EndContext();
            BeginContext(3018, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 82 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
                }

#line default
#line hidden
            BeginContext(3048, 37, true);
            WriteLiteral("\r\n            </select>\r\n            ");
            EndContext();
            BeginContext(3086, 48, false);
#line 85 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nomeusuarioresponsavel"));

#line default
#line hidden
            EndContext();
            BeginContext(3134, 157, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"duracaotarefa\">Prazo</label>\r\n            <input type=\"date\" name=\"duracaotarefa\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3291, "\"", 3319, 1);
#line 89 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 3299, Model.DuracaoTarefa, 3299, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3320, 55, true);
            WriteLiteral(" class=\"form-control\" id=\"duracaotarefa\">\r\n            ");
            EndContext();
            BeginContext(3376, 39, false);
#line 90 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
       Write(Html.ValidationMessage("duracaotarefa"));

#line default
#line hidden
            EndContext();
            BeginContext(3415, 165, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"descricaotarefa\">Descrição</label>\r\n            <input type=\"text\" name=\"descricaotarefa\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3580, "\"", 3610, 1);
#line 94 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
WriteAttributeValue("", 3588, Model.DescricaoTarefa, 3588, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3611, 58, true);
            WriteLiteral(" class=\"form-control\" id=\"descricaotarefa\" >\r\n            ");
            EndContext();
            BeginContext(3670, 41, false);
#line 95 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
       Write(Html.ValidationMessage("descricaotarefa"));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n    ");
            EndContext();
            BeginContext(3818, 16, false);
#line 99 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(3834, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Tarefa> Html { get; private set; }
    }
}
#pragma warning restore 1591
