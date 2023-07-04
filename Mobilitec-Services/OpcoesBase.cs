using System.Collections.Generic;
using System.Windows.Forms;

namespace Mobilitec_Services
{
    public class OpcoesBase
    {

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
                            hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                        }
                    }
                    return hashSetOpcoes;
                }
            }
        }
    }
}