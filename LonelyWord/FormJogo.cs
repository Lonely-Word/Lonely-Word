﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LonelyWord
{ 
    public partial class FormJogo : Form
    {
        int fase;
        int tentativas = 3;
        int acertos = 0;
        SoundPlayer player;

        private static string RemoveAcentos(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        private void ShowMenu()
        {
            FormMenu fMenu = new FormMenu();
            fMenu.Show();
            player.Stop();
            this.Hide();
        }

        private void ShowProximaFase()
        {
            string cutscene = "";
            switch (this.fase + 1)
            {
                case 2:
                    cutscene = @"..\..\Resources\cutscene02.mp4";
                    break;
                case 3:
                    cutscene = @"..\..\Resources\cutscene03.mp4";
                    break;
                case 4:
                    cutscene = @"..\..\Resources\cutscene04.mp4";
                    break;
                case 5:
                    cutscene = @"..\..\Resources\cutscene05.mp4";
                    break;
                case 6:
                    cutscene = @"..\..\Resources\cutscene06.mp4";
                    break;
            }
            FormApresentacao fApresentacao = new FormApresentacao(cutscene, this.fase+1);
            fApresentacao.Show();
            player.Stop();
            this.Hide();
        }

        private void letraClick(object sender, EventArgs e)
        {
            var letra = (Label)sender;
            var palavra = (Palavra)letra.Tag;
            FormErro dialogErro = new FormErro();
            FormAcerto dialogAcerto = new FormAcerto();

            if (palavra != null)
            {
                FormPalavra pDialog = new FormPalavra();
                if (pDialog.ShowDialog(this) == DialogResult.OK)
                { 
                    if (palavra.palavra.ToUpper() == RemoveAcentos(pDialog.getPalavra().ToUpper()))
                    {
                        dialogAcerto.SetMsg("PARABÉNS VOCÊ ACERTOU!");
                        if (dialogAcerto.ShowDialog(this) == DialogResult.OK)
                        {
                            int posLetra = 0;
                            for (int col = palavra.colIni; col <= palavra.colFim; col++)
                            {
                                for (int row = palavra.rowIni; row <= palavra.rowFim; row++)
                                {
                                    var ctrl = palavrasCruzadas.GetControlFromPosition(col, row);
                                    if (ctrl != null)
                                        ctrl.Text = palavra.palavra.Substring(posLetra, 1);
                                    posLetra++;
                                }
                            }
                            acertos++;
                            if (acertos == 5)
                            {
                                dialogAcerto.SetMsg("PARABÉNS VOCÊ PASSOU PARA A PRÓXIMA FASE!");
                                dialogAcerto.ShowDialog(this);
                                ShowProximaFase();
                            }
                        }
                    } else
                    {
                        tentativas--;
                        switch (tentativas)
                        {
                            case 0:
                                vida1.Visible = false;
                                vida2.Visible = false;
                                vida3.Visible = false;
                                dialogErro.SetMsgDica(":( Não foi desta vez!", "Reveja a estória do Sr. Luiz e tente novamente!");
                                dialogErro.ShowDialog(this);
                                ShowMenu();
                                break;
                            case 1:
                                vida1.Visible = false;
                                vida2.Visible = false;
                                vida3.Visible = true;
                                dialogErro.SetMsgDica("Você errou, pega a dica abaixo:", palavra.dica);
                                dialogErro.ShowDialog(this);
                                break;
                            case 2:
                                vida1.Visible = false;
                                vida2.Visible = true;
                                vida3.Visible = true;
                                dialogErro.SetMsgDica("Você errou, pega a dica abaixo:", palavra.dica);                                
                                dialogErro.ShowDialog(this);                                    
                                break;
                            default:
                                vida1.Visible = true;
                                vida2.Visible = true;
                                vida3.Visible = true;
                                break;

                        }
                    }                
                }
                pDialog.Dispose();
            }
        }

        private void InitGame()
        {
            tentativas = 3;
            acertos = 0;

            List<Palavra> PalavrasFase = new List<Palavra>();
            Fase fase = new Fase();
            switch (this.fase)
            {
                case 1:
                    /* Fase 1 */
                    PalavrasFase.Add(new Palavra("PSICOLOGICO", "Pertencente à psique ou aos fenômenos mentais ou emocionais. (11 letras)", "Vertical", 11, 11, 4, 14));
                    PalavrasFase.Add(new Palavra("SOLIDAO", "Estado de quem se acha ou se sente desacompanhado. (7 letras)", "Vertical", 13, 13, 7, 13));
                    PalavrasFase.Add(new Palavra("ABANDONO", "Ato ou efeito de largar, de sair sem a intenção de voltar. (8 letras)", "Horizontal", 6, 13, 8, 8));
                    PalavrasFase.Add(new Palavra("MELANCOLIA", "Estado de grande tristeza e desencanto gera. (10 letras)", "Horizontal", 5, 14, 10, 10));
                    PalavrasFase.Add(new Palavra("IDOSO", "Que ou quem tem muitos anos de vida. (5 letras)", "Horizontal", 7, 11, 14, 14));
                    fase = new Fase(1, "Abandono: Solidão, doenças, síndromes.", "Abandono: Solidão, doenças, síndromes.", PalavrasFase);
                    player = new SoundPlayer(Properties.Resources._125);
                    break;
                case 2:
                    /* Fase 2 */                    
                    PalavrasFase.Add(new Palavra("FILHOS", "Descendentes diretos. (6 letras)", "Horizontal", 5, 10, 15, 15));
                    PalavrasFase.Add(new Palavra("ESPOSA", "Mulher, em relação à pessoa a quem está matrimonialmente vinculada. (6 letras)", "Vertical", 10, 10, 11, 16));
                    PalavrasFase.Add(new Palavra("NETOS", "Descendentes de segundo nível. (5 letras)", "Horizontal", 9, 13, 11, 11));
                    PalavrasFase.Add(new Palavra("FAMILIA", "O conjunto de parentes de uma pessoa. (7 letras)", "Horizontal", 8, 14, 6, 6));
                    PalavrasFase.Add(new Palavra("CUIDADOS", "Que foi ou é objeto de tratamento especial, zelo, bom trato. (8 letras)", "Vertical", 13, 13, 4, 11));
                    fase = new Fase(2, "Estrutura familiar: Direitos e deveres.", "Estrutura familiar: Direitos e deveres.", PalavrasFase);
                    player = new SoundPlayer(Properties.Resources._125);
                    break;
                case 3:
                    /* Fase 3 */                    
                    PalavrasFase.Add(new Palavra("SAUDE", "Voto que se faz a alguém que espirra. (5 letras)", "Horizontal", 8, 12, 19, 19));
                    PalavrasFase.Add(new Palavra("APOSENTADORIA", "A remuneração recebida mensalmente pelo trabalhador aposentado. (13 letras)", "Vertical", 7, 7, 1, 13));
                    PalavrasFase.Add(new Palavra("REMEDIOS", "Substância ou recurso utilizado para combater uma dor, uma doença. (8 letras)", "Vertical", 14, 14, 9, 16));
                    PalavrasFase.Add(new Palavra("PRIORIDADE", "Possibilidade legal de passar à frente dos outros. (10 letras)", "Horizontal", 5, 14, 12, 12));
                    PalavrasFase.Add(new Palavra("GRATUIDADE", "Condição ou estado do que é oferecido de graça. (10 letras)", "Vertical", 12, 12, 10, 19));
                    fase = new Fase(3, "Desafios da 3° idade: Qualidade de vida.", "Desafios da 3° idade: Qualidade de vida.", PalavrasFase);
                    player = new SoundPlayer(Properties.Resources._34);
                    break;
                case 4:
                    /* Fase 4 */                     
                    PalavrasFase.Add(new Palavra("MUTIRAO", "Mobilização coletiva de pessoas que, realizam um trabalho em conjunto para alcançar um objetivo comum. (7 letras)", "Horizontal", 5, 11, 13, 13));
                    PalavrasFase.Add(new Palavra("AMIZADE", "Sentimento de afeto, carinho e estima entre pessoas. (7 letras)", "Horizontal", 5, 11, 4, 4));
                    PalavrasFase.Add(new Palavra("SUPERACAO", "A ação de vencer desafios, ultrapassar obstáculos e superar dificuldades. (9 letras)", "Vertical", 11, 11, 8, 16));
                    PalavrasFase.Add(new Palavra("ASSISTENCIA", "Ação de ajudar, apoiar ou fornecer auxílio a alguém. (11 letras)", "Vertical", 9, 9, 4, 14));
                    PalavrasFase.Add(new Palavra("AJUDA", "Ação de prestar auxilio a alguém. (5 letras)", "Vertical", 6, 6, 11, 15));
                    fase = new Fase(4, "Quebrando barreiras: Amizade, superação e respeito.", "Quebrando barreiras: Amizade, superação e respeito.", PalavrasFase);
                    player = new SoundPlayer(Properties.Resources._34);
                    break;
                case 5:
                    /* Fase 5 */
                    PalavrasFase.Add(new Palavra("IDOSO", "Que ou quem tem muitos anos de vida. (5 letras)", "Horizontal", 9, 13, 8, 8));
                    PalavrasFase.Add(new Palavra("FAMILIA", "O conjunto de parentes de uma pessoa. (7 letras)", "Vertical", 14, 14, 10, 16));
                    PalavrasFase.Add(new Palavra("SUPERACAO", "A ação de vencer desafios, ultrapassar obstáculos e superar dificuldades. (9 letras)", "Horizontal", 7, 15, 11, 11));
                    PalavrasFase.Add(new Palavra("CUIDADOS", "Que foi ou é objeto de tratamento especial, zelo, bom trato. (8 letras)", "Horizontal", 4, 11, 5, 5));
                    PalavrasFase.Add(new Palavra("PRIORIDADE", "Possibilidade legal de passar à frente dos outros. (10 letras)", "Vertical", 10, 10, 2, 11));
                    player = new SoundPlayer(Properties.Resources._125);
                    fase = new Fase(5, "Valorize seu idoso, amanhã será você o idoso.", "Valorize seu idoso, amanhã será você o idoso.", PalavrasFase);
                    break;                                                        
            }
            player.Play();

            capitulo.Text = "Capítulo " + this.fase.ToString();
            tema.Text = fase.tema;

            int numLetras = 0;
            int numPalavra = 0;
            Label[] letras = new Label[400];
            Label[] letraDicas = new Label[5];
            foreach (var palavra in PalavrasFase)
            {
                numPalavra++;
                int posLetra = 0;
                switch(numPalavra)
                {
                    case 1:
                        dica1.Text = numPalavra.ToString() + ": " + palavra.dica;
                        break;
                    case 2:
                        dica2.Text = numPalavra.ToString() + ": " + palavra.dica;
                        break;
                    case 3:
                        dica3.Text = numPalavra.ToString() + ": " + palavra.dica;
                        break;
                    case 4:
                        dica4.Text = numPalavra.ToString() + ": " + palavra.dica;
                        break;
                    case 5:
                        dica5.Text = numPalavra.ToString() + ": " + palavra.dica;
                        break;
                }
                for (int col = palavra.colIni; col <= palavra.colFim; col++)
                {
                    for (int row = palavra.rowIni; row <= palavra.rowFim; row++)
                    {                        
                        if (posLetra == 0)
                        {
                            letraDicas[numPalavra-1] = new Label();
                            letraDicas[numPalavra - 1].BackColor = Color.WhiteSmoke;
                            letraDicas[numPalavra - 1].Text = numPalavra.ToString();
                            letraDicas[numPalavra - 1].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            letraDicas[numPalavra - 1].ForeColor = Color.Black;
                            letraDicas[numPalavra - 1].Dock = DockStyle.Fill;
                            letraDicas[numPalavra - 1].FlatStyle = FlatStyle.Flat;
                            letraDicas[numPalavra - 1].Margin = new System.Windows.Forms.Padding(2);
                            letraDicas[numPalavra - 1].Tag = palavra;
                            letraDicas[numPalavra - 1].Click += new EventHandler(letraClick);

                            if (palavra.direcao == "Vertical")
                                palavrasCruzadas.Controls.Add(letraDicas[numPalavra - 1], col, row - 1);
                            else
                                palavrasCruzadas.Controls.Add(letraDicas[numPalavra - 1], col - 1, row);                            
                        }
                        posLetra++;
                        letras[numLetras] = new Label();
                        letras[numLetras].BackColor = Color.Teal;
                        letras[numLetras].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        letras[numLetras].ForeColor = Color.WhiteSmoke;
                        letras[numLetras].Dock= DockStyle.Fill;
                        letras[numLetras].FlatStyle = FlatStyle.Flat;
                        letras[numLetras].Margin = new System.Windows.Forms.Padding(2);
                        letras[numLetras].Tag = palavra;
                        letras[numLetras].Click += new EventHandler(letraClick);
                        var ctrl = palavrasCruzadas.GetControlFromPosition(col, row);
                        if (ctrl == null)
                            palavrasCruzadas.Controls.Add(letras[numLetras], col, row);                            
                        else
                            ctrl.Tag = null;
                        numLetras++;
                    }
                }                              
            }
        }

        public FormJogo(int fase)
        {
            this.fase = fase;
            InitializeComponent();
            InitGame();
        }

        private void FormJogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMenu();
        }

        private void FormJogo_Leave(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
