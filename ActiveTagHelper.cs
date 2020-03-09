using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{

    [HtmlTargetElement("a", Attributes = "active-when")]
    public class ActiveTagHelper : TagHelper
    {

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string ActiveWhen { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var currentClass = output.Attributes["class"]?.Value?.ToString();
            var currentRoute = ViewContext.RouteData.Values["Controller"].ToString() + "/" + ViewContext.RouteData.Values["Action"].ToString();

            output.Attributes.RemoveAll("active-when");

            if (ActiveWhen == currentRoute)
                output.Attributes.SetAttribute("class", currentClass + " active");
        }
    }
}