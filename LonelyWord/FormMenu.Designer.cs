namespace LonelyWord
{
    partial class FormMenu
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJogar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJogar.FlatAppearance.BorderSize = 2;
            this.btnJogar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnJogar.ForeColor = System.Drawing.Color.White;
            this.btnJogar.Location = new System.Drawing.Point(51, 210);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(300, 70);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "J O G A R";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.Transparent;
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTutorial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTutorial.FlatAppearance.BorderSize = 2;
            this.btnTutorial.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnTutorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTutorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnTutorial.ForeColor = System.Drawing.Color.White;
            this.btnTutorial.Location = new System.Drawing.Point(51, 396);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(300, 70);
            this.btnTutorial.TabIndex = 1;
            this.btnTutorial.Text = "T U T O R I A L";
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.Transparent;
            this.btnCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreditos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreditos.FlatAppearance.BorderSize = 2;
            this.btnCreditos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnCreditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCreditos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditos.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnCreditos.ForeColor = System.Drawing.Color.White;
            this.btnCreditos.Location = new System.Drawing.Point(51, 303);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(300, 70);
            this.btnCreditos.TabIndex = 2;
            this.btnCreditos.Text = "C R É D I T O S";
            this.btnCreditos.UseVisualStyleBackColor = false;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(51, 489);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(300, 70);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "S A I R";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LonelyWord.Properties.Resources.menu_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnJogar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lonely Word";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Button btnSair;
    }
}

