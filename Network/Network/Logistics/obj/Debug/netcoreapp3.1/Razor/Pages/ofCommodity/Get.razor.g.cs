#pragma checksum "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72e82926b8bd38c8ceb98bab3497aa435439cad1"
// <auto-generated/>
#pragma warning disable 1591
namespace Logistics.Pages.ofCommodity
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Logistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using Logistics.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Get/Commodity")]
    public partial class Get : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                   CreateDialogSwitch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "생성");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatDivider>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __Blazor.Logistics.Pages.ofCommodity.Get.TypeInference.CreateMatTable_0(__builder, 8, 9, 
#nullable restore
#line 9 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                  Commodities

#line default
#line hidden
#nullable disable
            , 10, "mat-elevation-z5", 11, (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<th>No</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>Name</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>Category</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>Manager</th>\r\n    ");
            }
            , 17, (context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 17 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
             context.CommodityNo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 18 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
             context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 19 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
             context.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatButton>(30);
                __builder2.AddAttribute(31, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                               () => UpdateDialogSwitch(context.CommodityNo)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "수정");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<MatBlazor.MatButton>(36);
                __builder2.AddAttribute(37, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                               () => DeleteDialogSwitch(context.CommodityNo)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "삭제");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "a");
                __builder2.AddAttribute(43, "href", "/Get/Commodity/CommodityDetail/" + (
#nullable restore
#line 23 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                     context.CommodityNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<MatBlazor.MatButton>(44);
                __builder2.AddAttribute(45, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(47, "디테일");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenElement(49, "a");
                __builder2.AddAttribute(50, "href", "/Get/Commodity/Option/" + (
#nullable restore
#line 24 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                            context.CommodityNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<MatBlazor.MatButton>(51);
                __builder2.AddAttribute(52, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(54, "옵션");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(57, "\r\n\r\n");
#nullable restore
#line 29 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
 if (DeleteDialogIsOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "    ");
            __builder.OpenComponent<Logistics.Pages.ofCommodity.Delete>(59);
            __builder.AddAttribute(60, "CommodityNo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                          CommodityNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "DialogSwitch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 31 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                     DeleteDialogSwitch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(62, "DeleteDialogIsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                             DeleteDialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 32 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 34 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
 if (CreateDialogIsOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "    ");
            __builder.OpenComponent<Logistics.Pages.ofCommodity.Create>(66);
            __builder.AddAttribute(67, "DialogSwitch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 36 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                           CreateDialogSwitch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(68, "CreateDialogIsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                   CreateDialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 37 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 39 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
 if (UpdateDialogIsOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "    ");
            __builder.OpenComponent<Logistics.Pages.ofCommodity.Update>(72);
            __builder.AddAttribute(73, "CommodityNo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                          CommodityNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "DialogSwitch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 41 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                     UpdateDialogSwitch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(75, "UpdateDialogIsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                             UpdateDialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 42 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Logistics.Pages.ofCommodity.Get
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", __arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
