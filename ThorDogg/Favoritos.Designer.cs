namespace ThorDogg
{
    partial class Favoritos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favoritos));
            this.labelSubtexto = new System.Windows.Forms.Label();
            this.textRacas = new System.Windows.Forms.Label();
            this.listaFavoritos = new System.Windows.Forms.ListBox();
            this.btnDesfavoritar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubtexto
            // 
            this.labelSubtexto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubtexto.Location = new System.Drawing.Point(12, 30);
            this.labelSubtexto.Name = "labelSubtexto";
            this.labelSubtexto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSubtexto.Size = new System.Drawing.Size(328, 51);
            this.labelSubtexto.TabIndex = 4;
            this.labelSubtexto.Text = "Aqui você encontra a lista dos seus cãozinhos favoritos!";
            this.labelSubtexto.UseMnemonic = false;
            // 
            // textRacas
            // 
            this.textRacas.AutoSize = true;
            this.textRacas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textRacas.Location = new System.Drawing.Point(12, 9);
            this.textRacas.Name = "textRacas";
            this.textRacas.Size = new System.Drawing.Size(116, 21);
            this.textRacas.TabIndex = 3;
            this.textRacas.Text = "Meus favoritos";
            this.textRacas.Click += new System.EventHandler(this.textRacas_Click);
            // 
            // listaFavoritos
            // 
            this.listaFavoritos.FormattingEnabled = true;
            this.listaFavoritos.ItemHeight = 15;
            this.listaFavoritos.Location = new System.Drawing.Point(12, 68);
            this.listaFavoritos.Name = "listaFavoritos";
            this.listaFavoritos.Size = new System.Drawing.Size(328, 214);
            this.listaFavoritos.TabIndex = 5;
            this.listaFavoritos.SelectedIndexChanged += new System.EventHandler(this.listaFavoritos_SelectedIndexChanged);
            // 
            // btnDesfavoritar
            // 
            this.btnDesfavoritar.Location = new System.Drawing.Point(218, 294);
            this.btnDesfavoritar.Name = "btnDesfavoritar";
            this.btnDesfavoritar.Size = new System.Drawing.Size(122, 23);
            this.btnDesfavoritar.TabIndex = 13;
            this.btnDesfavoritar.Text = "Excluir favorito";
            this.btnDesfavoritar.UseVisualStyleBackColor = true;
            this.btnDesfavoritar.Click += new System.EventHandler(this.btnDesfavoritar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Voltar ao início";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Favoritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 329);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDesfavoritar);
            this.Controls.Add(this.listaFavoritos);
            this.Controls.Add(this.labelSubtexto);
            this.Controls.Add(this.textRacas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Favoritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animaizinhos Favoritos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSubtexto;
        private Label textRacas;
        private ListBox listaFavoritos;
        private Button btnDesfavoritar;
        private Button btnClose;
    }
}