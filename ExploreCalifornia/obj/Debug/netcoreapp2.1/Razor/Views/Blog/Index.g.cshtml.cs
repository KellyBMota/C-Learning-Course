#pragma checksum "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b16eaa4e7afd7c0de5c2e40f9c0adf4ed7528f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b16eaa4e7afd7c0de5c2e40f9c0adf4ed7528f9", @"/Views/Blog/Index.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExploreCalifornia.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 131, true);
            WriteLiteral("\r\n<h1>Explorer\'s Blog</h1>\r\n\r\n<p>\r\n    Below are a few of the latest posts from some of our explorers.\r\n</p>\r\n\r\n<p class=\"pager\">\r\n");
            EndContext();
#line 10 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
     if (ViewBag.HasPreviousPage)
    {

#line default
#line hidden
            BeginContext(224, 23, true);
            WriteLiteral("        <a class=\"prev\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 247, "\"", 320, 1);
#line 12 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
WriteAttributeValue("", 254, Url.Action("Index", "Blog" , new { page = ViewBag.PreviousPage }), 254, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(321, 44, true);
            WriteLiteral(">\r\n            &lt; Previous\r\n        </a>\r\n");
            EndContext();
#line 15 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(372, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
     if (ViewBag.HasNextPage)
    {

#line default
#line hidden
            BeginContext(412, 23, true);
            WriteLiteral("        <a class=\"next\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 435, "\"", 504, 1);
#line 19 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
WriteAttributeValue("", 442, Url.Action("Index", "Blog" , new { page = ViewBag.NextPage }), 442, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(505, 40, true);
            WriteLiteral(">\r\n            Next &gt;\r\n        </a>\r\n");
            EndContext();
#line 22 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(552, 34, true);
            WriteLiteral("</p>\r\n\r\n<div class=\"blog-posts\">\r\n");
            EndContext();
#line 26 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
     foreach (var post in Model)
    {
        

#line default
#line hidden
            BeginContext(636, 38, false);
#line 28 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
   Write(await Html.PartialAsync("_Post", post));

#line default
#line hidden
            EndContext();
#line 28 "D:\learning c#\ExploreCalifornia\C-Learning-Course\ExploreCalifornia\Views\Blog\Index.cshtml"
                                               
    }

#line default
#line hidden
            BeginContext(683, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExploreCalifornia.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
