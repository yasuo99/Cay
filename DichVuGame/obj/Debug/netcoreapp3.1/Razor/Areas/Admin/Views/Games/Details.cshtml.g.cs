#pragma checksum "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a1d7e2d1144ce4f0b06370f01cd9ccf812d1dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Games_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Games/Details.cshtml")]
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
#line 1 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\_ViewImports.cshtml"
using DichVuGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\_ViewImports.cshtml"
using DichVuGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a1d7e2d1144ce4f0b06370f01cd9ccf812d1dd", @"/Areas/Admin/Views/Games/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983c4a7f1991df620ced787059c0b171deaefb73", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DichVuGame.Models.ViewModels.GamesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/AdminHome/_CMSLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chi tiết</h1>\r\n\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.Gamename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.Gamename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.GamePoster));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 604, "\"", 632, 1);
#nullable restore
#line 24 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
WriteAttributeValue("", 610, Model.Game.GamePoster, 610, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\" />\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.GameDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.GameDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.Release));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.Release));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.Studio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.Studio.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.RentalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.RentalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.AvailableCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.AvailableCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Game.AvailableAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Game.AvailableAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a1d7e2d1144ce4f0b06370f01cd9ccf812d1dd11592", async() => {
                WriteLiteral("Chỉnh sửa");
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
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\Must save\WebGame_TMDT-20200701T023531Z-001\WebGame_TMDT\DichVuGame\Areas\Admin\Views\Games\Details.cshtml"
                                                                   WriteLiteral(Model.Game.ID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a1d7e2d1144ce4f0b06370f01cd9ccf812d1dd13898", async() => {
                WriteLiteral("Quay lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DichVuGame.Models.ViewModels.GamesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
