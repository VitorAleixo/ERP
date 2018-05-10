using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServer.AppCode;
using MySql;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Xml.Serialization;
using System.Data.SqlClient;
using static WebServer.AppCode.BuscaProduto;

namespace WebServer.Web_Service
{


    /// <summary>
    /// Summary description for Login
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class Login : System.Web.Services.WebService
    {

        [WebMethod]
        public bool LoginSistema(
                  string Usuario
                , string Senha)
        {
            Criptografia c = new Criptografia();
            string senhaCriptografada = c.SHA256(Senha);

            LoginUsuario login = new LoginUsuario();

            login.Logar(Usuario, senhaCriptografada);


            if (login.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool CadastroFornecedor(
                  string Nome
                , string CPF
                , string CEP
                , string Endereco
                , string Bairro
                , string Cidade
                , string Complemento
                , string Estado
                , string Complemento2
                , string Numero
                , string Telefone
                , string Telefone2
                , string EMAIL)
        {
            CadastroFornecedor cadastroForn = new CadastroFornecedor();
            cadastroForn.GravarFornecedor(Nome, CPF, CEP, Endereco, Bairro, Cidade, Complemento, Estado, Complemento2, Numero, Telefone, Telefone2, EMAIL);

            if (cadastroForn.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool CadastroUsuario(
                     string Nome
                , string Funcao
                , string Departamento
                , string Usuario
                , string Senha
                , DateTime DataCriacao)
        {
            CadastroUsuario cadastroUser = new CadastroUsuario();
            cadastroUser.GravarUsuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao);

            if (cadastroUser.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [WebMethod]
        public bool CadastroProduto(
                   string CodigoProduto
                 , string Nome
                 , float Preco
                 , string UnidadeMedida
                 , float QtdMinima
                 , float QtdMaxima
                 , float QtdEstoque)
        {
            CadastroProduto cadastroProd = new CadastroProduto();
            cadastroProd.GravarProduto(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque);

            if (cadastroProd.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        [WebMethod]
        public string RetornaSetor(
                  string Usuario)
        {
            BuscaDepartamento principal = new BuscaDepartamento();
            principal.BuscaSetor(Usuario);

            return principal.Setor;
        }

        [WebMethod]
        public BuscaProduto.ListaProduto RetornaProduto()
        {
            BuscaProduto produto = new BuscaProduto();

            BuscaProduto.Program.RetornarProduto();

            return BuscaProduto.Program.list;

        }

        [WebMethod]
        public BuscaFornecedor.ListaFornecedor RetornaFornecedor()
        {
            BuscaFornecedor fornecedor = new BuscaFornecedor();

            BuscaFornecedor.Program.RetornarFornecedor();

            return BuscaFornecedor.Program.list; 
        }

        [WebMethod]
        public BuscaEstoque.ListaEstoque RetornaEstoque()
        {
            BuscaEstoque estoque = new BuscaEstoque();

            BuscaEstoque.Program.RetornarEstoque();

            return BuscaEstoque.Program.list;
        }

        [WebMethod]
        public BuscaUsuario.ListaUsuario RetornaUsuario()
        {
            BuscaUsuario Usuario = new BuscaUsuario();

            BuscaUsuario.Program.RetornarUsuario();

            return BuscaUsuario.Program.list;
        }
    }
}

