using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["usuario"] != null) {

            Response.Redirect("~/Login.aspx");
        
        }

    }
    protected void btnBotao_Click(object sender, EventArgs e)
    {

        SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["login"].ToString());

        conexao.Open();

        string consulta =  "select count(*) from usuarios where usuario= '" + txtNome.Text + "' and senha='" + txtSenha.Text + "' ";

        SqlCommand comando = new SqlCommand(consulta, conexao);

        string saida = comando.ExecuteScalar().ToString();

        if (saida == "1") {

            Session["usuario"] = txtNome.Text;

            Response.Redirect("~/Inicio.aspx");
        
        }
        else
        {

           //Response.Write("Login falhou");
            txtTexto.Text = "Falha ao logar no sistema";

        }



    }
}