using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{

  [HtmlTargetElement("phone")]
  public class PhoneTagHelper : TagHelper
  {

    // Usage <phone call-to="..." icon="true|false" />. 

    public string CallTo { get; set; }
    public bool Icon { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      output.TagName = "a";

      var number = new string(CallTo.Where(char.IsNumber).ToArray());
      output.Attributes.SetAttribute("href", "callto:" + number);
      output.Content.SetContent(CallTo);

      if (Icon)
        output.PreElement.SetHtmlContent("<i class=\"fa fa-phone\">&nbsp;</i>");

    }
  }

}
