#pragma checksum "C:\Eduardo\Web\Pages\Atualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec6d2d21709e399b3ea75dd43f53be9aa6a4777b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Web.Pages.Pages_Atualizar), @"mvc.1.0.razor-page", @"/Pages/Atualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Atualizar.cshtml", typeof(Web.Pages.Pages_Atualizar), null)]
namespace Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Eduardo\Web\Pages\_ViewImports.cshtml"
using Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6d2d21709e399b3ea75dd43f53be9aa6a4777b", @"/Pages/Atualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd1deb18c44cd7d6db8c10fa2a764d1f024bcd9a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Atualizar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 88, true);
            WriteLiteral("\r\n\r\n<h2>Login</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"container thumbnail\">\r\n        ");
            EndContext();
            BeginContext(125, 973, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa5dc1f616542c0b7f466522ae38e8f", async() => {
                BeginContext(131, 960, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""labelemail"">Nome</label>
                <input type=""text"" class=""form-control"" id=""nome"" placeholder=""Nome"">
            </div>

            <div class=""form-group"">
                <label for=""formGroupExampleInput2"">E-mail</label>
                <input type=""text"" class=""form-control"" id=""email"" placeholder=""e-mail"">
            </div>

            <div class=""form-group"">
                <label for=""formGroupExampleInput2"">Senha</label>
                <input type=""text"" class=""form-control"" id=""senha"" placeholder=""Senha"">
            </div>
            <hr />
            <button type=""submit"" id=""addButton"" class=""btn btn-primary"" onclick=""addEntra();"">
                Atualizar
            </button>

            <button type=""submit"" id=""addButton"" class=""btn btn-danger"" onclick=""addExcluir();"">
                Excluir
            </button>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1098, 2110, true);
            WriteLiteral(@"
    </div>
</div>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>

<script>

    function addEntra() {      
        Atualiza();
    }

    function atualizar() {

        var email = $(""#email"").val();
        var senha = $(""#senha"").val();
        var nome = $(""#nome"").val();

        $.ajax({
            url: 'https://localhost:44328/api/usuario/',
            type: 'PUT',           
            contentType: ""application/json"",
            data: JSON.stringify({ ""email"": email, ""senhahash"": senha, ""nome"": nome }),
            dataType: ""json"",

            success: function (result) {
                alert(result);
            },

            error: function (error) {
                alert(error.responseJSON);
            }
        });
    }

    function Atualiza() {

        var email = $(""#email"").val();
        var senha = $(""#senha"").val();
        var nome = $(""#nome"").val();

        var xhr = new XMLHttpRequest();");
            WriteLiteral(@"
        xhr.open('PUT', 'https://localhost:44328/api/usuario/');
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.onload = function () {
            if (xhr.status === 200) {
                var userInfo = JSON.parse(xhr.responseText);
            }
        };
        xhr.send(JSON.stringify({
            ""nome"": nome,
            ""senha"": senha,
            ""senhahash"": senha

        }));    }

 
    function excluir() {

        var email = $(""#email"").val();
        var senha = $(""#senha"").val();
        var nome = $(""#nome"").val();

        $.ajax({
            url: 'https://localhost:44328/api/usuario/',
            type: 'Delete',
            contentType: ""application/json"",
            data: JSON.stringify({ ""email"": email, ""senhahash"": senha, ""nome"": nome }),
            dataType: ""json"",

            success: function (result) {
                alert(result);
            },

            error: function (error) {
                alert('e");
            WriteLiteral("rro\');\r\n            }\r\n        });\r\n    }\r\n\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AtualizarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AtualizarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AtualizarModel>)PageContext?.ViewData;
        public AtualizarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
