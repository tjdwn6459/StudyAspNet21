using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmrRichControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CalMain_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write(CalMain.SelectedDate.ToShortDateString() + "<hr/>"); // ToShortDateString 현재 DateTime 개체의 값을 해당하는 짧은 날짜 문자열 표현으로 변환합니다.
        }
    }
}