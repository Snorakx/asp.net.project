#pragma checksum "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38216d344486e66bf2ddc34fc0bc42f1f08a582d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\_ViewImports.cshtml"
using DotNetProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\_ViewImports.cshtml"
using DotNetProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38216d344486e66bf2ddc34fc0bc42f1f08a582d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d78ed2a19c57873cc12e8211501f79e700a983", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobsListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Jobs list</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38216d344486e66bf2ddc34fc0bc42f1f08a582d4498", async() => {
                WriteLiteral(@"
    <div class=""input-group mb-3"">
        <input type=""text"" class=""form-control"" name=""SearchString"">
        <div class=""input-group-append"">
            <button class=""btn btn-outline-secondary"" id=""button-addon2"" type=""submit"">Search</button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div id=\"success-alert\" class=\"alert alert-success\" style=\"display:none;\">Wooo, You have done it</div>\r\n    <div>\r\n        <div class=\"table table-sm table-striped table-bordered m-2\">\r\n            <div>\r\n");
#nullable restore
#line 19 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
                 foreach (var r in Model.Jobs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n\r\n                        <p>");
#nullable restore
#line 23 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
                      Write(r.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 24 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
                      Write(r.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p>");
#nullable restore
#line 25 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
                      Write(r.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 908, "\"", 1001, 14);
            WriteAttributeValue("", 918, "AddJobToFavourite(\'", 918, 19, true);
#nullable restore
#line 26 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 937, User.Identity.Name, 937, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 956, "\',", 956, 2, true);
            WriteAttributeValue(" ", 958, "\'", 959, 2, true);
#nullable restore
#line 26 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 960, r.Title, 960, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 968, "\',", 968, 2, true);
            WriteAttributeValue(" ", 970, "\'", 971, 2, true);
#nullable restore
#line 26 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 972, r.Category, 972, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 983, "\',", 983, 2, true);
#nullable restore
#line 26 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 985, r.Id, 985, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 990, ",", 990, 1, true);
            WriteAttributeValue(" ", 991, "\'", 992, 2, true);
#nullable restore
#line 26 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 993, r.Url, 993, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 999, "\')", 999, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Dodaj do ulubionych</button>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 29 "G:\aspDotNetProject\DotNetProject\DotNetProject\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">

    const AddJobToFavourite = async (userId, title, category, id, url) => {
                                const UserId = userId
                                const Title = title;
                                const Category = category;
                                const Id = id;
                                const Url = url;


                                const requestData = {
                                    UserId,
                                    Title,
                                    Category,
                                    Id,
                                    Url
                                }
                                const response = await fetch('/Api/Adding', {
                                    method: 'POST',
                                    headers: {
                                        'Content-type': 'application/json'
                     ");
            WriteLiteral(@"               },
                                    body: JSON.stringify(requestData),
                                });

                                const responseJson = await response.json();

                                if (responseJson.success) {
                                    console.log(""nice"")
                                }

                                return responseJson;

                            };

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobsListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
