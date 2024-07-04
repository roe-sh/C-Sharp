<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task7_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
      
<body>
    <form id="form1" runat="server">
        <div class="mb-3">
            <label for="Numer1" class="form-label">Numer1</label>
            <asp:TextBox ID="Numer1" runat="server" CssClass="form-control" placeholder="Numer1" />
        </div>

        <br />
        <div class="mb-3">
            <label for="Numer2" class="form-label">Numer2</label>
            <asp:TextBox ID="Numer2" runat="server" CssClass="form-control" placeholder="Numer2" />
        </div>

        <div class="container">
            <div class="row">
                <asp:Button class="col" ID="ButtonAdd" runat="server" Text="+" OnClick="ButtonAdd_Click" style="background-color:green;" />
                <asp:Button class="col"  ID="ButtonSubtract" runat="server" Text="-" OnClick="ButtonSubtract_Click" style="background-color:yellow;" />
                <asp:Button class="col" ID="ButtonMultiply" runat="server" Text="*" OnClick="ButtonMultiply_Click" style="background-color:green;" />
            </div>
        </div>

        <div class="mb-3 mt-3">
            <asp:Label ID="resultLabel" runat="server" CssClass="form-label"></asp:Label>
        </div>
    </form>
</body>
</html>
