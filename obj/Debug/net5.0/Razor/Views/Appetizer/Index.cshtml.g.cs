#pragma checksum "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38ec765d58665feec6a28b085ed33b015b190e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appetizer_Index), @"mvc.1.0.view", @"/Views/Appetizer/Index.cshtml")]
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
#line 1 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\_ViewImports.cshtml"
using MyFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\_ViewImports.cshtml"
using MyFood.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
using MyFood.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ec765d58665feec6a28b085ed33b015b190e70", @"/Views/Appetizer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd04cb5c94b88746e44e1ce16cdc2e7a9da983a8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Appetizer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyFood.Models.ViewModels.Appetizer>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appetizer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("enter-list"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "appetizer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a onclick=""scrollToTop();"" class=""scrollTop"" ><i class=""fas fa-angle-double-up""></i></a>
<section class=""appetizer"">

    <div class=""container__categories"">


        <div class=""container__categories__heading"">
            <h1>List of Appetizers <i class=""fas fa-candy-cane""></i></h1>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec765d58665feec6a28b085ed33b015b190e706020", async() => {
                WriteLiteral("\r\n                <span></span>\r\n                <span></span>\r\n                <span></span>\r\n                <span></span>\r\n                Create\r\n                <i class=\"fas fa-folder-plus\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                \r\n        </div>\r\n\r\n        <div class=\"container__categories__list\">\r\n                \r\n");
#nullable restore
#line 30 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
              
                var Id = "";

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                 foreach (var a in Model)
                {
                    if (a.UserId == @ViewBag.userId) Id = @ViewBag.userId;
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                 if (Model.Any() && Id != "")
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                     foreach (var appetizer in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                         if (appetizer.UserId == @ViewBag.userId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"container__categories__title\">\r\n\r\n                                <div class=\"info\">\r\n                                    <h4>");
#nullable restore
#line 48 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                                   Write(appetizer.AppetizerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 49 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                                     for (var i = 0; i < @appetizer.EvaluationRating; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <label></label>\r\n");
#nullable restore
#line 52 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec765d58665feec6a28b085ed33b015b190e7010180", async() => {
                WriteLiteral(@"
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                    <span></span>
                                    Show
                                        <i class=""far fa-eye""></i>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                                                                                                        WriteLiteral(appetizer.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </div>\r\n");
#nullable restore
#line 64 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"else\">No appetizer created yet</p>\r\n");
#nullable restore
#line 70 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n        </div>\r\n\r\n\r\n        <div class=\"container__categories__buttons\">\r\n\r\n            <div class=\"btn back\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38ec765d58665feec6a28b085ed33b015b190e7014130", async() => {
                WriteLiteral("Back&nbsp<i class=\"fas fa-arrow-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n            \r\n    </div>\r\n    \r\n");
#nullable restore
#line 87 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
     if (TempData["success"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"toastr\" class=\"showToaster\" ><i class=\"fas fa-check\"></i> ");
#nullable restore
#line 89 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
                                                                      Write(TempData["success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 90 "C:\Users\pawel\OneDrive\Pulpit\MyFood\Views\Appetizer\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </section>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyFood.Models.ViewModels.Appetizer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
