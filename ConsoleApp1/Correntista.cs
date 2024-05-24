using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Correntista
    {
        public void CadastrarCorrentista(string conection)
        {
            Console.WriteLine("Digite o nome novo correntista:");
            string nome=Console.ReadLine();
            Console.WriteLine("Digite o cpf:" );
            string cpf = Console.ReadLine();
            using (var cntx = new SQLiteConnection(conection))
            {
                cntx.Open();
                string query = "INSERT INTO Correntistas(nome,cpf) values(@nome,@cpf)";
                using (var cmd = new SQLiteCommand(query,cntx))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.ExecuteNonQuery();
                   
                }
                
            }
            Console.WriteLine("Correntista criado com sucesso! :)");
        }
            
        public void EditarCorrentista()
        {

        }

        public void ExcluirCorrentista()
        {

        }

        public void VisualizarCorrentista()
        {

        }



    }
}
