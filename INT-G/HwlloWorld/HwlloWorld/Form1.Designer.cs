namespace HwlloWorld
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lbHelloWorld = new System.Windows.Forms.Label();
            this.Cltext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickThis.Location = new System.Drawing.Point(467, 144);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(208, 72);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lbHelloWorld
            // 
            this.lbHelloWorld.AutoSize = true;
            this.lbHelloWorld.BackColor = System.Drawing.Color.Yellow;
            this.lbHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelloWorld.Location = new System.Drawing.Point(514, 236);
            this.lbHelloWorld.Name = "lbHelloWorld";
            this.lbHelloWorld.Size = new System.Drawing.Size(0, 25);
            this.lbHelloWorld.TabIndex = 1;
            // 
            // Cltext
            // 
            this.Cltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cltext.Location = new System.Drawing.Point(467, 305);
            this.Cltext.Name = "Cltext";
            this.Cltext.Size = new System.Drawing.Size(208, 72);
            this.Cltext.TabIndex = 2;
            this.Cltext.Text = "Clean";
            this.Cltext.UseVisualStyleBackColor = true;
            this.Cltext.Click += new System.EventHandler(this.Cltext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 590);
            this.Controls.Add(this.Cltext);
            this.Controls.Add(this.lbHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lbHelloWorld;
        private System.Windows.Forms.Button Cltext;
    }
}

