#pragma checksum "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "befa24eb6ea98b0a591677d738ae8c2eb4be2ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actions_Index), @"mvc.1.0.view", @"/Views/Actions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Actions/Index.cshtml", typeof(AspNetCore.Views_Actions_Index))]
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
#line 1 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\_ViewImports.cshtml"
using BolsaDeValores;

#line default
#line hidden
#line 2 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\_ViewImports.cshtml"
using BolsaDeValores.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"befa24eb6ea98b0a591677d738ae8c2eb4be2ba0", @"/Views/Actions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1dec5359cb5b05e62a72fb3cafef476cab133f", @"/Views/_ViewImports.cshtml")]
    public class Views_Actions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BolsaDeValores.Models.Actions>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
  
    ViewData["Title"] = "Ações à venda";

#line default
#line hidden
            BeginContext(102, 28, true);
            WriteLiteral("\r\n<h2>Ações à venda</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
 if (Program.currentClient.Admin)
{

#line default
#line hidden
            BeginContext(168, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(185, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4153ec319cea4581b0716080d887111e", async() => {
                BeginContext(208, 19, true);
                WriteLiteral("Cadastrar nova ação");
                EndContext();
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
            EndContext();
            BeginContext(231, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
}

#line default
#line hidden
            BeginContext(246, 461, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
               Nome
            </th>
            <th>
               Dono
            </th>
            <th>
                Quantidade
            </th>
            <th>
                Preço unitário
            </th>
            <th>
                Quantidade mínima de compra
            </th>            
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 38 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(739, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(788, 45, false);
#line 41 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCategory));

#line default
#line hidden
            EndContext();
            BeginContext(833, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(889, 42, false);
#line 44 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdOwner));

#line default
#line hidden
            EndContext();
            BeginContext(931, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(987, 43, false);
#line 47 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1086, 45, false);
#line 50 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PriceQuant));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1187, 47, false);
#line 53 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantMinSell));

#line default
#line hidden
            EndContext();
            BeginContext(1234, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 56 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
                 if (item.Status)
                {

#line default
#line hidden
            BeginContext(1327, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1347, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cbb3502f60a4d19bca9b6548a3d9c44", async() => {
                BeginContext(1397, 12, true);
                WriteLiteral("Comprar ação");
                EndContext();
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
#line 58 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
                                                WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1413, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
                                                                                  
                }

#line default
#line hidden
            BeginContext(1518, 38, true);
            WriteLiteral("            </td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\William Menegaldi\Desktop\BolsaDeValores\BolsaDeValores\Views\Actions\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1559, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BolsaDeValores.Models.Actions>> Html { get; private set; }
    }
}
#pragma warning restore 1591