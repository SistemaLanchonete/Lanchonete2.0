namespace Lanchonete_2._0.Telas
{
    partial class TelaCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCarrinho));
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.lista_compra = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lista_produto = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.bt_nvcompra = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button3.BackgroundImage")));
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 19;
            this.guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2Button3.Location = new System.Drawing.Point(17, 14);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Button3.PressedDepth = 2;
            this.guna2Button3.Size = new System.Drawing.Size(39, 57);
            this.guna2Button3.TabIndex = 30;
            this.guna2Button3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // lista_compra
            // 
            this.lista_compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_compra.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_compra.FormattingEnabled = true;
            this.lista_compra.ItemHeight = 18;
            this.lista_compra.Location = new System.Drawing.Point(377, 160);
            this.lista_compra.Name = "lista_compra";
            this.lista_compra.Size = new System.Drawing.Size(335, 216);
            this.lista_compra.TabIndex = 29;
            this.lista_compra.SelectedIndexChanged += new System.EventHandler(this.lista_compra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "COMPRAS";
            // 
            // lista_produto
            // 
            this.lista_produto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_produto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_produto.FormattingEnabled = true;
            this.lista_produto.ItemHeight = 18;
            this.lista_produto.Location = new System.Drawing.Point(17, 160);
            this.lista_produto.Name = "lista_produto";
            this.lista_produto.Size = new System.Drawing.Size(335, 216);
            this.lista_produto.TabIndex = 38;
            this.lista_produto.DoubleClick += new System.EventHandler(this.lista_produto_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-17, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 29);
            this.panel1.TabIndex = 36;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Indigo;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(0, -1);
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 28);
            this.guna2Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Button1.Location = new System.Drawing.Point(532, 453);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "Continuar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(208, 14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(41, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 34;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "| Carrinho de Compras";
            // 
            // lb_total
            // 
            this.lb_total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_total.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(377, 391);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(335, 46);
            this.lb_total.TabIndex = 32;
            this.lb_total.Text = "COMPRAS";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_nvcompra
            // 
            this.bt_nvcompra.BorderRadius = 5;
            this.bt_nvcompra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_nvcompra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_nvcompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_nvcompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_nvcompra.FillColor = System.Drawing.Color.Indigo;
            this.bt_nvcompra.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nvcompra.ForeColor = System.Drawing.Color.White;
            this.bt_nvcompra.Image = ((System.Drawing.Image)(resources.GetObject("bt_nvcompra.Image")));
            this.bt_nvcompra.ImageSize = new System.Drawing.Size(35, 35);
            this.bt_nvcompra.Location = new System.Drawing.Point(76, 453);
            this.bt_nvcompra.Name = "bt_nvcompra";
            this.bt_nvcompra.Size = new System.Drawing.Size(180, 45);
            this.bt_nvcompra.TabIndex = 31;
            this.bt_nvcompra.Text = "NOVA COMPRA";
            this.bt_nvcompra.Click += new System.EventHandler(this.bt_nvcompra_Click);
            // 
            // TelaCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.lista_compra);
            this.Controls.Add(this.lista_produto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.bt_nvcompra);
            this.Name = "TelaCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCarrinho";
            this.Load += new System.EventHandler(this.TelaCarrinho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.ListBox lista_compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lista_produto;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_total;
        private Guna.UI2.WinForms.Guna2Button bt_nvcompra;
    }
}