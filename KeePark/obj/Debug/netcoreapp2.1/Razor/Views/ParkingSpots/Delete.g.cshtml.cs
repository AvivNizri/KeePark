#pragma checksum "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7ac786f4c42c5a522ed3b68bae0fcc9c7b9047"
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
#line 1 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark;

#line default
#line hidden
#line 2 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\_ViewImports.cshtml"
using KeePark.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7ac786f4c42c5a522ed3b68bae0fcc9c7b9047", @"/Views/ParkingSpots/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b1e00afec4be47fa6467e2196b8f25b55ca0f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ParkingSpots_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeePark.Models.ParkingSpot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("190"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var photoPath = "~/SpotImages/" + (Model.filePath ?? "noimage.jpg");

#line default
#line hidden
            BeginContext(200, 487, true);
            WriteLiteral(@"<style>
    .mycard {
        size: 20rem;
    }

    .grid {
        display: grid;
        grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
        grid-gap: 150px;
        align-items: stretch;
    }
</style>

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ParkingSpot</h4>
    <hr />
    <div class=""grid"">
        <div class=""mycard"">
            <dl class=""dl-horizontal"">
                <dt>
                    ");
            EndContext();
            BeginContext(688, 44, false);
#line 31 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(732, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(800, 40, false);
#line 34 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SpotName));

#line default
#line hidden
            EndContext();
            BeginContext(840, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(908, 43, false);
#line 37 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(951, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1019, 39, false);
#line 40 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1126, 41, false);
#line 43 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1235, 37, false);
#line 46 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1340, 51, false);
#line 49 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SpotDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1459, 47, false);
#line 52 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SpotDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 58, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            \r\n");
            EndContext();
#line 56 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
                  if (User.IsInRole("Administrator"))
                   {

#line default
#line hidden
            BeginContext(1641, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1665, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bb8822314f4431aa6e31b64206808d5", async() => {
                BeginContext(1691, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1721, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e64bbc8c95c4055b7733717adff3360", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
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
                BeginContext(1768, 120, true);
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1895, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
                       }
                   

#line default
#line hidden
            BeginContext(1945, 72, true);
            WriteLiteral("            \r\n        </div>\r\n\r\n        <div class=\"card\">\r\n            ");
            EndContext();
            BeginContext(2017, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea0afd64a44b4c88ad3a22de6e85ade1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
                               WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 68 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2113, 1794, true);
            WriteLiteral(@"
        </div>
    </div>
</div>


<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
    body {
        font-family: Arial, Helvetica, sans-serif;
    }

    /* The Modal (background) */
    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 100px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }

    /* Modal Content */
    .modal-content {
        position: relative;
        background-color: #fefefe;
        margin: auto;
        padding: 0;
        border: 1px solid #888;
        width: 40%;
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);");
            WriteLiteral(@"
        -webkit-animation-name: animatetop;
        -webkit-animation-duration: 0.4s;
        animation-name: animatetop;
        animation-duration: 0.4s
    }


    /* The Close Button */
    .close {
        color: white;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

        .close:hover,
        .close:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }

    .modal-header {
        padding: 2px 16px;
        background-color: #5cb85c;
        color: white;
    }

    .modal-body {
        padding: 1px 1px;
    }

    .modal-footer {
        padding: 1px 1px;
        background-color: #5cb85c;
        color: white;
    }
</style>
");
            EndContext();
            BeginContext(3907, 1827, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31a27ca3171843179bfbcdf8baf7ee59", async() => {
                BeginContext(3913, 371, true);
                WriteLiteral(@"
    <!-- The Modal for recomendation system -->
    <div id=""deleteModal"" class=""modal"">
        <!-- Modal content -->
        <div class=""modal-content"">

            <div class=""modal-header"">
                <h2 class=""heading-third section-title text-left"">Sorry </h2>
                <span id=""delClose"" class=""close"">&times;</span>
            </div>

");
                EndContext();
#line 153 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
             if (User.Identity.IsAuthenticated && !User.IsInRole("Administrator"))
            {

#line default
#line hidden
                BeginContext(4383, 937, true);
                WriteLiteral(@"                <script>
                    // Get the modal
                    var delete_modal = document.getElementById(""deleteModal"");
                    // Open the modal
                    delete_modal.style.display = ""block"";
                    // Get the <span> element that closes the modal
                    var span = document.getElementById(""delClose"");
                    // When the user clicks on <span> (x), close the modal
                    span.onclick = function () {
                        delete_modal.style.display = ""none"";
                    }
                    // When the user clicks anywhere outside of the modal, close it
                    window.onclick = function (event) {
                        if (event.target == delete_modal) {
                            delete_modal.style.display = ""none"";
                        }
                    }
                </script>
");
                EndContext();
#line 173 "C:\Users\taliamelikhov\Talia\KeePark\KeePark\Views\ParkingSpots\Delete.cshtml"
            }

#line default
#line hidden
                BeginContext(5335, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(5353, 323, true);
                WriteLiteral(@"                <div>
                                <p>
                                    In Order To Delete Your Spot
                                    <br />
                                    Contact With Our Customer Service KeePark@KeePark.com
                                </p>
                </div>
");
                EndContext();
                BeginContext(5695, 32, true);
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n\r\n");
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
