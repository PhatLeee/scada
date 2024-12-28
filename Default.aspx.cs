using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SQL _sql;
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
        _sql = new SQL(connectionString);

        HienThiGiaTriCamBien();
    }

    void HienThiGiaTriCamBien()
    {
        /* Literal_HienThiGiaTriCamBien.Text =
            "<table>"+
                "<tr>"+
                "<th> Tên-Cảm-Biến</th>"+            
                "<th> Giá Trị </th>" +
                "<th> Thời điểm cập nhật dữ liệu </th>" +
                "</tr>" +
                "<tr>" +
                "<td> CB1 </td>" +
                "<td> 100 </td>" +
                "<td> 2024 - 12 - 04 13:55:01 </td>" +
                "</tr>" +
                "<tr>" +
                "<td> CB1 </td>" +
                "<td> 12.35532 </td>" +
                "<td> 2024 - 12 - 04 15:46:01 </td>" +
                "</tr>" +
                "</table> "; */

        string html1 =
            "<table>" +
                "<tr>" +
                "<th> Tên-Cảm-Biến</th>" +
                "<th> Giá Trị </th>" +
                "<th> Thời điểm cập nhật dữ liệu </th>" +
                "</tr>";
        string html2 = "";
        DataTable cb = _sql.GetSensor();
        for (int i = 0; i < cb.Rows.Count; i++)
        {
            string TenCamBien = cb.Rows[i]["TenCamBien"].ToString();
            double GiaTri = Convert.ToDouble(cb.Rows[i]["GiaTri"]);
            DateTime NgayCapNhat = Convert.ToDateTime(cb.Rows[i]["NgayCapNhat"]);

            html2 +=
                "<tr>" +
                "<td>" + TenCamBien + "</td>" +
                "<td>" + GiaTri.ToString() + "</td>" +
                "<td>" + NgayCapNhat.ToString() + "</td>" +
                "</tr>";
        }

        string html3 = "</table> ";

        Literal_HienThiGiaTriCamBien.Text = html1 + html2 + html3;
    }
}