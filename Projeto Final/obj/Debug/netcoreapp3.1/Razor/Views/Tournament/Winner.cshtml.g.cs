#pragma checksum "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d4a819817c316ea7e072cdc69f1c2b36bc909f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournament_Winner), @"mvc.1.0.view", @"/Views/Tournament/Winner.cshtml")]
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
#nullable restore
#line 1 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\_ViewImports.cshtml"
using Projeto_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\_ViewImports.cshtml"
using Projeto_Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d4a819817c316ea7e072cdc69f1c2b36bc909f", @"/Views/Tournament/Winner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0f11c877b8160f2778780b62b0cbf6e0796ec9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tournament_Winner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto_Final.Models.Fighter.Fighter>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("g-cards"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
  
    ViewData["Title"] = "Start";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"align-div\">\r\n    <div class=\"fighter-cards-div\">\r\n        <div class=\"f-cards\"");
            BeginWriteAttribute("id", " id=\"", 180, "\"", 194, 1);
#nullable restore
#line 9 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
WriteAttributeValue("", 185, Model.Id, 185, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 195, "\"", 221, 3);
            WriteAttributeValue("", 205, "getId(", 205, 6, true);
#nullable restore
#line 9 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
WriteAttributeValue("", 211, Model.Id, 211, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 220, ")", 220, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"c-cards\">\r\n                <p class=\"f-name\">");
#nullable restore
#line 11 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"f-age\">Idade: ");
#nullable restore
#line 12 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
                                    Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"f-total-fights\">Lutas: ");
#nullable restore
#line 13 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
                                             Write(Model.TotalFights);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"f-martial-arts\">Artes M.: ");
#nullable restore
#line 14 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
                                                Write(Model.MartialArts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"f-victories\">Vit??rias: ");
#nullable restore
#line 15 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
                                             Write(Model.Victories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"f-defeats\">Derrotas: ");
#nullable restore
#line 16 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
                                           Write(Model.Defeats);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"background-card\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95d4a819817c316ea7e072cdc69f1c2b36bc909f6829", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 741, "~/media/fighters/", 741, 17, true);
#nullable restore
#line 18 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
AddHtmlAttributeValue("", 758, Model.Name, 758, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 771, ".png", 771, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\Users\heito\Downloads\T-Systems\Projeto Final\Projeto Final\Views\Tournament\Winner.cshtml"
AddHtmlAttributeValue("", 782, Model.Name, 782, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto_Final.Models.Fighter.Fighter> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
