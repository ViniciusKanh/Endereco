using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CEP
    {
        public static string Inserir(string cep, int idbairro, int idcidade, int idlogradouro, int idtipologradouro)
        {

            DCep obj = new();
            obj.endereco = cep;
            obj.IDBairro = idbairro;
            obj.IDCidade = idcidade;
            obj.IDLogradouro = idlogradouro;
            obj.IDTipoLogradouro = idtipologradouro;

            return obj.Incluir_cep(obj);

        }

        public static string Editar(int id, string cep, int idbairro, int idcidade, int idlogradouro, int idtipologradouro)
        {

            DCep obj = new();
            obj.ID = id;
            obj.endereco = cep;
            obj.IDBairro = idbairro;
            obj.IDCidade = idcidade;
            obj.IDLogradouro = idlogradouro;
            obj.IDTipoLogradouro = idtipologradouro;

            return obj.Alterar_cep(obj);

        }

        public static DataTable Buscar(string cep)
        {

            DCep obj = new();
            obj.txtBuscar = cep;

            return obj.Buscar_ViaCEP(obj);

        }

        public static string Remover(int id)
        {

            DCep obj = new();
            obj.ID = id;

            return obj.Remover_cep(obj);

        }

        public static DataTable Mostrar()
        {
            return new DCep().Mostrar_Endereco();


        }
    }
}
