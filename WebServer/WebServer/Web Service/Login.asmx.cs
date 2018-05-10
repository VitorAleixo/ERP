﻿using System;
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
        public int CadastroUsuario(
                     string Nome
                , string Funcao
                , string Departamento
                , string Usuario
                , string Senha
                , DateTime DataCriacao)
        {
            CadastroUsuario cadastroUser = new CadastroUsuario();
           return cadastroUser.GravarUsuario(Nome, Funcao, Departamento, Usuario, Senha, DataCriacao);

        }

        [WebMethod]

        public bool CadastroPermissoesUsuario(
                    string Departamento
                  , int IdUsuario
                  , string Nome)
        {
            CadastroUsuario cadastrouser = new CadastroUsuario();
            cadastrouser.GravarPermissoes(Departamento, IdUsuario, Nome);
            if (cadastrouser.valor == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public int CadastroProduto(
                   string CodigoProduto
                 , string Nome
                 , float Preco
                 , string UnidadeMedida
                 , float QtdMinima
                 , float QtdMaxima
                 , float QtdEstoque)

        {
            CadastroProduto cadastroProd = new CadastroProduto();
            return cadastroProd.GravarProduto(CodigoProduto, Nome, Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque);

        }

        [WebMethod]
        public bool CadastroProdutoEstoque(
                  int IdProduto
                , float QtdMinima
                , float QtdMaxima
                , float QtdEstoque)

        {
            CadastroProduto cadastroProd = new CadastroProduto();
            cadastroProd.GravarProdutoEstoque(IdProduto, QtdMinima, QtdMaxima, QtdEstoque);

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
            BuscaProduto.Program.RetornarProduto();

            return BuscaProduto.Program.list;

        }

        [WebMethod]
        public BuscaFornecedor.ListaFornecedor RetornaFornecedor()
        {
            BuscaFornecedor.Program.RetornarFornecedor();

            return BuscaFornecedor.Program.list;
        }

        [WebMethod]
        public BuscaEstoque.ListaEstoque RetornaEstoque()
        {
            BuscaEstoque.Program.RetornarEstoque();

            return BuscaEstoque.Program.list;
        }

        [WebMethod]
        public BuscaUsuario.ListaUsuario RetornaUsuario()
        {
            BuscaUsuario.Program.RetornarUsuario();

            return BuscaUsuario.Program.list;
        }

        [WebMethod]
        public BuscaSolicitacao.ListaSolicitacao RetornarSolicitacao()
        {
            BuscaSolicitacao.Program.RetornaSolicitacao();

            return BuscaSolicitacao.Program.list;
        }

        [WebMethod]
        public int GerarPedido(
                   string Solicitante
                 , string Urgencia
                 , string Motivo)
        {
            CadastroGerarPedido gerarpedido = new CadastroGerarPedido();
            return gerarpedido.GravarPedido(Solicitante, Urgencia, Motivo);
        }

        [WebMethod]
        public bool GerarPedidoItem(
                  string Cod
                , string Nome
                , double QtdEstoque
                , double QtdMaxima
                , double QtdMinima
                , string UnidadeMedida
                , double Solicitar
                , int IdPedido)
        {
            CadastroGerarPedido gerarpedido = new CadastroGerarPedido();
            gerarpedido.GravarPedidoItens(Cod, Nome, QtdEstoque, QtdMaxima, QtdMinima, UnidadeMedida, Solicitar, IdPedido);
            if (gerarpedido.valorItem == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

