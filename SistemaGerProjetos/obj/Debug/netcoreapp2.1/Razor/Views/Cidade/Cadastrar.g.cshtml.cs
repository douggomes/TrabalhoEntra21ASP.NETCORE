#pragma checksum "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43367cef33cc7d03def8adff8c57c11bd2eaf8b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidade_Cadastrar), @"mvc.1.0.view", @"/Views/Cidade/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cidade/Cadastrar.cshtml", typeof(AspNetCore.Views_Cidade_Cadastrar))]
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
#line 1 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43367cef33cc7d03def8adff8c57c11bd2eaf8b7", @"/Views/Cidade/Cadastrar.cshtml")]
    public class Views_Cidade_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaGerProjetos.Models.Cidade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
  
    ViewBag.Title = "Cadastro de Cidades";

#line default
#line hidden
            BeginContext(164, 91, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <form method=\"post\">\r\n        <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 255, "\"", 272, 1);
#line 14 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
WriteAttributeValue("", 263, Model.Id, 263, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 125, true);
            WriteLiteral(" />\r\n        <div class=\"form-group\">\r\n            <label for=\"nome\">Nome</label>\r\n            <input type=\"text\" name=\"nome\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 398, "\"", 417, 1);
#line 17 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
WriteAttributeValue("", 406, Model.Nome, 406, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(418, 84, true);
            WriteLiteral(" class=\"form-control\" id=\"nome\" placeholder=\"Digite o nome da cidade\">\r\n            ");
            EndContext();
            BeginContext(503, 30, false);
#line 18 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
       Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(533, 261, true);
            WriteLiteral(@"
        </div>
        <div class=""form-group"">
            <label for=""nomeestado"">Estado</label>
            <select name=""nomeestado"" class=""form-control"">
                <option disabled=""disabled"" selected=""selected"">Selecione um Estado</option>

");
            EndContext();
#line 25 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                 if (ViewBag.NomeEstadoDB != null)
                {

                    

#line default
#line hidden
#line 28 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                     foreach (var NomeEstado in ViewBag.NomeEstadoDB)
                    {

#line default
#line hidden
            BeginContext(961, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 992, "\"", 1011, 1);
#line 30 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
WriteAttributeValue("", 1000, NomeEstado, 1000, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1012, 10, true);
            WriteLiteral(" selected>");
            EndContext();
            BeginContext(1023, 10, false);
#line 30 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                                                        Write(NomeEstado);

#line default
#line hidden
            EndContext();
            BeginContext(1033, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 31 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                    }

#line default
#line hidden
#line 31 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                     

                }

#line default
#line hidden
            BeginContext(1088, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                 foreach (var estado in ViewBag.Estado)
                {

#line default
#line hidden
            BeginContext(1166, 27, true);
            WriteLiteral("                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1193, "\"", 1219, 1);
#line 37 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
WriteAttributeValue("", 1201, estado.NomeEstado, 1201, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1220, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1222, 17, false);
#line 37 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                                                  Write(estado.NomeEstado);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 38 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
                }

#line default
#line hidden
            BeginContext(1269, 37, true);
            WriteLiteral("\r\n            </select>\r\n            ");
            EndContext();
            BeginContext(1307, 32, false);
#line 41 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
       Write(Html.ValidationMessage("estado"));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 158, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"numeroHabitantes\"></label>\r\n            <input type=\"text\" name=\"numeroHabitantes\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1497, "\"", 1528, 1);
#line 45 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
WriteAttributeValue("", 1505, Model.NumeroHabitantes, 1505, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1529, 103, true);
            WriteLiteral(" class=\"form-control\" id=\"numeroHabitantes\" placeholder=\"Informe o número de habitantes\">\r\n            ");
            EndContext();
            BeginContext(1633, 42, false);
#line 46 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
       Write(Html.ValidationMessage("numeroHabitantes"));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 106, true);
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    </form>\r\n    ");
            EndContext();
            BeginContext(1782, 16, false);
#line 50 "C:\Users\T-Gamer\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Cadastrar.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(1798, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaGerProjetos.Models.Cidade> Html { get; private set; }
    }
}
#pragma warning restore 1591
