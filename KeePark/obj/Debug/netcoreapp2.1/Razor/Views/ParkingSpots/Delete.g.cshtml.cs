#pragma checksum "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f60708c9b5479f24e3c9592ad1b2c72b1d53d2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ParkingSpots_Delete), @"mvc.1.0.view", @"/Views/ParkingSpots/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ParkingSpots/Delete.cshtml", typeof(AspNetCore.Views_ParkingSpots_Delete))]
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
#line 1 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark;

#line default
#line hidden
#line 2 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f60708c9b5479f24e3c9592ad1b2c72b1d53d2e", @"/Views/ParkingSpots/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ParkingSpots_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeePark.Models.ParkingSpot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ParkingSpot</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(299, 44, false);
#line 16 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(387, 40, false);
#line 19 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(427, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(471, 43, false);
#line 22 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerID));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(558, 39, false);
#line 25 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OwnerID));

#line default
#line hidden
            EndContext();
            BeginContext(597, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(641, 43, false);
#line 28 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(728, 39, false);
#line 31 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(811, 41, false);
#line 34 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(896, 37, false);
#line 37 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(933, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(977, 47, false);
#line 40 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NunOfOrders));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1068, 43, false);
#line 43 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NunOfOrders));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1155, 44, false);
#line 46 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.filePath));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1243, 40, false);
#line 49 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.filePath));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1327, 51, false);
#line 52 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpotDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1422, 47, false);
#line 55 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpotDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1507, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "894d5aaef1964c3c8325b33f3879c816", async() => {
                BeginContext(1533, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1543, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3318b86842642c3a6a2e55557e59f32", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ParkingSpotID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1590, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1674, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "146260f99c194d28984f4efa3f6f310e", async() => {
                    BeginContext(1696, 12, true);
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
                BeginContext(1712, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1725, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeePark.Models.ParkingSpot> Html { get; private set; }
    }
}
#pragma warning restore 1591
