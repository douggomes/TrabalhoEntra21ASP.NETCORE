#pragma checksum "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cd88191ad26f5f9ffc61cf54dfa1143dad8a35d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoria/Index.cshtml", typeof(AspNetCore.Views_Categoria_Index))]
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
#line 1 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 2 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cd88191ad26f5f9ffc61cf54dfa1143dad8a35d", @"/Views/Categoria/Index.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<SistemaGerProjetos.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/categoria/cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
  
    ViewBag.Title = "Lista de Categorias";

#line default
#line hidden
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(249, 60, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(310, 20, false);
#line 17 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(330, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
            BeginContext(347, 52, true);
            WriteLiteral("\r\n    <p class=\"h3 mt-3\">Lista de Categorias</p>\r\n\r\n");
            EndContext();
            BeginContext(399, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8758a33da3c4bf5be2d73d112c5af16", async() => {
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
            BeginContext(467, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(471, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "540f0020a93c4ae786408a9a24d26865", async() => {
                BeginContext(527, 9, true);
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
            BeginContext(540, 34, true);
            WriteLiteral("\r\n<span><b>Total de Registros:</b>");
            EndContext();
            BeginContext(575, 20, false);
#line 26 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
                           Write(Model.TotalItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(595, 301, true);
            WriteLiteral(@"</span>

<table class=""table table-striped table-bordered table-hover mt-1 "">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Código</th>
            <th scope=""col"">Nome da Categoria</th>
            <th scope=""col"">Ação</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
         foreach (var categoria in Model)
        {

#line default
#line hidden
            BeginContext(950, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(989, 12, false);
#line 40 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
               Write(categoria.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1029, 23, false);
#line 41 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
               Write(categoria.NomeCategoria);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 51, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1103, "\"", 1141, 2);
            WriteAttributeValue("", 1110, "/estado/atualizar/", 1110, 18, true);
#line 43 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 1128, categoria.Id, 1128, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1142, 59, true);
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1201, "\"", 1237, 2);
            WriteAttributeValue("", 1208, "/estado/excluir/", 1208, 16, true);
#line 44 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 1224, categoria.Id, 1224, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1238, 79, true);
            WriteLiteral(" class=\"btn btn-danger\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 47 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1328, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(1353, 81, false);
#line 50 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Categoria\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<SistemaGerProjetos.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
