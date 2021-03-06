﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmCadastroProduto : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }

        }
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        void LimparCampos()
        {
            txtCod.Text = "";
            txtId.Text = "";
            txtNome.Text = "";
            txtQtdEst.Text = "";
            txtQtdMax.Text = "";
            txtQtdMin.Text = "";
            txtTipo.Text = "";
            txtPreco.Text = "";
            cmbUM.SelectedIndex = -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "" || txtNome.Text == "" ||  txtQtdEst.Text == "" || txtQtdMax.Text == "" || txtQtdMin.Text == "" || txtTipo.Text == "")
                {
                    MessageBox.Show("OOPS! Tem algum dado faltando!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    localhostAmx.Almoxarifado cadastroProduto = new localhostAmx.Almoxarifado();
                    string CodigoProduto = txtCod.Text;
                    string Nome = txtNome.Text;
                    double Preco = Convert.ToDouble(txtPreco.Text.Replace(".", "").Replace(",", "."));
                    string UnidadeMedida = cmbUM.SelectedItem.ToString();
                    float QtdMinima = float.Parse(txtQtdMin.Text.Replace(".", "").Replace(",", "."));
                    float QtdMaxima = float.Parse(txtQtdMax.Text.Replace(".", "").Replace(",", "."));
                    float QtdEstoque = float.Parse(txtQtdEst.Text.Replace(".", "").Replace(",", "."));
                    string Tipo = txtTipo.Text;

                    int IdProduto = cadastroProduto.CadastroProduto(CodigoProduto, Nome,Preco, UnidadeMedida, QtdMinima, QtdMaxima, QtdEstoque, Tipo);

   
                    if (IdProduto > 0)
                    {
                        cadastroProduto.CadastroProdutoEstoque(IdProduto, QtdMinima, QtdMaxima, QtdEstoque);
                        DialogResult dialogResult = MessageBox.Show("Cadastrado com Sucesso!\nDeseja continuar cadastrando?", "Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            LimparCampos();
                        }
                        else
                        {
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Produto!!!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
