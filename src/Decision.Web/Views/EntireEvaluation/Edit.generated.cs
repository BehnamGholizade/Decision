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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EntireEvaluation/Edit.cshtml")]
    public partial class _Views_EntireEvaluation_Edit_cshtml : System.Web.Mvc.WebViewPage<Decision.ViewModel.EntireEvaluation.EditEntireEvaluationViewModel>
    {
        public _Views_EntireEvaluation_Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"panel-title\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-edit\"");

WriteLiteral("></i>\r\n                </h3>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\EntireEvaluation\Edit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\EntireEvaluation\Edit.cshtml"
                 using (Html.BeginForm(MVC.EntireEvaluation.Edit(), FormMethod.Post, new { @class = "form-horizontal", id = "editEntireEvaluationForm", autocomplete = "off", enctype = "multipart/form-data" }))
                {
                    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\EntireEvaluation\Edit.cshtml"
               Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\EntireEvaluation\Edit.cshtml"
                                            
                    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\EntireEvaluation\Edit.cshtml"
               Write(Html.HiddenFor(model => model.Id));

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\EntireEvaluation\Edit.cshtml"
                                                      
                    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\EntireEvaluation\Edit.cshtml"
               Write(Html.HiddenFor(model => model.RowVersion));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\EntireEvaluation\Edit.cshtml"
                                                              
                    
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\EntireEvaluation\Edit.cshtml"
               Write(Html.HiddenFor(model => model.ApplicantId));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\EntireEvaluation\Edit.cshtml"
                                                               
                    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\EntireEvaluation\Edit.cshtml"
               Write(Html.HiddenFor(model => model.AttachmentScan));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\EntireEvaluation\Edit.cshtml"
                                                                  


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 23 "..\..\Views\EntireEvaluation\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Brief, htmlAttributes: new { @class = "control-label col-md-1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 25 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.Brief, new { @class = "form-control ckeditor", rows = 3 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 26 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Brief, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 29 "..\..\Views\EntireEvaluation\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 31 "..\..\Views\EntireEvaluation\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Content, htmlAttributes: new { @class = "control-label col-md-1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 33 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.Content, new { @class = "form-control ckeditor", rows = 10 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 34 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 37 "..\..\Views\EntireEvaluation\Edit.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 39 "..\..\Views\EntireEvaluation\Edit.cshtml"
                   Write(Html.LabelFor(model => model.Foible, htmlAttributes: new { @class = "control-label col-md-1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.Foible, new { @class = "form-control ckeditor", rows = 3 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Foible, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 46 "..\..\Views\EntireEvaluation\Edit.cshtml"
                   Write(Html.LabelFor(model => model.StrongPoint, htmlAttributes: new { @class = "control-label col-md-1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 48 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.TextAreaFor(model => model.StrongPoint, new { @class = "form-control ckeditor", rows = 3 }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.StrongPoint, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 52 "..\..\Views\EntireEvaluation\Edit.cshtml"



            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 55 "..\..\Views\EntireEvaluation\Edit.cshtml"
                   Write(Html.LabelFor(model => model.EvaluatorId, htmlAttributes: new { @class = "control-label col-md-1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 57 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.DropDownListFor(model => model.EvaluatorId, Model.Evaluators, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 58 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.EvaluatorId, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 62 "..\..\Views\EntireEvaluation\Edit.cshtml"
                   Write(Html.LabelFor(model => model.EvaluationDate, htmlAttributes: new { @class = "control-label col-md-1" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 64 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.EditorFor(model => model.EvaluationDate, MVC.Shared.Views.EditorTemplates.PersianDatePicker));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 65 "..\..\Views\EntireEvaluation\Edit.cshtml"
                       Write(Html.ValidationMessageFor(model => model.EvaluationDate, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 68 "..\..\Views\EntireEvaluation\Edit.cshtml"
              
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"panel-footer \"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"editEntireEvaluationButton\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" onclick=\"AjaxForm.CustomSubmitWithEditor(this, \'editEntireEvaluationForm\')\"");

WriteLiteral(" data-loading-text=\"در حال ارسال اطلاعات\"");

WriteLiteral(" class=\"btn btn-success btn-md\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-check-square-o\"");

WriteLiteral("></i>\r\n                        ذخیره تغییرات\r\n                    </button>\r\n    " +
"                <a");

WriteLiteral(" class=\"btn btn-default btn-md\"");

WriteAttribute("href", Tuple.Create("\r\n                       href=\"", 4627), Tuple.Create("\"", 4715)
            
            #line 79 "..\..\Views\EntireEvaluation\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 4658), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.EntireEvaluation.List(Model.ApplicantId))
            
            #line default
            #line hidden
, 4658), false)
);

WriteLiteral(" role=\"button\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-arrow-right\"");

WriteLiteral("></i>\r\n                        انصراف\r\n                    </a>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");

DefineSection("Menu", () => {

WriteLiteral("\r\n");

            
            #line 92 "..\..\Views\EntireEvaluation\Edit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 92 "..\..\Views\EntireEvaluation\Edit.cshtml"
      Html.RenderPartial(MVC.Applicant.Views._ApplicantRelatedLinksBuilder, Model.ApplicantId);
            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 95 "..\..\Views\EntireEvaluation\Edit.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 96 "..\..\Views\EntireEvaluation\Edit.cshtml"
Write(Scripts.Render("~/bundles/datePicker"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 97 "..\..\Views\EntireEvaluation\Edit.cshtml"
Write(Scripts.Render("~/bundles/editor"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
