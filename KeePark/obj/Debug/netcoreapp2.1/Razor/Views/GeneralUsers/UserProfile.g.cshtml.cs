#pragma checksum "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7587b60becdedebec308e909e44685a926ac03b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GeneralUsers_UserProfile), @"mvc.1.0.view", @"/Views/GeneralUsers/UserProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GeneralUsers/UserProfile.cshtml", typeof(AspNetCore.Views_GeneralUsers_UserProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7587b60becdedebec308e909e44685a926ac03b", @"/Views/GeneralUsers/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralUsers_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KeePark.Data.GeneralUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/userstyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("CreateText()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "UserProfile";

#line default
#line hidden
            BeginContext(120, 793, true);
            WriteLiteral(@"
<style>
    .fontuse {
        text-shadow: 1px 1px #808080;
    }

    .multiple-columns {
        padding: 30px;
        column-count: 3;
        column-gap: 20px;
        column-rule-style: solid;
        font-size: small;
        text-decoration: none;
    }

    #border-radius {
        border-radius: 15px 15px 50px 50px;
        background: #EEEEEE;
        padding: 500px, 300px;
        width: auto;
                text-decoration: none;

        height: auto;
    }

    p {
        font-family: ""Merriweather"", -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, ""Noto Sans"", sans-serif, ""Apple Color Emoji"", ""Segoe UI Emoji"", ""Segoe UI Symbol"", ""Noto Color Emoji"";
    }
</style>
<!DOCTYPE html>
<html lang=""en"">



");
            EndContext();
            BeginContext(913, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3a72cba82346139280312cecf3d6f3", async() => {
                BeginContext(919, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(925, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4b9d2fa82294cedb444df3fb43b3a8b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1008, 106, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n\r\n");
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
            BeginContext(1121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1123, 3399, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b457be9c6ca4e1e868e5823c269f0a5", async() => {
                BeginContext(1151, 232, true);
                WriteLiteral("\r\n    <div class=\"jumbotron text-center\">\r\n        <div class=\"section-title\">\r\n            <h1>ACCOUNT</h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n");
                EndContext();
#line 57 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                 foreach (var item in Model)
                {
                    if (item.UserName == User.Identity.Name)
                    {

#line default
#line hidden
                BeginContext(1533, 71, true);
                WriteLiteral("                        <h2 class=\"name\">\r\n                            ");
                EndContext();
                BeginContext(1605, 44, false);
#line 62 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1649, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1680, 43, false);
#line 63 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1723, 33, true);
                WriteLiteral("\r\n                        </h2>\r\n");
                EndContext();
                BeginContext(1760, 48, true);
                WriteLiteral("                        <p class=\"email\">Email: ");
                EndContext();
                BeginContext(1809, 18, false);
#line 67 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                           Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1827, 61, true);
                WriteLiteral("</p>\r\n                        <p class=\"phone\">Phone Number: ");
                EndContext();
                BeginContext(1889, 46, false);
#line 68 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(1935, 58, true);
                WriteLiteral("</p>\r\n                        <p class=\"balance\">Balance: ");
                EndContext();
                BeginContext(1994, 42, false);
#line 69 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Balance));

#line default
#line hidden
                EndContext();
                BeginContext(2036, 64, true);
                WriteLiteral("</p>\r\n                        <p class=\"car-number\">Car Number: ");
                EndContext();
                BeginContext(2101, 44, false);
#line 70 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.CarNumber));

#line default
#line hidden
                EndContext();
                BeginContext(2145, 58, true);
                WriteLiteral("</p>\r\n                        <p class=\"address\">Address: ");
                EndContext();
                BeginContext(2204, 42, false);
#line 71 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
                EndContext();
                BeginContext(2246, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 72 "C:\Users\razs9744\Source\Repos\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                    }
                }

#line default
#line hidden
                BeginContext(2294, 2221, true);
                WriteLiteral(@"
                <a id=""edit_details"" href=""/Identity/Account/Manage"">Edit Details</a>







            </div>
            <div class=""col-sm-8"">

                <script>
                    var c = document.getElementById(""myCanvas"");
                    var ctx = c.getContext(""2d"");

                    // Create gradient
                    var grd = ctx.createLinearGradient(0, 0, 900, 0);
                    grd.addColorStop(0, ""#EEEEEE"");

                    // Fill with gradient
                    ctx.fillStyle = grd;
                    ctx.fillRect(10, 10, 950, 80);
                </script><br />


                <section>
                    <div class=""multiple-columns"" id=""border-radius"">
                        <a id=""my_reservations"" href=""/ReserveSpots/Index"">
                            <h2 class=""fontuse"">MY ORDER HISTORY</h2>
                            <p>look which spots you already visited!<br /></p>
                        </a>

                    ");
                WriteLiteral(@"    <a id=""future_orders"" href=""/ReserveSpots/FutureOrders"">
                            <h2 class=""fontuse"">MY FUTURE ORDERS</h2>
                            <p>Have a reservation? view the details of your order.<br /></p>
                        </a>
                        <a id=""future_orders"" href=""/ParkingSpots/Index"">
                            <h2 class=""fontuse"">MY SPOTS</h2>
                            <p>Take a look at your spots!<br /></p>
                        </a>
                        <a id=""rent_site"" href=""/ParkingSpots/Create"">
                            <h2 class=""fontuse"">RENT MY SPOT</h2>
                            <p>Have an available parking spot? Rent it and make some money!</p>
                        </a>
                    </div>
                </section>



            </div>
        </div>
    </div>




    </br>
    </br>
    </br>
    </br>
    </br>
    </br>
    </br>



    <footer>
        <section class=""footer-email-signup max-1");
                WriteLiteral("350\">\r\n            <div class=\"warpper\">\r\n                <canvas id=\"myCanvas\" width=\"700\" height=\"150\"></canvas>\r\n            </div>\r\n        </section>\r\n    </footer>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4522, 464, true);
            WriteLiteral(@"
</html>
<script>
    function CreateText() {
        var canvas = document.getElementById(""myCanvas"");
        var canvasContext = canvas.getContext(""2d"");
        var y = 100;
        var x = 80;
        canvasContext.font = 'bold 58pt UniversBoldCondensed';//sets font style, size and type
        canvasContext.fillStyle = 'Black';//sets font color
        canvasContext.fillText(""Parking For All!"", x, y);//sets text to be rendered
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KeePark.Data.GeneralUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
