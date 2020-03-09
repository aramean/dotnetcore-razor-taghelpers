using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Web.TagHelpers
{

  [HtmlTargetElement("email")]
  public class EmailTagHelper : TagHelper
  {

    // Usage <email mail-to="..." icon="true|false" />. 

    public string MailTo { get; set; }
    public bool Icon { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      output.TagName = "a";

      var address = MailTo;
      output.Attributes.SetAttribute("href", "mailto:" + address);
      output.Content.SetContent(address);

      if (Icon)
        output.PreElement.SetHtmlContent("<i class=\"fa fa-envelope-o\">&nbsp;</i>");

    }
  }

}
