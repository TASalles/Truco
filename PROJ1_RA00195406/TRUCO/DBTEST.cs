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
        static String dbName = "Tetris.sqlite";
        static String sConexao = "Data Source =" + dbName;
        static SQLiteConnection conexao;

        public static void CreateDB()
        {
            conexao = new SQLiteConnection(sConexao);
            if (!File.Exists(dbName))
            {
                conexao.Open();
                CreateTables();
            }
            else
            {
                conexao.Open();
            }
        }

        public void SalvarJogo()
        {

        }
    }
}
