﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Decision.Framework.HtmlHelpers;
    using Decision.Utility;
    using Decision.Web.HtmlHelpers;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Question/_Create.cshtml")]
    public partial class _Views_Question__Create_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.Question.AddQuestionViewModel>
    {
        public _Views_Question__Create_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Question\_Create.cshtml"
  
    var optionId = Model.Options != null && Model.Options.Any() ? Model.Options.Count : 0;
  
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Question\_Create.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Question\_Create.cshtml"
         using (Html.BeginForm(MVC.Question.Create(), FormMethod.Post, new { @class = "form-horizontal", id = "createQuestionForm", autocomplete = "off" }))
        {
            
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Question\_Create.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Question\_Create.cshtml"
                                    


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 12 "..\..\Views\Question\_Create.cshtml"
           Write(Html.LabelFor(model => model.Title, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 14 "..\..\Views\Question\_Create.cshtml"
               Write(Html.NoAutoCompleteTextBoxFor(model => model.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 15 "..\..\Views\Question\_Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 18 "..\..\Views\Question\_Create.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Question\_Create.cshtml"
           Write(Html.LabelFor(model => model.Weight, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"col-md-5\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Views\Question\_Create.cshtml"
               Write(Html.NoAutoCompleteTextBoxForNumber(model => model.Weight));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..\Views\Question\_Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Weight, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 26 "..\..\Views\Question\_Create.cshtml"

           
            if (Model.Options != null && Model.Options.Any())
            {
                for (var i = 0; i < Model.Options.Count; i++)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group option\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 33 "..\..\Views\Question\_Create.cshtml"
                   Write(Html.Label("Options[" + i + "].Name","متن گزینه", htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 35 "..\..\Views\Question\_Create.cshtml"
                       Write(Html.TextBox("Options[" + i + "].Name",Model.Options.ElementAt(i).Name, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 36 "..\..\Views\Question\_Create.cshtml"
                       Write(Html.ValidationMessage("Options[" + i + "].Name", "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\Question\_Create.cshtml"
                   Write(Html.Label("Options[" + i + "].Weight","وزن ارزش گزینه", htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 40 "..\..\Views\Question\_Create.cshtml"
                       Write(Html.TextBox("Options[" + i + "].Weight", Model.Options.ElementAt(i).Weight, new { @class = "form-control" ,dir="ltr"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Views\Question\_Create.cshtml"
                       Write(Html.ValidationMessage("Options[" + i + "].Weight", "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 44 "..\..\Views\Question\_Create.cshtml"

                }
            }
           

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" id=\"questionSubmit\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-md-6 col-md-offset-2\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"createQuestionButton\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" onclick=\"formDataSubmitWidOutEditor(this, \'createQuestionForm\', \'#questionList\'," +
" \'#create-question\')\"");

WriteLiteral(" data-loading-text=\"در حال ارسال اطلاعات\"");

WriteLiteral(" class=\"btn btn-success btn-md\"");

WriteLiteral(">\r\n                        ثبت سوال جدید\r\n                    </button>\r\n        " +
"            ");

WriteLiteral("\r\n                  \r\n                </div>\r\n               \r\n            </div>" +
"\r\n");

            
            #line 59 "..\..\Views\Question\_Create.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
