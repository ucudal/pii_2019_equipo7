#pragma checksum "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f4ba6a6e0b70d3dc2df4ea27340691307b3366b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IgnisMercado.Pages.Propuestas.Pages_Propuestas_Delete), @"mvc.1.0.razor-page", @"/Pages/Propuestas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Propuestas/Delete.cshtml", typeof(IgnisMercado.Pages.Propuestas.Pages_Propuestas_Delete), null)]
namespace IgnisMercado.Pages.Propuestas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\_ViewImports.cshtml"
using IgnisMercado;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f4ba6a6e0b70d3dc2df4ea27340691307b3366b", @"/Pages/Propuestas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96259bf34af82fc2a021cafbd6be683f66de899e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Propuestas_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(95, 168, true);
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Propuesta</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(264, 63, false);
#line 16 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Propuesta.NivelDeDificultad));

#line default
#line hidden
            EndContext();
            BeginContext(327, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(386, 59, false);
#line 19 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Propuesta.NivelDeDificultad));

#line default
#line hidden
            EndContext();
            BeginContext(445, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(503, 61, false);
#line 22 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Propuesta.EstimadoPorHora));

#line default
#line hidden
            EndContext();
            BeginContext(564, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(623, 57, false);
#line 25 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Propuesta.EstimadoPorHora));

#line default
#line hidden
            EndContext();
            BeginContext(680, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(738, 52, false);
#line 28 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Propuesta.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(790, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(849, 48, false);
#line 31 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Propuesta.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(897, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(955, 70, false);
#line 34 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Propuesta.DescripcionDeLaPropuesta));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1084, 66, false);
#line 37 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Propuesta.DescripcionDeLaPropuesta));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1208, 71, false);
#line 40 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Propuesta.ListaDeTecnicosPostulados));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1338, 67, false);
#line 43 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Propuesta.ListaDeTecnicosPostulados));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1463, 61, false);
#line 46 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Propuesta.TecnicoAsignado));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1583, 57, false);
#line 49 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Propuesta.TecnicoAsignado));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(1674, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f4ba6a6e0b70d3dc2df4ea27340691307b3366b10689", async() => {
                BeginContext(1694, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1703, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7f4ba6a6e0b70d3dc2df4ea27340691307b3366b11079", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "C:\Users\estudiante.fit\Desktop\Hola-Mundo\Santiago\pii_2019_equipo7-santiago\IgnisMercado\Pages\Propuestas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Propuesta.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1749, 81, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                EndContext();
                BeginContext(1830, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f4ba6a6e0b70d3dc2df4ea27340691307b3366b13033", async() => {
                    BeginContext(1852, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1868, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1880, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IgnisMercado.Pages.Propuestas.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IgnisMercado.Pages.Propuestas.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IgnisMercado.Pages.Propuestas.DeleteModel>)PageContext?.ViewData;
        public IgnisMercado.Pages.Propuestas.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
