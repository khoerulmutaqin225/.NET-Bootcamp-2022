#pragma checksum "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7f33f1f72bcb670cf91d0a43a553e94496a84ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Person), @"mvc.1.0.view", @"/Views/Employee/Person.cshtml")]
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
#line 1 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\_ViewImports.cshtml"
using Northwind.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\_ViewImports.cshtml"
using Northwind.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7f33f1f72bcb670cf91d0a43a553e94496a84ed", @"/Views/Employee/Person.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad76091869ede8adbd28e701c0fcdceb8678800", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Person : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
  
   //Layout = null;
   //untuk mematikan javastript

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3 align =\"Center\">\r\n    <u>\r\n        List of Person\r\n    </u>\r\n        \r\n    </h3>\r\n    \r\n");
            WriteLiteral(@"
      <table class=""table"">
  <thead>
            <tr>
              <th scope=""col"">#</th>
              <th scope=""col"">FullName</th>
              <th scope=""col"">Email</th>
              <th scope=""col"">Birth Date</th>
            </tr>
  </thead>
      <tbody>
");
#nullable restore
#line 37 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
                   Write(item.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "D:\.NET Bootcamp\NorthwindSolution\Northwind.Web\Views\Employee\Person.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n  </table>\r\n\r\n</div> \r\n</div> ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
