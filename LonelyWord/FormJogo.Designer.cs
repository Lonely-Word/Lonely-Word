namespace LonelyWord
{
    partial class FormJogo
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
            this.resposta = new System.Windows.Forms.TextBox();
            this.vida3 = new System.Windows.Forms.PictureBox();
            this.Capitulo = new System.Windows.Forms.Label();
            this.tema = new System.Windows.Forms.Label();
            this.vida2 = new System.Windows.Forms.PictureBox();
            this.vida1 = new System.Windows.Forms.PictureBox();
            this.acertos = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.digite = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.cacaPalavras = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).BeginInit();
            this.SuspendLayout();
            // 
            // resposta
            // 
            this.resposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resposta.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.resposta.Location = new System.Drawing.Point(709, 146);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(238, 36);
            this.resposta.TabIndex = 5;
            // 
            // vida3
            // 
            this.vida3.BackColor = System.Drawing.Color.Transparent;
            this.vida3.Image = global::LonelyWord.Properties.Resources.caneta;
            this.vida3.Location = new System.Drawing.Point(949, 12);
            this.vida3.Name = "vida3";
            this.vida3.Size = new System.Drawing.Size(43, 40);
            this.vida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vida3.TabIndex = 1;
            this.vida3.TabStop = false;
            // 
            // Capitulo
            // 
            this.Capitulo.AutoSize = true;
            this.Capitulo.BackColor = System.Drawing.Color.Transparent;
            this.Capitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Capitulo.Location = new System.Drawing.Point(10, 12);
            this.Capitulo.Name = "Capitulo";
            this.Capitulo.Size = new System.Drawing.Size(192, 47);
            this.Capitulo.TabIndex = 2;
            this.Capitulo.Text = "Capítulo X";
            this.Capitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tema
            // 
            this.tema.AutoSize = true;
            this.tema.BackColor = System.Drawing.Color.Transparent;
            this.tema.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tema.ForeColor = System.Drawing.SystemColors.Control;
            this.tema.Location = new System.Drawing.Point(12, 65);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(89, 32);
            this.tema.TabIndex = 3;
            this.tema.Text = "Tema x";
            // 
            // vida2
            // 
            this.vida2.BackColor = System.Drawing.Color.Transparent;
            this.vida2.Image = global::LonelyWord.Properties.Resources.caneta;
            this.vida2.Location = new System.Drawing.Point(900, 12);
            this.vida2.Name = "vida2";
            this.vida2.Size = new System.Drawing.Size(43, 40);
            this.vida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vida2.TabIndex = 6;
            this.vida2.TabStop = false;
            this.vida2.Click += new System.EventHandler(this.vidadois_Click);
            // 
            // vida1
            // 
            this.vida1.BackColor = System.Drawing.Color.Transparent;
            this.vida1.Image = global::LonelyWord.Properties.Resources.caneta;
            this.vida1.Location = new System.Drawing.Point(851, 12);
            this.vida1.Name = "vida1";
            this.vida1.Size = new System.Drawing.Size(43, 40);
            this.vida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vida1.TabIndex = 7;
            this.vida1.TabStop = false;
            // 
            // acertos
            // 
            this.acertos.AutoSize = true;
            this.acertos.BackColor = System.Drawing.Color.Transparent;
            this.acertos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acertos.ForeColor = System.Drawing.SystemColors.Control;
            this.acertos.Location = new System.Drawing.Point(850, 51);
            this.acertos.Name = "acertos";
            this.acertos.Size = new System.Drawing.Size(145, 25);
            this.acertos.TabIndex = 9;
            this.acertos.Text = "Acertos: 1 de 10";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(709, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 514);
            this.listBox1.TabIndex = 13;
            // 
            // digite
            // 
            this.digite.AutoSize = true;
            this.digite.BackColor = System.Drawing.SystemColors.Window;
            this.digite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digite.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digite.Location = new System.Drawing.Point(709, 126);
            this.digite.Name = "digite";
            this.digite.Size = new System.Drawing.Size(199, 17);
            this.digite.TabIndex = 14;
            this.digite.Text = "Digite aqui a palavra encontrada";
            this.digite.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BackgroundImage = global::LonelyWord.Properties.Resources.check;
            this.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(953, 145);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(39, 39);
            this.btnVerificar.TabIndex = 15;
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // cacaPalavras
            // 
            this.cacaPalavras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cacaPalavras.BackColor = System.Drawing.Color.Transparent;
            this.cacaPalavras.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.cacaPalavras.ColumnCount = 20;
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.Enabled = false;
            this.cacaPalavras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacaPalavras.Location = new System.Drawing.Point(18, 126);
            this.cacaPalavras.Name = "cacaPalavras";
            this.cacaPalavras.RowCount = 20;
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.cacaPalavras.Size = new System.Drawing.Size(685, 591);
            this.cacaPalavras.TabIndex = 16;
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LonelyWord.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.cacaPalavras);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.digite);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.vida1);
            this.Controls.Add(this.vida2);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.Capitulo);
            this.Controls.Add(this.vida3);
            this.Controls.Add(this.acertos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lonely Word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJogo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resposta;
        private System.Windows.Forms.PictureBox vida3;
        private System.Windows.Forms.Label Capitulo;
        private System.Windows.Forms.Label tema;
        private System.Windows.Forms.PictureBox vida2;
        private System.Windows.Forms.PictureBox vida1;
        private System.Windows.Forms.Label acertos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label digite;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TableLayoutPanel cacaPalavras;
    }
}