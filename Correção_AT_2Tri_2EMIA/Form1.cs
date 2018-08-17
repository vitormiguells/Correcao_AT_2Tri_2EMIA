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

        Jogadas jogadaSelecionada = Jogadas.NENHUMA;

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
        
        enum Jogadas
        {
            NENHUMA,
            Pedra,
            Papel,
            Tesoura
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btPedra_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = Jogadas.Pedra;
            AtualizarJogadaSelecionada();
        }

        private void AtualizarJogadaSelecionada()
        {
            if (ChecarJogadaValida())
            {
                lbJogadaSelecionada.Text = string.Format(
                            "Você selecionou a jogada {0}.",
                            jogadaSelecionada.ToString()
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

        private void Jogar()
        {
            Random rnd = new Random();
            Jogadas jogadaComputador = (Jogadas)rnd.Next(1, jogadas.Length + 1);

            ExibirJogada("Jogador", jogadaSelecionada);
            ExibirJogada("Computador", jogadaComputador);

            // Jogada Selecionada = Pedra
            //if (jogadaSelecionada == Jogadas.PEDRA)
            if (jogadaSelecionada == Jogadas.Pedra)
            {
                // Jogada do Computador = Pedra
                if (jogadaComputador == Jogadas.Pedra)
                {
                    // Empate
                    Empate();
                }
                // Jogada do Computador = Papel
                else if (jogadaComputador == Jogadas.Papel)
                {
                    // Derrota
                    Derrota();
                }
                // Jogada do Computador = Tesoura
                else if (jogadaComputador == Jogadas.Tesoura)
                {
                    // Vitória
                    Vitoria();
                }
            }
            // Jogada Selecionada = Papel
            else if (jogadaSelecionada == Jogadas.Papel)
            {
                // Jogada do Computador = Pedra
                if (jogadaComputador == Jogadas.Pedra)
                {
                    Vitoria();
                }
                // Jogada do Computador = Papel
                else if (jogadaComputador == Jogadas.Papel)
                {
                    Empate();
                }
                // Jogada do Computador = Tesoura
                else if (jogadaComputador == Jogadas.Tesoura)
                {
                    Derrota();
                }
            }
            // Jogada Selecionada = Tesoura
            else if (jogadaSelecionada == Jogadas.Tesoura)
            {
                // Jogada do Computador = Pedra
                if (jogadaComputador == Jogadas.Pedra)
                {
                    Derrota();
                }
                // Jogada do Computador = Papel
                else if (jogadaComputador == Jogadas.Papel)
                {
                    Vitoria();
                }
                // Jogada do Computador = Tesoura
                else if (jogadaComputador == Jogadas.Tesoura)
                {
                    Empate();
                }
            }

            AvancarRodada();
        }

        private void ExibirJogada(string nomeJogador, Jogadas jogada)
        {
            rbResultado.AppendText(
                string.Format(
                    "{0}: {1}\n",
                    nomeJogador,
                    //jogada.ToString().ToLower().First().ToString().ToUpper() + jogada.ToString().ToLower().Substring(1)
                    jogada.ToString()
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
            jogadaSelecionada = Jogadas.Papel;
            AtualizarJogadaSelecionada();
        }

        private void btTesoura_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = Jogadas.Tesoura;
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
