#pragma checksum "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ObjetoEscuelaSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c84aadae47decb21b1f9008e023a1d66a09b7eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple), @"mvc.1.0.view", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ObjetoEscuelaSimple.cshtml", typeof(AspNetCore.Views_Shared_ObjetoEscuelaSimple))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c84aadae47decb21b1f9008e023a1d66a09b7eb", @"/Views/Shared/ObjetoEscuelaSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec87c02a19c0aae6024f40643ce4b6fba92b1c4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ObjetoEscuelaSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ObjetoEscuelaBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 17, true);
            WriteLiteral("<p>\r\n    Nombre: ");
            EndContext();
            BeginContext(44, 12, false);
#line 3 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ObjetoEscuelaSimple.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(56, 16, true);
            WriteLiteral("<br />\r\n    id: ");
            EndContext();
            BeginContext(73, 14, false);
#line 4 "C:\Users\ppabl\source\repos\CursoPlatzi\Platzi_ASP_NET_CORE\Views\Shared\ObjetoEscuelaSimple.cshtml"
   Write(Model.UniqueId);

#line default
#line hidden
            EndContext();
            BeginContext(87, 12, true);
            WriteLiteral("\r\n</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObjetoEscuelaBase> Html { get; private set; }
    }
}
#pragma warning restore 1591
