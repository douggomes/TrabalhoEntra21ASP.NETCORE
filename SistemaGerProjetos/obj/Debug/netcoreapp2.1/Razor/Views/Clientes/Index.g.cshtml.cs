#pragma checksum "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b6cb55c0ab980747bc35ba5a1d8e815a99df07"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b6cb55c0ab980747bc35ba5a1d8e815a99df07", @"/Views/Clientes/Index.cshtml")]
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
            BeginContext(343, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(345, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4818781d785845949b0ea876d5270dda", async() => {
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
            BeginContext(413, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(417, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0c6e957857443379ddd97578ca2152c", async() => {
                BeginContext(472, 9, true);
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
            BeginContext(485, 34, true);
            WriteLiteral("\r\n<span><b>Total de Registros:</b>");
            EndContext();
            BeginContext(520, 20, false);
#line 24 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
                           Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(540, 502, true);
            WriteLiteral(@"</span>

<table class=""table"">
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
#line 41 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
         foreach (var cliente in Model)
        {

#line default
#line hidden
            BeginContext(1094, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1133, 10, false);
#line 44 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1171, 12, false);
#line 45 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1211, 11, false);
#line 46 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(1222, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1250, 22, false);
#line 47 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1300, 14, false);
#line 48 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1342, 19, false);
#line 49 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Complemento);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1389, 18, false);
#line 50 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Logradouro);

#line default
#line hidden
            EndContext();
            BeginContext(1407, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1435, 11, false);
#line 51 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
               Write(cliente.Cep);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1497, "\"", 1535, 2);
            WriteAttributeValue("", 1504, "/clientes/atualizar/", 1504, 20, true);
#line 53 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 1524, cliente.Id, 1524, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1536, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1595, "\"", 1631, 2);
            WriteAttributeValue("", 1602, "/clientes/excluir/", 1602, 18, true);
#line 54 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 1620, cliente.Id, 1620, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1632, 80, true);
            WriteLiteral(" class=\"btn btn-primary\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1723, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1752, 81, false);
#line 62 "T:\Documentos\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Clientes\Index.cshtml"
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
