#pragma checksum "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240d3c0f0ca2535bb65b68e7116a2257664ccd27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UserViewRazorPages.Pages.AdminPages.UserManagement.Pages_AdminPages_UserManagement_UserReportManagement), @"mvc.1.0.razor-page", @"/Pages/AdminPages/UserManagement/UserReportManagement.cshtml")]
namespace UserViewRazorPages.Pages.AdminPages.UserManagement
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
#line 1 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\_ViewImports.cshtml"
using UserViewRazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240d3c0f0ca2535bb65b68e7116a2257664ccd27", @"/Pages/AdminPages/UserManagement/UserReportManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e37e08e62cc9b4870a3c8554ddf746023cbf07", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_AdminPages_UserManagement_UserReportManagement : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Deny", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
  
    ViewData["Title"] = "Edit Family Details";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
 if (TempData["notification"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">");
#nullable restore
#line 9 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                             Write(TempData["notification"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].DateReported));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].Reporter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
 foreach (var item in Model.AccountReport) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 36 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 39 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateReported));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 42 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 45 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reporter.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 48 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                     switch (item.StatusId)
                    {
                        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>Processing</a>\n");
#nullable restore
#line 52 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                            break;
                        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"color:limegreen\">Accepted </a>\n");
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                            break;
                        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"color:red\">Rejected </a>\n");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                            break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n");
#nullable restore
#line 61 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                 if (item.StatusId == 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240d3c0f0ca2535bb65b68e7116a2257664ccd2711006", async() => {
                WriteLiteral("Accept");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                                             WriteLiteral(item.UserId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240d3c0f0ca2535bb65b68e7116a2257664ccd2713257", async() => {
                WriteLiteral("Deny");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n                    </td>\n");
#nullable restore
#line 66 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n");
#nullable restore
#line 68 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\AdminPages\UserManagement\UserReportManagement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewRazorPages.Pages.AdminPages.UserManagement.UserReportManagementModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.AdminPages.UserManagement.UserReportManagementModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.AdminPages.UserManagement.UserReportManagementModel>)PageContext?.ViewData;
        public UserViewRazorPages.Pages.AdminPages.UserManagement.UserReportManagementModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
