#pragma checksum "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofSCommodity\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b472e93ebd3ccbc8f67b1d7e41abfb546abb775a"
// <auto-generated/>
#pragma warning disable 1591
namespace Logistics.Pages.ofSCommodity
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
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatDialog>(0);
            __builder.AddAttribute(1, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofSCommodity\Delete.razor"
                   DeleteDialogIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.AddMarkupContent(7, "<center>\r\n            <p>관리상품 삭제</p>\r\n            <p>정말로 삭제하시겠습니까?</p>\r\n            <p>상품옵션과 디테일정보 또한 삭제됩니다.</p>\r\n        </center>\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __Blazor.Logistics.Pages.ofSCommodity.Delete.TypeInference.CreateMatCheckbox_0(__builder3, 14, 15, "파일과 데이터 분리 삭제", 16, 
#nullable restore
#line 13 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofSCommodity\Delete.razor"
                                       IsDetached

#line default
#line hidden
#nullable disable
                    , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsDetached = __value, IsDetached)), 18, () => IsDetached);
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(21);
                    __builder3.AddAttribute(22, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofSCommodity\Delete.razor"
                            DeleteDataAndFile

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "삭제");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(26);
                    __builder3.AddAttribute(27, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Pages\ofSCommodity\Delete.razor"
                            DialogSwitch.InvokeAsync

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "취소");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Logistics.Pages.ofSCommodity.Delete
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatCheckbox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatCheckbox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591