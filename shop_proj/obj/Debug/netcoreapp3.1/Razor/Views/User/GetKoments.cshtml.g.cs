#pragma checksum "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62775143afd0facfa4ceb93b8b54bb7a8c056ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetKoments), @"mvc.1.0.view", @"/Views/User/GetKoments.cshtml")]
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
#line 1 "F:\univer\asp\shop_proj\shop_proj\Views\_ViewImports.cshtml"
using shop_proj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\univer\asp\shop_proj\shop_proj\Views\_ViewImports.cshtml"
using shop_proj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62775143afd0facfa4ceb93b8b54bb7a8c056ca3", @"/Views/User/GetKoments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d2a2b0e41e553517f8c2fd49101f0ca93b0b7ab", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetKoments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<shop_proj.Models.Tovar>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\" id=\"komm\">\r\n");
#nullable restore
#line 3 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
     foreach (var kom in Model.Komentars)
    {
        string t = "#demo" + kom.Id.ToString();
        string t1 = "demo" + kom.Id.ToString();
        string c = "ans" + kom.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"komans \">\r\n            <div class=\"row\">\r\n                <Button data-toggle=\"collapse\" data-target=");
#nullable restore
#line 10 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
                                                      Write(t);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"col col-lg-1 col-md-1 butkom \">+</Button>\r\n                <h6 class=\"col col-lg-11 col-md-11\">");
#nullable restore
#line 11 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
                                               Write(kom.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("id", " id=", 522, "", 529, 1);
#nullable restore
#line 13 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
WriteAttributeValue("", 526, t1, 526, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse col col-lg-12 col-md-12\" style=\"padding-right:20px;\">\r\n                <div class=\"row\">\r\n                    <div class=\"col col-lg-1 col-md-1  \"></div>\r\n                    <input type=\"text\" class=\" col col-lg-9 col-md-9 input1\"");
            BeginWriteAttribute("id", " id=", 777, "", 783, 1);
#nullable restore
#line 16 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
WriteAttributeValue("", 781, c, 781, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> <input type=\"button\" value=\"Відповісти\"");
            BeginWriteAttribute("id", " id=", 826, "", 837, 1);
#nullable restore
#line 16 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
WriteAttributeValue("", 830, kom.Id, 830, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col col-lg-2 col-md-2 butkom2 addAns\" />\r\n                </div>\r\n                <div id=\"answer\" >\r\n");
#nullable restore
#line 19 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
                     foreach (var ans in kom.Answers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row \">\r\n                            <div class=\"col col-lg-1 col-md-1  \" style=\"text-align:right;\">-</div>\r\n\r\n                            <div class=\"col col-lg-10 col-md-10  \">");
#nullable restore
#line 23 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
                                                              Write(ans.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n");
#nullable restore
#line 25 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62775143afd0facfa4ceb93b8b54bb7a8c056ca37592", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62775143afd0facfa4ceb93b8b54bb7a8c056ca38635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
  
        <script type=""text/javascript"">
        $(function () {




            $('.addAns').bind('click', function () {
                 var idr = $(this).attr(""id"");
                 var text = ""#ans"" + idr;
               var text1 = $(text).val();

               var data = {
                   UserId: ""rr"",
                   KomentarId: parseInt(idr),
                   Text: text1
                 };
                 alert(data.KomentarId);
                  $.ajax({
                    type: 'POST',
                    url: '");
#nullable restore
#line 53 "F:\univer\asp\shop_proj\shop_proj\Views\User\GetKoments.cshtml"
                     Write(Url.Action("AddAnswer", "User"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    data: JSON.stringify(data),
                    //dataType: 'JSON',
                    contentType: ""application/json"",
                    success: function (data) {
                        $('#answer').replaceWith(data);
                    },
                    error: function (passParams) {
                        console.log(""Error is "" + passParams);
                    }
                })

            })

    })


        </script>
   

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<shop_proj.Models.Tovar> Html { get; private set; }
    }
}
#pragma warning restore 1591
