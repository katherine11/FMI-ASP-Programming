#pragma checksum "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b7fdf5e7418c1e422272b598d4147f2bc6ec44d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Save), @"mvc.1.0.view", @"/Views/Shop/Save.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Save.cshtml", typeof(AspNetCore.Views_Shop_Save))]
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
#line 1 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\_ViewImports.cshtml"
using CozmeticZone;

#line default
#line hidden
#line 2 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\_ViewImports.cshtml"
using CozmeticZone.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b7fdf5e7418c1e422272b598d4147f2bc6ec44d", @"/Views/Shop/Save.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"323951d90a5d60676e60516d69e5133a30215e05", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Save : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewComponent>
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
            BeginContext(22, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(51, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29b38f4a45f34ecf8749b8de8094c767", async() => {
                BeginContext(57, 28, true);
                WriteLiteral("\r\n    <title>title</title>\r\n");
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
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 762, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3f0adaea9c4ad0b948d39da94bbf56", async() => {
                BeginContext(100, 35, true);
                WriteLiteral("\r\n<div>\r\n\r\n    <strong>\r\n        \r\n");
                EndContext();
#line 14 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
         if (ViewBag.IncorrectFormat != null && ViewBag.IncorrectFormat)
        {

#line default
#line hidden
                BeginContext(220, 102, true);
                WriteLiteral("            <i style=\"color: darkred\">Възникна проблем при форматирането на полетата от формата.</i>\r\n");
                EndContext();
#line 17 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
        }

#line default
#line hidden
                BeginContext(333, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
         if (ViewBag.FileExists != null && ViewBag.FileExists)
        {

#line default
#line hidden
                BeginContext(410, 71, true);
                WriteLiteral("            <i style=\"color: darkred\">XML Файлът вече съществува.</i>\r\n");
                EndContext();
#line 22 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
        }

#line default
#line hidden
                BeginContext(492, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 24 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
         if (ViewBag.ValidXML != null)
        {
            if (ViewBag.ValidXML)
            {

#line default
#line hidden
                BeginContext(595, 85, true);
                WriteLiteral("                <i style=\"color: forestgreen\">XML файлът беше успешно създаден.</i>\r\n");
                EndContext();
#line 29 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(728, 68, true);
                WriteLiteral("                <i style=\"color: red\">XML файлът не е валиден.</i>\r\n");
                EndContext();
#line 33 "C:\Users\ksimeonova\Documents\ASP\CozmeticZone\CozmeticZone\Views\Shop\Save.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(822, 27, true);
                WriteLiteral("\r\n    </strong>\r\n\r\n</div>\r\n");
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
            BeginContext(856, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
