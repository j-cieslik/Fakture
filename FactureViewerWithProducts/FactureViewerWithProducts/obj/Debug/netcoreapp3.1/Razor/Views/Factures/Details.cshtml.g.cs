#pragma checksum "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a79f0dc8f609ed5927d1dc9a632c0da0ec1c4ac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factures_Details), @"mvc.1.0.view", @"/Views/Factures/Details.cshtml")]
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
#line 1 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\_ViewImports.cshtml"
using FactureViewerWithProducts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\_ViewImports.cshtml"
using FactureViewerWithProducts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79f0dc8f609ed5927d1dc9a632c0da0ec1c4ac4", @"/Views/Factures/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b0f3134ed714786cb1069172820157f8fdd688d", @"/Views/_ViewImports.cshtml")]
    public class Views_Factures_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactureViewerWithProducts.Dtos.FactureDetailsDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FactureProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Facture</h3>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n<h5 style=\"margin-bottom: 10px;\">Products: </h5>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79f0dc8f609ed5927d1dc9a632c0da0ec1c4ac48018", async() => {
                WriteLiteral("Add New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                                                              WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n</p>\r\n\r\n</div>\r\n<dd class=\"col-sm-10\">\r\n\t<table class=\"table\">\r\n\t\t\t<tr>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 48 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                       Write(Html.DisplayNameFor(model => Model.Product[0].WareName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 51 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                       Write(Html.DisplayNameFor(model => Model.Product[0].Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 54 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                       Write(Html.DisplayNameFor(model => Model.Product[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 57 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                       Write(Html.DisplayNameFor(model => Model.Product[0].Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</th>\r\n\t\t\t\t\t<th></th>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 61 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
             foreach (var item in Model.Product)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 65 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                   Write(Html.DisplayFor(model => item.WareName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 68 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                   Write(Html.DisplayFor(model => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 71 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                   Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 74 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                   Write(Convert.ToDouble(item.Tax).ToString("P1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1965, "\"", 2073, 2);
            WriteAttributeValue("", 1972, "/FactureProducts/Delete/", 1972, 24, true);
#nullable restore
#line 77 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
WriteAttributeValue("", 1996, item.FactureProducts.Where(t => t.FactureId == Model.Id).FirstOrDefault().Id, 1996, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n          </td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 80 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</table>\r\n\t<div style=\"padding: 10px\">\r\n\t\t<span style=\"font-weight: bold;\">Razem(brutto):  </span>\r\n\t\t<span>");
#nullable restore
#line 84 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
         Write(Html.DisplayFor(model => model.PriceBrutto));

#line default
#line hidden
#nullable disable
            WriteLiteral(" PLN</span>\r\n\t</div>\r\n\r\n\t<div style=\"padding: 10px\">\r\n\t\t<span style=\"font-weight: bold\">Razem(netto):  </span>\r\n\t\t<span>");
#nullable restore
#line 89 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
         Write(Html.DisplayFor(model => model.PriceNetto));

#line default
#line hidden
#nullable disable
            WriteLiteral(" PLN</span>\r\n\t</div>\r\n</dd>\r\n\r\n\r\n<div style=\"margin top: 20px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79f0dc8f609ed5927d1dc9a632c0da0ec1c4ac415854", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\Kuba\Documents\dokumenty\programing\web\Zadanie\FactureViewerWithProducts\FactureViewerWithProducts\Views\Factures\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79f0dc8f609ed5927d1dc9a632c0da0ec1c4ac418056", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FactureViewerWithProducts.Dtos.FactureDetailsDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
