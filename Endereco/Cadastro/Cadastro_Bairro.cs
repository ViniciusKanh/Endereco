﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;


namespace Endereco.Cadastro
{
    public partial class Cadastro_Bairro : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public Cadastro_Bairro()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txt_Nome, "Inserir nome do Bairro");
        }

        private void MensagemOK(string Mensagem)
        {
            MessageBox.Show(Mensagem, "BusSpot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensagemErro(string Mensagem)
        {
            MessageBox.Show(Mensagem, "BusSpot", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpar()
        {
            this.txt_IDBairro.Text = string.Empty;
            this.txt_Nome.Text = string.Empty;

        }

        private void Habilitar(bool valor)
        {
            this.txt_IDBairro.ReadOnly = !valor;
            this.txt_Nome.ReadOnly = !valor;

        }
        private void HabilitarBotoes()
        {
            if (this.eNovo || eEditar)
            {
                this.Habilitar(true);
                this.btn_Novo.Enabled = false;
                this.btn_Salvar.Enabled = true;
                this.btn_Editar.Enabled = false;
                this.btn_Cancelar.Enabled = true;

            }

            else
            {

                this.Habilitar(false);
                this.btn_Novo.Enabled = true;
                this.btn_Salvar.Enabled = false;
                this.btn_Editar.Enabled = true;
                this.btn_Cancelar.Enabled = false;
            }

        }

        private void OcultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

        }


        private void Mostrar()
        {
            this.dataLista.DataSource = Bairro.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Bairro " + Convert.ToString(dataLista.Rows.Count);
        }

        private void BuscarBairro()
        {
            this.dataLista.DataSource = Bairro.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Bairros " + Convert.ToString(dataLista.Rows.Count);
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txt_IDBairro.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["ID"].Value);
            this.txt_Nome.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Nome"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar esse Bairro", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Bairro.Remover(Convert.ToInt32(Codigo));

                            if (Resp.Equals("OK"))
                            {
                                this.MensagemOK("Registro Removido com Sucesso");
                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void conexaoDBBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void conexaoDBBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void chkk_deletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkk_deletar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarBairro();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarBairro();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ttMensagem_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_IDBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (this.txt_Nome.Text.Equals(""))
            {

                this.MensagemErro("Selecione um Registro para Inserir");
            }
            else
            {
                this.eEditar = true;
                this.HabilitarBotoes();
                this.Habilitar(true);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Limpar();
            this.Habilitar(true);
            this.txt_Nome.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txt_Nome.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");
                    errorIcone.SetError(txt_Nome, "insira o Nome");
                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = Bairro.Inserir(txt_Nome.Text.Trim());
                    }
                    else
                    {
                        Resp = Bairro.Editar(Convert.ToInt32(txt_IDBairro.Text), txt_Nome.Text.Trim());
                    }

                    if (Resp.Equals("OK"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOK("Registro Salvo");
                        }
                        else
                        {
                            this.MensagemOK("Registro Alterado com Sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(Resp);
                    }

                    this.eNovo = false;
                    this.eEditar = false;
                    this.HabilitarBotoes();
                    this.Limpar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Bairro_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();
        }
    }
}
