namespace Lanchonete_2._0
{
    partial class TelaGerenciadorCardapio
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Editar = new Guna.UI2.WinForms.Guna2Button();
            this.add_produtos = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(140, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(568, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Editar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Location = new System.Drawing.Point(258, 117);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(180, 45);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // add_produtos
            // 
            this.add_produtos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_produtos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_produtos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_produtos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_produtos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_produtos.ForeColor = System.Drawing.Color.White;
            this.add_produtos.Location = new System.Drawing.Point(478, 117);
            this.add_produtos.Name = "add_produtos";
            this.add_produtos.Size = new System.Drawing.Size(180, 45);
            this.add_produtos.TabIndex = 2;
            this.add_produtos.Text = "add";
            this.add_produtos.Click += new System.EventHandler(this.add_produtos_Click);
            // 
            // TelaGerenciadorCardapio
            // 
            this.ClientSize = new System.Drawing.Size(809, 485);
            this.Controls.Add(this.add_produtos);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.dataGridView2);
            this.Name = "TelaGerenciadorCardapio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2Button Editar;
        private Guna.UI2.WinForms.Guna2Button add_produtos;
    }
}