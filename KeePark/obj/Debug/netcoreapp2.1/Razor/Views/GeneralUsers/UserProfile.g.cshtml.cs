#pragma checksum "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c299bc0d98e70dd87b2992a46ea8a1defaeda6f"
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
#line 1 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark;

#line default
#line hidden
#line 2 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c299bc0d98e70dd87b2992a46ea8a1defaeda6f", @"/Views/GeneralUsers/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_GeneralUsers_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KeePark.Data.GeneralUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/userstyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "UserProfile";

#line default
#line hidden
            BeginContext(120, 482, true);
            WriteLiteral(@"
<style>
    .fontuse {
        text-shadow: 1px 1px #808080;
    }

    .multiple-columns {
        padding: 30px;
        column-count: 4;
        column-gap: 20px;
        column-rule-style: solid;
        font-size: small;
    }

    #border-radius {
        border-radius: 15px 15px 50px 50px;
        background: #EEEEEE;
        padding: 500px, 300px;
        width: 730px;
        height: 200px;
    }
</style>
<!DOCTYPE html>
<html lang=""en"">



");
            EndContext();
            BeginContext(602, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9485cb49664bbf9ddb43c0f26677ca", async() => {
                BeginContext(608, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(614, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "55bbb492f0094939a4d9ec8633d7d8c5", async() => {
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
                BeginContext(697, 106, true);
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
            BeginContext(810, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(812, 3005, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22b51f88ee054081a57f484d8786a3af", async() => {
                BeginContext(818, 232, true);
                WriteLiteral("\r\n    <div class=\"jumbotron text-center\">\r\n        <div class=\"section-title\">\r\n            <h1>ACCOUNT</h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n");
                EndContext();
#line 50 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                 foreach (var item in Model)
                {
                    if (item.UserName == User.Identity.Name)
                    {

#line default
#line hidden
                BeginContext(1200, 71, true);
                WriteLiteral("                        <h5 class=\"name\">\r\n                            ");
                EndContext();
                BeginContext(1272, 44, false);
#line 55 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1316, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1347, 43, false);
#line 56 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1390, 33, true);
                WriteLiteral("\r\n                        </h5>\r\n");
                EndContext();
                BeginContext(1427, 41, true);
                WriteLiteral("                        <p class=\"email\">");
                EndContext();
                BeginContext(1469, 18, false);
#line 60 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                    Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1487, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(1495, 42, true);
                WriteLiteral("                        <p class=\"phone\"> ");
                EndContext();
                BeginContext(1538, 46, false);
#line 62 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(1584, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 63 "C:\Users\avivn\Documents\Computer-Science\שנה ב\סימסטר ג\KeePark\KeePark\Views\GeneralUsers\UserProfile.cshtml"
                    }
                }

#line default
#line hidden
                BeginContext(1632, 2178, true);
                WriteLiteral(@"
                <a id=""my_reservations"" href=""/ReserveSpots/Index"">Reservation History</a>
                <br />
                <a id=""future_orders"" href=""/ReserveSpots/FutureOrders"">My Future Orders</a>
                <br />
                <a id=""rent_site"" href=""/ParkingSpots/Create"">Rent Your Site</a>
                <br />
                <a id=""edit_details"" href=""/Identity/Account/Manage"">Edit Details</a>







            </div>
            <div class=""col-sm-8"">
                <h5>Order History</h5>

                <canvas id=""myCanvas"" width=""730"" height=""70""></canvas>

                <script>
                    var c = document.getElementById(""myCanvas"");
                    var ctx = c.getContext(""2d"");

                    // Create gradient
                    var grd = ctx.createLinearGradient(0, 0, 900, 0);
                    grd.addColorStop(0, ""#EEEEEE"");

                    // Fill with gradient
                    ctx.fillStyle = grd;
            ");
                WriteLiteral(@"        ctx.fillRect(10, 10, 950, 80);
                </script><br />


                <section>
                    <div class=""multiple-columns"" id=""border-radius"">
                        <h1 class=""fontuse"">MY ORDER HISTORY</h1>
                        <p>look which spots you already visited!<br /><br /><br /></p>

                        <h1 class=""fontuse"">MY FUTURE ORDERS</h1>
                        <p>Have a reservation? vie the details of your order</p>

                        <h1 class=""fontuse"">RENT MY SPOT</h1>
                        <p>Have an available parking spot? Rent it and make some money!</p>
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
        <section class=""footer-email-signup max-1350"">
            <div class=""jumbotron text-center"" style=""background-color:#ffffff"">
                <div class=""warpper""");
                WriteLiteral(">\r\n                    <h4>DON\'T MISS OUT!</h4>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </footer>\r\n\r\n");
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
            BeginContext(3817, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KeePark.Data.GeneralUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
