#pragma checksum "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2c6e149aba5078faabea647fb321103fdc12254"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UserViewRazorPages.Pages.Bodt.Pages_Bodt_AccountReportList), @"mvc.1.0.razor-page", @"/Pages/Bodt/AccountReportList.cshtml")]
namespace UserViewRazorPages.Pages.Bodt
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2c6e149aba5078faabea647fb321103fdc12254", @"/Pages/Bodt/AccountReportList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e37e08e62cc9b4870a3c8554ddf746023cbf07", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Bodt_AccountReportList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
  
    ViewData["Title"] = "Account Report List";
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Account Report List</h1>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 12 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].DateReported));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountReport[0].Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 27 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
 foreach (var item in Model.AccountReport) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateReported));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 36 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n                <td>\n");
#nullable restore
#line 39 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
                     switch (item.StatusId)
                    {
                        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a>Processing</a>\n");
#nullable restore
#line 43 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
                            break;
                        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"color:limegreen\">Accepted </a>\n");
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
                            break;
                        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"color:red\">Rejected </a>\n");
#nullable restore
#line 49 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
                            break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n        </tr>\n");
#nullable restore
#line 53 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\AccountReportList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewRazorPages.Pages.Bodt.AccountReportListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.Bodt.AccountReportListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.Bodt.AccountReportListModel>)PageContext?.ViewData;
        public UserViewRazorPages.Pages.Bodt.AccountReportListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
