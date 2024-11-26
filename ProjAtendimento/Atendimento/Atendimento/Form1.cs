using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas;
        private Guiches guiches;
        public Form1()
        {
            InitializeComponent();

            senhas = new Senhas();
            guiches = new Guiches();

            // Configurar interface inicial
            AtualizarListaFila();
            AtualizarListaGuiches();
        }

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            senhas.Gerar();
            AtualizarListaFila();
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            int id = guiches.ListaGuiches.Count + 1;
            guiches.Adicionar(new Guiche(id));
            AtualizarListaGuiches();
        }

        private void btnChamarSenha_Click(object sender, EventArgs e)
        {
            if (listBoxGuiches.SelectedIndex >= 0)
            {
                Guiche guicheSelecionado = guiches.ListaGuiches[listBoxGuiches.SelectedIndex];
                bool sucesso = guicheSelecionado.Chamar(senhas.FilaSenhas);

                if (sucesso)
                {
                    MessageBox.Show($"Senha chamada pelo Guichê {guicheSelecionado.Id}");
                }
                else
                {
                    MessageBox.Show("Nenhuma senha disponível na fila.");
                }

                AtualizarListaFila();
                AtualizarAtendimentos(guicheSelecionado);
            }
            else
            {
                MessageBox.Show("Selecione um guichê para chamar a senha.");
            }
        }

        private void AtualizarListaFila()
        {
            listBoxFilaSenhas.Items.Clear();
            foreach (var senha in senhas.FilaSenhas)
            {
                listBoxFilaSenhas.Items.Add(senha.DadosParciais());
            }
        }

        private void AtualizarListaGuiches()
        {
            listBoxGuiches.Items.Clear();
            foreach (var guiche in guiches.ListaGuiches)
            {
                listBoxGuiches.Items.Add($"Guichê {guiche.Id}");
            }
        }

        private void AtualizarAtendimentos(Guiche guiche)
        {
            listBoxAtendimentos.Items.Clear();
            foreach (var atendimento in guiche.Atendimentos)
            {
                listBoxAtendimentos.Items.Add(atendimento.DadosCompletos());
            }
        }
    }
}
 