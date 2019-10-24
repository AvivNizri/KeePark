#pragma checksum "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59da3768f7aeb478678797015ba686c81e8ddfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReserveSpots_Details), @"mvc.1.0.view", @"/Views/ReserveSpots/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReserveSpots/Details.cshtml", typeof(AspNetCore.Views_ReserveSpots_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59da3768f7aeb478678797015ba686c81e8ddfb", @"/Views/ReserveSpots/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ReserveSpots_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeePark.Models.ReserveSpot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9cd2c07f6a440d5a50467643c0427fc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 447, true);
            WriteLiteral(@"

<ul class=""list-group list-group-flush"">
    <li class=""list-group-item"">
        <h2>Weather</h2>
        <div id=""weather""></div>
        <p id=""name""></p>
        <p id=""temp""></p>
        <p id=""humidity""></p>

        <script async defer
                src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAVcfCRAnKSNw2eYs2Gev0ZMS4sHmG30hE&callback=initMap"">
        </script>

        <script>
            var address = '");
            EndContext();
            BeginContext(626, 44, false);
#line 22 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
                      Write(Html.DisplayFor(model => model.Spot.Address));

#line default
#line hidden
            EndContext();
            BeginContext(670, 1493, true);
            WriteLiteral(@"';
            var lat;
            var lng;
              function initMap() {
                  var geocoder = new google.maps.Geocoder();

                geocoder.geocode({'address': address}, function(results, status) {
                    if (status === 'OK') {
                        lat = results[0].geometry.location.lat();
                        lng = results[0].geometry.location.lng();
                        weather(lat, lng);

                    } else {
                        alert('Geocode was not successful for the following reason: ' + status);
                    }
                });
            }


           function weather(lt, lg) {
                $(document).ready(function () {
                    $.get(""https://api.openweathermap.org/data/2.5/weather?lat="" + lt + ""&lon="" + lg + ""&APPID=010276a0143f95cc47608eb8666c4365&units=metric"", function (response) {
                        //response
                        console.log(response);
                      $");
            WriteLiteral(@"(""#name"").text(""City: ""+response.name);
                       $(""#temp"").text(""💨 Temperature: ""+response.main.temp);
                        $(""#humidity"").text(""💧 % Humidity:""+response.main.humidity);

                    });


                });
            }

        </script>

    </li>


    <li class=""list-group-item"">

        <h2>Details Of Your Reservation</h2>

        <dl class=""dl-horizontal"">

            <dt>
                ");
            EndContext();
            BeginContext(2164, 42, false);
#line 68 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(2206, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2262, 38, false);
#line 71 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2356, 40, false);
#line 74 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Spot));

#line default
#line hidden
            EndContext();
            BeginContext(2396, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2452, 44, false);
#line 77 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.Spot.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2552, 45, false);
#line 80 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2597, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2653, 41, false);
#line 83 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2694, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2750, 51, false);
#line 86 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ReservationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2801, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2857, 47, false);
#line 89 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.ReservationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2904, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2960, 51, false);
#line 92 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ReservationHour));

#line default
#line hidden
            EndContext();
            BeginContext(3011, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3067, 47, false);
#line 95 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.ReservationHour));

#line default
#line hidden
            EndContext();
            BeginContext(3114, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3170, 44, false);
#line 98 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(3214, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3270, 40, false);
#line 101 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
            EndContext();
            BeginContext(3310, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3366, 45, false);
#line 104 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.carNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3411, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3467, 41, false);
#line 107 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
           Write(Html.DisplayFor(model => model.carNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3508, 67, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3575, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0193dc1b09684e8e95d092d78095b411", async() => {
                BeginContext(3632, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "\\Mac\Home\Documents\AppProject\KeePark\KeePark\Views\ReserveSpots\Details.cshtml"
                                   WriteLiteral(Model.ReserveSpotID);

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
            BeginContext(3640, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(3656, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d45646183553494698452799338c9a43", async() => {
                BeginContext(3678, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3694, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </li>\r\n\r\n</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeePark.Models.ReserveSpot> Html { get; private set; }
    }
}
#pragma warning restore 1591
