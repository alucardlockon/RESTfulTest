<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>实习生学习</title>
    <%--引用--%>

    <script>

    </script>
    <style>
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            html标签控件 
            <input type="text" id="html_name" runat="server" value=""  />

            asp服务控件<asp:TextBox runat="server"  ID="fm_name" Text="1"></asp:TextBox>


            <input type="text" id="name" runat="server" />
            <input type="text" id="sex" runat="server" />
            <input type="text" id="age" runat="server"/>

            <button runat="server" id="btnSave" onserverclick="BtnSave_Click">转换</button>
           
<%--            姓名、性别、年龄
            数据行--%>
            控件

            <button runat="server" id="button1" onserverclick="button1_Click">查找</button>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <input  runat="server" type="text" id="XUEH" />
            <button runat="server" id="button2" onserverclick="button2_Click">插入</button>
            <button runat="server" id="button3" onserverclick="button3_Click">修改</button>

            <button runat="server" id="button4" onserverclick="button4_Click">删除</button>
        </div>
    </form>

</body>
</html>
