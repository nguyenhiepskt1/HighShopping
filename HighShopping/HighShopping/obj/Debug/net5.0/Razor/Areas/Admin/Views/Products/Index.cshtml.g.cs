#pragma checksum "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5523e3750d187cd8d1e65d31dd57edd3144371d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\_ViewImports.cshtml"
using HighShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\_ViewImports.cshtml"
using HighShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5523e3750d187cd8d1e65d31dd57edd3144371d", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd76b98747452278ab9476e28eca733e755a037", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-target", "/admin/products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::HighShopping.Infrastructure.PaginationTagHelper __HighShopping_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Quản lý sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sản phẩm</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5523e3750d187cd8d1e65d31dd57edd3144371d4296", async() => {
                WriteLiteral("Thêm sản phẩm");
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
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Tên sản phẩm
            </th>
            <th>
                Giá
            </th>
            <th>
                Danh mục
            </th>
            <th>
                Hình ảnh
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                hình ảnh\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Sửa", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Chi tiết", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |                \r\n                ");
#nullable restore
#line 48 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.ActionLink("Xóa", "Delete", new { id = item.Id }, new { onclick = "return confirm('Bạn có chắc chắn muốn xóa?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"d-flex w-100 justify-content-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pagination", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5523e3750d187cd8d1e65d31dd57edd3144371d8551", async() => {
            }
            );
            __HighShopping_Infrastructure_PaginationTagHelper = CreateTagHelper<global::HighShopping.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__HighShopping_Infrastructure_PaginationTagHelper);
#nullable restore
#line 56 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
__HighShopping_Infrastructure_PaginationTagHelper.PageCount = ViewBag.TotalPages;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __HighShopping_Infrastructure_PaginationTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __HighShopping_Infrastructure_PaginationTagHelper.PageTarget = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 56 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
__HighShopping_Infrastructure_PaginationTagHelper.PageNumber = ViewBag.PageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-number", __HighShopping_Infrastructure_PaginationTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 56 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Products\Index.cshtml"
__HighShopping_Infrastructure_PaginationTagHelper.PageRange = ViewBag.PageRange;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-range", __HighShopping_Infrastructure_PaginationTagHelper.PageRange, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
