#pragma checksum "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfa83b36489be3e38c3c53bc857b8d793b94ad42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReserveSpots_Index), @"mvc.1.0.view", @"/Views/ReserveSpots/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReserveSpots/Index.cshtml", typeof(AspNetCore.Views_ReserveSpots_Index))]
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
#line 1 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark;

#line default
#line hidden
#line 2 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfa83b36489be3e38c3c53bc857b8d793b94ad42", @"/Views/ReserveSpots/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ReserveSpots_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KeePark.Models.ReserveSpot>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ReserveSpots/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 28, true);
            WriteLiteral("\r\n<h2>Order History</h2>\r\n\r\n");
            EndContext();
            BeginContext(166, 290, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba008dca7f44459d9bdf1d4ef6adba03", async() => {
                BeginContext(214, 235, true);
                WriteLiteral("\r\n    Spot\'s Name: <input type=\"text\" name=\"spotsName\" />\r\n    Reservations\'s Date: <input type=\"datetime\" name=\"reservationsDate\" />\r\n    Car Number: <input type=\"text\" name=\"carNumber\" />\r\n    <input type=\"submit\" value=\"search\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(456, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(545, 42, false);
#line 21 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(587, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(643, 40, false);
#line 24 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Spot));

#line default
#line hidden
            EndContext();
            BeginContext(683, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(739, 45, false);
#line 27 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(784, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(840, 51, false);
#line 30 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReservationDate));

#line default
#line hidden
            EndContext();
            BeginContext(891, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(947, 51, false);
#line 33 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReservationHour));

#line default
#line hidden
            EndContext();
            BeginContext(998, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1054, 44, false);
#line 36 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(1098, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1154, 45, false);
#line 39 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.carNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
         foreach (var item in Model)
        {
          



#line default
#line hidden
            BeginContext(1350, 74, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1425, 41, false);
#line 53 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1546, 48, false);
#line 56 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Spot.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1674, 44, false);
#line 59 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1798, 50, false);
#line 62 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ReservationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1928, 50, false);
#line 65 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ReservationHour));

#line default
#line hidden
            EndContext();
            BeginContext(1978, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2058, 43, false);
#line 68 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(2101, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2181, 44, false);
#line 71 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.carNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
            EndContext();
            BeginContext(2306, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e17ff56e91348f5986e9749f1cab235", async() => {
                BeginContext(2362, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                                               WriteLiteral(item.ReserveSpotID);

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
            BeginContext(2370, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2398, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a084c88f4a28421f8e412d8eff70abf1", async() => {
                BeginContext(2457, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                                                  WriteLiteral(item.ReserveSpotID);

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
            BeginContext(2468, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2496, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1fce17abc24be792dd310a21e27762", async() => {
                BeginContext(2554, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
                                                 WriteLiteral(item.ReserveSpotID);

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
            BeginContext(2564, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 80 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2631, 34, true);
            WriteLiteral("        \r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KeePark.Models.ReserveSpot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
