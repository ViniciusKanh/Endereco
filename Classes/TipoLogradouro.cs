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
    public class TipoLogradouro
    {
        public static string Inserir(string nome)
        {

            DTipoLogradouro obj = new();
            obj.nome = nome;


            return obj.Incluir_TipoLogradouro(obj);

        }

        public static string Editar(int id, string nome)
        {

            DTipoLogradouro obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_TipoLogradouro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            DTipoLogradouro obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_TipoLogradouro(obj);

        }

        public static string Remover(int id)
        {

            DTipoLogradouro obj = new();
            obj.ID = id;

            return obj.Remover_TipoLogradouro(obj);

        }

        public static DataTable Mostrar()
        {
            return new DTipoLogradouro().Mostrar_TipoLogradouro();


        }
    }
}
