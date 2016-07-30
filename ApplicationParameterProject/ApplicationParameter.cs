using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanalog
{
    [ToolboxData("<{0}:ApplicationParameter runat=server></{0}:ApplicationParameter>")]
    public class ApplicationParameter : Parameter
    {
        public string AppKeyName { get; set; }

        public ApplicationParameter()
        {
            if (HttpContext.Current.Application[AppKeyName] != null)
                this.DefaultValue = HttpContext.Current.Application[AppKeyName].ToString();
            else
                this.DefaultValue = "31";

            this.Type = System.TypeCode.Int16;
        }
    }
}
