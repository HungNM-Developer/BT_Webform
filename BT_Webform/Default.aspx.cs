using BT_Webform.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BT_Webform.DTO;

namespace BT_Webform
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                List<Shoe> shoes = new ShoeBUS().GetAll();
                gvShoe.DataSource = shoes;
                gvShoe.DataBind();
            }
        }

        protected void gvShoe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(gvShoe.SelectedRow.Cells[1].Text.Trim());
            Shoe shoe = new ShoeBUS().GetDetails(code);
            if (shoe != null)
            {
                txtCode.Text = shoe.Code.ToString();
                txtName.Text = shoe.Name;
                txtType.Text = shoe.Type;
                txtSize.Text = shoe.Size.ToString();
                txtPrice.Text = shoe.Price.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Shoe newShoe = new Shoe()
            {
                Code = int.Parse(txtCode.Text.Trim()),
                Name = txtName.Text.Trim(),
                Type = txtType.Text.Trim(),
                Size = int.Parse(txtSize.Text.Trim()),
                Price = int.Parse(txtPrice.Text.Trim()),
            };
            bool result = new ShoeBUS().Update(newShoe);
            if (result)
            {
                List<Shoe> shoes = new ShoeBUS().GetAll();
                gvShoe.DataSource = shoes;
                gvShoe.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Shoe> shoes = new ShoeBUS().SearchByName(keyword);
            gvShoe.DataSource = shoes;
            gvShoe.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Shoe newShoe = new Shoe()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Type = txtType.Text.Trim(),
                Size = int.Parse(txtSize.Text.Trim()),
                Price = int.Parse(txtPrice.Text.Trim()),
            };
            bool result = new ShoeBUS().AddItem(newShoe);
            if (result)
            {
                List<Shoe> shoes = new ShoeBUS().GetAll();
                gvShoe.DataSource = shoes;
                gvShoe.DataBind();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int code = int.Parse(gvShoe.SelectedRow.Cells[1].Text.Trim());
            bool result = new ShoeBUS().Delete(code);
            if (result)
            {
                List<Shoe> shoes = new ShoeBUS().GetAll();
                gvShoe.DataSource = shoes;
                gvShoe.DataBind();
            }          
        }
    }
}