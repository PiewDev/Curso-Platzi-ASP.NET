#pragma checksum "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ListaObjetoEscuela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "942d97adc9b50c9782952c9312d9f343c5c8082f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ListaObjetoEscuela), @"mvc.1.0.view", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ListaObjetoEscuela.cshtml", typeof(AspNetCore.Views_Shared_ListaObjetoEscuela))]
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
#line 1 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\_ViewImports.cshtml"
using Platzi_ASP_NET_CORE;

#line default
#line hidden
#line 2 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\_ViewImports.cshtml"
using Platzi_ASP_NET_CORE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942d97adc9b50c9782952c9312d9f343c5c8082f", @"/Views/Shared/ListaObjetoEscuela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec87c02a19c0aae6024f40643ce4b6fba92b1c4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ListaObjetoEscuela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 208, true);
            WriteLiteral("\r\n<table class=\"table table-dark table-hover table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Id</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 12 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ListaObjetoEscuela.cshtml"
         foreach (var obj in Model)
        {

#line default
#line hidden
            BeginContext(256, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(317, 10, false);
#line 16 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ListaObjetoEscuela.cshtml"
               Write(obj.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(327, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(395, 6, false);
#line 19 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ListaObjetoEscuela.cshtml"
               Write(obj.Id);

#line default
#line hidden
            EndContext();
            BeginContext(401, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 22 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ListaObjetoEscuela.cshtml"

        }

#line default
#line hidden
            BeginContext(458, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
