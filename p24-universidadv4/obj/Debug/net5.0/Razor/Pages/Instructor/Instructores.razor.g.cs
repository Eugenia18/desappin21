#pragma checksum "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40824b84b8751b6785055a83001c3fbc8f755c0d"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Instructor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Instructores")]
    public partial class Instructores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Instructores</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarInstructores");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Cargando ...</p>");
#nullable restore
#line 14 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, @"<thead><th>Id</th>
            <th>Apeido Paterno</th>
            <th>Apeido Materno</th>
            <th>Nombre</th>
            <th>Email</th>
            <th>Fecha Ingreso</th>
            <th>Ubicacion</th>
            <th>Cursos Asignados</th></thead>
    
    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 28 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 31 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                     i.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                     i.Apaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                     i.Amaterno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 34 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                     i.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 35 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                     i.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 36 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                     i.FechaContratacion.ToString("yyy-MMM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 37 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                      i.OficinaAsignada==null?"-sin oficina-":i.OficinaAsignada.Ubicacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                 if(i.AsignacionCursos.Count==0) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<td>-sin asignacion-</td>");
#nullable restore
#line 40 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                } else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "td");
#nullable restore
#line 42 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                         foreach(var a in i.AsignacionCursos) {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, 
#nullable restore
#line 43 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                             a.Curso.CursoId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, " - ");
            __builder.AddContent(36, 
#nullable restore
#line 43 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                                                  a.Curso.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, " <br />\n");
#nullable restore
#line 44 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 46 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "EditarInstructores/" + (
#nullable restore
#line 48 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                                                                  i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                     ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "ElimnarInstructores/" + (
#nullable restore
#line 51 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
                                                                    i.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Instructor/Instructores.razor"
       
    List<Instructor> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores serv { get; set; }
    }
}
#pragma warning restore 1591
