#pragma checksum "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85611d81c9536e82c219949d407518dc26142567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrateur_Blogueurs), @"mvc.1.0.view", @"/Views/Administrateur/Blogueurs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\_ViewImports.cshtml"
using Blog_Barneaud_Huyghe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\_ViewImports.cshtml"
using Blog_Barneaud_Huyghe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85611d81c9536e82c219949d407518dc26142567", @"/Views/Administrateur/Blogueurs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43f59f38de277b8a15bc6132a7305bf40cd0bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrateur_Blogueurs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog_Barneaud_Huyghe.Models.Individu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReverseAutorisation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h1>Liste des blogueurs :</h1>\r\n\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 8 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <th>");
#nullable restore
#line 12 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
               Write(Html.DisplayNameFor(model => model.Identifiant));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 13 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
               Write(Html.DisplayNameFor(model => model.EstBloggeur));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
                   Write(item.Identifiant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
                   Write(item.EstBloggeur);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85611d81c9536e82c219949d407518dc261425675533", async() => {
                WriteLiteral("Inverser l\'autorisation");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
                             WriteLiteral(item.IndividuId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 27 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Il n\'y a pas de blogueurs.</p>\r\n");
#nullable restore
#line 31 "C:\Users\Moi\source\repos\Blog_Barneaud_Huyghe\Blog_Barneaud_Huyghe\Views\Administrateur\Blogueurs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog_Barneaud_Huyghe.Models.Individu>> Html { get; private set; }
    }
}
#pragma warning restore 1591