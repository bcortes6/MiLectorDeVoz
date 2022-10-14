namespace MiLectorDeVoz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbTexto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.btnSpeak);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPausa);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrir.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.bandeja_de_entrada;
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbrir.Location = new System.Drawing.Point(22, 6);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(42, 35);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.Transparent;
            this.btnSpeak.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.conversacion;
            this.btnSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSpeak.Location = new System.Drawing.Point(733, 6);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(41, 35);
            this.btnSpeak.TabIndex = 4;
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.boton_detener1;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnStop.Location = new System.Drawing.Point(430, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 35);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.Color.Transparent;
            this.btnPausa.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.boton_de_pausa_de_video;
            this.btnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausa.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnPausa.Location = new System.Drawing.Point(372, 6);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(36, 35);
            this.btnPausa.TabIndex = 2;
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::MiLectorDeVoz.Properties.Resources.boton_de_play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnPlay.Location = new System.Drawing.Point(311, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(37, 35);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTexto
            // 
            this.lbTexto.BackColor = System.Drawing.Color.Lavender;
            this.lbTexto.Location = new System.Drawing.Point(0, 51);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(801, 400);
            this.lbTexto.TabIndex = 1;
            this.lbTexto.Text = " Lector de Texto Avanzado";
            this.lbTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lbTexto;
    }
}

