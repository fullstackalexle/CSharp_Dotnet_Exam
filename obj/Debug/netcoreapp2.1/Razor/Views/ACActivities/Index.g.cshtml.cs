#pragma checksum "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d09ae6c31c6dbf2d8bf9577476941d769fd07297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ACActivities_Index), @"mvc.1.0.view", @"/Views/ACActivities/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ACActivities/Index.cshtml", typeof(AspNetCore.Views_ACActivities_Index))]
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
#line 1 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 1 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09ae6c31c6dbf2d8bf9577476941d769fd07297", @"/Views/ACActivities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_ACActivities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(30, 266, true);
            WriteLiteral(@"
<h1>Dojo Activity Center</h1>

<table class=""table"">
	<thead class=""thead-dark"">
		<tr>
			<th>Activity</th>
			<th>Date and Time</th>
			<th>Duration</th>
			<th>Event Coordinator</th>
			<th>No. of Participants</th>
			<th>Actions</th>
		</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 17 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
         if(@ViewBag.AllACActivities.Count > 0)
		{
			

#line default
#line hidden
#line 19 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
             foreach(var activity in @ViewBag.AllACActivities)
			{
				var participants = (IEnumerable<Join>)@activity.Participants;
				

#line default
#line hidden
            BeginContext(471, 16, true);
            WriteLiteral("<tr>\n\t\t\t\t\t<td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 487, "\"", 528, 2);
            WriteAttributeValue("", 494, "/activities/", 494, 12, true);
#line 23 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
WriteAttributeValue("", 506, activity.ACActivityId, 506, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(529, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(531, 14, false);
#line 23 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                                                                Write(activity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(545, 19, true);
            WriteLiteral("</a></td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(565, 13, false);
#line 24 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                   Write(activity.Date);

#line default
#line hidden
            EndContext();
            BeginContext(578, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(594, 17, false);
#line 25 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                   Write(activity.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(611, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(627, 18, false);
#line 26 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                   Write(activity.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(645, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 27 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                     if(@activity.Participants.Count > 0)
					{

#line default
#line hidden
            BeginContext(701, 10, true);
            WriteLiteral("\t\t\t\t\t\t<td>");
            EndContext();
            BeginContext(712, 27, false);
#line 29 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                       Write(activity.Participants.Count);

#line default
#line hidden
            EndContext();
            BeginContext(739, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 30 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
					}
					else
					{

#line default
#line hidden
            BeginContext(769, 17, true);
            WriteLiteral("\t\t\t\t\t\t<td>0</td>\n");
            EndContext();
#line 34 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
					}

#line default
#line hidden
            BeginContext(793, 5, true);
            WriteLiteral("\t\t\t\t\t");
            EndContext();
#line 35 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
                     if(@activity.UserId == @ViewBag.CurrUserId)
					{

#line default
#line hidden
            BeginContext(850, 18, true);
            WriteLiteral("\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(868, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b59d06acd21f46b78626f9a48d290b0a", async() => {
                BeginContext(925, 58, true);
                WriteLiteral("\n\t    \t\t\t\t\t\t<input type=\"submit\" value=\"Delete\" />\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 882, "/activities/", 882, 12, true);
#line 38 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
AddHtmlAttributeValue("", 894, activity.ACActivityId, 894, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 916, "/delete", 916, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(990, 13, true);
            WriteLiteral("\n\t\t\t\t\t\t</td>\n");
            EndContext();
#line 42 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
					}
					else if(participants.Any(r => r.UserId == @ViewBag.CurrUserId))
					{

#line default
#line hidden
            BeginContext(1086, 18, true);
            WriteLiteral("\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1104, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5e0809618f4016921df938c3fc7b9e", async() => {
                BeginContext(1160, 57, true);
                WriteLiteral("\n\t    \t\t\t\t\t\t<input type=\"submit\" value=\"Leave\" />\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1118, "/activities/", 1118, 12, true);
#line 46 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
AddHtmlAttributeValue("", 1130, activity.ACActivityId, 1130, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1152, "/leave", 1152, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1224, 18, true);
            WriteLiteral("\n\t\t\t\t\t\t</td>\t\t\t\t\t\n");
            EndContext();
#line 50 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
					}
					else 
					{

#line default
#line hidden
            BeginContext(1267, 18, true);
            WriteLiteral("\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1285, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59bbe34f821b4455b2bbd2d4ee4e6b82", async() => {
                BeginContext(1340, 56, true);
                WriteLiteral("\n\t    \t\t\t\t\t\t<input type=\"submit\" value=\"Join\" />\n\t\t\t\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1299, "/activities/", 1299, 12, true);
#line 54 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
AddHtmlAttributeValue("", 1311, activity.ACActivityId, 1311, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1333, "/join", 1333, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1403, 13, true);
            WriteLiteral("\n\t\t\t\t\t\t</td>\n");
            EndContext();
#line 58 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
					}

#line default
#line hidden
            BeginContext(1423, 10, true);
            WriteLiteral("\t\t\t\t</tr>\n");
            EndContext();
#line 60 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
			}

#line default
#line hidden
#line 60 "/Users/alexle/source/CodingDojo/Coding-Dojo-C#/ActivityCenter/Views/ACActivities/Index.cshtml"
             	
		}

#line default
#line hidden
            BeginContext(1443, 66, true);
            WriteLiteral("\t</tbody>\n</table>\n<a href=\"/activities/new\">Add New Activity</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
