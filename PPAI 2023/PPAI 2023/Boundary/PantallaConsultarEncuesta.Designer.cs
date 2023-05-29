namespace PPAI_2023
{
    partial class PantallaConsultarEncuesta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDescripcionRespuestas = new System.Windows.Forms.DataGridView();
            this.tomarOpcionCsv = new System.Windows.Forms.Button();
            this.tomarOpcionImprimir = new System.Windows.Forms.Button();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNroCelular = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdLlamadas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.maskedFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDescripcionEncuesta = new System.Windows.Forms.Label();
            this.grdRespuestasPosibles = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescripcionOperadorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObservacionAuditorColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDescripcionRespuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRespuestasPosibles)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDescripcionRespuestas
            // 
            this.grdDescripcionRespuestas.AllowUserToAddRows = false;
            this.grdDescripcionRespuestas.AllowUserToDeleteRows = false;
            this.grdDescripcionRespuestas.BackgroundColor = System.Drawing.Color.White;
            this.grdDescripcionRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDescripcionRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionRespuesta});
            this.grdDescripcionRespuestas.Location = new System.Drawing.Point(959, 445);
            this.grdDescripcionRespuestas.Name = "grdDescripcionRespuestas";
            this.grdDescripcionRespuestas.ReadOnly = true;
            this.grdDescripcionRespuestas.RowHeadersVisible = false;
            this.grdDescripcionRespuestas.RowHeadersWidth = 51;
            this.grdDescripcionRespuestas.RowTemplate.Height = 24;
            this.grdDescripcionRespuestas.Size = new System.Drawing.Size(315, 136);
            this.grdDescripcionRespuestas.TabIndex = 57;
            // 
            // tomarOpcionCsv
            // 
            this.tomarOpcionCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tomarOpcionCsv.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.tomarOpcionCsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.tomarOpcionCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tomarOpcionCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomarOpcionCsv.ForeColor = System.Drawing.Color.White;
            this.tomarOpcionCsv.Location = new System.Drawing.Point(1026, 598);
            this.tomarOpcionCsv.Name = "tomarOpcionCsv";
            this.tomarOpcionCsv.Size = new System.Drawing.Size(248, 54);
            this.tomarOpcionCsv.TabIndex = 56;
            this.tomarOpcionCsv.Text = "Generar Csv";
            this.tomarOpcionCsv.UseVisualStyleBackColor = false;
            this.tomarOpcionCsv.Click += new System.EventHandler(this.tomarOpcionCsv_Click);
            // 
            // tomarOpcionImprimir
            // 
            this.tomarOpcionImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tomarOpcionImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.tomarOpcionImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.tomarOpcionImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tomarOpcionImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomarOpcionImprimir.ForeColor = System.Drawing.Color.White;
            this.tomarOpcionImprimir.Location = new System.Drawing.Point(840, 598);
            this.tomarOpcionImprimir.Name = "tomarOpcionImprimir";
            this.tomarOpcionImprimir.Size = new System.Drawing.Size(148, 54);
            this.tomarOpcionImprimir.TabIndex = 55;
            this.tomarOpcionImprimir.Text = "Imprimir";
            this.tomarOpcionImprimir.UseVisualStyleBackColor = false;
            this.tomarOpcionImprimir.Click += new System.EventHandler(this.tomarOpcionImprimir_Click);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(905, 347);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(64, 25);
            this.lblDuracion.TabIndex = 53;
            this.lblDuracion.Text = "label2";
            this.lblDuracion.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(658, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 29);
            this.label8.TabIndex = 52;
            this.label8.Text = "Duracion de llamada:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(905, 302);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 25);
            this.lblEstado.TabIndex = 51;
            this.lblEstado.Text = "label2";
            this.lblEstado.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(679, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Estado de llamada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(838, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(802, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 48;
            this.label6.Text = "Celular:";
            // 
            // lblNroCelular
            // 
            this.lblNroCelular.AutoSize = true;
            this.lblNroCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCelular.ForeColor = System.Drawing.Color.White;
            this.lblNroCelular.Location = new System.Drawing.Point(905, 208);
            this.lblNroCelular.Name = "lblNroCelular";
            this.lblNroCelular.Size = new System.Drawing.Size(64, 25);
            this.lblNroCelular.TabIndex = 47;
            this.lblNroCelular.Text = "label2";
            this.lblNroCelular.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(905, 169);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(64, 25);
            this.lblDni.TabIndex = 46;
            this.lblDni.Text = "label2";
            this.lblDni.Visible = false;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(905, 130);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(64, 25);
            this.lblnombre.TabIndex = 43;
            this.lblnombre.Text = "label2";
            this.lblnombre.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(792, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(30, 598);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 54);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(473, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 38);
            this.label4.TabIndex = 40;
            this.label4.Text = "CONSULTAR ENCUESTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Seleccione una llamada:";
            // 
            // grdLlamadas
            // 
            this.grdLlamadas.AllowUserToAddRows = false;
            this.grdLlamadas.AllowUserToDeleteRows = false;
            this.grdLlamadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLlamadas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLlamadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLlamadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionOperadorColumn,
            this.DuracionColumn,
            this.ObservacionAuditorColum});
            this.grdLlamadas.Location = new System.Drawing.Point(40, 215);
            this.grdLlamadas.Name = "grdLlamadas";
            this.grdLlamadas.ReadOnly = true;
            this.grdLlamadas.RowHeadersVisible = false;
            this.grdLlamadas.RowHeadersWidth = 51;
            this.grdLlamadas.RowTemplate.Height = 24;
            this.grdLlamadas.Size = new System.Drawing.Size(442, 186);
            this.grdLlamadas.TabIndex = 38;
            this.grdLlamadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarLlamadaSeleccionada);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha de fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha de inicio:";
            // 
            // maskedFechaFin
            // 
            this.maskedFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedFechaFin.Location = new System.Drawing.Point(270, 128);
            this.maskedFechaFin.Mask = "00/00/0000";
            this.maskedFechaFin.Name = "maskedFechaFin";
            this.maskedFechaFin.Size = new System.Drawing.Size(162, 38);
            this.maskedFechaFin.TabIndex = 35;
            // 
            // maskedFechaInicio
            // 
            this.maskedFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedFechaInicio.Location = new System.Drawing.Point(40, 127);
            this.maskedFechaInicio.Mask = "00/00/0000";
            this.maskedFechaInicio.Name = "maskedFechaInicio";
            this.maskedFechaInicio.Size = new System.Drawing.Size(159, 38);
            this.maskedFechaInicio.TabIndex = 34;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(480, 125);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 45);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(751, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 29);
            this.label10.TabIndex = 60;
            this.label10.Text = "Descripcion:";
            // 
            // lblDescripcionEncuesta
            // 
            this.lblDescripcionEncuesta.AutoSize = true;
            this.lblDescripcionEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionEncuesta.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionEncuesta.Location = new System.Drawing.Point(905, 390);
            this.lblDescripcionEncuesta.Name = "lblDescripcionEncuesta";
            this.lblDescripcionEncuesta.Size = new System.Drawing.Size(69, 25);
            this.lblDescripcionEncuesta.TabIndex = 59;
            this.lblDescripcionEncuesta.Text = "sweee";
            this.lblDescripcionEncuesta.Visible = false;
            // 
            // grdRespuestasPosibles
            // 
            this.grdRespuestasPosibles.AllowUserToAddRows = false;
            this.grdRespuestasPosibles.AllowUserToDeleteRows = false;
            this.grdRespuestasPosibles.BackgroundColor = System.Drawing.Color.White;
            this.grdRespuestasPosibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRespuestasPosibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pregunta});
            this.grdRespuestasPosibles.Location = new System.Drawing.Point(626, 445);
            this.grdRespuestasPosibles.Name = "grdRespuestasPosibles";
            this.grdRespuestasPosibles.ReadOnly = true;
            this.grdRespuestasPosibles.RowHeadersVisible = false;
            this.grdRespuestasPosibles.RowHeadersWidth = 51;
            this.grdRespuestasPosibles.RowTemplate.Height = 24;
            this.grdRespuestasPosibles.Size = new System.Drawing.Size(315, 136);
            this.grdRespuestasPosibles.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(890, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 29);
            this.label11.TabIndex = 62;
            this.label11.Text = "Datos del cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(890, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 29);
            this.label12.TabIndex = 63;
            this.label12.Text = "Datos de la llamada:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(613, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 512);
            this.panel1.TabIndex = 64;
            // 
            // DescripcionOperadorColumn
            // 
            this.DescripcionOperadorColumn.HeaderText = "Descripcion Operador";
            this.DescripcionOperadorColumn.MinimumWidth = 6;
            this.DescripcionOperadorColumn.Name = "DescripcionOperadorColumn";
            this.DescripcionOperadorColumn.ReadOnly = true;
            // 
            // DuracionColumn
            // 
            this.DuracionColumn.HeaderText = "Duracion";
            this.DuracionColumn.MinimumWidth = 6;
            this.DuracionColumn.Name = "DuracionColumn";
            this.DuracionColumn.ReadOnly = true;
            // 
            // ObservacionAuditorColum
            // 
            this.ObservacionAuditorColum.HeaderText = "Observacion Auditor";
            this.ObservacionAuditorColum.MinimumWidth = 6;
            this.ObservacionAuditorColum.Name = "ObservacionAuditorColum";
            this.ObservacionAuditorColum.ReadOnly = true;
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.MinimumWidth = 6;
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            // 
            // DescripcionRespuesta
            // 
            this.DescripcionRespuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionRespuesta.HeaderText = "Descripcion";
            this.DescripcionRespuesta.MinimumWidth = 6;
            this.DescripcionRespuesta.Name = "DescripcionRespuesta";
            this.DescripcionRespuesta.ReadOnly = true;
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1292, 664);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grdRespuestasPosibles);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDescripcionEncuesta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.grdDescripcionRespuestas);
            this.Controls.Add(this.tomarOpcionCsv);
            this.Controls.Add(this.tomarOpcionImprimir);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNroCelular);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdLlamadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedFechaFin);
            this.Controls.Add(this.maskedFechaInicio);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaConsultarEncuesta";
            this.Text = "PantallaConsultarEncuesta";
            this.Load += new System.EventHandler(this.PantallaConsultarEncuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDescripcionRespuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRespuestasPosibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDescripcionRespuestas;
        private System.Windows.Forms.Button tomarOpcionCsv;
        private System.Windows.Forms.Button tomarOpcionImprimir;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNroCelular;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdLlamadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedFechaFin;
        private System.Windows.Forms.MaskedTextBox maskedFechaInicio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDescripcionEncuesta;
        private System.Windows.Forms.DataGridView grdRespuestasPosibles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionOperadorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObservacionAuditorColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
    }
}