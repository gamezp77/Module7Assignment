#pragma checksum "/Users/gamezjr/Desktop/HTML Project/MidTermProject/html_project/Views/Home/UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75546cbee4b6b0e9bfb2cc42b5b82cc05f498fbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserProfile), @"mvc.1.0.view", @"/Views/Home/UserProfile.cshtml")]
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
#line 1 "/Users/gamezjr/Desktop/HTML Project/MidTermProject/html_project/Views/_ViewImports.cshtml"
using html_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/gamezjr/Desktop/HTML Project/MidTermProject/html_project/Views/_ViewImports.cshtml"
using html_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75546cbee4b6b0e9bfb2cc42b5b82cc05f498fbb", @"/Views/Home/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c1d5664c1cbf0ddb53cc5dc6c72ebc8678212f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75546cbee4b6b0e9bfb2cc42b5b82cc05f498fbb3183", async() => {
                WriteLiteral(@"
    <table class=""center"">
        <tbody>
            <tr>
                <td>
                    <label for=""FirstName"">First Name:</label>
                </td>
                <td>
                    <input type=""text"" id=""FirstName""
                          placeholder=""Add your First Name""/> 
                </td>
                <td>
                    <label for=""LasttName"">Last Name:</label>
                </td>
                <td>
                    <input type=""text"" id=""LasttName""
                        placeholder=""Add your Last Name""/>  
                </td>

                </tr>
            <tr>
                <td>
                    <label>Gender:</label>
                </td>
                <td colspan=""5"">
                    <input type=""radio"" id=""MaleGender"" name=""gender"" />
                    <label for=""MaleGender"">Male</label>

                    <input type=""radio"" id=""FemaleGender"" name=""gender"" />
                    <label for=""FemaleGender"">Female</label>

       ");
                WriteLiteral(@"             <input type=""radio"" id=""NoResponseGender"" name=""gender"" />
                    <label for=""NoResponseGender"">Prefer not to respond</label>
                    </td>           
                    </tr>
                    <tr>
                <td colspan=""3"">
                    <label for=""Email"">Email:      </label>
                    <input type=""email"" id=""Email"" size=""40""
                        placeholder=""Add your Email Address""
                           autofocus/>  
                </td>
             </tr>
             <tr>
                <td colspan=""5"">
                    <button>Update User Information</button>
                </td>
            </tr>

</tbody>
    </table>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
