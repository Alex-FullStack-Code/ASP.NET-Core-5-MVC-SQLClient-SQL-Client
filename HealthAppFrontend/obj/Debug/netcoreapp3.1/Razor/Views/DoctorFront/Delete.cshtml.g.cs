#pragma checksum "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "91f645d880837241fbacacb4ce843c7cefd2d3f11d5fa1a1328efae53bf2b47d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_DoctorFront_Delete), @"mvc.1.0.view", @"/Views/DoctorFront/Delete.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\_ViewImports.cshtml"
using HealthAppFrontend

#nullable disable
    ;
#nullable restore
#line 2 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\_ViewImports.cshtml"
using HealthAppFrontend.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"91f645d880837241fbacacb4ce843c7cefd2d3f11d5fa1a1328efae53bf2b47d", @"/Views/DoctorFront/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2fbc8c36018767507f99ab787e8359e0a39680f8ffaeee723494ab82520b1d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_DoctorFront_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
       HealthAppFrontend.Models.DoctorFront

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>DoctorFront</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 15 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 18 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 21 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.firstname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 24 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.firstname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 27 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.lastname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 30 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.lastname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 33 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.birthdate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 36 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.birthdate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 39 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.graduation_date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 42 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.graduation_date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 45 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.phone_number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 48 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.phone_number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 51 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 54 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 57 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.specialty)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 60 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.specialty)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 63 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayNameFor(model => model.center)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 66 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Delete.cshtml"
             Html.DisplayFor(model => model.center)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91f645d880837241fbacacb4ce843c7cefd2d3f11d5fa1a1328efae53bf2b47d11464", async() => {
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91f645d880837241fbacacb4ce843c7cefd2d3f11d5fa1a1328efae53bf2b47d11832", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthAppFrontend.Models.DoctorFront> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
