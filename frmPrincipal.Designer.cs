namespace DekalCore
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.picFalas = new System.Windows.Forms.PictureBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtMágico = new System.Windows.Forms.TextBox();
            this.txtFísico = new System.Windows.Forms.TextBox();
            this.picZerar = new System.Windows.Forms.PictureBox();
            this.picRefinar = new System.Windows.Forms.PictureBox();
            this.lblRefino = new System.Windows.Forms.Label();
            this.refNível_01 = new System.Windows.Forms.PictureBox();
            this.refNível_02 = new System.Windows.Forms.PictureBox();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.refNível_03 = new System.Windows.Forms.PictureBox();
            this.refNível_04 = new System.Windows.Forms.PictureBox();
            this.refNível_05 = new System.Windows.Forms.PictureBox();
            this.refNível_06 = new System.Windows.Forms.PictureBox();
            this.refNível_12 = new System.Windows.Forms.PictureBox();
            this.refNível_11 = new System.Windows.Forms.PictureBox();
            this.refNível_10 = new System.Windows.Forms.PictureBox();
            this.refNível_09 = new System.Windows.Forms.PictureBox();
            this.refNível_08 = new System.Windows.Forms.PictureBox();
            this.refNível_07 = new System.Windows.Forms.PictureBox();
            this.lblFísico = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblMágico = new System.Windows.Forms.Label();
            this.Mágico = new System.Windows.Forms.Label();
            this.Físico = new System.Windows.Forms.Label();
            this.HitPoints = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.picPlayPause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefinar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).BeginInit();
            this.SuspendLayout();
            // 
            // picFalas
            // 
            this.picFalas.BackColor = System.Drawing.Color.Transparent;
            this.picFalas.Location = new System.Drawing.Point(8, 14);
            this.picFalas.Name = "picFalas";
            this.picFalas.Size = new System.Drawing.Size(509, 117);
            this.picFalas.TabIndex = 0;
            this.picFalas.TabStop = false;
            // 
            // txtHP
            // 
            this.txtHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHP.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHP.Location = new System.Drawing.Point(183, 292);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(138, 18);
            this.txtHP.TabIndex = 2;
            this.txtHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHP.MouseHover += new System.EventHandler(this.txtHP_MouseHover);
            // 
            // txtMágico
            // 
            this.txtMágico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMágico.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMágico.Location = new System.Drawing.Point(183, 252);
            this.txtMágico.Name = "txtMágico";
            this.txtMágico.Size = new System.Drawing.Size(138, 18);
            this.txtMágico.TabIndex = 1;
            this.txtMágico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMágico.MouseHover += new System.EventHandler(this.txtMágico_MouseHover);
            // 
            // txtFísico
            // 
            this.txtFísico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFísico.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFísico.Location = new System.Drawing.Point(183, 212);
            this.txtFísico.Name = "txtFísico";
            this.txtFísico.Size = new System.Drawing.Size(138, 18);
            this.txtFísico.TabIndex = 0;
            this.txtFísico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFísico.MouseHover += new System.EventHandler(this.txtFísico_MouseHover);
            // 
            // picZerar
            // 
            this.picZerar.BackColor = System.Drawing.Color.Transparent;
            this.picZerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picZerar.Location = new System.Drawing.Point(258, 396);
            this.picZerar.Name = "picZerar";
            this.picZerar.Size = new System.Drawing.Size(74, 29);
            this.picZerar.TabIndex = 4;
            this.picZerar.TabStop = false;
            this.picZerar.Click += new System.EventHandler(this.picZerar_Click);
            // 
            // picRefinar
            // 
            this.picRefinar.BackColor = System.Drawing.Color.Transparent;
            this.picRefinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefinar.Location = new System.Drawing.Point(258, 360);
            this.picRefinar.Name = "picRefinar";
            this.picRefinar.Size = new System.Drawing.Size(74, 29);
            this.picRefinar.TabIndex = 5;
            this.picRefinar.TabStop = false;
            this.picRefinar.Click += new System.EventHandler(this.picRefinar_Click);
            this.picRefinar.MouseHover += new System.EventHandler(this.picRefinar_MouseHover);
            // 
            // lblRefino
            // 
            this.lblRefino.BackColor = System.Drawing.Color.Transparent;
            this.lblRefino.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRefino.Location = new System.Drawing.Point(195, 326);
            this.lblRefino.Name = "lblRefino";
            this.lblRefino.Size = new System.Drawing.Size(60, 31);
            this.lblRefino.TabIndex = 6;
            this.lblRefino.Text = "+0";
            this.lblRefino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refNível_01
            // 
            this.refNível_01.BackColor = System.Drawing.Color.Transparent;
            this.refNível_01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_01.Location = new System.Drawing.Point(30, 362);
            this.refNível_01.Name = "refNível_01";
            this.refNível_01.Size = new System.Drawing.Size(26, 25);
            this.refNível_01.TabIndex = 7;
            this.refNível_01.TabStop = false;
            this.refNível_01.Click += new System.EventHandler(this.refNível_01_Click);
            // 
            // refNível_02
            // 
            this.refNível_02.BackColor = System.Drawing.Color.Transparent;
            this.refNível_02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_02.Location = new System.Drawing.Point(59, 362);
            this.refNível_02.Name = "refNível_02";
            this.refNível_02.Size = new System.Drawing.Size(26, 25);
            this.refNível_02.TabIndex = 8;
            this.refNível_02.TabStop = false;
            this.refNível_02.Click += new System.EventHandler(this.refNível_02_Click);
            // 
            // picFechar
            // 
            this.picFechar.BackColor = System.Drawing.Color.Transparent;
            this.picFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFechar.Image = global::DekalCore.Properties.Resources.Fechar_Leave;
            this.picFechar.Location = new System.Drawing.Point(640, -6);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(66, 68);
            this.picFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFechar.TabIndex = 9;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
            this.picFechar.MouseLeave += new System.EventHandler(this.picFechar_MouseLeave);
            this.picFechar.MouseHover += new System.EventHandler(this.picFechar_MouseHover);
            // 
            // refNível_03
            // 
            this.refNível_03.BackColor = System.Drawing.Color.Transparent;
            this.refNível_03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_03.Location = new System.Drawing.Point(89, 362);
            this.refNível_03.Name = "refNível_03";
            this.refNível_03.Size = new System.Drawing.Size(26, 25);
            this.refNível_03.TabIndex = 10;
            this.refNível_03.TabStop = false;
            this.refNível_03.Click += new System.EventHandler(this.refNível_03_Click);
            // 
            // refNível_04
            // 
            this.refNível_04.BackColor = System.Drawing.Color.Transparent;
            this.refNível_04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_04.Location = new System.Drawing.Point(118, 362);
            this.refNível_04.Name = "refNível_04";
            this.refNível_04.Size = new System.Drawing.Size(26, 25);
            this.refNível_04.TabIndex = 11;
            this.refNível_04.TabStop = false;
            this.refNível_04.Click += new System.EventHandler(this.refNível_04_Click);
            // 
            // refNível_05
            // 
            this.refNível_05.BackColor = System.Drawing.Color.Transparent;
            this.refNível_05.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_05.Location = new System.Drawing.Point(147, 362);
            this.refNível_05.Name = "refNível_05";
            this.refNível_05.Size = new System.Drawing.Size(26, 25);
            this.refNível_05.TabIndex = 12;
            this.refNível_05.TabStop = false;
            this.refNível_05.Click += new System.EventHandler(this.refNível_05_Click);
            // 
            // refNível_06
            // 
            this.refNível_06.BackColor = System.Drawing.Color.Transparent;
            this.refNível_06.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_06.Location = new System.Drawing.Point(176, 362);
            this.refNível_06.Name = "refNível_06";
            this.refNível_06.Size = new System.Drawing.Size(26, 25);
            this.refNível_06.TabIndex = 13;
            this.refNível_06.TabStop = false;
            this.refNível_06.Click += new System.EventHandler(this.refNível_06_Click);
            // 
            // refNível_12
            // 
            this.refNível_12.BackColor = System.Drawing.Color.Transparent;
            this.refNível_12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_12.Location = new System.Drawing.Point(176, 390);
            this.refNível_12.Name = "refNível_12";
            this.refNível_12.Size = new System.Drawing.Size(26, 25);
            this.refNível_12.TabIndex = 19;
            this.refNível_12.TabStop = false;
            this.refNível_12.Click += new System.EventHandler(this.refNível_12_Click);
            // 
            // refNível_11
            // 
            this.refNível_11.BackColor = System.Drawing.Color.Transparent;
            this.refNível_11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_11.Location = new System.Drawing.Point(147, 390);
            this.refNível_11.Name = "refNível_11";
            this.refNível_11.Size = new System.Drawing.Size(26, 25);
            this.refNível_11.TabIndex = 18;
            this.refNível_11.TabStop = false;
            this.refNível_11.Click += new System.EventHandler(this.refNível_11_Click);
            // 
            // refNível_10
            // 
            this.refNível_10.BackColor = System.Drawing.Color.Transparent;
            this.refNível_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_10.Location = new System.Drawing.Point(118, 390);
            this.refNível_10.Name = "refNível_10";
            this.refNível_10.Size = new System.Drawing.Size(26, 25);
            this.refNível_10.TabIndex = 17;
            this.refNível_10.TabStop = false;
            this.refNível_10.Click += new System.EventHandler(this.refNível_10_Click);
            // 
            // refNível_09
            // 
            this.refNível_09.BackColor = System.Drawing.Color.Transparent;
            this.refNível_09.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_09.Location = new System.Drawing.Point(89, 390);
            this.refNível_09.Name = "refNível_09";
            this.refNível_09.Size = new System.Drawing.Size(26, 25);
            this.refNível_09.TabIndex = 16;
            this.refNível_09.TabStop = false;
            this.refNível_09.Click += new System.EventHandler(this.refNível_09_Click);
            // 
            // refNível_08
            // 
            this.refNível_08.BackColor = System.Drawing.Color.Transparent;
            this.refNível_08.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_08.Location = new System.Drawing.Point(59, 390);
            this.refNível_08.Name = "refNível_08";
            this.refNível_08.Size = new System.Drawing.Size(26, 25);
            this.refNível_08.TabIndex = 15;
            this.refNível_08.TabStop = false;
            this.refNível_08.Click += new System.EventHandler(this.refNível_08_Click);
            // 
            // refNível_07
            // 
            this.refNível_07.BackColor = System.Drawing.Color.Transparent;
            this.refNível_07.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refNível_07.Location = new System.Drawing.Point(30, 390);
            this.refNível_07.Name = "refNível_07";
            this.refNível_07.Size = new System.Drawing.Size(26, 25);
            this.refNível_07.TabIndex = 14;
            this.refNível_07.TabStop = false;
            this.refNível_07.Click += new System.EventHandler(this.refNível_07_Click);
            // 
            // lblFísico
            // 
            this.lblFísico.BackColor = System.Drawing.Color.Transparent;
            this.lblFísico.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFísico.Location = new System.Drawing.Point(34, 81);
            this.lblFísico.Name = "lblFísico";
            this.lblFísico.Size = new System.Drawing.Size(120, 41);
            this.lblFísico.TabIndex = 20;
            this.lblFísico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHP
            // 
            this.lblHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHP.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(322, 81);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(120, 41);
            this.lblHP.TabIndex = 21;
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMágico
            // 
            this.lblMágico.BackColor = System.Drawing.Color.Transparent;
            this.lblMágico.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMágico.Location = new System.Drawing.Point(178, 81);
            this.lblMágico.Name = "lblMágico";
            this.lblMágico.Size = new System.Drawing.Size(120, 41);
            this.lblMágico.TabIndex = 22;
            this.lblMágico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mágico
            // 
            this.Mágico.AutoSize = true;
            this.Mágico.BackColor = System.Drawing.Color.Transparent;
            this.Mágico.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mágico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mágico.Location = new System.Drawing.Point(187, 25);
            this.Mágico.Name = "Mágico";
            this.Mágico.Size = new System.Drawing.Size(103, 56);
            this.Mágico.TabIndex = 25;
            this.Mágico.Text = "Atributo \r\nMágico:";
            this.Mágico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Físico
            // 
            this.Físico.AutoSize = true;
            this.Físico.BackColor = System.Drawing.Color.Transparent;
            this.Físico.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Físico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Físico.Location = new System.Drawing.Point(43, 25);
            this.Físico.Name = "Físico";
            this.Físico.Size = new System.Drawing.Size(103, 56);
            this.Físico.TabIndex = 26;
            this.Físico.Text = "Atributo \r\nFísico:";
            this.Físico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HitPoints
            // 
            this.HitPoints.AutoSize = true;
            this.HitPoints.BackColor = System.Drawing.Color.Transparent;
            this.HitPoints.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HitPoints.Location = new System.Drawing.Point(341, 25);
            this.HitPoints.Name = "HitPoints";
            this.HitPoints.Size = new System.Drawing.Size(84, 56);
            this.HitPoints.TabIndex = 27;
            this.HitPoints.Text = "Hit \r\nPoints:";
            this.HitPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // picPlayPause
            // 
            this.picPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.picPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlayPause.Location = new System.Drawing.Point(669, 345);
            this.picPlayPause.Name = "picPlayPause";
            this.picPlayPause.Size = new System.Drawing.Size(26, 26);
            this.picPlayPause.TabIndex = 28;
            this.picPlayPause.TabStop = false;
            this.picPlayPause.Click += new System.EventHandler(this.picPlayPause_Click);
            this.picPlayPause.MouseHover += new System.EventHandler(this.picPlayPause_MouseHover);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DekalCore.Properties.Resources.Principal;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.picPlayPause);
            this.Controls.Add(this.lblFísico);
            this.Controls.Add(this.lblMágico);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.HitPoints);
            this.Controls.Add(this.Físico);
            this.Controls.Add(this.Mágico);
            this.Controls.Add(this.refNível_12);
            this.Controls.Add(this.refNível_11);
            this.Controls.Add(this.refNível_10);
            this.Controls.Add(this.refNível_09);
            this.Controls.Add(this.refNível_08);
            this.Controls.Add(this.refNível_07);
            this.Controls.Add(this.refNível_06);
            this.Controls.Add(this.refNível_05);
            this.Controls.Add(this.refNível_04);
            this.Controls.Add(this.refNível_03);
            this.Controls.Add(this.picFechar);
            this.Controls.Add(this.refNível_02);
            this.Controls.Add(this.refNível_01);
            this.Controls.Add(this.lblRefino);
            this.Controls.Add(this.picRefinar);
            this.Controls.Add(this.picZerar);
            this.Controls.Add(this.txtFísico);
            this.Controls.Add(this.txtMágico);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.picFalas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dekal\'s Core";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseLeave += new System.EventHandler(this.frmPrincipal_MouseLeave);
            this.MouseHover += new System.EventHandler(this.frmPrincipal_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picFalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefinar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refNível_07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFalas;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtMágico;
        private System.Windows.Forms.TextBox txtFísico;
        private System.Windows.Forms.PictureBox picZerar;
        private System.Windows.Forms.PictureBox picRefinar;
        private System.Windows.Forms.Label lblRefino;
        private System.Windows.Forms.PictureBox refNível_01;
        private System.Windows.Forms.PictureBox refNível_02;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox refNível_03;
        private System.Windows.Forms.PictureBox refNível_04;
        private System.Windows.Forms.PictureBox refNível_05;
        private System.Windows.Forms.PictureBox refNível_06;
        private System.Windows.Forms.PictureBox refNível_12;
        private System.Windows.Forms.PictureBox refNível_11;
        private System.Windows.Forms.PictureBox refNível_10;
        private System.Windows.Forms.PictureBox refNível_09;
        private System.Windows.Forms.PictureBox refNível_08;
        private System.Windows.Forms.PictureBox refNível_07;
        private System.Windows.Forms.Label lblFísico;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblMágico;
        private System.Windows.Forms.Label Mágico;
        private System.Windows.Forms.Label Físico;
        private System.Windows.Forms.Label HitPoints;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.PictureBox picPlayPause;
    }
}

