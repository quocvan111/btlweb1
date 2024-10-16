<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="dssp.aspx.cs" Inherits="BTLLTW_webBanQuanAo.male" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style/base.css">
    <link rel="stylesheet" href="style/styleIndex.css">
    <link rel="stylesheet" href="style/styleList.css">
</head>

<body>
    <div class="body">
        <div class="title"><h1>THỜI TRANG <span id="showTitle" runat ="server"></span></h1>
        </div>
        <hr/>
        <br/>
        <div class="container">
            <div class="sidebar col-3">
                <h2>Bộ lọc</h2>
                <form id="form1" runat="server" method="post">
                    <select name="filterdo" id="filterdo" >
                        <option value=""></option>
                        <option value="casual">Đồ mặc hằng ngày</option>
                        <option value="work">Đồ công sở</option>
                        <option value="sports">Đồ thể thao</option>
                    </select>
                    <select name="filtertien" id="filtertien" >
                        <option value=""></option>
                        <option value="giatren500">>500.000</option>
                        <option value="gia200-500">200.000-500.000</option>
                        <option value="giaduoi200"><200.000</option>
                    </select>
                    <input type="submit" name="loc" value="Lọc " />
                </form>
                
            </div>
            <div class ="content col-9" id="hienoday" runat="server" style=" display: flex; flex-wrap: wrap;gap: 20px;">

            </div>
        </div>
     </div>
</body>
</html>

</asp:Content>