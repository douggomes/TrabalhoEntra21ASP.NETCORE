#pragma checksum "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3271d4c46ca4b712710f4052933cc067f5759c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Index), @"mvc.1.0.view", @"/Views/Tarefa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Index.cshtml", typeof(AspNetCore.Views_Tarefa_Index))]
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
#line 1 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3271d4c46ca4b712710f4052933cc067f5759c78", @"/Views/Tarefa/Index.cshtml")]
    public class Views_Tarefa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<SistemaGerProjetos.Models.Tarefa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/tarefa/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
  
    ViewBag.Title = "Lista de Tarefas";

#line default
#line hidden
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(243, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(304, 20, false);
#line 17 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(324, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
}

#line default
#line hidden
            BeginContext(341, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(343, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b78d84fd6564b85bab225d1b384e231", async() => {
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
            BeginContext(411, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(415, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6beb9ad63a224682935b45d414fb9ca3", async() => {
                BeginContext(468, 9, true);
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
            BeginContext(481, 34, true);
            WriteLiteral("\r\n<span><b>Total de Registros:</b>");
            EndContext();
            BeginContext(516, 20, false);
#line 24 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
                           Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(536, 493, true);
            WriteLiteral(@"</span>

<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Código</th>
            <th scope=""col"">Título da tarefa</th>
            <th scope=""col"">Categoria</th>
            <th scope=""col"">Projeto Designado</th>
            <th scope=""col"">Responsável pela tarefa</th>
            <th scope=""col"">Duração</th>
            <th scope=""col"">Descrição</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 40 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
         foreach (var tarefa in Model)
        {

#line default
#line hidden
            BeginContext(1080, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1119, 9, false);
#line 43 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1156, 19, false);
#line 44 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.TituloTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1203, 16, false);
#line 45 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1247, 24, false);
#line 46 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.NomeProjetoTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1299, 29, false);
#line 47 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.NomeUsuarioResponsavel);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1356, 20, false);
#line 48 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.DuracaoTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1404, 22, false);
#line 49 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
               Write(tarefa.DescricaoTarefa);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1477, "\"", 1512, 2);
            WriteAttributeValue("", 1484, "/estado/atualizar/", 1484, 18, true);
#line 51 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
WriteAttributeValue("", 1502, tarefa.Id, 1502, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1513, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1572, "\"", 1605, 2);
            WriteAttributeValue("", 1579, "/estado/excluir/", 1579, 16, true);
#line 52 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
WriteAttributeValue("", 1595, tarefa.Id, 1595, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1606, 80, true);
            WriteLiteral(" class=\"btn btn-primary\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1697, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(1722, 81, false);
#line 58 "C:\Users\gomes\Documents\GitHub\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Tarefa\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<SistemaGerProjetos.Models.Tarefa>> Html { get; private set; }
    }
}
#pragma warning restore 1591