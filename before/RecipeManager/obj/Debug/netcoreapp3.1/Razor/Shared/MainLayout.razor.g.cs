#pragma checksum "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e40cfdf2268301b675c785c5129ede9afaf71c7"
// <auto-generated/>
#pragma warning disable 1591
namespace RecipeManager.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using RecipeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using RecipeManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<RecipeManager.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Blazored.Toast.BlazoredToasts>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\">\r\n        <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddContent(15, 
#nullable restore
#line 14 "D:\Projects\Code with Julian\Contents\2021\37.1. RecipeManager-5\Project\tutorial\RecipeManager-3\RecipeManager\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
