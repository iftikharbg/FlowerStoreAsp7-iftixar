#pragma checksum "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331579f2d8153836832a540bd56bc36907b912fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSearchPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductSearchPartial.cshtml")]
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
#line 1 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\_ViewImports.cshtml"
using FlowerStore.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\_ViewImports.cshtml"
using FlowerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"331579f2d8153836832a540bd56bc36907b912fd", @"/Views/Shared/_ProductSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9dc3f933a48cef12520dd54ffebe326d2c3eef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductSearchPartial.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <li>\r\n     No Result\r\n </li>\r\n");
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductSearchPartial.cshtml"
}
else
{
    foreach (var item in Model)

    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"d-flex\">\r\n            <div>\r\n                \r\n                ");
#nullable restore
#line 17 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductSearchPartial.cshtml"
           Write(Html.Raw(item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <p>");
#nullable restore
#line 18 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductSearchPartial.cshtml"
              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 21 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Shared\_ProductSearchPartial.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
