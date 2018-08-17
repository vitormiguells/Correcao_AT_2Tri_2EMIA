using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correção_AT_2Tri_2EMIA
{
    public partial class Form1 : Form
    {
        /*
        Valor da Jogada Selecionada.
        0 = Nenhuma jogada
        1 = Pedra
        2 = Papel
        3 = Tesoura
        */

        int jogadaSelecionada = 0;

        string[] jogadas = new string[3]
        {
            "Pedra",
            "Papel",
            "Tesoura"
        };

        int rodada = 1;
        int vitorias = 0;
        int empates = 0;
        int derrotas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btPedra_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = 1;
            AtualizarJogadaSelecionada();
        }

        private void AtualizarJogadaSelecionada()
        {
            if (ChecarJogadaValida())
            {
                lbJogadaSelecionada.Text = string.Format(
                            "Você selecionou a jogada {0}.",
                            jogadas[jogadaSelecionada - 1]
                        );
            }
            else
            {
                lbJogadaSelecionada.Text = "Nenhuma jogada selecionada.";
            }
        }

        private bool ChecarJogadaValida()
        {
            return jogadaSelecionada > 0;
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (ChecarJogadaValida())
            {
                Jogar();
            }
        }

        enum Jogadas
        {
            PEDRA = 1,
            PAPEL = 2,
            TESOURA = 3
        }

        private void Jogar()
        {
            Random rnd = new Random();
            int jogadaComputador = rnd.Next(1, jogadas.Length + 1);

            ExibirJogada("Jogador", jogadaSelecionada);
            ExibirJogada("Computador", jogadaComputador);

            // Jogada Selecionada = Pedra
            //if (jogadaSelecionada == Jogadas.PEDRA)
            if (jogadaSelecionada == 1)
            {
                // Jogada do Computador = Pedra
                if (jogadaComputador == 1)
                {
                    // Empate
                    Empate();
                }
                // Jogada do Computador = Papel
                else if (jogadaComputador == 2)
                {
                    // Derrota
                    Derrota();
                }
                // Jogada do Computador = Tesoura
                else if (jogadaComputador == 3)
                {
                    // Vitória
                    Vitoria();
                }
            }
            // Jogada Selecionada = Papel
            else if (jogadaSelecionada == 2)
            {
                // Jogada do Computador = Pedra
                if (jogadaComputador == 1)
                {
                    Vitoria();
                }
                // Jogada do Computador = Papel
                else if (jogadaComputador == 2)
                {
                    Empate();
                }
                // Jogada do Computador = Tesoura
                else if (jogadaComputador == 3)
                {
                    Derrota();
                }
            }
            // Jogada Selecionada = Tesoura
            else if (jogadaSelecionada == 3)
            {
                // Jogada do Computador = Pedra
                if (jogadaComputador == 1)
                {
                    Derrota();
                }
                // Jogada do Computador = Papel
                else if (jogadaComputador == 2)
                {
                    Vitoria();
                }
                // Jogada do Computador = Tesoura
                else if (jogadaComputador == 3)
                {
                    Empate();
                }
            }

            AvancarRodada();
        }

        private void ExibirJogada(string nomeJogador, int jogada)
        {
            rbResultado.AppendText(
                string.Format(
                    "{0}: {1}\n",
                    nomeJogador,
                    jogadas[jogada - 1]
                )
            );
        }

        private void Vitoria()
        {
            vitorias++;

            rbResultado.AppendText("Você ganhou.\n");
        }

        private void AvancarRodada()
        {
            DesselecionarJogada();
            rodada++;
            AtualizarLabelsJogo();
        }

        private void DesselecionarJogada()
        {
            jogadaSelecionada = 0;
            AtualizarJogadaSelecionada();
        }

        private void AtualizarLabelsJogo()
        {
            lbRodada.Text = "Rodada: " + rodada;
            lbVitorias.Text = "Vitórias: " + vitorias;
            lbEmpates.Text = "Empates: " + empates;
            lbDerrotas.Text = "Derrotas: " + derrotas;
        }

        private void Derrota()
        {
            derrotas++;

            rbResultado.AppendText("Você perdeu.\n");
        }

        private void Empate()
        {
            empates++;

            rbResultado.AppendText("Você empatou.\n");
        }

        private void btPapel_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = 2;
            AtualizarJogadaSelecionada();
        }

        private void btTesoura_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = 3;
            AtualizarJogadaSelecionada();
        }

        private void btDesselecionarJogada_Click(object sender, EventArgs e)
        {
            DesselecionarJogada();
        }

        private void btReiniciarJogo_Click(object sender, EventArgs e)
        {
            rodada = 1;
            vitorias = 0;
            empates = 0;
            derrotas = 0;
            AtualizarLabelsJogo();

            DesselecionarJogada();

            rbResultado.Clear();
        }
    }
}
