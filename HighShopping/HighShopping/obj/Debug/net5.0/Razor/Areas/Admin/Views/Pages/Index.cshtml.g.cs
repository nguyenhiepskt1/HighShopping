#pragma checksum "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f62c0ff09dc3b15dacfbeceb1c802a46e2f167ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pages_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f62c0ff09dc3b15dacfbeceb1c802a46e2f167ec", @"/Areas/Admin/Views/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e530b2997ed0d2455b301dd22915d6ded0a2114f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Pages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Page>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f62c0ff09dc3b15dacfbeceb1c802a46e2f167ec3826", async() => {
                WriteLiteral("Create New");
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
<table class=""table sorting"" id=""pages"">
    <thead>
        <tr class=""home"">
            <th>
                Tiêu đề
            </th>
            <th>
                URL
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 474, "\"", 490, 2);
            WriteAttributeValue("", 479, "id_", 479, 3, true);
#nullable restore
#line 27 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
WriteAttributeValue("", 482, item.Id, 482, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 491, "\"", 509, 1);
#nullable restore
#line 27 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
WriteAttributeValue("", 499, item.Slug, 499, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
               Write(item.Slug);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 36 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
#nullable restore
#line 37 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
                     if (item.Slug != "home")
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { onclick = "return confirm('Bạn có chắc chắn muốn xóa?');" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
                                                                                                                                                     
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\nguye\Desktop\c5\HighShoppingProject\HighShopping\HighShopping\Areas\Admin\Views\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //Jquery
        $(""table#pages tbody"").sortable({
            items: ""tr:not(.home)"",
            placeholder: ""ui-state-highlight"",
            update: function () {
                let ids = $(""table#pages tbody"").sortable(""serialize"");
                let url = ""/admin/pages/reorder"";

                //Ajax
                $.post(url, ids, function () { });
            }                     
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Page>> Html { get; private set; }
    }
}
#pragma warning restore 1591
