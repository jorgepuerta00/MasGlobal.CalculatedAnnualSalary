#pragma checksum "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db66bbc0ff4f5b786995b7045bc844785a29b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Employee), @"mvc.1.0.view", @"/Views/Employee/Employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Employee.cshtml", typeof(AspNetCore.Views_Employee_Employee))]
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
#line 1 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\_ViewImports.cshtml"
using CalculatedAnnualSalary.WebAppEmployees;

#line default
#line hidden
#line 2 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\_ViewImports.cshtml"
using CalculatedAnnualSalary.WebAppEmployees.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db66bbc0ff4f5b786995b7045bc844785a29b49", @"/Views/Employee/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39cd2664ef6d9d3026c905848f08e9d293dff18a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CalculatedAnnualSalary.WebAppEmployees.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
  
    ViewBag.Title = "Annual Salary";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(168, 37, true);
            WriteLiteral("<h2>Annual Salary Per Employee</h2>\r\n");
            EndContext();
#line 7 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
 using (Html.BeginForm("Employee", "Employee"))
{

#line default
#line hidden
            BeginContext(257, 240, true);
            WriteLiteral("    <div class=\"input-group\">\r\n        <span class=\"input-group-btn\">\r\n            <button class=\"btn btn-default\" type=\"submit\">Go!</button>\r\n        </span>\r\n        <input id=\"id\" name=\"id\" type=\"text\" class=\"form-control\">\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
}

#line default
#line hidden
            BeginContext(500, 133, true);
            WriteLiteral("<br />\r\n<div>\r\n    <table class=\"table table-bordered table-responsive table-hover\" id=\"tblEmployee\">\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(634, 38, false);
#line 20 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(672, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(696, 40, false);
#line 21 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(736, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(760, 52, false);
#line 22 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.ContractTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(812, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(836, 42, false);
#line 23 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(878, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(902, 44, false);
#line 24 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(946, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(970, 51, false);
#line 25 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1045, 48, false);
#line 26 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.HourlySalary));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1117, 49, false);
#line 27 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlySalary));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(1190, 48, false);
#line 28 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
           Write(Html.DisplayNameFor(model => model.AnnualSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 22, true);
            WriteLiteral("</th>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
         using (Html.BeginForm())
        {
            foreach (var employee in Model)
            {

#line default
#line hidden
            BeginContext(1366, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1413, 11, false);
#line 35 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1456, 13, false);
#line 36 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1469, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1501, 25, false);
#line 37 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.ContractTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1526, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1558, 15, false);
#line 38 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.RoleId);

#line default
#line hidden
            EndContext();
            BeginContext(1573, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1605, 17, false);
#line 39 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(1622, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1654, 24, false);
#line 40 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.RoleDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1710, 21, false);
#line 41 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.HourlySalary);

#line default
#line hidden
            EndContext();
            BeginContext(1731, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1763, 22, false);
#line 42 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.MonthlySalary);

#line default
#line hidden
            EndContext();
            BeginContext(1785, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1817, 21, false);
#line 43 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
                   Write(employee.AnnualSalary);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1894, 18, true);
            WriteLiteral("    </table>\r\n    ");
            EndContext();
            BeginContext(1913, 64, false);
#line 48 "C:\Users\jorge.puerta\Documents\GitHub\MasGlobal.CalculatedAnnualSalary\CalculatedAnnualSalary.WebAppEmployees\Views\Employee\Employee.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CalculatedAnnualSalary.WebAppEmployees.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
