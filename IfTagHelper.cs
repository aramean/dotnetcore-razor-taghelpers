using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{
  [HtmlTargetElement(Attributes = "exclude-if")]
  public class IfTagHelper : TagHelper
  {

    // Usage <element exlude-if="1 == 1" />

    public string ExcludeIf { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {

      List<string> valueIs = Regex.Split(ExcludeIf, " == ").ToList();

      if ((valueIs.ElementAt(1) == "null" && valueIs.ElementAt(0).Length == 0) || (valueIs.ElementAt(0) == valueIs.ElementAt(1)))
      {
        output.TagName = "";
        output.Content.SetContent("");
      }
    }

  }
}
