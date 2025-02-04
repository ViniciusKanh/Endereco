﻿using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace BancoDados
{
    public class DCep
    {
		public int ID { get; set; }
		public String endereco { get; set; }
		public int IDBairro { get; set; }
		public int IDCidade { get; set; }
		public int IDLogradouro { get; set; }
		public int IDTipoLogradouro { get; set; }
		public string txtBuscar { get; set; }



		///  
		public string Incluir_cep(DCep cep)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoBD.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Inserir_Endereco";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParNome_ENDERECO = new SqlParameter();
				ParNome_ENDERECO.ParameterName = "@CEP";
				ParNome_ENDERECO.SqlDbType = SqlDbType.VarChar;
				ParNome_ENDERECO.Size = 50;
				ParNome_ENDERECO.Value = endereco;
				SqlCmd.Parameters.Add(ParNome_ENDERECO);

				SqlParameter ParID_BAIRRO = new SqlParameter();
				ParID_BAIRRO.ParameterName = "@ID_bairro";
				ParID_BAIRRO.SqlDbType = SqlDbType.Int;
				ParID_BAIRRO.Value = IDBairro;
				SqlCmd.Parameters.Add(ParID_BAIRRO);

				SqlParameter ParID_CIDADE = new SqlParameter();
				ParID_CIDADE.ParameterName = "@ID_Cidade";
				ParID_CIDADE.SqlDbType = SqlDbType.Int;
				ParID_CIDADE.Value = IDCidade;
				SqlCmd.Parameters.Add(ParID_CIDADE);

				SqlParameter ParID_LOGRADOURO = new SqlParameter();
				ParID_LOGRADOURO.ParameterName = "@ID_Logradouro";
				ParID_LOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_LOGRADOURO.Value = IDLogradouro;
				SqlCmd.Parameters.Add(ParID_LOGRADOURO);

				SqlParameter ParID_TIPOLOGRADOURO = new SqlParameter();
				ParID_TIPOLOGRADOURO.ParameterName = "@ID_TipoLogradouro";
				ParID_TIPOLOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_TIPOLOGRADOURO.Value = IDTipoLogradouro;
				SqlCmd.Parameters.Add(ParID_TIPOLOGRADOURO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cidade Não Inserido";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return Resp;

		}

		public DataTable Mostrar_Endereco()
		{
			DataTable DtResultado = new DataTable("Endereco");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoBD.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Mostrar_Endereco";
				SqlCmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);


			}
			catch (Exception error)
			{
				DtResultado = null;

			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return DtResultado;



		}
		///  
		public string Remover_cep(DCep cep)
		{

			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoBD.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Remover_Endereco";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_ENDERECO = new SqlParameter();
				ParID_ENDERECO.ParameterName = "@ID";
				ParID_ENDERECO.SqlDbType = SqlDbType.Int;
				ParID_ENDERECO.Value = ID;
				SqlCmd.Parameters.Add(ParID_ENDERECO);


				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Cidade Não Encontrado";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;

		}

		///  
		public string Alterar_cep(DCep cep)
		{
			string Resp;

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoBD.cn;
				Sqlcon.Open();
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Alterar_Endereco";
				SqlCmd.CommandType = CommandType.StoredProcedure;

				SqlParameter ParID_ENDERECO = new SqlParameter();
				ParID_ENDERECO.ParameterName = "@ID";
				ParID_ENDERECO.SqlDbType = SqlDbType.Int;
				ParID_ENDERECO.Value = ID;
				SqlCmd.Parameters.Add(ParID_ENDERECO);


				SqlParameter ParNome_ENDERECO = new SqlParameter();
				ParNome_ENDERECO.ParameterName = "@CEP";
				ParNome_ENDERECO.SqlDbType = SqlDbType.VarChar;
				ParNome_ENDERECO.Size = 50;
				ParNome_ENDERECO.Value = cep;
				SqlCmd.Parameters.Add(ParNome_ENDERECO);

				SqlParameter ParID_BAIRRO = new SqlParameter();
				ParID_BAIRRO.ParameterName = "@ID_bairro";
				ParID_BAIRRO.SqlDbType = SqlDbType.Int;
				ParID_BAIRRO.Value = IDBairro;
				SqlCmd.Parameters.Add(ParID_BAIRRO);

				SqlParameter ParID_CIDADE = new SqlParameter();
				ParID_CIDADE.ParameterName = "@ID_Cidade";
				ParID_CIDADE.SqlDbType = SqlDbType.Int;
				ParID_CIDADE.Value = IDCidade;
				SqlCmd.Parameters.Add(ParID_CIDADE);

				SqlParameter ParID_LOGRADOURO = new SqlParameter();
				ParID_LOGRADOURO.ParameterName = "@ID_Logradouro";
				ParID_LOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_LOGRADOURO.Value = IDLogradouro;
				SqlCmd.Parameters.Add(ParID_LOGRADOURO);

				SqlParameter ParID_TIPOLOGRADOURO = new SqlParameter();
				ParID_TIPOLOGRADOURO.ParameterName = "@ID_TipoLogradouro";
				ParID_TIPOLOGRADOURO.SqlDbType = SqlDbType.Int;
				ParID_TIPOLOGRADOURO.Value = IDTipoLogradouro;
				SqlCmd.Parameters.Add(ParID_TIPOLOGRADOURO);



				Resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Edicao Não Concluida";



			}
			catch (Exception error)
			{

				Resp = error.Message;
			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }
			return Resp;
		}

		///  
		public DataTable Buscar_ViaCEP(DCep cep)
		{
			DataTable DtResultado = new DataTable("Endereco");

			SqlConnection Sqlcon = new SqlConnection();

			try
			{
				Sqlcon.ConnectionString = ConexaoBD.cn;
				SqlCommand SqlCmd = new SqlCommand();
				SqlCmd.Connection = Sqlcon;
				SqlCmd.CommandText = "Proc_Buscar_Endereco";
				SqlCmd.CommandType = CommandType.StoredProcedure;


				SqlParameter Partextobuscar = new SqlParameter();
				Partextobuscar.ParameterName = "@textobuscar";
				Partextobuscar.SqlDbType = SqlDbType.VarChar;
				Partextobuscar.Size = 50;
				Partextobuscar.Value = txtBuscar;
				SqlCmd.Parameters.Add(Partextobuscar);

				SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
				SqlDat.Fill(DtResultado);





			}
			catch (Exception error)
			{
				DtResultado = null;

			}

			finally { if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close(); }

			return DtResultado;
		}
	}
}
