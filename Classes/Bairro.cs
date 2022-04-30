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
    public class Bairro
    {
        public static string Inserir(string nome)
        {

            DBairro obj = new();
            obj.nome = nome;


            return obj.Incluir_Bairro(obj);

        }

        public static string Editar(int id, string nome)
        {

            DBairro obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_Bairro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            DBairro obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Bairro(obj);

        }

        public static string Remover(int id)
        {

            DBairro obj = new();
            obj.ID = id;

            return obj.Remover_Bairro(obj);

        }

        public static DataTable Mostrar()
        {
            return new DBairro().Mostrar_Bairro();


        }
    }
}
