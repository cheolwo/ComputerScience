#pragma checksum "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d468499f2f3653e6aa1eb2213cc1cf735662d7f4"
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
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "/Create/Commodity");
            __builder.OpenComponent<MatBlazor.MatButton>(2);
            __builder.AddAttribute(3, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "생성");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<MatBlazor.MatDivider>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n\r\n");
            __Blazor.Logistics.Pages.ofCommodity.Get.TypeInference.CreateMatTable_0(__builder, 9, 10, 
#nullable restore
#line 9 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                  Commodities

#line default
#line hidden
#nullable disable
            , 11, "mat-elevation-z5", 12, (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<th>No</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>Name</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>Category</th>\r\n        ");
                __builder2.AddMarkupContent(17, "<th>DataManager</th>\r\n    ");
            }
            , 18, (context) => (__builder2) => {
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 17 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
             context.CommodityNo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 18 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
             context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 19 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
             context.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "td");
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "a");
                __builder2.AddAttribute(32, "href", "/Update/Commodity/" + (
#nullable restore
#line 21 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                        context.CommodityNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<MatBlazor.MatButton>(33);
                __builder2.AddAttribute(34, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(36, "수정");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "a");
                __builder2.AddAttribute(39, "href", "/Get/Commodity/Option/" + (
#nullable restore
#line 23 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                            context.CommodityNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<MatBlazor.MatButton>(40);
                __builder2.AddAttribute(41, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "옵션");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "a");
                __builder2.AddAttribute(46, "href", "/Get/Commodity/Detail/" + (
#nullable restore
#line 24 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                            context.CommodityNo

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<MatBlazor.MatButton>(47);
                __builder2.AddAttribute(48, "Raised", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "배송");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(53, "\r\n\r\n");
#nullable restore
#line 30 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
 if (DeleteDialogIsOpen)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.OpenComponent<MatBlazor.MatDialog>(55);
            __builder.AddAttribute(56, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                              DeleteDialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeleteDialogIsOpen = __value, DeleteDialogIsOpen))));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(60);
                __builder2.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(62, "Hi");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n            ");
                    __builder3.AddMarkupContent(67, "<p>Really Delete of Commodity?</p>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(69);
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(71, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(72);
                    __builder3.AddAttribute(73, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                  e => { DeleteDialogIsOpen = false; }

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(75, "NO");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n            ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(77);
                    __builder3.AddAttribute(78, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofCommodity\Get.razor"
                                () =>DeleteCommodity(CommodityNo)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(80, "OK");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(81, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n");
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
