#pragma checksum "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09eaa46e59822bb5ef016e6587cc9adfc478e636"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Pages.Bookings
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Contracts;

#line default
#line hidden
#nullable disable
    public partial class FormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                  booking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                          OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "fieldset");
                __builder2.AddAttribute(9, "disabled", 
#nullable restore
#line 5 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                         Disabled

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label>Vehicle: </label>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.OpenElement(14, "select");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                               booking.VehicleId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => booking.VehicleId = __value, booking.VehicleId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(18, "option");
                __builder2.AddAttribute(19, "value");
                __builder2.AddContent(20, "-- Select Vehicle --");
                __builder2.CloseElement();
#nullable restore
#line 11 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                     if (Vehicles != null)
                    {
                        foreach (var vehicle in Vehicles)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "option");
                __builder2.AddAttribute(22, "value", 
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                            vehicle.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
__builder2.AddContent(23, vehicle.Make.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, " ");
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
__builder2.AddContent(25, vehicle.Model.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, " | ");
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
__builder2.AddContent(27, vehicle.LicensePlateNumber);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 16 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 19 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                          () => booking.VehicleId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label>Customer: </label>\r\n            ");
                __builder2.OpenElement(35, "div");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateInputSelect_1(__builder2, 36, 37, "form-control", 38, 
#nullable restore
#line 25 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                          booking.CustomerId

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => booking.CustomerId = __value, booking.CustomerId)), 40, () => booking.CustomerId, 41, (__builder3) => {
                    __builder3.AddMarkupContent(42, "<option value>-- Select Customer --</option>");
#nullable restore
#line 27 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                     if (Customers != null)
                    {
                        foreach (var customer in Customers)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(43, "option");
                    __builder3.AddAttribute(44, "value", 
#nullable restore
#line 31 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                            customer.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 31 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
__builder3.AddContent(45, customer.TaxId);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, " | ");
#nullable restore
#line 31 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
__builder3.AddContent(47, customer.EmailAddress);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 32 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(48, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateValidationMessage_2(__builder2, 49, 50, 
#nullable restore
#line 35 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                          () => booking.CustomerId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "<label>Date Out:</label>\r\n            ");
                __builder2.OpenElement(55, "div");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateInputDate_3(__builder2, 56, 57, "form-control", 58, 
#nullable restore
#line 42 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                         booking.DateOut

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => booking.DateOut = __value, booking.DateOut)), 60, () => booking.DateOut);
                __builder2.AddMarkupContent(61, "\r\n                ");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateValidationMessage_4(__builder2, 62, 63, 
#nullable restore
#line 43 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                          () => booking.DateOut

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 47 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
         if (booking.Id > 0)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Date In:</label>\r\n                ");
                __builder2.OpenElement(67, "div");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateInputDate_5(__builder2, 68, 69, "form-control", 70, 
#nullable restore
#line 52 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                             booking.DateIn

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => booking.DateIn = __value, booking.DateIn)), 72, () => booking.DateIn);
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent.TypeInference.CreateValidationMessage_6(__builder2, 74, 75, 
#nullable restore
#line 53 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
                                              () => booking.DateIn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 56 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 58 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
     if (!Disabled)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(76, "button");
                __builder2.AddAttribute(77, "type", "submit");
                __builder2.AddAttribute(78, "class", "btn btn-success btn-block");
#nullable restore
#line 61 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
__builder2.AddContent(79, ButtonText);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 63 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Pages\Bookings\FormComponent.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<CarRentalManagement.Client.Components.BackToList>(80);
                __builder2.AddAttribute(81, "Target", "bookings");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CarRentalManagement.Client.Pages.Bookings.FormComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
