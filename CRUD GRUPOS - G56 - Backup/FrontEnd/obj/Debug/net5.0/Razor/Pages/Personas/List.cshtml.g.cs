#pragma checksum "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68254e09d0d04d1f9b4f6e8ec4005a3a55d4af28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Personas.Pages_Personas_List), @"mvc.1.0.razor-page", @"/Pages/Personas/List.cshtml")]
namespace FrontEnd.Pages.Personas
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
#line 1 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68254e09d0d04d1f9b4f6e8ec4005a3a55d4af28", @"/Pages/Personas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"text-center center\">\r\n    <h1>Personas</h1>\r\n</div>\r\n\r\n<br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68254e09d0d04d1f9b4f6e8ec4005a3a55d4af283374", async() => {
                WriteLiteral("\r\n       Crear Persona <i class=\"fa fa-plus\" aria-hidden=\"true\"></i>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br/>\r\n<br/>\r\n<table class=\"table\">\r\n    <tr>\r\n        <!-- <th>Id</th> -->\r\n        <th>Nombre</th>\r\n        <th>Edad</th>\r\n        <th>Altura</th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml"
     foreach (var persona in Model.Personas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <!--<td>");
#nullable restore
#line 27 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml"
               Write(persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>-->\r\n        <td>");
#nullable restore
#line 28 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml"
       Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml"
           Write(persona.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml"
           Write(persona.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\jnata\Documents\PROYECTOS\Ciclo3_NET_CORE\CRUD GRUPOS - G56 - Backup\FrontEnd\Pages\Personas\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ListModel>)PageContext?.ViewData;
        public MyApp.Namespace.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
