namespace Pilas_Colas.Usuario
{
    partial class frmInterfaz
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveCola = new System.Windows.Forms.Button();
            this.btnAddCola = new System.Windows.Forms.Button();
            this.txtDatoCola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNuevoSize = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sección de Colas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sección de Pilas";
            // 
            // btnRemoveCola
            // 
            this.btnRemoveCola.Location = new System.Drawing.Point(414, 139);
            this.btnRemoveCola.Name = "btnRemoveCola";
            this.btnRemoveCola.Size = new System.Drawing.Size(99, 23);
            this.btnRemoveCola.TabIndex = 25;
            this.btnRemoveCola.Text = "Quitar elemento";
            this.btnRemoveCola.UseVisualStyleBackColor = true;
            // 
            // btnAddCola
            // 
            this.btnAddCola.Location = new System.Drawing.Point(414, 110);
            this.btnAddCola.Name = "btnAddCola";
            this.btnAddCola.Size = new System.Drawing.Size(99, 23);
            this.btnAddCola.TabIndex = 24;
            this.btnAddCola.Text = "Agregar dato";
            this.btnAddCola.UseVisualStyleBackColor = true;
            // 
            // txtDatoCola
            // 
            this.txtDatoCola.Location = new System.Drawing.Point(308, 112);
            this.txtDatoCola.Name = "txtDatoCola";
            this.txtDatoCola.Size = new System.Drawing.Size(100, 20);
            this.txtDatoCola.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dato:";
            // 
            // btnNuevoSize
            // 
            this.btnNuevoSize.Location = new System.Drawing.Point(414, 68);
            this.btnNuevoSize.Name = "btnNuevoSize";
            this.btnNuevoSize.Size = new System.Drawing.Size(99, 23);
            this.btnNuevoSize.TabIndex = 21;
            this.btnNuevoSize.Text = "Cambiar tamaño";
            this.btnNuevoSize.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(414, 39);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(99, 23);
            this.btnAplicar.TabIndex = 20;
            this.btnAplicar.Text = "Establecer";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(308, 41);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tamaño:";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(41, 100);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(99, 23);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "Quitar elemento";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 71);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar dato";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(40, 41);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 15;
            this.txtDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDato_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dato:";
            // 
            // frmInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 165);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRemoveCola);
            this.Controls.Add(this.btnAddCola);
            this.Controls.Add(this.txtDatoCola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNuevoSize);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "frmInterfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilas y Colas";
            this.Load += new System.EventHandler(this.frmInterfaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveCola;
        private System.Windows.Forms.Button btnAddCola;
        private System.Windows.Forms.TextBox txtDatoCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNuevoSize;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
    }
}