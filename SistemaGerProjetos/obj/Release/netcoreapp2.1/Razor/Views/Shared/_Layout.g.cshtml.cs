#pragma checksum "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d29d6b5c0729388ce8f5195ef0c087d2a96455"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d29d6b5c0729388ce8f5195ef0c087d2a96455", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
  
    string login = Context.Session.GetString("Login");

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(127, 326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3451555692514d52b2105665e1d7a1e6", async() => {
                BeginContext(133, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(206, 13, false);
#line 11 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(219, 227, true);
                WriteLiteral("</title>\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(453, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(455, 4266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a061ceaa6fc44b582202961eab4debf", async() => {
                BeginContext(461, 438, true);
                WriteLiteral(@"
    <header>
        <!--Menu-->
        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
            <a class=""navbar-brand"" href=""/"">Sist Ger Proj</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

");
                EndContext();
#line 23 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
             if (login != null)
            {

#line default
#line hidden
                BeginContext(947, 2051, true);
                WriteLiteral(@"                <div class=""collapse navbar-collapse"" id=""navbarNav"">
                    <ul class=""navbar-nav"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/"">Inicio</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/clientes/index"">Clientes</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/projeto/index"">Projetos</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/tarefa/index"">Tarefas</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/categoria/index"">Categorias</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-lin");
                WriteLiteral(@"k dropdown-toggle"" href=""#"" id=""navbarDropdownMenuLink"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Usuários
                            </a>
                            <div class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                                <a class=""dropdown-item "" href=""/usuario/cadastro"">Cadastro de usuários</a>
                                <a class=""dropdown-item "" href=""/usuario/listausuarios"">Lista de usuários</a>
                            </div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/cidade/index"">Cidades</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/estado/index"">Estados</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">O");
                WriteLiteral("lá ");
                EndContext();
                BeginContext(2999, 18, false);
#line 59 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
                                                        Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3017, 251, true);
                WriteLiteral(" !</a>\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            <a class=\"nav-link\" href=\"/usuario/logout\">Logout</a>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n");
                EndContext();
#line 66 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(3316, 368, true);
                WriteLiteral(@"                <ul class=""navbar-nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/usuario/cadastro"">Cadastrar-se</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/usuario/login"">Login</a>
                    </li>
                </ul>
");
                EndContext();
#line 77 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(3699, 129, true);
                WriteLiteral("\r\n        </nav>\r\n    </header>\r\n    <div class=\"container\">\r\n        <div>\r\n            <!-- Conteúdo - Página -->\r\n            ");
                EndContext();
                BeginContext(3829, 12, false);
#line 84 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3841, 171, true);
                WriteLiteral("\r\n        </div>\r\n        <footer>\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    Todos os direitos reservados &copy; 2010 - ");
                EndContext();
                BeginContext(4013, 17, false);
#line 89 "C:\Users\gomes\Downloads\TrabalhoEntra21ASP.NETCORE\SistemaGerProjetos\Views\Shared\_Layout.cshtml"
                                                          Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(4030, 684, true);
                WriteLiteral(@"
                </div>
            </div>
        </footer>
    </div>

    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4721, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
