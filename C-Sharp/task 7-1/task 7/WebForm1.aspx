<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task_7.WebForm1" %>

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
            <label for="name" class="form-label">Name:</label>
            <asp:TextBox ID="name" runat="server" CssClass="form-control" placeholder="Name" />
        </div>
        <div class="mb-3 mt-3">
            <label for="email" class="form-label">Email:</label>
            <asp:TextBox ID="email" runat="server" CssClass="form-control" placeholder="Enter email" TextMode="Email" />
        </div>
        <div class="mb-3 mt-3">
            <label for="id" class="form-label">ID:</label>
            <asp:TextBox ID="id" runat="server" CssClass="form-control" placeholder="ID" />
        </div>
        <div class="form-check mb-3">
            <label >Gender:</label><br />
            <p>
                <asp:RadioButton ID="female" runat="server" GroupName="gender" Text="Female"  />
            </p>
            <p>
                <asp:RadioButton ID="male" runat="server" GroupName="gender" Text="Male" />

            </p>
        </div>
        <div class="form-check mb-3">
            <label >Course:</label>
            <asp:RadioButton ID="courseCSharp" runat="server" GroupName="course" Text="C#" />
            <asp:RadioButton ID="courseCpp" runat="server" GroupName="course" Text="C++"  />
        </div>
        <div class="form-check mb-3">
            <label for="comment">Comments:</label>
            <asp:TextBox ID="comment" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
           
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass="btn btn-primary" />
        </div>
        <div class="mb-3 mt-3">
            <asp:Label ID="resultLabel" runat="server" CssClass="form-label"></asp:Label>
        </div>
    </form>
</body>
</html>

