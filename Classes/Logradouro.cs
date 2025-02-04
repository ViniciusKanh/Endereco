﻿using System.Data;
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
    public class Logradouro
    {
        public static string Inserir(string nome)
        {

            DLogradouro obj = new();
            obj.nome = nome;


            return obj.Incluir_Logradouro(obj);

        }

        public static string Editar(int id, string nome)
        {

            DLogradouro obj = new();
            obj.ID = id;
            obj.nome = nome;


            return obj.Alterar_Logradouro(obj);

        }

        public static DataTable Buscar(string nome)
        {

            DLogradouro obj = new();
            obj.txtBuscar = nome;

            return obj.Buscar_Logradouro(obj);

        }

        public static string Remover(int id)
        {

            DLogradouro obj = new();
            obj.ID = id;

            return obj.Remover_Logradouro(obj);

        }

        public static DataTable Mostrar()
        {
            return new DLogradouro().Mostrar_Logradouro();


        }
    }
}
