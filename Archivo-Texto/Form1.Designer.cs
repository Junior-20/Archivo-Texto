namespace Archivo_Texto
{
    partial class Form1
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
            this.txtregistro = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLeer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.texregistro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrnc = new System.Windows.Forms.TextBox();
            this.textnomina = new System.Windows.Forms.TextBox();
            this.textcedula = new System.Windows.Forms.TextBox();
            this.textsalario = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtregistro
            // 
            this.txtregistro.AutoSize = true;
            this.txtregistro.Location = new System.Drawing.Point(12, 151);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(133, 20);
            this.txtregistro.TabIndex = 2;
            this.txtregistro.Text = "Tipo de Registro :";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(12, 212);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(173, 20);
            this.label64.TabIndex = 3;
            this.label64.Text = "Fecha de Transmisión :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Autodeterminacion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de Nómina : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cédula :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "RNC :";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(480, 492);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(439, 45);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // texregistro
            // 
            this.texregistro.Location = new System.Drawing.Point(143, 151);
            this.texregistro.Name = "texregistro";
            this.texregistro.Size = new System.Drawing.Size(289, 26);
            this.texregistro.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Salario Neto :";
            // 
            // txtrnc
            // 
            this.txtrnc.Location = new System.Drawing.Point(72, 106);
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.Size = new System.Drawing.Size(360, 26);
            this.txtrnc.TabIndex = 12;
            // 
            // textnomina
            // 
            this.textnomina.Location = new System.Drawing.Point(167, 319);
            this.textnomina.Name = "textnomina";
            this.textnomina.Size = new System.Drawing.Size(265, 26);
            this.textnomina.TabIndex = 13;
            // 
            // textcedula
            // 
            this.textcedula.Location = new System.Drawing.Point(80, 363);
            this.textcedula.Name = "textcedula";
            this.textcedula.Size = new System.Drawing.Size(352, 26);
            this.textcedula.TabIndex = 14;
            // 
            // textsalario
            // 
            this.textsalario.Location = new System.Drawing.Point(117, 406);
            this.textsalario.Name = "textsalario";
            this.textsalario.Size = new System.Drawing.Size(315, 26);
            this.textsalario.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 26);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(232, 266);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(500, 326);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textsalario);
            this.Controls.Add(this.textcedula);
            this.Controls.Add(this.textnomina);
            this.Controls.Add(this.txtrnc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texregistro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.txtregistro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtregistro;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox texregistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrnc;
        private System.Windows.Forms.TextBox textnomina;
        private System.Windows.Forms.TextBox textcedula;
        private System.Windows.Forms.TextBox textsalario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

