#pragma checksum "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ffd3af7ae293104d81a47b58894547277cd835993d16d3e8bdf7f6116dfa9509"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_DoctorFront_Details), @"mvc.1.0.view", @"/Views/DoctorFront/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ffd3af7ae293104d81a47b58894547277cd835993d16d3e8bdf7f6116dfa9509", @"/Views/DoctorFront/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2fbc8c36018767507f99ab787e8359e0a39680f8ffaeee723494ab82520b1d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_DoctorFront_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
       HealthAppFrontend.Models.RichDoctorFront

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>RichDoctorFront</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 14 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 17 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 20 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.firstname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 23 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.firstname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 26 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.lastname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 29 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.lastname)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 32 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.birthdate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 35 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.birthdate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 38 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.career)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 41 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.career)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 44 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.graduation_date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 47 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.graduation_date)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 50 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.phone_number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 53 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.phone_number)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 56 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 59 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 62 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.field)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 65 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.field)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 68 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.specialty)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 71 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.specialty)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 74 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 77 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 80 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.center)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 83 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.center)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 86 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.centerAddress)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 89 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.centerAddress)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            Write(
#nullable restore
#line 92 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayNameFor(model => model.centerPhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            Write(
#nullable restore
#line 95 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
             Html.DisplayFor(model => model.centerPhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            Write(
#nullable restore
#line 100 "C:\Home\Cоре MVC Dapper\HealthApp_NetCore-main\HealthAppFrontend\Views\DoctorFront\Details.cshtml"
     Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd3af7ae293104d81a47b58894547277cd835993d16d3e8bdf7f6116dfa950914906", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthAppFrontend.Models.RichDoctorFront> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591