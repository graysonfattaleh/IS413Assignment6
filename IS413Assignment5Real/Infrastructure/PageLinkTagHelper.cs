using System;
using System.Linq;
using IS413Assignment5Real.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IS413Assignment5Real.Models
{
    //litty
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        // will help generate tag  helpers
        private IUrlHelperFactory urlHelperFactory;
        //makes these methods accessible pbulicly
        public PageLinkTagHelper(IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        // this mans straight up said I dont need to know what this does
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }
        // hypothetical variable stuff
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        //Overriding
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");
            // change attributes of r4esulting div
            
            for(int i =1; i <= PageModel.TotalPages; i++)
            {
                // make new a tag
                TagBuilder tag = new TagBuilder("a");
                // check and see enabled classes, makes sense I guess
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);

                }
                // put page number in href add specific class for each a tag etc
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString());
                //tag.Attributes["class"] = "text-center ank";
                tag.Attributes["id"] = "pagenumber" +i.ToString();
                result.InnerHtml.AppendHtml(tag).AppendHtml(" ");
            }
            output.Content.AppendHtml(result.InnerHtml);
            // changes arrtibutes of resulting div
            output.Attributes.SetAttribute("class", "navvy");

        }
    }
}
