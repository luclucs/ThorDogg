namespace ThorDogg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRacas = new System.Windows.Forms.Button();
            this.labelBemvindo = new System.Windows.Forms.Label();
            this.picDog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRacas
            // 
            this.btnRacas.Location = new System.Drawing.Point(12, 12);
            this.btnRacas.Name = "btnRacas";
            this.btnRacas.Size = new System.Drawing.Size(328, 23);
            this.btnRacas.TabIndex = 0;
            this.btnRacas.Text = "Buscar Raças";
            this.btnRacas.UseVisualStyleBackColor = true;
            this.btnRacas.Click += new System.EventHandler(this.btnRacas_Click);
            // 
            // labelBemvindo
            // 
            this.labelBemvindo.AutoSize = true;
            this.labelBemvindo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBemvindo.Location = new System.Drawing.Point(79, 200);
            this.labelBemvindo.Name = "labelBemvindo";
            this.labelBemvindo.Size = new System.Drawing.Size(181, 20);
            this.labelBemvindo.TabIndex = 2;
            this.labelBemvindo.Text = "Bem vindo ao Thor Dogg!";
            // 
            // picDog
            // 
            this.picDog.Image = ((System.Drawing.Image)(resources.GetObject("picDog.Image")));
            this.picDog.Location = new System.Drawing.Point(123, 84);
            this.picDog.Name = "picDog";
            this.picDog.Size = new System.Drawing.Size(100, 92);
            this.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDog.TabIndex = 3;
            this.picDog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 329);
            this.Controls.Add(this.picDog);
            this.Controls.Add(this.labelBemvindo);
            this.Controls.Add(this.btnRacas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindo ao Thor Dogg";
            ((System.ComponentModel.ISupportInitialize)(this.picDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRacas;
        private Label labelBemvindo;
        private PictureBox picDog;
    }
}