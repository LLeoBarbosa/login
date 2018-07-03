using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class Inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if(Session["usuario"] != null){

            txtUsuario.Text = "Você esta logado: " + Session["usuario"].ToString();
            
        }

    }

    protected void btSair_Click(object sender, EventArgs e)

    {

        if (MessageBox.Show("Deseja sair do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {

            Session.Remove("usuario");
            Response.Redirect("~/Login.aspx");

        }
        
            

    }
}