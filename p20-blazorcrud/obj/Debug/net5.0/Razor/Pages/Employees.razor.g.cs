#pragma checksum "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf0e401ae09b92f246cef24d092914545b038ada"
// <auto-generated/>
#pragma warning disable 1591
namespace p20_blazorcrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using p20_blazorcrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/_Imports.razor"
using p20_blazorcrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
using p20_blazorcrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employees Info</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AddEmployees");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Add New</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
 if(EmpObj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading ...</em></p>");
#nullable restore
#line 13 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
}
else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><th>Emp Id</th>\r\n        <th>Employe Name</th>\r\n        <th>Gender</th>\r\n        <th>Designation</th>\r\n        <th>City</th></thead>\r\n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 24 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
         foreach(var emp in EmpObj) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 26 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                     emp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 27 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                     emp.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 28 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                     emp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 29 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                     emp.Designation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 30 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                     emp.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "class", "nac-link");
            __builder.AddAttribute(30, "href", "EditEmployees/" + (
#nullable restore
#line 32 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                                                             emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<span class=\"oi oi-pencil\">Edit</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "nac-link");
            __builder.AddAttribute(35, "href", "DeleteEmployees/" + (
#nullable restore
#line 35 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
                                                               emp.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "<span class=\"oi oi-trash\">Delete</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p20-blazorcrud/Pages/Employees.razor"
       
    List<Employee> EmpObj;
    protected override void OnInitialized() {
        EmpObj = employeeService.GetAllEmployee();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591
