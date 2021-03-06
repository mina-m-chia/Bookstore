#pragma checksum "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c0517dc8ec64d867d558251f5347eaf1703714"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n\n    ");
            __builder.AddMarkupContent(3, "<thead>\n        <tr>\n            <th>Book ID</th>\n            <th>Title</th>\n            <th>Author</th>\n            <th>Price</th>\n        </tr>\n    </thead>\n\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n\n");
#nullable restore
#line 18 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
         if (BookData?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
             foreach (Book b in BookData)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 23 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                         b.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 24 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                         b.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 25 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                         b.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, "$");
            __builder.AddContent(20, 
#nullable restore
#line 26 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                          b.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 29 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                                                                    GetDetailsUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, "Details");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 33 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                                                                       GetEditUrl(b.BookId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
                                                                          x => RemoveBook(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 40 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "            ");
            __builder.AddMarkupContent(50, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Books</td>\n            </tr>\n");
#nullable restore
#line 47 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "href", "/admin/books/create");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Users/minachia/Documents/GitHub/Bookstore/Mission7/Pages/Admin/Books.razor"
       

    public IBookstoreRepository repo => Service;

    public IEnumerable<Book> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";
    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook (Book b)
    {
        repo.DeleteBook(b);
        await UpdateData();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
