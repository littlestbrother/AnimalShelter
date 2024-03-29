#pragma checksum "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afd602a69a613803de35a08fb18e94d5d2a7be50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breeds_Index), @"mvc.1.0.view", @"/Views/Breeds/Index.cshtml")]
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
#line 5 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afd602a69a613803de35a08fb18e94d5d2a7be50", @"/Views/Breeds/Index.cshtml")]
    public class Views_Breeds_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Breeds</h1>\n\n");
#nullable restore
#line 9 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No Breeds have been added yet!</h3>\n");
#nullable restore
#line 12 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 15 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
   foreach(Breed Breed in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 17 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
   Write(Html.ActionLink($"{Breed.Name}", "Details", new { id = Breed.BreedId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 21 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
Write(Html.ActionLink("Add new Breed", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 22 "/home/aaron/Documents/epicodus/epicodus-fullstack/AnimalShelter/AnimalShelter/Views/Breeds/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
