#pragma checksum "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dddcff68bbd71dbd96f82f0f9e6ad98accd1b76e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Index.cshtml", typeof(AspNetCore.Views_Clientes_Index))]
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
#line 1 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dddcff68bbd71dbd96f82f0f9e6ad98accd1b76e", @"/Views/Clientes/Index.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<SistemaGerProjetos.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/clientes/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
  
    ViewBag.Title = "Lista de Clientes";

#line default
#line hidden
            BeginContext(204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(245, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(306, 20, false);
#line 17 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(326, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 19 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
}

#line default
#line hidden
            BeginContext(343, 50, true);
            WriteLiteral("\r\n    <p class=\"h3 mt-3\">Lista de Clientes</p>\r\n\r\n");
            EndContext();
            BeginContext(393, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c01b227b152b42f0a86754d50697fd6f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(461, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(465, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd3fb9822a24832b840ec1fc5dba1ec", async() => {
                BeginContext(520, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(533, 34, true);
            WriteLiteral("\r\n<span><b>Total de Registros:</b>");
            EndContext();
            BeginContext(568, 20, false);
#line 26 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
                           Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(588, 549, true);
            WriteLiteral(@"</span>

<table class=""table table-striped table-bordered table-hover mt-1 "">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Código</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">CPF</th>
            <th scope=""col"">Data de Nascimento</th>
            <th scope=""col"">Número</th>
            <th scope=""col"">Complemento</th>
            <th scope=""col"">Logradouro</th>
            <th scope=""col"">CEP</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 43 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
         foreach (var cliente in Model)
        {

#line default
#line hidden
            BeginContext(1189, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1228, 10, false);
#line 46 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1238, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1266, 12, false);
#line 47 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1306, 11, false);
#line 48 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(1317, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1345, 22, false);
#line 49 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1395, 14, false);
#line 50 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(1409, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1437, 19, false);
#line 51 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Complemento);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1484, 18, false);
#line 52 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Logradouro);

#line default
#line hidden
            EndContext();
            BeginContext(1502, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1530, 11, false);
#line 53 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Cep);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1592, "\"", 1630, 2);
            WriteAttributeValue("", 1599, "/clientes/atualizar/", 1599, 20, true);
#line 55 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 1619, cliente.Id, 1619, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1631, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1690, "\"", 1726, 2);
            WriteAttributeValue("", 1697, "/clientes/excluir/", 1697, 18, true);
#line 56 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 1715, cliente.Id, 1715, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1727, 79, true);
            WriteLiteral(" class=\"btn btn-danger\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 59 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1817, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1846, 81, false);
#line 64 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<SistemaGerProjetos.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
