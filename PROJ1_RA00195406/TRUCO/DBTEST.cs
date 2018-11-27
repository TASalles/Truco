using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TRUCO
{
    class DBTEST
    {
        #region Propriedades
        static String dbName = "Truco.sqlite";
        static String sConexao = "Data Source =" + dbName;
        static SQLiteConnection conexao;
        #endregion

        #region CriaDB
        public static void CreateDB()
        {
            conexao = new SQLiteConnection(sConexao);
            if (!File.Exists(dbName))
            {
                conexao.Open();
                CreateTable();
            }
            else
            {
                conexao.Open();
            }
        }
        #endregion

        #region CriaTabela
        public static void CreateTable()
        {
            String sSQL = "CREATE TABLE 'TABULEIRO' (";
            sSQL += " 'LINHA' INTEGER";
            sSQL += "'COLUNA' INTEGER";
            sSQL += " 'JOGADOR' INTEGER";
            sSQL += ");";
            SQLiteCommand comando = new SQLiteCommand(conexao);
            comando.CommandText = sSQL;
            comando.ExecuteNonQuery();
            CreatePlacar();
        }
        #endregion

        #region CriaPlacar
        public static void CreatePlacar()
        {
            SQLiteCommand comando = new SQLiteCommand(conexao);
            comando.CommandText = "CREATE TABLE 'PLACAR' ('RESULTADO' INTEGER, 'id' INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE); ";
            comando.ExecuteNonQuery();
        }
        #endregion

        #region SelectAllMesa
        public static SQLiteDataReader SelectAllMesa()
        {
            String sSQL = "SELECT LINHA,COLUNA,JOGADOR FROM MESA ";
            SQLiteCommand comando = new SQLiteCommand(conexao);
            comando.CommandText = sSQL;
            SQLiteDataReader dataReader = comando.ExecuteReader();

            return dataReader;
        }
        #endregion

        #region InsertMesa
        // A Corrigir 
        //public static void InsertMesa()
        //{
        //    String sSQL = "INSERT INTO 'TABULEIRO'(LINHA,COLUNA,JOGADOR)";
        //    sSQL += "VALUES (" + "," + algo + "," + ((int)jogador) + ")";
        //    SQLiteCommand comando = new SQLiteCommand(conexao);
        //    comando.CommandText = sSQL;
        //    comando.ExecuteNonQuery();
        //
        //}
        #endregion

        #region LoadMesa
        // A Corrigir 2.0
        public static void LoadMesa()
        {


        }
        #endregion

        #region DeletAllPlacar
        public static void DeletAllPlacar()
        {

        }
        #endregion

        #region SalvarJogo
        public void SalvarJogo()
        {

        }
        #endregion
    }
}
