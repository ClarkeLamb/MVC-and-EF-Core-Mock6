#pragma checksum "C:\Users\cflam\source\repos\Mock6\Mock6\Views\Home\RetirementInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd18110d9030b8ed62a14b4a3b3cef4de1a72b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RetirementInfo), @"mvc.1.0.view", @"/Views/Home/RetirementInfo.cshtml")]
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
#line 1 "C:\Users\cflam\source\repos\Mock6\Mock6\Views\_ViewImports.cshtml"
using Mock6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cflam\source\repos\Mock6\Mock6\Views\_ViewImports.cshtml"
using Mock6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd18110d9030b8ed62a14b4a3b3cef4de1a72b8", @"/Views/Home/RetirementInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3b5e05cdff2dc3a36db26be0c175f011f06981", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RetirementInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Your retirement status: True = eligible, False = noneligible</h1>\r\n<h2>");
#nullable restore
#line 2 "C:\Users\cflam\source\repos\Mock6\Mock6\Views\Home\RetirementInfo.cshtml"
Write(ViewBag.CanRetire);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>You will recieve ");
#nullable restore
#line 3 "C:\Users\cflam\source\repos\Mock6\Mock6\Views\Home\RetirementInfo.cshtml"
                Write(ViewBag.Benefits);

#line default
#line hidden
#nullable disable
            WriteLiteral(" when/if eligible for retirement</h3>\r\n");
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