#pragma checksum "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e046e2fb50ab6a590fddae82ba5b955a9da202c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cidade_Index), @"mvc.1.0.view", @"/Views/Cidade/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cidade/Index.cshtml", typeof(AspNetCore.Views_Cidade_Index))]
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
#line 1 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e046e2fb50ab6a590fddae82ba5b955a9da202c3", @"/Views/Cidade/Index.cshtml")]
    public class Views_Cidade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<SistemaGerProjetos.Models.Cidade>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cidade/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
  
    ViewBag.Title = "Lista de Cidades";

#line default
#line hidden
            BeginContext(202, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(243, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(304, 20, false);
#line 17 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(324, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
}

#line default
#line hidden
            BeginContext(341, 49, true);
            WriteLiteral("\r\n    <p class=\"h3 mt-3\">Lista de Cidades</p>\r\n\r\n");
            EndContext();
            BeginContext(390, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9310e5da84994d7088d4f3269022cc51", async() => {
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
            BeginContext(458, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(462, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3600ac629ee4208b498c610b75f9294", async() => {
                BeginContext(515, 9, true);
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
            BeginContext(528, 34, true);
            WriteLiteral("\r\n<span><b>Total de Registros:</b>");
            EndContext();
            BeginContext(563, 20, false);
#line 26 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
                           Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(583, 384, true);
            WriteLiteral(@"</span>

<table class=""table table-striped table-bordered table-hover mt-1 "">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Código</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Estado</th>
            <th scope=""col"">Número de Habitantes</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 39 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
         foreach (var cidade in Model)
        {

#line default
#line hidden
            BeginContext(1018, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1057, 9, false);
#line 42 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
               Write(cidade.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1066, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1094, 11, false);
#line 43 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
               Write(cidade.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1133, 17, false);
#line 44 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
               Write(cidade.NomeEstado);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1178, 23, false);
#line 45 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
               Write(cidade.NumeroHabitantes);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1252, "\"", 1287, 2);
            WriteAttributeValue("", 1259, "/cidade/atualizar/", 1259, 18, true);
#line 47 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
WriteAttributeValue("", 1277, cidade.Id, 1277, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1288, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1347, "\"", 1380, 2);
            WriteAttributeValue("", 1354, "/cidade/excluir/", 1354, 16, true);
#line 48 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
WriteAttributeValue("", 1370, cidade.Id, 1370, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1381, 79, true);
            WriteLiteral(" class=\"btn btn-danger\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 51 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1471, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(1496, 81, false);
#line 54 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Cidade\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<SistemaGerProjetos.Models.Cidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
