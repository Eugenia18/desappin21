#pragma checksum "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "243f2b0fa139e2ad9aba7b6bca0788741ded37ab"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.OficinaAsignada
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p26-universidadv6/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarOficinaAsignadas/{Id:int}")]
    public partial class EdtarOficinaAsignadas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Oficina Asignada</h3> \n\n ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                      obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                           EditarOficinaAsignada

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n            ");
                __builder2.OpenElement(13, "fieldset");
                __builder2.AddAttribute(14, "disabled", "true");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label for=\"InstructorId\" class=\"control-label\">Instructor </label>\n                ");
                __Blazor.p21_universidadv1.Pages.OficinaAsignada.EdtarOficinaAsignadas.TypeInference.CreateInputSelect_0(__builder2, 18, 19, "InstructorId", 20, "form-control", 21, 
#nullable restore
#line 18 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                                                                 obj.InstructorId

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.InstructorId = __value, obj.InstructorId)), 23, () => obj.InstructorId, 24, (__builder3) => {
                    __builder3.OpenElement(25, "option");
                    __builder3.AddAttribute(26, "value", 
#nullable restore
#line 19 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                     0

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(27, "disabled");
                    __builder3.AddContent(28, "-Elije un Instructor-");
                    __builder3.CloseElement();
#nullable restore
#line 20 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                     foreach (var i in @objins )
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(29, "option");
                    __builder3.AddAttribute(30, "value", 
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                        i.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(31, 
#nullable restore
#line 22 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                               i.NombreCompleto

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n               ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"Ubicacion\" class=\"control-label\">Ubicacion</label>\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "id", "Ubicacion");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                                                            obj.Ubicacion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Ubicacion = __value, obj.Ubicacion))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Ubicacion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n            \n            ");
                __builder2.AddMarkupContent(43, "<button type=\"submit\" class=\"btn btn-primary\">Actualizar</button>\n            ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "button");
                __builder2.AddAttribute(46, "class", "btn btn-primary");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
                                                                     Cancelar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/castr/Downloads/programas/p26-universidadv6/Pages/OficinaAsignada/EdtarOficinaAsignadas.razor"
       
    [Parameter] public int Id {get; set;}
    OficinaAsignada obj = new OficinaAsignada();
    List<Instructor> objins;
    protected void EditarOficinaAsignada() {
        serv.Actualizar(obj);
        NavigationManager.NavigateTo("OficinaAsignadas");
    }
    protected void Cancelar() {
       NavigationManager.NavigateTo("OficinaAsignadas");
    }
    protected override void OnInitialized() {
         objins = sins.ObtenerTodo("");
         obj = serv.Obtener(Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioInstructores sins { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioOficinaAsignadas serv { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.p21_universidadv1.Pages.OficinaAsignada.EdtarOficinaAsignadas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
