#pragma checksum "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc337fd9750ca6c84cbeb5565719b24fb04c6f5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UserViewRazorPages.Pages.Hiepth.Events.Pages_Hiepth_Events_AddMember), @"mvc.1.0.razor-page", @"/Pages/Hiepth/Events/AddMember.cshtml")]
namespace UserViewRazorPages.Pages.Hiepth.Events
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc337fd9750ca6c84cbeb5565719b24fb04c6f5d", @"/Pages/Hiepth/Events/AddMember.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e37e08e62cc9b4870a3c8554ddf746023cbf07", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Hiepth_Events_AddMember : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DeleteMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
  
    ViewData["Title"] = "Add Member To Event";
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Event</h1>\n<div>\n<dl class=\"row\">\n    <dt class=\"col-sm-2\">\n        Event Name:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class=\"col-sm-2\">\n        Information:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 21 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.Information));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class=\"col-sm-2\">\n        Location:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 27 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class=\"col-sm-2\">\n        Creator:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.Creator.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class=\"col-sm-2\">\n        Start Date:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 39 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class=\"col-sm-2\">\n        End Date:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 45 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n    <dt class=\"col-sm-2\">\n        Status:\n    </dt>\n    <dd class=\"col-sm-10\">\n        ");
#nullable restore
#line 51 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
   Write(Html.DisplayFor(model => model.Event.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </dd>\n</dl>\n");
#nullable restore
#line 54 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
     if (Model.AddedUsers.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h3>Members</h3>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Gender</th>
                    <th scope=""col"">Phone Number</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 69 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                 foreach (var (index, item) in Model.AddedUsers.Select((item, i) => (i, item)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 72 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 73 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 74 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 75 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                         if (@item.Gender == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Male</td>\n");
#nullable restore
#line 78 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Female</td>\n");
#nullable restore
#line 82 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 83 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 85 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                             if (item.UserId != Model.LoginUserId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc337fd9750ca6c84cbeb5565719b24fb04c6f5d11221", async() => {
                WriteLiteral("\n                                    <input type=\"hidden\" name=\"eventId\"");
                BeginWriteAttribute("value", " value=\"", 2591, "\"", 2619, 1);
#nullable restore
#line 88 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
WriteAttributeValue("", 2599, Model.Event.EventId, 2599, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                    <input type=\"hidden\" name=\"index\"");
                BeginWriteAttribute("value", " value=\"", 2693, "\"", 2707, 1);
#nullable restore
#line 89 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
WriteAttributeValue("", 2701, index, 2701, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                    <button class=\"btn btn-danger\">Delete</button>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 92 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                    </tr>\n");
#nullable restore
#line 95 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc337fd9750ca6c84cbeb5565719b24fb04c6f5d14623", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"eventId\"");
                BeginWriteAttribute("value", " value=\"", 3053, "\"", 3081, 1);
#nullable restore
#line 99 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
WriteAttributeValue("", 3061, Model.Event.EventId, 3061, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <button class=\"btn btn-primary\">Add Members</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 102 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<hr/>\n");
#nullable restore
#line 105 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
 if (Model.Users.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <h3>Member list</h3>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Gender</th>
                    <th scope=""col"">Phone Number</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 121 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                 foreach (var item in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 124 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 125 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 126 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 127 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                         if (@item.Gender == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Male</td>\n");
#nullable restore
#line 130 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Female</td>\n");
#nullable restore
#line 134 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 135 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                       Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc337fd9750ca6c84cbeb5565719b24fb04c6f5d20309", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" name=\"eventId\"");
                BeginWriteAttribute("value", " value=\"", 4394, "\"", 4422, 1);
#nullable restore
#line 138 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
WriteAttributeValue("", 4402, Model.Event.EventId, 4402, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 4493, "\"", 4513, 1);
#nullable restore
#line 139 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
WriteAttributeValue("", 4501, item.UserId, 4501, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <button class=\"btn btn-primary\">Add</button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 144 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n");
#nullable restore
#line 148 "C:\Users\ADMIN\Desktop\PRN221_Project\Group1_SE1604_InteractiveFamilyTree\UserViewRazorPages\Pages\Hiepth\Events\AddMember.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewRazorPages.Pages.Hiepth.Events.AddMemberModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.Hiepth.Events.AddMemberModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UserViewRazorPages.Pages.Hiepth.Events.AddMemberModel>)PageContext?.ViewData;
        public UserViewRazorPages.Pages.Hiepth.Events.AddMemberModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591