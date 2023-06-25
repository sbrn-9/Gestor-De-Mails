namespace WinFormsApp
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
            dataGridView1 = new DataGridView();
            MailId = new DataGridViewTextBoxColumn();
            Asunto = new DataGridViewTextBoxColumn();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            cbTamanioPagina = new ComboBox();
            txtSearch = new TextBox();
            txtPageIndex = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnEnviar = new Button();
            TxtAsunto = new TextBox();
            TxtContenido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtRemitente = new TextBox();
            label5 = new Label();
            TxtDestinatario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MailId, Asunto });
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(507, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MailId
            // 
            MailId.HeaderText = "MailId";
            MailId.Name = "MailId";
            MailId.ReadOnly = true;
            // 
            // Asunto
            // 
            Asunto.HeaderText = "Asunto";
            Asunto.Name = "Asunto";
            Asunto.ReadOnly = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.Lavender;
            btnSiguiente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(713, 35);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.Lavender;
            btnAnterior.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnterior.Location = new Point(577, 36);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // cbTamanioPagina
            // 
            cbTamanioPagina.FormattingEnabled = true;
            cbTamanioPagina.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbTamanioPagina.Location = new Point(525, 36);
            cbTamanioPagina.Name = "cbTamanioPagina";
            cbTamanioPagina.Size = new Size(46, 23);
            cbTamanioPagina.TabIndex = 3;
            cbTamanioPagina.SelectedIndexChanged += cbTamanioPagina_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtPageIndex
            // 
            txtPageIndex.Location = new Point(658, 36);
            txtPageIndex.Name = "txtPageIndex";
            txtPageIndex.Size = new Size(49, 23);
            txtPageIndex.TabIndex = 5;
            txtPageIndex.TextChanged += txtPageIndex_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 6;
            button1.Text = "Bandeja de entrada";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(371, 415);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 7;
            button2.Text = "Bandeja de salida";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Lavender;
            btnEnviar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(632, 276);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // TxtAsunto
            // 
            TxtAsunto.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAsunto.Location = new Point(525, 112);
            TxtAsunto.Name = "TxtAsunto";
            TxtAsunto.Size = new Size(263, 22);
            TxtAsunto.TabIndex = 9;
            // 
            // TxtContenido
            // 
            TxtContenido.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtContenido.Location = new Point(525, 156);
            TxtContenido.Name = "TxtContenido";
            TxtContenido.Size = new Size(263, 22);
            TxtContenido.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(533, 94);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 11;
            label1.Text = "Asunto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(533, 138);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 12;
            label2.Text = "Contenido";
            // 
            // TxtRemitente
            // 
            TxtRemitente.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRemitente.Location = new Point(525, 200);
            TxtRemitente.Name = "TxtRemitente";
            TxtRemitente.Size = new Size(263, 22);
            TxtRemitente.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 17);
            label5.Name = "label5";
            label5.Size = new Size(50, 17);
            label5.TabIndex = 16;
            label5.Text = "Buscar:";
            // 
            // TxtDestinatario
            // 
            TxtDestinatario.Location = new Point(525, 247);
            TxtDestinatario.Name = "TxtDestinatario";
            TxtDestinatario.Size = new Size(263, 23);
            TxtDestinatario.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(533, 182);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 13;
            label3.Text = "Remitente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(533, 227);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 18;
            label4.Text = "Destinatario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(TxtDestinatario);
            Controls.Add(label5);
            Controls.Add(TxtRemitente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtContenido);
            Controls.Add(TxtAsunto);
            Controls.Add(btnEnviar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPageIndex);
            Controls.Add(txtSearch);
            Controls.Add(cbTamanioPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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