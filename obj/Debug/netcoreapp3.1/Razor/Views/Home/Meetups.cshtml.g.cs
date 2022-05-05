#pragma checksum "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42dbb627288bcef37bfd77a64c26745ac9bc41bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Meetups), @"mvc.1.0.view", @"/Views/Home/Meetups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42dbb627288bcef37bfd77a64c26745ac9bc41bb", @"/Views/Home/Meetups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b02ad6caa2dc5987ab88b6a07b1a70792c8219", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Meetups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meetup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shadow-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/reservations/reserve"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
  
    ViewData["Title"] = "Events";
    ViewData["Header"] = "Events";
    int rId = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table table-hover m-0 p-0 shadow\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral(@"                <th id=""th_header"" class=""bg-dark text-light"" scope=""col"">Event</th>
                <th id=""th_header"" class=""bg-dark text-light"" scope=""col"">Date</th>
                <th id=""th_header"" class=""bg-dark text-light"" scope=""col"">RSVP</th>

            </tr>
        </thead>
        <tbody class=""bg-light border rounded"">
");
#nullable restore
#line 20 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
             foreach (Meetup x in @ViewBag.AllMeetups)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                 if (x.Date > DateTime.Now)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                         if (@x.UserId == @ViewBag.Session_UserId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"align-middle\">\r\n                                <p class=\"m-0 p-0 shadow-sm\"><a class=\"btn btn-primary btn-block my-2\"");
            BeginWriteAttribute("href", "\r\n                            href=\"", 1084, "\"", 1140, 2);
            WriteAttributeValue("", 1120, "/meetups/", 1120, 9, true);
#nullable restore
#line 32 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
WriteAttributeValue("", 1129, x.MeetupId, 1129, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Your ");
#nullable restore
#line 32 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                                        Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            </td>\r\n");
#nullable restore
#line 34 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"


                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"align-middle\">\r\n                                <p class=\"m-0 p-0 shadow-sm\"><a class=\"btn btn-secondary btn-block my-2\"");
            BeginWriteAttribute("href", "\r\n                            href=\"", 1447, "\"", 1503, 2);
            WriteAttributeValue("", 1483, "/meetups/", 1483, 9, true);
#nullable restore
#line 41 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
WriteAttributeValue("", 1492, x.MeetupId, 1492, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                                   Write(x.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s ");
#nullable restore
#line 41 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                                                     Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            </td>\r\n");
#nullable restore
#line 43 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-middle\">\r\n                            <p class=\"m-0 p-0\">");
#nullable restore
#line 45 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                          Write(x.Date.ToString("MMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"m-0 p-0 text-muted\"><small>");
#nullable restore
#line 46 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                                            Write(x.Date.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                        </td>\r\n");
#nullable restore
#line 48 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                         if (@x.UserId == @ViewBag.Session_UserId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"align-middle\"><a class=\"btn btn-danger btn-block my-2\"");
            BeginWriteAttribute("href", " href=\"", 2055, "\"", 2089, 2);
            WriteAttributeValue("", 2062, "/meetups/delete/", 2062, 16, true);
#nullable restore
#line 50 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
WriteAttributeValue("", 2078, x.MeetupId, 2078, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">✖\r\n                                    </a></td>\r\n");
#nullable restore
#line 52 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                         if (@x.UserId != @ViewBag.Session_UserId)
                        {
                            bool found = false;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                             foreach (Reservation a in @ViewBag.OneUserReservations)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                 if (a.MeetupId == x.MeetupId)
                                {
                                    found = true;
                                    rId = a.ReservationId;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                             
                            if (found && rId != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle\">\r\n                                    <a class=\"btn btn-success btn-block my-2 shadow-sm\"");
            BeginWriteAttribute("href", " href=\"", 2984, "\"", 3016, 2);
            WriteAttributeValue("", 2991, "/reservations/delete/", 2991, 21, true);
#nullable restore
#line 69 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
WriteAttributeValue("", 3012, rId, 3012, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ⭐\r\n                                    </a>\r\n                                </td>\r\n");
#nullable restore
#line 73 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td class=\"align-middle\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42dbb627288bcef37bfd77a64c26745ac9bc41bb13608", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42dbb627288bcef37bfd77a64c26745ac9bc41bb13907", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42dbb627288bcef37bfd77a64c26745ac9bc41bb16390", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 79 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MeetupId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                                                                          WriteLiteral(x.MeetupId);

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
                WriteLiteral("\r\n                                        <input type=\"submit\" value=\"☁\" class=\"btn btn-outline-success btn-block my-2\">\r\n                                    ");
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
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 83 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tr>\r\n");
#nullable restore
#line 87 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\nieme\Documents\CodingDojo\CSharpStack2022\exam_01\Views\Home\Meetups.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
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
