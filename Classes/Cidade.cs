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
    public class Cidade
    {
        public static string Inserir(string nome, int IDESTADO, string Cep)
        {

            DCidade obj = new();
            obj.nome = nome;
            obj.estado = IDESTADO;
            obj.cep = Cep;

            return obj.Incluir_Cidade(obj);

        }

        public static string Editar(int id, string nome, int IDESTADO, string Cep)
        {

            DCidade obj = new();
            obj.ID = id;
            obj.nome = nome;
            obj.estado = IDESTADO;
            obj.cep = Cep;

            return obj.Alterar_Cidade(obj);

        }

        public static DataTable Buscar(string nome)
        {

            DCidade obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Cidade(obj);

        }

        public static string Remover(int id)
        {

            DCidade obj = new();
            obj.ID = id;

            return obj.Remover_Cidade(obj);

        }

        public static DataTable Mostrar()
        {
            return new DCidade().Mostrar_Cidade();


        }

    }
}
