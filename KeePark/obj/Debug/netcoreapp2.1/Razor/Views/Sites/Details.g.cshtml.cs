#pragma checksum "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfea832d35f793b349c95c1411b7405cb872e836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sites_Details), @"mvc.1.0.view", @"/Views/Sites/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sites/Details.cshtml", typeof(AspNetCore.Views_Sites_Details))]
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
#line 1 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark;

#line default
#line hidden
#line 2 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfea832d35f793b349c95c1411b7405cb872e836", @"/Views/Sites/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Sites_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeepPark.Models.Site>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(74, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Site</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(193, 44, false);
#line 14 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteName));

#line default
#line hidden
            EndContext();
            BeginContext(237, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(281, 40, false);
#line 17 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.SiteName));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(365, 43, false);
#line 20 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerID));

#line default
#line hidden
            EndContext();
            BeginContext(408, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(452, 39, false);
#line 23 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerID));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(535, 43, false);
#line 26 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(578, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(622, 39, false);
#line 29 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(661, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(705, 51, false);
#line 32 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteDescription));

#line default
#line hidden
            EndContext();
            BeginContext(756, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(800, 47, false);
#line 35 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.SiteDescription));

#line default
#line hidden
            EndContext();
            BeginContext(847, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(891, 51, false);
#line 38 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SitePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(986, 47, false);
#line 41 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.SitePhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1077, 48, false);
#line 44 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PricePerHour));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1169, 44, false);
#line 47 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.PricePerHour));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1257, 41, false);
#line 50 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Label));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1342, 37, false);
#line 53 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
       Write(Html.DisplayFor(model => model.Label));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1426, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42237ef7b50d45ab8a83e05bb76696a5", async() => {
                BeginContext(1476, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\AvivNizri\Documents\Computer science\שנה ב\סימסטר ג\אפליקציות\KeePark\KeePark\Views\Sites\Details.cshtml"
                           WriteLiteral(Model.SiteID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1484, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1492, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e65cd2280279459e8c928095c14c4874", async() => {
                BeginContext(1514, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1530, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeepPark.Models.Site> Html { get; private set; }
    }
}
#pragma warning restore 1591
