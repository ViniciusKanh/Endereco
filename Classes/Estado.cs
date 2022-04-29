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
    public class Estado
    {
        public static string Inserir(string nome, string sigla)
        {

            DEstado obj = new BancoDados.DEstado();
            obj.nome = nome;
            obj.sigla = sigla;

            return obj.Incluir_Estado(obj);

        }

        public static string Editar(int id, string nome, string sigla)
        {

            DEstado obj = new();
            obj.ID = id;
            obj.nome = nome;
            obj.sigla = sigla;

            return obj.Alterar_Estado(obj);

        }

        public static DataTable Buscar(string sigla)
        {

            DEstado obj = new();
            obj.txtBuscar = sigla;

            return obj.Buscar_Estado(obj);

        }

        public static string Remover(int id)
        {

            DEstado obj = new();
            obj.ID = id;

            return obj.Remover_Estado(obj);

        }

        public static DataTable Mostrar()
        {
            return new DEstado().Mostrar_Estado();


        }
    }
}
