#pragma checksum "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cf1898086b6f8f27da7cab78c624201cfe70a98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_Index), @"mvc.1.0.view", @"/Views/City/Index.cshtml")]
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
#line 1 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using EmployeeG6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using EmployeeG6.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using EmployeeG6.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using EmployeeG6.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using EmployeeG6.Models.ViewModels.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using EmployeeG6.Resources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf1898086b6f8f27da7cab78c624201cfe70a98", @"/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ce1c4bc1748be81713e44163430a2867b7de763", @"/Views/_ViewImports.cshtml")]
    public class Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<City>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm mx-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
  
    ViewData["Title"] = SharedLocalizer["Page"] + " " + SharedLocalizer["Cities"];
    var index = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom\">\r\n    <h1 class=\"h2\">");
#nullable restore
#line 9 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
              Write(SharedLocalizer["Cities"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"btn-toolbar mb-2 mb-md-0\">\r\n        <div class=\"btn-group mr-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf1898086b6f8f27da7cab78c624201cfe70a986423", async() => {
                WriteLiteral("<i class=\"bi bi-plus-circle\"></i>&nbsp; ");
#nullable restore
#line 12 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                                                                                                                            Write(SharedLocalizer["Create.New"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""table-responsive"">
    <table class=""table table-striped table-sm"">
        <thead>
            <tr>
                <th style=""width:5%"">#</th>
                <th style=""width:30%"">
                    ");
#nullable restore
#line 22 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width:50%\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th style=\"width:15%\"></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 1239, "\"", 1256, 2);
            WriteAttributeValue("", 1244, "row_", 1244, 4, true);
#nullable restore
#line 33 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
WriteAttributeValue("", 1248, item.Id, 1248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                    Write(index++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"btn-group\" role=\"group\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cf1898086b6f8f27da7cab78c624201cfe70a9811367", async() => {
                WriteLiteral(" <i class=\"bi bi-pencil-square\"></i>");
#nullable restore
#line 46 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                                                                                                  Write(SharedLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 45 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-sm btn-danger mx-1\" onClick=Delete(\'/City/Delete/");
#nullable restore
#line 47 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\'#row_");
#nullable restore
#line 47 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                                                                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\')> <i class=\"bi bi-trash-fill\"></i>");
#nullable restore
#line 47 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
                                                                                                                                                                         Write(SharedLocalizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Ahmed\source\repos\EmployeeG6 - Copy\EmployeeG6\Views\City\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResources> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
