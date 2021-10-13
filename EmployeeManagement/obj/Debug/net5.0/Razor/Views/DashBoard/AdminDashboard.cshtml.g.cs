#pragma checksum "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452c7163cd9864d9c797c8ceb76b6f9d1d127804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_AdminDashboard), @"mvc.1.0.view", @"/Views/DashBoard/AdminDashboard.cshtml")]
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
#line 1 "C:\EmployeeTimeSheet\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\EmployeeTimeSheet\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\EmployeeTimeSheet\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452c7163cd9864d9c797c8ceb76b6f9d1d127804", @"/Views/DashBoard/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a438abb455ce872e5fe241c70018e289f3369ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Models.TimeSheet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
  
    ViewBag.Title = "Admin Dashboard";

    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid px-4"">
    <div class=""row g-3 my-2"">
        <div class=""col-8 col-sm-4 offset-sm-1"">
            <div class=""p-3 bg-white shadow-sm d-flex justify-content-around align-items-center rounded"">
                <div>
                    <h3 class=""fs-2"">");
#nullable restore
#line 14 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <p class=""fs-5 lable-text"">Employees present today</p>
                </div>
                <i class=""fas fa-lg f fa-clipboard-list fs-1 primary-text border rounded-full secondary-bg p-3""></i>
            </div>
        </div>

        <div class=""col-8 col-sm-4 offset-sm-2"">
            <div class=""p-3 bg-white shadow-sm d-flex justify-content-around align-items-center rounded"">
                <div>
                    <h3 class=""fs-2"">0</h3>
                    <p class=""fs-5 lable-text"">Active Employees</p>
                </div>
                <i class=""fas fa-lg fa-user-check fs-1 primary-text border rounded-full secondary-bg p-3""></i>
            </div>
        </div>
        <h3 class=""fs-4 mt-3 ml-sm-5 mb-0"">Employees</h3>
        <div class=""row my-2 ml-2"">
            <div class=""col-sm-11 ml-sm-4"">
                <table class=""table bg-white rounded shadow-sm  table-hover"">
                    <thead>
                        <tr>
                ");
            WriteLiteral("            <th scope=\"col\">\r\n                                ");
#nullable restore
#line 37 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            \r\n                            <th scope=\"col\">\r\n                                ");
#nullable restore
#line 41 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                           Write(Html.DisplayNameFor(model => model.TotalBreakTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th scope=\"col\">\r\n                                ");
#nullable restore
#line 44 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                           Write(Html.DisplayNameFor(model => model.TotalWorkingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 49 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                         if (Model.Any())
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 55 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                                   Write(Html.DisplayFor(model => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                   \r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                                   Write(Html.DisplayFor(model => item.TotalBreakTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                                   Write(Html.DisplayFor(model => item.TotalWorkingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 65 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>There is no Record for the given date</td>\r\n                            </tr>\r\n");
#nullable restore
#line 72 "C:\EmployeeTimeSheet\EmployeeManagement\Views\DashBoard\AdminDashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Models.TimeSheet>> Html { get; private set; }
    }
}
#pragma warning restore 1591