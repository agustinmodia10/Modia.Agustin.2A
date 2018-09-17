namespace ejercicioclase06
{
    partial class formupluma
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
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.selecnumero = new System.Windows.Forms.NumericUpDown();
            this.txtcant = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.Label();
            this.cmbtintas = new System.Windows.Forms.ComboBox();
            this.txttinta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selecnumero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(50, 212);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(131, 212);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // selecnumero
            // 
            this.selecnumero.Location = new System.Drawing.Point(66, 47);
            this.selecnumero.Name = "selecnumero";
            this.selecnumero.Size = new System.Drawing.Size(120, 20);
            this.selecnumero.TabIndex = 5;
            this.selecnumero.ValueChanged += new System.EventHandler(this.selecnumero_ValueChanged);
            // 
            // txtcant
            // 
            this.txtcant.AutoSize = true;
            this.txtcant.Location = new System.Drawing.Point(63, 18);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(62, 13);
            this.txtcant.TabIndex = 6;
            this.txtcant.Text = "CANTIDAD";
            this.txtcant.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbmarca
            // 
            this.cmbmarca.Location = new System.Drawing.Point(66, 108);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(120, 20);
            this.cmbmarca.TabIndex = 8;
            this.cmbmarca.TextChanged += new System.EventHandler(this.cmbmarca_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.AutoSize = true;
            this.txtmarca.Location = new System.Drawing.Point(63, 82);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(45, 13);
            this.txtmarca.TabIndex = 9;
            this.txtmarca.Text = "MARCA";
            // 
            // cmbtintas
            // 
            this.cmbtintas.FormattingEnabled = true;
            this.cmbtintas.Location = new System.Drawing.Point(65, 174);
            this.cmbtintas.Name = "cmbtintas";
            this.cmbtintas.Size = new System.Drawing.Size(121, 21);
            this.cmbtintas.TabIndex = 10;
            this.cmbtintas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txttinta
            // 
            this.txttinta.AutoSize = true;
            this.txttinta.Location = new System.Drawing.Point(62, 144);
            this.txttinta.Name = "txttinta";
            this.txttinta.Size = new System.Drawing.Size(39, 13);
            this.txttinta.TabIndex = 13;
            this.txttinta.Text = "TINTA";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 127);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // formupluma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 291);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txttinta);
            this.Controls.Add(this.cmbtintas);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.cmbmarca);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.selecnumero);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Name = "formupluma";
            this.Text = "formupluma";
            this.Load += new System.EventHandler(this.formupluma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selecnumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.NumericUpDown selecnumero;
        private System.Windows.Forms.Label txtcant;
        private System.Windows.Forms.TextBox cmbmarca;
        private System.Windows.Forms.Label txtmarca;
        private System.Windows.Forms.ComboBox cmbtintas;
        private System.Windows.Forms.Label txttinta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}