#pragma checksum "C:\Users\Andrew\Documents\Coding\101\Unit 7 Intro to Asp.net Core\Property Rental\Views\Catalog\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "885616bc0280362fbeec992eecd0e27b913863c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Register), @"mvc.1.0.view", @"/Views/Catalog/Register.cshtml")]
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
#line 1 "C:\Users\Andrew\Documents\Coding\101\Unit 7 Intro to Asp.net Core\Property Rental\Views\_ViewImports.cshtml"
using Property_Rental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andrew\Documents\Coding\101\Unit 7 Intro to Asp.net Core\Property Rental\Views\_ViewImports.cshtml"
using Property_Rental.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"885616bc0280362fbeec992eecd0e27b913863c0", @"/Views/Catalog/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775ee8c96e5b4c280361624011872b4f13152da0", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "C:\Users\Andrew\Documents\Coding\101\Unit 7 Intro to Asp.net Core\Property Rental\Views\Catalog\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css\"> \r\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "885616bc0280362fbeec992eecd0e27b913863c03798", async() => {
                WriteLiteral(@"
  <div class=""form-group row"">
    <label for=""RentalTitle"" class=""col-4 col-form-label"">Title of Home</label> 
    <div class=""col-8"">
      <input id=""RentalTitle"" name=""RentalTitle"" placeholder=""Beautiful Ocean Condo"" type=""text"" class=""form-control control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""RentalBeds"" class=""col-4 col-form-label"">Bedrooms</label> 
    <div class=""col-8"">
      <input id=""RentalBeds"" name=""RentalBeds"" placeholder=""3"" type=""text"" class=""form-control control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""RentalBathrooms"" class=""col-4 col-form-label"">Bathrooms</label> 
    <div class=""col-8"">
      <input id=""RentalBathrooms"" name=""RentalBathrooms"" placeholder=""1.5"" type=""text"" class=""form-control control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""RentalPrice"" class=""col-4 col-form-label"">Price</label> 
    <div class=""col-8"">
      <input id=""RentalPrice"" name=""RentalPrice"" placeholder=""");
                WriteLiteral(@"$1400/m"" type=""text"" class=""form-control control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""RentalArea"" class=""col-4 col-form-label"">Area (Sq. Ft)</label> 
    <div class=""col-8"">
      <input id=""RentalArea"" name=""RentalArea"" placeholder=""2,500sq ft"" type=""text"" class=""form-control control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""RentalImage"" class=""col-4 col-form-label"">Image URL</label> 
    <div class=""col-8"">
      <input id=""RentalImage"" name=""RentalImage"" placeholder=""https://imgur.com/D32kmd"" type=""text"" class=""form-control control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""RentalDescription"" class=""col-4 col-form-label"">Description</label> 
    <div class=""col-8"">
      <textarea id=""RentalDescription"" name=""RentalDescription"" cols=""40"" rows=""3"" class=""form-control control""></textarea>
    </div>
  </div>
  <div class=""form-group row"">
    <label class=""col-4"">Parking Included?</label> 
    <div cla");
                WriteLiteral(@"ss=""col-8"">
      <div class=""custom-control custom-radio custom-control-inline"">
        <input name=""RentalParking"" id=""RentalParking_0"" type=""radio"" class=""custom-control-input control"" value=""Yes""> 
        <label for=""RentalParking_0"" class=""custom-control-label"">Yes</label>
      </div>
      <div class=""custom-control custom-radio custom-control-inline"">
        <input name=""RentalParking"" id=""RentalParking_1"" type=""radio"" class=""custom-control-input control"" value=""No""> 
        <label for=""RentalParking_1"" class=""custom-control-label"">No</label>
      </div>
    </div>
  </div>
  <div class=""form-group row"">
    <div class=""offset-4 col-8"">
      <button name=""btnSave"" type=""Button"" class=""btn btn-primary"" id=""btnSave"">Save</button>
    </div>
  </div>
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/register.js\"></script>\r\n    <script src=\"/js/PropertyLists.js\"></script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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