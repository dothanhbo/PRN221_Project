#pragma checksum "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8fef91d39a9e17fea9f60f2ace72d1ec36671a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UserViewRazorPages.Pages.Bodt.Pages_Bodt_Details), @"mvc.1.0.razor-page", @"/Pages/Bodt/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8fef91d39a9e17fea9f60f2ace72d1ec36671a", @"/Pages/Bodt/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e37e08e62cc9b4870a3c8554ddf746023cbf07", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Bodt_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Bodt/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Bodt/MainPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>User</h4>\n    <hr />\n    <img");
            BeginWriteAttribute("src", " src=\"", 186, "\"", 208, 2);
            WriteAttributeValue("", 192, "/", 192, 1, true);
#nullable restore
#line 13 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
WriteAttributeValue("", 193, Model.User.Img, 193, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"User Image\" style=\"width:200px; height:250px\">\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 16 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 19 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 25 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 28 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n");
#nullable restore
#line 31 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
             if (Model.User.Gender == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>Male</a>\n");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
            }
            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a>Female</a>\n");
#nullable restore
#line 36 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 40 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 43 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 46 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 49 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 52 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 61 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n");
#nullable restore
#line 64 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
     if (Model.User.UserId != Model.UserId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8fef91d39a9e17fea9f60f2ace72d1ec36671a10377", async() => {
                WriteLiteral("Request for delete");
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
#line 67 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
                                         WriteLiteral(Model.User.UserId);

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
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 69 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Bodt\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8fef91d39a9e17fea9f60f2ace72d1ec36671a12845", async() => {
                WriteLiteral("Back to MainPage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewRazorPages.Pages.Bodt.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.Bodt.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.Bodt.DetailsModel>)PageContext?.ViewData;
        public UserViewRazorPages.Pages.Bodt.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
