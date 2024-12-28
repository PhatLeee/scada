<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Hello World!
    </div>
        <div>
            <asp:Literal ID="Literal_HienThiGiaTriCamBien" runat="server"></asp:Literal>
            <%--<table>
                <tr>
                    <th>Tên Cảm Biến</th>
                    <th>Giá Trị</th>
                    <th>Thời điểm cập nhật dữ liệu</th>
                </tr>
                <tr>
                    <td>CB1</td>
                    <td>100</td>
                    <td>2024-12-04 13:55:01</td>
                </tr>
                <tr>
                    <td>CB1</td>
                    <td>12.35532</td>
                    <td>2024-12-04 15:46:01</td>
                </tr>
            </table>--%>
        </div>
    </form>
</body>
</html>
