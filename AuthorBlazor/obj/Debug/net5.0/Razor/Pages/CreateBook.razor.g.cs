#pragma checksum "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4d0304f65db7c0376e584b2a6bf570c9d8010b"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateBook")]
    public partial class CreateBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateBook</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                  _book

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                         AddNewBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddContent(6, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, " ISBN<br> ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_0(__builder2, 12, 13, 
#nullable restore
#line 14 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                                                 _book.ISBN

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _book.ISBN = __value, _book.ISBN)), 15, () => _book.ISBN);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, " Title:<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(20);
                __builder2.AddAttribute(21, "rows", "1");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                                                              _book.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _book.Title = __value, _book.Title))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _book.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, " Publication Year<br> ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_1(__builder2, 29, 30, 
#nullable restore
#line 16 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                                                             _book.PublicationYear

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _book.PublicationYear = __value, _book.PublicationYear)), 32, () => _book.PublicationYear);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group");
                __builder2.AddMarkupContent(36, " Number of Pages<br> ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_2(__builder2, 37, 38, 
#nullable restore
#line 17 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                                                            _book.NumOfPages

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _book.NumOfPages = __value, _book.NumOfPages)), 40, () => _book.NumOfPages);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, " Genre<br> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                __builder2.AddAttribute(46, "rows", "1");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                                                             _book.Genre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _book.Genre = __value, _book.Genre))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _book.Genre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, " Author Id<br> ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_3(__builder2, 54, 55, 
#nullable restore
#line 19 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                                                      authorId

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => authorId = __value, authorId)), 57, () => authorId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-6 col-lg-4 col-xl-3 p-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(61);
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenDropDown<Author>>(63);
                    __builder3.AddAttribute(64, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                        true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "Class", "w-100");
                    __builder3.AddAttribute(66, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(67, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 26 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                  _authors

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "TextProperty", "FirstName");
                    __builder3.AddAttribute(69, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 27 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
                                     args => OnChange(args, "OmegaMeme")

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.AddMarkupContent(71, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Add Book</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Frederik\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\CreateBook.razor"
       

    private IList<Author> _authors;
    private Book _book;
    private int authorId = 0;

    protected override async Task OnInitializedAsync()
    {
        _book = new();
        _authors = await _authorHandler.GetAuthors();
    }

    private async Task AddNewBook()
    {
        if (authorId != 0)
        {
            _bookHandler.AddBook(_book, authorId);
            _navigationManager.NavigateTo("/ViewBooks");
        }
    }

    private void OnChange(object args, string dropdownWithCustomFiltering)
    {
        Author author = new Author();
        author = (Author) args;
        authorId = author.Id;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookHandler _bookHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorHandler _authorHandler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
namespace __Blazor.AuthorBlazor.Pages.CreateBook
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
