using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using BancoDados;

namespace Endereco.Cadastro
{
    public partial class Cadastro_CEP : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public Cadastro_CEP()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txt_CEP, "Inserir o CEP");
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
            this.txt_IDCEP.Text = string.Empty;
            this.txt_CEP.Text = string.Empty;
            this.cb_IDBAIRRO.Text = string.Empty;
            this.cb_IDCIDADE.Text = string.Empty;
            this.cb_IDLOGRADOURO.Text = string.Empty;
            this.cb_IDTIPOLOGRADOURO.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.txt_IDCEP.ReadOnly = !valor;
            this.txt_CEP.ReadOnly = !valor;

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

        private void BuscarEndereco()
        {
            this.dataLista.DataSource = CEP.Buscar(this.txt_Buscar.Text);
            //  this.OcultarColunas();
            lbl_total.Text = "Total de Endereços " + Convert.ToString(dataLista.Rows.Count);
        }

        private void Mostrar()
        {
            this.dataLista.DataSource = CEP.Mostrar();
            this.OcultarColunas();
            lbl_total.Text = "Total de Endereços " + Convert.ToString(dataLista.Rows.Count);
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txt_IDCEP.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["ID"].Value);
            this.txt_CEP.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["CEP"].Value);
            this.cb_IDBAIRRO.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Bairro"].Value);
            this.cb_IDCIDADE.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Cidade"].Value);
            this.cb_IDLOGRADOURO.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Logradouro"].Value);
            this.cb_IDTIPOLOGRADOURO.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Tipo de Logradouro"].Value);
            this.tabControl1.SelectedIndex = 1;

        }

        private void Cadastro_CEP_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(true);
            this.HabilitarBotoes();

            string sqlqBAIRRO = "select ID, Nome from Bairro order by Nome";
            string sqlqCIDADE = "select ID, Nome from CIDADE order by Nome";
            string sqlqLOGRADOURO = "select ID, Nome from Logradouro order by Nome";
            string sqlqTIPOLOGRADOURO = "select ID, Nome from Tipo_logradouro order by Nome";

            cb_IDBAIRRO.DataSource = ConexaoBD.dql(sqlqBAIRRO);
            cb_IDBAIRRO.DisplayMember = "Nome";
            cb_IDBAIRRO.ValueMember = "ID";

            cb_IDCIDADE.DataSource = ConexaoBD.dql(sqlqCIDADE);
            cb_IDCIDADE.DisplayMember = "Nome";
            cb_IDCIDADE.ValueMember = "ID";

            cb_IDLOGRADOURO.DataSource = ConexaoBD.dql(sqlqLOGRADOURO);
            cb_IDLOGRADOURO.DisplayMember = "Nome";
            cb_IDLOGRADOURO.ValueMember = "ID";

            cb_IDTIPOLOGRADOURO.DataSource = ConexaoBD.dql(sqlqTIPOLOGRADOURO);
            cb_IDTIPOLOGRADOURO.DisplayMember = "Nome";
            cb_IDTIPOLOGRADOURO.ValueMember = "ID";
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja Realmente Apagar esse CEP", "BusSpott", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = CEP.Remover(Convert.ToInt32(Codigo));

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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.HabilitarBotoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (this.txt_CEP.Text == string.Empty)
                {
                    MensagemErro("Preencha Todos os Campos");
                    errorIcone.SetError(txt_CEP, "insira o Nome");
                }
                else
                {
                    if (this.eNovo)
                    {
                        Resp = CEP.Inserir(txt_CEP.Text, Convert.ToInt32(cb_IDBAIRRO.SelectedValue), Convert.ToInt32(cb_IDCIDADE.SelectedValue), Convert.ToInt32(cb_IDLOGRADOURO.SelectedValue), Convert.ToInt32(cb_IDTIPOLOGRADOURO.SelectedValue));
                    }
                    else
                    {
                        Resp = CEP.Editar(Convert.ToInt32(txt_IDCEP.Text), txt_CEP.Text.Trim(), Convert.ToInt32(cb_IDBAIRRO.SelectedValue), Convert.ToInt32(cb_IDCIDADE.SelectedValue), Convert.ToInt32(cb_IDLOGRADOURO.SelectedValue), Convert.ToInt32(cb_IDTIPOLOGRADOURO.SelectedValue));
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (this.txt_CEP.Text.Equals(""))
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
            this.txt_CEP.Focus();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarEndereco();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarEndereco();
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
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
    }
}
