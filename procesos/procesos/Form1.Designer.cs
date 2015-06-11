namespace procesos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboProceso = new System.Windows.Forms.ComboBox();
            this.cboPagina = new System.Windows.Forms.ComboBox();
            this.cboTermino = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEjecucion = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEspera = new System.Windows.Forms.ListBox();
            this.dgvProceso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proceso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "T. de Página";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Term. Proceso";
            // 
            // cboProceso
            // 
            this.cboProceso.FormattingEnabled = true;
            this.cboProceso.Location = new System.Drawing.Point(94, 24);
            this.cboProceso.Name = "cboProceso";
            this.cboProceso.Size = new System.Drawing.Size(51, 21);
            this.cboProceso.TabIndex = 2;
            this.cboProceso.SelectedIndexChanged += new System.EventHandler(this.cboProceso_SelectedIndexChanged);
            // 
            // cboPagina
            // 
            this.cboPagina.FormattingEnabled = true;
            this.cboPagina.Location = new System.Drawing.Point(94, 62);
            this.cboPagina.Name = "cboPagina";
            this.cboPagina.Size = new System.Drawing.Size(51, 21);
            this.cboPagina.TabIndex = 3;
            // 
            // cboTermino
            // 
            this.cboTermino.FormattingEnabled = true;
            this.cboTermino.Location = new System.Drawing.Point(104, 160);
            this.cboTermino.Name = "cboTermino";
            this.cboTermino.Size = new System.Drawing.Size(51, 21);
            this.cboTermino.TabIndex = 4;
            this.cboTermino.SelectedIndexChanged += new System.EventHandler(this.cboTermino_SelectedIndexChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(204, 60);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(111, 23);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar Proceso";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(204, 160);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(111, 23);
            this.btnTerminar.TabIndex = 6;
            this.btnTerminar.Text = "Terminar Proceso";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEjecucion);
            this.groupBox1.Location = new System.Drawing.Point(387, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejecucion";
            // 
            // lblEjecucion
            // 
            this.lblEjecucion.FormattingEnabled = true;
            this.lblEjecucion.Location = new System.Drawing.Point(21, 24);
            this.lblEjecucion.Name = "lblEjecucion";
            this.lblEjecucion.Size = new System.Drawing.Size(164, 121);
            this.lblEjecucion.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEspera);
            this.groupBox2.Location = new System.Drawing.Point(387, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En espera";
            // 
            // lblEspera
            // 
            this.lblEspera.FormattingEnabled = true;
            this.lblEspera.Location = new System.Drawing.Point(21, 19);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(164, 160);
            this.lblEspera.TabIndex = 0;
            // 
            // dgvProceso
            // 
            this.dgvProceso.AllowUserToAddRows = false;
            this.dgvProceso.AllowUserToDeleteRows = false;
            this.dgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProceso.ColumnHeadersVisible = false;
            this.dgvProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvProceso.Location = new System.Drawing.Point(668, 28);
            this.dgvProceso.Name = "dgvProceso";
            this.dgvProceso.ReadOnly = true;
            this.dgvProceso.RowHeadersVisible = false;
            this.dgvProceso.Size = new System.Drawing.Size(166, 246);
            this.dgvProceso.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(603, 290);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(67, 51);
            this.btnEjecutar.TabIndex = 11;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgvProceso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cboTermino);
            this.Controls.Add(this.cboPagina);
            this.Controls.Add(this.cboProceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProceso;
        private System.Windows.Forms.ComboBox cboPagina;
        private System.Windows.Forms.ComboBox cboTermino;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lblEjecucion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lblEspera;
        private System.Windows.Forms.DataGridView dgvProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button button1;
    }
}

