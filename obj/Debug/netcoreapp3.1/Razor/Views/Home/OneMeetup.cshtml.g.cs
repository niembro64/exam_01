#pragma checksum "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dfd241611c04537e6293eccd5e9cacb1e234ee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneMeetup), @"mvc.1.0.view", @"/Views/Home/OneMeetup.cshtml")]
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
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\_ViewImports.cshtml"
using exam_01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\_ViewImports.cshtml"
using exam_01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dfd241611c04537e6293eccd5e9cacb1e234ee5", @"/Views/Home/OneMeetup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b02ad6caa2dc5987ab88b6a07b1a70792c8219", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneMeetup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meetup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/reservations2/reserve"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
  
  ViewData["Title"] = "One Meetup";
  ViewData["Header"] = "";
  ViewData["Day"] = @ViewBag.OneMeetup.Date.ToString("d");
  ViewData["MonthDay"] = @ViewBag.OneMeetup.Date.ToString("MMM dd");
  ViewData["DayOfWeek"] = @ViewBag.OneMeetup.Date.DayOfWeek;
  ViewData["Time"] = @ViewBag.OneMeetup.Date.ToString("HH:mm");
  int numGuests = 0;
  int rId = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
 if (@ViewBag.OneMeetup.Creator.Name != "")
{
  ViewData["Header"] = $"{@ViewBag.OneMeetup.Creator.Name}'s {@ViewBag.OneMeetup.Title}";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div\r\n  class=\"d-flex flex-column align-items-center flex-wrap w-100 bg-dark rounded-bottom p-0 m-0 border border-top-0\">\r\n");
#nullable restore
#line 23 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
   if (@ViewBag.OneMeetup.Description != "" && @ViewBag.OneMeetup.Description != null)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"bg-warning text-dark rounded-bottom px-4 py-2 border border-top-0\">\r\n      <i>\"");
#nullable restore
#line 26 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
     Write(ViewBag.OneMeetup.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</i>\r\n    </h4>\r\n");
#nullable restore
#line 28 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"

  }
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <div class=\"d-flex flex-row flex-wrap justify-content-center rounded\" id=\"oneBoxBig\">\r\n");
            WriteLiteral("    <div id=\"oneBoxl\">\r\n");
#nullable restore
#line 50 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
       if (@ViewBag.OneMeetup.Creator.UserId == @ViewBag.Session_UserId)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td class=\"align-middle border-0  m-2\"><a class=\"btn btn-danger my-2\"");
            BeginWriteAttribute("href", "\r\n          href=\"", 1811, "\"", 1872, 2);
            WriteAttributeValue("", 1829, "/meetups/delete/", 1829, 16, true);
#nullable restore
#line 53 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 1845, ViewBag.OneMeetup.MeetupId, 1845, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">✖\r\n          </a></td>\r\n");
#nullable restore
#line 55 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"

      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
       if (@ViewBag.OneMeetup.Creator.UserId != @ViewBag.Session_UserId)
      {
        bool found = false;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
         foreach (Reservation a in @ViewBag.OneMeetupFull.UserList)
        {
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
           if (a.UserId == @ViewBag.Session_UserId)
          {
            found = true;
            rId = a.ReservationId;
          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
           
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
         
        if (found && rId != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td class=\"align-middle border-0 m-2\">\r\n            <a class=\"btn btn-success my-2 shadow-sm\"");
            BeginWriteAttribute("href", " href=\"", 2428, "\"", 2489, 4);
            WriteAttributeValue("", 2435, "/reservations2/delete/", 2435, 22, true);
#nullable restore
#line 72 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 2457, rId, 2457, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2461, "/", 2461, 1, true);
#nullable restore
#line 72 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
WriteAttributeValue("", 2462, ViewBag.OneMeetup.MeetupId, 2462, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              ⭐\r\n            </a>\r\n          </td>\r\n");
#nullable restore
#line 76 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <td class=\"align-middle border-0 m-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dfd241611c04537e6293eccd5e9cacb1e234ee510311", async() => {
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7dfd241611c04537e6293eccd5e9cacb1e234ee510584", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 81 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                                              WriteLiteral(ViewBag.Session_UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7dfd241611c04537e6293eccd5e9cacb1e234ee513019", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 82 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MeetupId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                                                WriteLiteral(ViewBag.OneMeetup.MeetupId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n              <input type=\"submit\" value=\"☁\" class=\"btn btn-outline-success my-2\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </td>\r\n");
#nullable restore
#line 86 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
        }
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <table class=\"table table-hover table-dark table-sm m-1p-1 w-75\">\r\n        <thead class=\"border-0\">\r\n          <tr class=\"border-0\">\r\n");
            WriteLiteral("            <th id=\"th_header\" class=\"border-0 text-light\" scope=\"col\">RSVPs</th>\r\n\r\n          </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 98 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
           foreach (Reservation a in @ViewBag.OneMeetupFull.UserList)
          {
            numGuests++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"border-0\">\r\n\r\n");
            WriteLiteral("              <td class=\"border-0\">");
#nullable restore
#line 104 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                              Write(a.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 107 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n      </table>\r\n    </div>\r\n\r\n    <div id=\"oneBoxr\" class=\"text-light\">\r\n      <p>");
#nullable restore
#line 113 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
    Write(ViewBag.OneMeetup.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is hosting an event called\r\n        \"");
#nullable restore
#line 114 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
    Write(ViewBag.OneMeetup.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" on ");
#nullable restore
#line 114 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                                 Write(ViewData["DayOfWeek"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 114 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                                                         Write(ViewData["MonthDay"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </p>");
#nullable restore
#line 114 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                                                                                          if (@numGuests
      ==
      0)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>So far there are no people coming. </p>\r\n");
#nullable restore
#line 119 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
      }
      else if (@numGuests == 1)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>So far there is one person coming. </p>\r\n");
#nullable restore
#line 123 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>So far there are ");
#nullable restore
#line 126 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
                       Write(numGuests);

#line default
#line hidden
#nullable disable
            WriteLiteral(" people coming. </p>\r\n");
#nullable restore
#line 127 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p><i>\"");
#nullable restore
#line 128 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\OneMeetup.cshtml"
        Write(ViewBag.OneMeetup.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</i>\r\n      </p>\r\n    </div>\r\n\r\n\r\n\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meetup> Html { get; private set; }
    }
}
#pragma warning restore 1591
