#pragma checksum "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5b1dfa76c756b48edab54283378444aa7e9bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ParkingSpots_DetailsFromSearching), @"mvc.1.0.view", @"/Views/ParkingSpots/DetailsFromSearching.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ParkingSpots/DetailsFromSearching.cshtml", typeof(AspNetCore.Views_ParkingSpots_DetailsFromSearching))]
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
#line 1 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark;

#line default
#line hidden
#line 2 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5b1dfa76c756b48edab54283378444aa7e9bbd", @"/Views/ParkingSpots/DetailsFromSearching.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ParkingSpots_DetailsFromSearching : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeePark.Models.ParkingSpot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReserveSpots", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
  
    ViewBag.Title = "Spot Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var photoPath = "~/SpotImages/" + (Model.filePath ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(202, 605, true);
            WriteLiteral(@"
<style>
    #map {
        height: 400px; /* The height is 400 pixels */
        width: 500px; /* The width is the width of the web page */
    }

    .mycard {
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        transition: 0.3s;
        size: 200rem;
    }

    .card {
        width: 100%;
    }

    .grid {
        display: grid;
        grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
        grid-gap: 200px;
        align-items: stretch;
    }
</style>

<hr />

<div class=""grid"">
    <div class=""mycard"">
        <div class=""mycard"">
            ");
            EndContext();
            BeginContext(807, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17dacf8e8b4d46deb16d9a3e07ac57b8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                               WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 38 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 221, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card\">\r\n\r\n        <!--The div element for the map -->\r\n        <div id=\"map\"></div>\r\n        <script>\r\n            // Initialize and add the map\r\n            var address = \'");
            EndContext();
            BeginContext(1125, 39, false);
#line 48 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                      Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 1434, true);
            WriteLiteral(@"';
            function initMap() {
                var geocoder = new google.maps.Geocoder();
                geocoder.geocode({'address': address}, function(results, status) {
                    if (status === 'OK') {
                        var map = new google.maps.Map(document.getElementById('map'), {
                            zoom: 14,
                            position: results[0].geometry.location
                        });
                        map.setCenter(results[0].geometry.location);
                        var marker = new google.maps.Marker({
                            map: map,
                            position: results[0].geometry.location
                    });
                    } else {
                        alert('Geocode was not successful for the following reason: ' + status);
                    }
                });
            }
        </script>
        <!--Load the API from the specified URL
        * The async attribute allows the browser to r");
            WriteLiteral(@"ender the page while the API loads
        * The key parameter will contain your own API key (which is not needed for this tutorial)
        * The callback parameter executes the initMap() function
        -->
        <script async defer
                src=""https://maps.googleapis.com/maps/api/js?key=&callback=initMap"">
        </script>
    </div>
</div>
<div class=""center"">

    <dt>
        ");
            EndContext();
            BeginContext(2599, 44, false);
#line 81 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
   Write(Html.DisplayNameFor(model => model.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(2643, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2646, 40, false);
#line 81 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                                                  Write(Html.DisplayFor(model => model.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 35, true);
            WriteLiteral("\r\n    </dt>\r\n\r\n\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2722, 43, false);
#line 86 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2765, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2768, 39, false);
#line 86 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                                                 Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2807, 54, true);
            WriteLiteral("\r\n    </dt>\r\n\r\n    <dt>\r\n        Parking Description: ");
            EndContext();
            BeginContext(2862, 47, false);
#line 90 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                        Write(Html.DisplayFor(model => model.SpotDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2909, 33, true);
            WriteLiteral("\r\n    </dt>\r\n\r\n    <dt>\r\n        ");
            EndContext();
            BeginContext(2943, 41, false);
#line 94 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2984, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(2987, 37, false);
#line 94 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                                               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3024, 17, true);
            WriteLiteral("\r\n    </dt>\r\n    ");
            EndContext();
            BeginContext(3041, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbba4b43696b408b9fe6a8073919c85d", async() => {
                BeginContext(3158, 18, true);
                WriteLiteral("Create Reservation");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\ParkingSpots\DetailsFromSearching.cshtml"
                                                           WriteLiteral(Model.ParkingSpotID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3180, 12, true);
            WriteLiteral("\r\n\r\n\r\n</div>");
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