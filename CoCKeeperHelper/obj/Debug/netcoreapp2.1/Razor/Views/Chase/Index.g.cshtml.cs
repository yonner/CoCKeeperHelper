#pragma checksum "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38a231fd8db6c2cfcee7180ea4085014489598f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chase_Index), @"mvc.1.0.view", @"/Views/Chase/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chase/Index.cshtml", typeof(AspNetCore.Views_Chase_Index))]
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
#line 1 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
using CoCKeeperHelper.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38a231fd8db6c2cfcee7180ea4085014489598f", @"/Views/Chase/Index.cshtml")]
    public class Views_Chase_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoCKeeperHelper.Data.CharacterPositions>
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
            BeginContext(77, 47, true);
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(124, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a9e76835789408d8319a18334e3d17c", async() => {
                BeginContext(130, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
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
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(162, 1351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84dd74ba84d54fedac6336c32d14f10a", async() => {
                BeginContext(168, 17, true);
                WriteLiteral("\r\n    <h1></h1>\r\n");
                EndContext();
                BeginContext(202, 55, false);
#line 11 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
   Write(Html.Raw(@"<div class=""container"" align=""center"">"));

#line default
#line hidden
                EndContext();
#line 11 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
                                                                ;

        for (int i = 0; i < (int)this.ViewData["Nodes"] - 1; i++)
        {

#line default
#line hidden
                BeginContext(340, 243, true);
                WriteLiteral("            <img src=\"../images/node.jpg\" alt=\"A node\" data-toggle=\"popover\" data-placement=\"bottom\" title=\"<b>Node</b>\" />\r\n            <img src=\"../images/path.jpg\" alt=\"A path\" />\r\n            <img src=\"../images/path.jpg\" alt=\"A path\" />\r\n");
                EndContext();
#line 18 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(594, 121, true);
                WriteLiteral("        <img src=\"../images/node.jpg\" alt=\"A node\" data-toggle=\"popover\" data-placement=\"bottom\" title=\"<b>Node</b>\" />\r\n");
                EndContext();
                BeginContext(726, 18, false);
#line 21 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
                EndContext();
#line 21 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
                           ;

        

#line default
#line hidden
                BeginContext(758, 55, false);
#line 23 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
   Write(Html.Raw(@"<div class=""container"" align=""center"">"));

#line default
#line hidden
                EndContext();
#line 23 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
                                                                ;

        for (int i = 0; i < (int)this.ViewData["Nodes"] - 1; i++)
        {

            foreach (var c in Model)
            {
                if (c.Position == i)
                {

#line default
#line hidden
                BeginContext(1008, 152, true);
                WriteLiteral("                    <img src=\"../images/char.jpg\" alt=\"Farmer\" data-toggle=\"popover\" data-placement=\"bottom\" title=\"<b>c</b>\" data-content=\"Farmer\" />\r\n");
                EndContext();
#line 33 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
                    break;
                }
                else
                {

#line default
#line hidden
                BeginContext(1248, 62, true);
                WriteLiteral("                    <img src=\"../images/blank.jpg\" alt=\"\" />\r\n");
                EndContext();
#line 38 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(1344, 114, true);
                WriteLiteral("            <img src=\"../images/blank.jpg\" alt=\"\" />\r\n            <img src=\"../images/blank.jpg\" alt=\"A path\" />\r\n");
                EndContext();
#line 42 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
        }
        

#line default
#line hidden
                BeginContext(1478, 18, false);
#line 43 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
   Write(Html.Raw("</div>"));

#line default
#line hidden
                EndContext();
#line 43 "C:\Development\CoCKeeperHelper\CoCKeeperHelper\Views\Chase\Index.cshtml"
                           ;
    

#line default
#line hidden
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
            BeginContext(1513, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoCKeeperHelper.Data.CharacterPositions> Html { get; private set; }
    }
}
#pragma warning restore 1591
