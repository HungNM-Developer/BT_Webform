<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BT_Webform.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="form-group">
                <label for="txtKeyword">Keyword</label>
                <asp:TextBox type="text" class="form-control"  placeholder="Enter keyword" ID="txtKeyword" runat="server"></asp:TextBox>
            </div>
            <asp:Button type="button" class="btn btn-outline-primary" ID="btnSearch" runat="server" Text="SEARCH" OnClick="btnSearch_Click" /><br />
            <br />
            <br />

            <asp:GridView class="col" ID="gvShoe" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvShoe_SelectedIndexChanged"></asp:GridView>
            <br />
            <br />
            <form>
                <div class="form-group">
                    <label for="txtCode">Code</label>
                    <asp:TextBox type="text" class="form-control"  placeholder="Enter code" ID="txtCode" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtName">Name</label>
                    <asp:TextBox type="text" class="form-control"  placeholder="Enter name" ID="txtName" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtType">Type</label>
                    <asp:TextBox type="text" class="form-control"  placeholder="Enter type" ID="txtType" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtSize">Size</label>
                    <asp:TextBox type="text" class="form-control"  placeholder="Enter size" ID="txtSize" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtPrice">Price</label>
                    <asp:TextBox type="text" class="form-control"  placeholder="Enter price" ID="txtPrice" runat="server"></asp:TextBox>
                </div>
            </form>

            <br />
            <asp:Button type="button" class="btn btn-success" ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
            <asp:Button type="button" class="btn btn-primary" ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
            <asp:Button type="button" class="btn btn-danger" ID="btnDelet" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
            <br />
            <br />
        </div>

    </form>
</body>
<script src="Scripts/bootstrap.min.js"></script>

</html>
