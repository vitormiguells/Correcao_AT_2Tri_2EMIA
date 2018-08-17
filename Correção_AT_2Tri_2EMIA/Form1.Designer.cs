namespace Correção_AT_2Tri_2EMIA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRodada = new System.Windows.Forms.Label();
            this.lbVitorias = new System.Windows.Forms.Label();
            this.lbEmpates = new System.Windows.Forms.Label();
            this.lbDerrotas = new System.Windows.Forms.Label();
            this.btPedra = new System.Windows.Forms.Button();
            this.btPapel = new System.Windows.Forms.Button();
            this.btTesoura = new System.Windows.Forms.Button();
            this.lbJogadaSelecionada = new System.Windows.Forms.Label();
            this.btJogar = new System.Windows.Forms.Button();
            this.rbResultado = new System.Windows.Forms.RichTextBox();
            this.btDesselecionarJogada = new System.Windows.Forms.Button();
            this.btReiniciarJogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRodada
            // 
            this.lbRodada.AutoSize = true;
            this.lbRodada.Location = new System.Drawing.Point(12, 9);
            this.lbRodada.Name = "lbRodada";
            this.lbRodada.Size = new System.Drawing.Size(57, 13);
            this.lbRodada.TabIndex = 0;
            this.lbRodada.Text = "Rodada: 1";
            // 
            // lbVitorias
            // 
            this.lbVitorias.AutoSize = true;
            this.lbVitorias.Location = new System.Drawing.Point(12, 31);
            this.lbVitorias.Name = "lbVitorias";
            this.lbVitorias.Size = new System.Drawing.Size(53, 13);
            this.lbVitorias.TabIndex = 1;
            this.lbVitorias.Text = "Vitórias: 0";
            // 
            // lbEmpates
            // 
            this.lbEmpates.AutoSize = true;
            this.lbEmpates.Location = new System.Drawing.Point(12, 53);
            this.lbEmpates.Name = "lbEmpates";
            this.lbEmpates.Size = new System.Drawing.Size(60, 13);
            this.lbEmpates.TabIndex = 2;
            this.lbEmpates.Text = "Empates: 0";
            // 
            // lbDerrotas
            // 
            this.lbDerrotas.AutoSize = true;
            this.lbDerrotas.Location = new System.Drawing.Point(12, 75);
            this.lbDerrotas.Name = "lbDerrotas";
            this.lbDerrotas.Size = new System.Drawing.Size(59, 13);
            this.lbDerrotas.TabIndex = 3;
            this.lbDerrotas.Text = "Derrotas: 0";
            // 
            // btPedra
            // 
            this.btPedra.Location = new System.Drawing.Point(12, 102);
            this.btPedra.Name = "btPedra";
            this.btPedra.Size = new System.Drawing.Size(111, 23);
            this.btPedra.TabIndex = 4;
            this.btPedra.Text = "Pedra";
            this.btPedra.UseVisualStyleBackColor = true;
            this.btPedra.Click += new System.EventHandler(this.btPedra_Click);
            // 
            // btPapel
            // 
            this.btPapel.Location = new System.Drawing.Point(129, 102);
            this.btPapel.Name = "btPapel";
            this.btPapel.Size = new System.Drawing.Size(111, 23);
            this.btPapel.TabIndex = 5;
            this.btPapel.Text = "Papel";
            this.btPapel.UseVisualStyleBackColor = true;
            this.btPapel.Click += new System.EventHandler(this.btPapel_Click);
            // 
            // btTesoura
            // 
            this.btTesoura.Location = new System.Drawing.Point(246, 102);
            this.btTesoura.Name = "btTesoura";
            this.btTesoura.Size = new System.Drawing.Size(111, 23);
            this.btTesoura.TabIndex = 6;
            this.btTesoura.Text = "Tesoura";
            this.btTesoura.UseVisualStyleBackColor = true;
            this.btTesoura.Click += new System.EventHandler(this.btTesoura_Click);
            // 
            // lbJogadaSelecionada
            // 
            this.lbJogadaSelecionada.AutoSize = true;
            this.lbJogadaSelecionada.Location = new System.Drawing.Point(12, 140);
            this.lbJogadaSelecionada.Name = "lbJogadaSelecionada";
            this.lbJogadaSelecionada.Size = new System.Drawing.Size(151, 13);
            this.lbJogadaSelecionada.TabIndex = 7;
            this.lbJogadaSelecionada.Text = "Nenhuma jogada selecionada.";
            // 
            // btJogar
            // 
            this.btJogar.Location = new System.Drawing.Point(12, 168);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(111, 44);
            this.btJogar.TabIndex = 8;
            this.btJogar.Text = "Jogar";
            this.btJogar.UseVisualStyleBackColor = true;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // rbResultado
            // 
            this.rbResultado.Location = new System.Drawing.Point(12, 222);
            this.rbResultado.Name = "rbResultado";
            this.rbResultado.Size = new System.Drawing.Size(345, 139);
            this.rbResultado.TabIndex = 9;
            this.rbResultado.Text = "";
            // 
            // btDesselecionarJogada
            // 
            this.btDesselecionarJogada.Location = new System.Drawing.Point(129, 168);
            this.btDesselecionarJogada.Name = "btDesselecionarJogada";
            this.btDesselecionarJogada.Size = new System.Drawing.Size(111, 44);
            this.btDesselecionarJogada.TabIndex = 10;
            this.btDesselecionarJogada.Text = "Desselecionar Jogada";
            this.btDesselecionarJogada.UseVisualStyleBackColor = true;
            this.btDesselecionarJogada.Click += new System.EventHandler(this.btDesselecionarJogada_Click);
            // 
            // btReiniciarJogo
            // 
            this.btReiniciarJogo.Location = new System.Drawing.Point(246, 168);
            this.btReiniciarJogo.Name = "btReiniciarJogo";
            this.btReiniciarJogo.Size = new System.Drawing.Size(111, 44);
            this.btReiniciarJogo.TabIndex = 11;
            this.btReiniciarJogo.Text = "Reiniciar Jogo";
            this.btReiniciarJogo.UseVisualStyleBackColor = true;
            this.btReiniciarJogo.Click += new System.EventHandler(this.btReiniciarJogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 373);
            this.Controls.Add(this.btReiniciarJogo);
            this.Controls.Add(this.btDesselecionarJogada);
            this.Controls.Add(this.rbResultado);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.lbJogadaSelecionada);
            this.Controls.Add(this.btTesoura);
            this.Controls.Add(this.btPapel);
            this.Controls.Add(this.btPedra);
            this.Controls.Add(this.lbDerrotas);
            this.Controls.Add(this.lbEmpates);
            this.Controls.Add(this.lbVitorias);
            this.Controls.Add(this.lbRodada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRodada;
        private System.Windows.Forms.Label lbVitorias;
        private System.Windows.Forms.Label lbEmpates;
        private System.Windows.Forms.Label lbDerrotas;
        private System.Windows.Forms.Button btPedra;
        private System.Windows.Forms.Button btPapel;
        private System.Windows.Forms.Button btTesoura;
        private System.Windows.Forms.Label lbJogadaSelecionada;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.RichTextBox rbResultado;
        private System.Windows.Forms.Button btDesselecionarJogada;
        private System.Windows.Forms.Button btReiniciarJogo;
    }
}

