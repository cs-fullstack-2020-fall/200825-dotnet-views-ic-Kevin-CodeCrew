#pragma checksum "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "239464fb948289624279653cc2593b8405dd94db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieRentalHistory), @"mvc.1.0.view", @"/Views/Movies/MovieRentalHistory.cshtml")]
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
#line 1 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\_ViewImports.cshtml"
using MovieRentals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\_ViewImports.cshtml"
using MovieRentals.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"239464fb948289624279653cc2593b8405dd94db", @"/Views/Movies/MovieRentalHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09d79ba51e8a4c3c186f7d943c91574f8ecbb38", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MovieRentalHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieRentals.ViewModels.MovieRentalDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Movie Rental History</h1>\r\n\r\n    <h3>Movie ID: ");
#nullable restore
#line 5 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
             Write(Model.Movie.MovieId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h2>Name: ");
#nullable restore
#line 6 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
         Write(Model.Movie.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>Genre: ");
#nullable restore
#line 7 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
          Write(Model.Movie.MovieGenre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Release Date: ");
#nullable restore
#line 8 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
                 Write(Model.Movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h2>Customers</h2>\r\n");
#nullable restore
#line 11 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
     foreach (Customer c in @Model.Customers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n        <li>\r\n            Customer ID: ");
#nullable restore
#line 15 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
                    Write(c.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            Customer Name: ");
#nullable restore
#line 18 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
                      Write(c.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            Premium Member? ");
#nullable restore
#line 21 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
                       Write(c.PremiumMember);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n\r\n        </ul>\r\n");
#nullable restore
#line 25 "C:\Users\kyancy\Code_School\concepts_4\200825-dotnet-views-ic-Kevin-CodeCrew\MovieRentals\Views\Movies\MovieRentalHistory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieRentals.ViewModels.MovieRentalDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591