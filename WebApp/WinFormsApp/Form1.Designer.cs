﻿namespace WinFormsApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.cbTamanioPagina = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPageIndex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.TxtContenido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRemitente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDestinatario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MailId,
            this.Asunto});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(507, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // MailId
            // 
            this.MailId.HeaderText = "MailId";
            this.MailId.Name = "MailId";
            this.MailId.ReadOnly = true;
            // 
            // Asunto
            // 
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Lavender;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Location = new System.Drawing.Point(713, 35);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Lavender;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior.Location = new System.Drawing.Point(577, 36);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // cbTamanioPagina
            // 
            this.cbTamanioPagina.FormattingEnabled = true;
            this.cbTamanioPagina.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.cbTamanioPagina.Location = new System.Drawing.Point(525, 36);
            this.cbTamanioPagina.Name = "cbTamanioPagina";
            this.cbTamanioPagina.Size = new System.Drawing.Size(46, 23);
            this.cbTamanioPagina.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(507, 23);
            this.txtSearch.TabIndex = 4;
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.Location = new System.Drawing.Point(658, 36);
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Size = new System.Drawing.Size(49, 23);
            this.txtPageIndex.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bandeja de entrada";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(371, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Bandeja de salida";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Lavender;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(632, 276);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAsunto.Location = new System.Drawing.Point(525, 112);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(263, 21);
            this.TxtAsunto.TabIndex = 9;
            // 
            // TxtContenido
            // 
            this.TxtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtContenido.Location = new System.Drawing.Point(525, 156);
            this.TxtContenido.Name = "TxtContenido";
            this.TxtContenido.Size = new System.Drawing.Size(263, 21);
            this.TxtContenido.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(533, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Asunto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(533, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contenido";
            // 
            // TxtRemitente
            // 
            this.TxtRemitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtRemitente.Location = new System.Drawing.Point(525, 200);
            this.TxtRemitente.Name = "TxtRemitente";
            this.TxtRemitente.Size = new System.Drawing.Size(263, 21);
            this.TxtRemitente.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Buscar:";
            // 
            // TxtDestinatario
            // 
            this.TxtDestinatario.Location = new System.Drawing.Point(525, 247);
            this.TxtDestinatario.Name = "TxtDestinatario";
            this.TxtDestinatario.Size = new System.Drawing.Size(263, 23);
            this.TxtDestinatario.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(533, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Remitente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(533, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Destinatario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDestinatario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRemitente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContenido);
            this.Controls.Add(this.TxtAsunto);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPageIndex);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbTamanioPagina);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSiguiente;
        private Button btnAnterior;
        private ComboBox cbTamanioPagina;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn MailId;
        private DataGridViewTextBoxColumn Asunto;
        private TextBox txtPageIndex;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox TxtAsunto;
        private TextBox TxtContenido;
        private Label label1;
        private Label label2;
        private TextBox TxtRemitente;
        private Button btnEnviar;
        private Label label5;
        private TextBox TxtDestinatario;
        private Label label3;
        private Label label4;
    }
}