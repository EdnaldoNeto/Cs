namespace Aula62___Componentes
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_transpSelecionados = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_resetarLista = new System.Windows.Forms.Button();
            this.btn_addNovoTransp = new System.Windows.Forms.Button();
            this.tb_novoTransp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(24, 62);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(239, 274);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_transpSelecionados
            // 
            this.btn_transpSelecionados.Location = new System.Drawing.Point(59, 357);
            this.btn_transpSelecionados.Name = "btn_transpSelecionados";
            this.btn_transpSelecionados.Size = new System.Drawing.Size(182, 33);
            this.btn_transpSelecionados.TabIndex = 1;
            this.btn_transpSelecionados.Text = "Mostra Selecionados";
            this.btn_transpSelecionados.UseVisualStyleBackColor = true;
            this.btn_transpSelecionados.Click += new System.EventHandler(this.btn_transpSelecionados_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.Location = new System.Drawing.Point(59, 396);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(182, 35);
            this.btn_limparLista.TabIndex = 2;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = true;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_resetarLista
            // 
            this.btn_resetarLista.Location = new System.Drawing.Point(59, 437);
            this.btn_resetarLista.Name = "btn_resetarLista";
            this.btn_resetarLista.Size = new System.Drawing.Size(182, 33);
            this.btn_resetarLista.TabIndex = 3;
            this.btn_resetarLista.Text = "Resetar Lista";
            this.btn_resetarLista.UseVisualStyleBackColor = true;
            this.btn_resetarLista.Click += new System.EventHandler(this.btn_resetarLista_Click);
            // 
            // btn_addNovoTransp
            // 
            this.btn_addNovoTransp.Location = new System.Drawing.Point(161, 26);
            this.btn_addNovoTransp.Name = "btn_addNovoTransp";
            this.btn_addNovoTransp.Size = new System.Drawing.Size(122, 30);
            this.btn_addNovoTransp.TabIndex = 4;
            this.btn_addNovoTransp.Text = "Adicionar transporte";
            this.btn_addNovoTransp.UseVisualStyleBackColor = true;
            this.btn_addNovoTransp.Click += new System.EventHandler(this.btn_addNovoTransp_Click);
            // 
            // tb_novoTransp
            // 
            this.tb_novoTransp.Location = new System.Drawing.Point(14, 32);
            this.tb_novoTransp.Name = "tb_novoTransp";
            this.tb_novoTransp.Size = new System.Drawing.Size(137, 20);
            this.tb_novoTransp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_novoTransp);
            this.Controls.Add(this.btn_addNovoTransp);
            this.Controls.Add(this.btn_resetarLista);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.btn_transpSelecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_transpSelecionados;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_resetarLista;
        private System.Windows.Forms.Button btn_addNovoTransp;
        private System.Windows.Forms.TextBox tb_novoTransp;
        private System.Windows.Forms.Label label1;
    }
}