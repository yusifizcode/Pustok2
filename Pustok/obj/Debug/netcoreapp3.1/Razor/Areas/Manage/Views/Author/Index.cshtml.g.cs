#pragma checksum "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f27e4c5a5f43e1a8211df6755e371ad14b14c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Author_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Author/Index.cshtml")]
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
#line 3 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f27e4c5a5f43e1a8211df6755e371ad14b14c9", @"/Areas/Manage/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e7b0aa6977cec3443560f4d49a2285efe14399", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 2 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-10 mx-auto"">
            <a class=""btn btn-primary"">Create</a>
        </div>
        <div class=""col-md-10 mx-auto"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">FullName</th>
                        <th scope=""col"">BirthDate</th>
                        <th scope=""col"">Books count</th>
                        <th scope=""col"">Actions</th>


                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 26 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
                     foreach (var auth in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 30 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
                           Write(auth.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
                           Write(auth.BirthDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
                           Write(auth.Books.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"btn btn-warning\">Edit</a>\r\n                                <a class=\"btn btn-danger\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Yusifiz\Desktop\AspPustok\ASP-PustokSite\Pustok\Areas\Manage\Views\Author\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
