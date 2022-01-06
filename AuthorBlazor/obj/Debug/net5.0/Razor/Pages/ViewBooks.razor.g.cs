#pragma checksum "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebe69b0b85c4dfb6a394d93bc0382275d4f43128"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
using AuthorAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewBooks")]
    public partial class ViewBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ViewBooks</h3>");
#nullable restore
#line 8 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
 if (_authors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
}
else if (!_authors.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No Authors exist. Please add some.</em></p>");
#nullable restore
#line 19 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Title</th>\r\n            <th>Publisher Year</th>\r\n            <th>Pages</th>\r\n            <th>Author First Name</th>\r\n            <th>Author Last Name</th>\r\n            <th>Delete</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 34 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
         foreach (Author author in _authors)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 42 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
                     author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 43 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
                     author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\N_i_v\RiderProjects\Test-Exam-A20\AuthorBlazor\Pages\ViewBooks.razor"
       
    private IList<Author> _authors;

    protected async override Task OnInitializedAsync()
    {
        _authors = await _authorHandler.GetAuthors();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorHandler _authorHandler { get; set; }
    }
}
#pragma warning restore 1591
