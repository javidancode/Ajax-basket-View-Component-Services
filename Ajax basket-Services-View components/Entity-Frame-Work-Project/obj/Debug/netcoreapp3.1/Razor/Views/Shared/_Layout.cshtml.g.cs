#pragma checksum "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d84fcbb47f7936264caadca8febd5d12be836cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\_ViewImports.cshtml"
using Entity_Frame_Work_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\_ViewImports.cshtml"
using Entity_Frame_Work_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\_ViewImports.cshtml"
using Entity_Frame_Work_Project.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d84fcbb47f7936264caadca8febd5d12be836cd", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54a638111d37f88a21eeaacedc428661bd2dbbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/owlcarousel/owl.carousel.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/owlcarousel/owl.theme.default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/owlcarousel/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d84fcbb47f7936264caadca8febd5d12be836cd5647", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">

    <link rel=""icon"" href=""img/favicon.png"" sizes=""192x192"" />
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
          integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d84fcbb47f7936264caadca8febd5d12be836cd6389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d84fcbb47f7936264caadca8febd5d12be836cd7568", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/11.6.1/sweetalert2.min.css"" integrity=""sha512-y6TjkITSFkRB9mZmDaJyDOsyHsYvOo3Np3iAKe02HgMDP4L4vbmbhlzNpbbIVC1x+GUUHvepTd1BKDe4kC6kNg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d84fcbb47f7936264caadca8febd5d12be836cd9041", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Entity_Frame_Work_Project</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d84fcbb47f7936264caadca8febd5d12be836cd11248", async() => {
                WriteLiteral("\r\n\r\n    <!-- HEADER START -->\r\n\r\n    ");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n    <!-- HEADER END -->\r\n\r\n    ");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <!-- FOOTER START -->

    <footer>
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item"">
                        <h6>CUSTOMER SERVICE</h6>
                        <ul class=""list-unstyled mt-4"">
                            <li><a class=""text-black-50""");
                BeginWriteAttribute("href", " href=\"", 1732, "\"", 1739, 0);
                EndWriteAttribute();
                WriteLiteral(">Help & Contact Us</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 1825, "\"", 1832, 0);
                EndWriteAttribute();
                WriteLiteral(">Returns & Refunds</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 1918, "\"", 1925, 0);
                EndWriteAttribute();
                WriteLiteral(">Online Stores</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 2007, "\"", 2014, 0);
                EndWriteAttribute();
                WriteLiteral(@">Terms & Conditions</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item"">
                        <h6>COMPANY</h6>
                        <ul class=""list-unstyled mt-4"">
                            <li><a class=""text-black-50""");
                BeginWriteAttribute("href", " href=\"", 2372, "\"", 2379, 0);
                EndWriteAttribute();
                WriteLiteral(">About Us</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 2456, "\"", 2463, 0);
                EndWriteAttribute();
                WriteLiteral(">Blog</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 2536, "\"", 2543, 0);
                EndWriteAttribute();
                WriteLiteral(">Order Tracking</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 2626, "\"", 2633, 0);
                EndWriteAttribute();
                WriteLiteral(">FAQ Page</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 2710, "\"", 2717, 0);
                EndWriteAttribute();
                WriteLiteral(">Contact Us</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 2796, "\"", 2803, 0);
                EndWriteAttribute();
                WriteLiteral(@">Login</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item"">
                        <h6>SOCIAL MEDIA</h6>
                        <ul class=""list-unstyled mt-4"">
                            <li><a class=""text-black-50""");
                BeginWriteAttribute("href", " href=\"", 3153, "\"", 3160, 0);
                EndWriteAttribute();
                WriteLiteral(">Twitter</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 3236, "\"", 3243, 0);
                EndWriteAttribute();
                WriteLiteral(">Instagram</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 3321, "\"", 3328, 0);
                EndWriteAttribute();
                WriteLiteral(">Tumblr</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 3403, "\"", 3410, 0);
                EndWriteAttribute();
                WriteLiteral(@">Pinterest</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-3"">
                    <div class=""item"">
                        <h6>ARCHIVE</h6>
                        <ul class=""list-unstyled mt-4"">
                            <li><a class=""text-black-50""");
                BeginWriteAttribute("href", " href=\"", 3759, "\"", 3766, 0);
                EndWriteAttribute();
                WriteLiteral(">Designer Shoes</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 3849, "\"", 3856, 0);
                EndWriteAttribute();
                WriteLiteral(">Gallery</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 3932, "\"", 3939, 0);
                EndWriteAttribute();
                WriteLiteral(">Pricing</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 4015, "\"", 4022, 0);
                EndWriteAttribute();
                WriteLiteral(">Feature Index</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 4104, "\"", 4111, 0);
                EndWriteAttribute();
                WriteLiteral(">Login</a></li>\r\n                            <li><a class=\"text-black-50\"");
                BeginWriteAttribute("href", " href=\"", 4185, "\"", 4192, 0);
                EndWriteAttribute();
                WriteLiteral(@">Help & Support</a></li>
                        </ul>
                    </div>
                </div>
            </div>

            <hr>

            <div class=""row py-2"">
                <div class="" col-lg-4 text-center text-lg-left"">
                    <p class=""text-black-50"">
                        Powered by <a class=""author text-muted""
                                      href=""https://www.bakhtiyar.az"">Bakhtiyar Shamilzada</a> 2020
                    </p>
                </div>
                <div class="" col-lg-4 text-center"">
                    <img src=""img/footer-bottom-1.png"" class=""fluid""");
                BeginWriteAttribute("alt", " alt=\"", 4830, "\"", 4836, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <div class="" col-lg-4 text-center text-lg-right mt-3 mt-lg-0"">
                    <a class=""text-black-50 mr-5""
                       href=""https://www.linkedin.com/in/bakhtiyar-shamilzada-145159185/"">LINKEDIN</a>
                    <a class=""text-black-50"" href=""https://www.facebook.com/shamilzada.bakhtiyar"">FACEBOOK</a>
                </div>
            </div>
        </div>
    </footer>

    <!-- FOOTER END -->

    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js""
            integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n""
            crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""
            integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo""
            crossorigin=""anonymous""></script>
    <script src=""https://stac");
                WriteLiteral(@"kpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""
            integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6""
            crossorigin=""anonymous""></script>
    <script src=""https://kit.fontawesome.com/e5e249fce2.js"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d84fcbb47f7936264caadca8febd5d12be836cd20150", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/11.6.1/sweetalert2.min.js"" integrity=""sha512-TZHwBGULaChdwt6/Y+eYLQZGLvuNdJV6ZlszDZAzczToJgjJtB/JEjxrethtTZMmvIuCGmzTgFXcOjNIP0zogg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""js/script.js""></script>

    ");
#nullable restore
#line 130 "C:\Users\ASUS\Desktop\Programming\Asp.net\Basket-task\Basket task\Entity-Frame-Work-Project\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
