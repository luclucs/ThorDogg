namespace ThorDogg
{
    partial class BuscarRaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRaca));
            this.btnClose = new System.Windows.Forms.Button();
            this.textRacas = new System.Windows.Forms.Label();
            this.labelSubtexto = new System.Windows.Forms.Label();
            this.labelDogTemperamento = new System.Windows.Forms.Label();
            this.labelDogOrigem = new System.Windows.Forms.Label();
            this.labelDogDescricao = new System.Windows.Forms.Label();
            this.labelRaca = new System.Windows.Forms.Label();
            this.labelResTemperamento = new System.Windows.Forms.Label();
            this.labelResVida = new System.Windows.Forms.Label();
            this.labelResDescricao = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureDogg = new System.Windows.Forms.PictureBox();
            this.labelRacaNome = new System.Windows.Forms.Label();
            this.btnSurprise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDogg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Voltar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textRacas
            // 
            this.textRacas.AutoSize = true;
            this.textRacas.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textRacas.Location = new System.Drawing.Point(12, 9);
            this.textRacas.Name = "textRacas";
            this.textRacas.Size = new System.Drawing.Size(197, 21);
            this.textRacas.TabIndex = 1;
            this.textRacas.Text = "Encontre sua raça favorita";
            // 
            // labelSubtexto
            // 
            this.labelSubtexto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubtexto.Location = new System.Drawing.Point(12, 30);
            this.labelSubtexto.Name = "labelSubtexto";
            this.labelSubtexto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSubtexto.Size = new System.Drawing.Size(328, 51);
            this.labelSubtexto.TabIndex = 2;
            this.labelSubtexto.Text = "Utilize o botão de buscar raças para encontrar características sobre determinado " +
    "doguinho e descobrir sua raça favorita! ";
            this.labelSubtexto.UseMnemonic = false;
            this.labelSubtexto.Click += new System.EventHandler(this.labelSubtexto_Click);
            // 
            // labelDogTemperamento
            // 
            this.labelDogTemperamento.AutoSize = true;
            this.labelDogTemperamento.Location = new System.Drawing.Point(24, 144);
            this.labelDogTemperamento.Name = "labelDogTemperamento";
            this.labelDogTemperamento.Size = new System.Drawing.Size(90, 15);
            this.labelDogTemperamento.TabIndex = 3;
            this.labelDogTemperamento.Text = "Temperamento:";
            // 
            // labelDogOrigem
            // 
            this.labelDogOrigem.AutoSize = true;
            this.labelDogOrigem.Location = new System.Drawing.Point(27, 178);
            this.labelDogOrigem.Name = "labelDogOrigem";
            this.labelDogOrigem.Size = new System.Drawing.Size(87, 15);
            this.labelDogOrigem.TabIndex = 4;
            this.labelDogOrigem.Text = "Tempo de vida:";
            // 
            // labelDogDescricao
            // 
            this.labelDogDescricao.AutoSize = true;
            this.labelDogDescricao.Location = new System.Drawing.Point(53, 215);
            this.labelDogDescricao.Name = "labelDogDescricao";
            this.labelDogDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDogDescricao.TabIndex = 5;
            this.labelDogDescricao.Text = "Descrição:";
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Location = new System.Drawing.Point(12, 112);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(102, 15);
            this.labelRaca.TabIndex = 6;
            this.labelRaca.Text = "Raça do cachorro:";
            // 
            // labelResTemperamento
            // 
            this.labelResTemperamento.AutoSize = true;
            this.labelResTemperamento.Location = new System.Drawing.Point(75, 159);
            this.labelResTemperamento.Name = "labelResTemperamento";
            this.labelResTemperamento.Size = new System.Drawing.Size(59, 15);
            this.labelResTemperamento.TabIndex = 8;
            this.labelResTemperamento.Text = "Resultado";
            this.labelResTemperamento.Click += new System.EventHandler(this.labelResTemperamento_Click);
            // 
            // labelResVida
            // 
            this.labelResVida.AutoSize = true;
            this.labelResVida.Location = new System.Drawing.Point(75, 193);
            this.labelResVida.Name = "labelResVida";
            this.labelResVida.Size = new System.Drawing.Size(59, 15);
            this.labelResVida.TabIndex = 9;
            this.labelResVida.Text = "Resultado";
            this.labelResVida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResDescricao
            // 
            this.labelResDescricao.AutoSize = true;
            this.labelResDescricao.Location = new System.Drawing.Point(75, 230);
            this.labelResDescricao.Name = "labelResDescricao";
            this.labelResDescricao.Size = new System.Drawing.Size(59, 15);
            this.labelResDescricao.TabIndex = 10;
            this.labelResDescricao.Text = "Resultado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(140, 294);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar aleatório";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureDogg
            // 
            this.pictureDogg.Location = new System.Drawing.Point(458, 9);
            this.pictureDogg.Name = "pictureDogg";
            this.pictureDogg.Size = new System.Drawing.Size(333, 308);
            this.pictureDogg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDogg.TabIndex = 13;
            this.pictureDogg.TabStop = false;
            this.pictureDogg.Click += new System.EventHandler(this.pictureDogg_Click);
            // 
            // labelRacaNome
            // 
            this.labelRacaNome.AutoSize = true;
            this.labelRacaNome.Location = new System.Drawing.Point(75, 127);
            this.labelRacaNome.Name = "labelRacaNome";
            this.labelRacaNome.Size = new System.Drawing.Size(59, 15);
            this.labelRacaNome.TabIndex = 14;
            this.labelRacaNome.Text = "Resultado";
            this.labelRacaNome.Click += new System.EventHandler(this.labelRacaNome_Click);
            // 
            // btnSurprise
            // 
            this.btnSurprise.Location = new System.Drawing.Point(268, 294);
            this.btnSurprise.Name = "btnSurprise";
            this.btnSurprise.Size = new System.Drawing.Size(122, 23);
            this.btnSurprise.TabIndex = 15;
            this.btnSurprise.Text = "?";
            this.btnSurprise.UseVisualStyleBackColor = true;
            this.btnSurprise.Click += new System.EventHandler(this.btnSurprise_Click);
            // 
            // BuscarRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 329);
            this.Controls.Add(this.btnSurprise);
            this.Controls.Add(this.labelRacaNome);
            this.Controls.Add(this.pictureDogg);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelResDescricao);
            this.Controls.Add(this.labelResVida);
            this.Controls.Add(this.labelResTemperamento);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.labelDogDescricao);
            this.Controls.Add(this.labelDogOrigem);
            this.Controls.Add(this.labelDogTemperamento);
            this.Controls.Add(this.labelSubtexto);
            this.Controls.Add(this.textRacas);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuscarRaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças";
            this.Load += new System.EventHandler(this.BuscarRaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDogg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Label textRacas;
        private Label labelSubtexto;
        private Label labelDogTemperamento;
        private Label labelDogOrigem;
        private Label labelDogDescricao;
        private Label labelRaca;
        private Label labelResTemperamento;
        private Label labelResVida;
        private Label labelResDescricao;
        private Button btnBuscar;
        private PictureBox pictureDogg;
        private Label labelRacaNome;
        private Button btnSurprise;
    }
}