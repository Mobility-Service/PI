using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Mobilitec_Services
{
    public class Opcoes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

        public Opcoes(string nome, string email, int v)
        {
            this.nome = nome;
            this.email = email;
        }

        public static HashSet<Opcoes> Criar(MenuStrip menu)
        {
            var hashSetOpcoes = new HashSet<Opcoes>();
            // Nível 1
            foreach (ToolStripMenuItem item in menu.Items)
            {
                var descricao1 = item.Text;

                if (item.HasDropDownItems)
                {
                    // Nível 2
                    foreach (ToolStripMenuItem opcao in item.DropDownItems)
                    {
                        var descricao2 = descricao1 + " / " + opcao.Text;

                        if (opcao.HasDropDownItems)
                        {
                            // Nível 3
                            foreach (ToolStripMenuItem subOpcao in opcao.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + subOpcao.Text;
                                hashSetOpcoes.Add(new Opcoes(subOpcao.Name, descricao3, 3));
                            }
                        }
                        else
                        {
                            hashSetOpcoes.Add(new Opcoes(opcao.Name, descricao2, 2));
                        }
                    }
                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                }
            }

            return hashSetOpcoes;
        }

        public static bool SalvarMenu(HashSet<Opcoes> opcoes)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbFuncionarios (nome, email) VALUES (@nome, @email)";
            comm.CommandType = CommandType.Text;

            try
            {
                MySqlConnection mySqlConnection = Connect.obterConexao();
                using (comm.Connection = mySqlConnection)
                {
                 
                    using (var cmd = new MySqlCommand(comm.CommandText, comm.Connection))
                    {
                        
                        cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100);
                        cmd.Parameters.Add("@email", MySqlDbType.VarChar, 100);

                        foreach (var item in opcoes)
                        {
                            cmd.Parameters["@nome"].Value = item.nome;
                            cmd.Parameters["@email"].Value = item.email;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    

            

        }

    }
