#pragma checksum "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce38dc3cac50c6a8369fbd801a562c6129b9b1cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Detail), @"mvc.1.0.view", @"/Views/Movie/Detail.cshtml")]
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
#line 1 "C:\Users\Weenog\source\repos\MovieControllerB\Views\_ViewImports.cshtml"
using MovieControllerB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Weenog\source\repos\MovieControllerB\Views\_ViewImports.cshtml"
using MovieControllerB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce38dc3cac50c6a8369fbd801a562c6129b9b1cb", @"/Views/Movie/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b6f03a151e84bce67a7400c3f7077f233c9f06", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieWeb.Models.MovieDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml"
  

    string title = "Movie Detail";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<h2>");
#nullable restore
#line 14 "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n\r\n<strong>Title</strong>\r\n\r\n<p>");
#nullable restore
#line 20 "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n<strong>Description</strong>\r\n\r\n<p>");
#nullable restore
#line 26 "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n<strong>Genre</strong>\r\n\r\n<p>");
#nullable restore
#line 32 "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml"
Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n<strong>Release Date</strong>\r\n\r\n<p>");
#nullable restore
#line 38 "C:\Users\Weenog\source\repos\MovieControllerB\Views\Movie\Detail.cshtml"
Write(Model.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieWeb.Models.MovieDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
