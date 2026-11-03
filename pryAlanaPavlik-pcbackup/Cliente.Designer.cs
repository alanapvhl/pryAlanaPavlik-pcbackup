namespace pryAlanaPavlik_pcbackup
{
    partial class pcbackup
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblMail = new Label();
            tboNombre = new TextBox();
            tboApellido = new TextBox();
            tboTelefono = new TextBox();
            tboMail = new TextBox();
            gboDatosCliente = new GroupBox();
            gboDatosDelEquipo = new GroupBox();
            cboFalla = new ComboBox();
            rtboDetallesFalla = new RichTextBox();
            txtNumeroDeSerie = new TextBox();
            cboTipo = new ComboBox();
            lblDetalleDeFalla = new Label();
            lblCategoriaDeFalla = new Label();
            lblNumeroDeSerie = new Label();
            lblTipoDeEquipo = new Label();
            gboTicket = new GroupBox();
            lblPresupuesto = new Label();
            numericUpDown1 = new NumericUpDown();
            tboTicket = new TextBox();
            lblNumeroDeTicket = new Label();
            gboDatosCliente.SuspendLayout();
            gboDatosDelEquipo.SuspendLayout();
            gboTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(23, 71);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(23, 116);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(23, 160);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(33, 15);
            lblMail.TabIndex = 3;
            lblMail.Text = "Mail:";
            // 
            // tboNombre
            // 
            tboNombre.Location = new Point(110, 25);
            tboNombre.Name = "tboNombre";
            tboNombre.Size = new Size(100, 23);
            tboNombre.TabIndex = 4;
            // 
            // tboApellido
            // 
            tboApellido.Location = new Point(110, 68);
            tboApellido.Name = "tboApellido";
            tboApellido.Size = new Size(100, 23);
            tboApellido.TabIndex = 5;
            // 
            // tboTelefono
            // 
            tboTelefono.Location = new Point(110, 113);
            tboTelefono.Name = "tboTelefono";
            tboTelefono.Size = new Size(100, 23);
            tboTelefono.TabIndex = 6;
            // 
            // tboMail
            // 
            tboMail.Location = new Point(110, 157);
            tboMail.Name = "tboMail";
            tboMail.Size = new Size(100, 23);
            tboMail.TabIndex = 7;
            // 
            // gboDatosCliente
            // 
            gboDatosCliente.BackColor = SystemColors.Control;
            gboDatosCliente.Controls.Add(tboMail);
            gboDatosCliente.Controls.Add(lblNombre);
            gboDatosCliente.Controls.Add(tboTelefono);
            gboDatosCliente.Controls.Add(lblApellido);
            gboDatosCliente.Controls.Add(tboApellido);
            gboDatosCliente.Controls.Add(lblTelefono);
            gboDatosCliente.Controls.Add(tboNombre);
            gboDatosCliente.Controls.Add(lblMail);
            gboDatosCliente.Location = new Point(12, 12);
            gboDatosCliente.Name = "gboDatosCliente";
            gboDatosCliente.Size = new Size(236, 199);
            gboDatosCliente.TabIndex = 8;
            gboDatosCliente.TabStop = false;
            gboDatosCliente.Text = "DATOS DEL CLIENTE";
            // 
            // gboDatosDelEquipo
            // 
            gboDatosDelEquipo.Controls.Add(cboFalla);
            gboDatosDelEquipo.Controls.Add(rtboDetallesFalla);
            gboDatosDelEquipo.Controls.Add(txtNumeroDeSerie);
            gboDatosDelEquipo.Controls.Add(cboTipo);
            gboDatosDelEquipo.Controls.Add(lblDetalleDeFalla);
            gboDatosDelEquipo.Controls.Add(lblCategoriaDeFalla);
            gboDatosDelEquipo.Controls.Add(lblNumeroDeSerie);
            gboDatosDelEquipo.Controls.Add(lblTipoDeEquipo);
            gboDatosDelEquipo.Location = new Point(12, 234);
            gboDatosDelEquipo.Name = "gboDatosDelEquipo";
            gboDatosDelEquipo.Size = new Size(236, 307);
            gboDatosDelEquipo.TabIndex = 9;
            gboDatosDelEquipo.TabStop = false;
            gboDatosDelEquipo.Text = "DATOS DEL EQUIPO";
            // 
            // cboFalla
            // 
            cboFalla.FormattingEnabled = true;
            cboFalla.Items.AddRange(new object[] { "Falla común", "Problema de diagnostico", "Problema de reparación" });
            cboFalla.Location = new Point(122, 129);
            cboFalla.Name = "cboFalla";
            cboFalla.Size = new Size(100, 23);
            cboFalla.TabIndex = 17;
            // 
            // rtboDetallesFalla
            // 
            rtboDetallesFalla.Location = new Point(23, 211);
            rtboDetallesFalla.Name = "rtboDetallesFalla";
            rtboDetallesFalla.Size = new Size(193, 73);
            rtboDetallesFalla.TabIndex = 16;
            rtboDetallesFalla.Text = "";
            // 
            // txtNumeroDeSerie
            // 
            txtNumeroDeSerie.Location = new Point(122, 84);
            txtNumeroDeSerie.Name = "txtNumeroDeSerie";
            txtNumeroDeSerie.Size = new Size(100, 23);
            txtNumeroDeSerie.TabIndex = 15;
            // 
            // cboTipo
            // 
            cboTipo.AllowDrop = true;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "PC de escritorio", "Notebook" });
            cboTipo.Location = new Point(121, 35);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(101, 23);
            cboTipo.TabIndex = 14;
            // 
            // lblDetalleDeFalla
            // 
            lblDetalleDeFalla.AutoSize = true;
            lblDetalleDeFalla.Location = new Point(18, 177);
            lblDetalleDeFalla.Name = "lblDetalleDeFalla";
            lblDetalleDeFalla.Size = new Size(87, 15);
            lblDetalleDeFalla.TabIndex = 12;
            lblDetalleDeFalla.Text = "Detalle de falla:";
            // 
            // lblCategoriaDeFalla
            // 
            lblCategoriaDeFalla.AutoSize = true;
            lblCategoriaDeFalla.Location = new Point(18, 132);
            lblCategoriaDeFalla.Name = "lblCategoriaDeFalla";
            lblCategoriaDeFalla.Size = new Size(102, 15);
            lblCategoriaDeFalla.TabIndex = 11;
            lblCategoriaDeFalla.Text = "Categoría de falla:";
            // 
            // lblNumeroDeSerie
            // 
            lblNumeroDeSerie.AutoSize = true;
            lblNumeroDeSerie.Location = new Point(18, 87);
            lblNumeroDeSerie.Name = "lblNumeroDeSerie";
            lblNumeroDeSerie.Size = new Size(97, 15);
            lblNumeroDeSerie.TabIndex = 10;
            lblNumeroDeSerie.Text = "Número de serie:";
            // 
            // lblTipoDeEquipo
            // 
            lblTipoDeEquipo.AutoSize = true;
            lblTipoDeEquipo.Location = new Point(18, 38);
            lblTipoDeEquipo.Name = "lblTipoDeEquipo";
            lblTipoDeEquipo.Size = new Size(90, 15);
            lblTipoDeEquipo.TabIndex = 10;
            lblTipoDeEquipo.Text = "Tipo de equipo:";
            // 
            // gboTicket
            // 
            gboTicket.Controls.Add(lblPresupuesto);
            gboTicket.Controls.Add(numericUpDown1);
            gboTicket.Controls.Add(tboTicket);
            gboTicket.Controls.Add(lblNumeroDeTicket);
            gboTicket.Location = new Point(282, 12);
            gboTicket.Name = "gboTicket";
            gboTicket.Size = new Size(236, 324);
            gboTicket.TabIndex = 10;
            gboTicket.TabStop = false;
            gboTicket.Text = "GESTIÓN DEL TIICKET";
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Location = new Point(16, 79);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(75, 15);
            lblPresupuesto.TabIndex = 11;
            lblPresupuesto.Text = "Presupuesto:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.AllowDrop = true;
            numericUpDown1.Location = new Point(124, 77);
            numericUpDown1.Maximum = new decimal(new int[] { 1241513984, 370409800, 542101, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // tboTicket
            // 
            tboTicket.Location = new Point(124, 25);
            tboTicket.Name = "tboTicket";
            tboTicket.Size = new Size(100, 23);
            tboTicket.TabIndex = 1;
            // 
            // lblNumeroDeTicket
            // 
            lblNumeroDeTicket.AutoSize = true;
            lblNumeroDeTicket.Location = new Point(16, 33);
            lblNumeroDeTicket.Name = "lblNumeroDeTicket";
            lblNumeroDeTicket.Size = new Size(102, 15);
            lblNumeroDeTicket.TabIndex = 0;
            lblNumeroDeTicket.Text = "Número de ticket:";
            // 
            // pcbackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 565);
            Controls.Add(gboTicket);
            Controls.Add(gboDatosDelEquipo);
            Controls.Add(gboDatosCliente);
            Name = "pcbackup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC-BACKUP";
            gboDatosCliente.ResumeLayout(false);
            gboDatosCliente.PerformLayout();
            gboDatosDelEquipo.ResumeLayout(false);
            gboDatosDelEquipo.PerformLayout();
            gboTicket.ResumeLayout(false);
            gboTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblMail;
        private TextBox tboNombre;
        private TextBox tboApellido;
        private TextBox tboTelefono;
        private TextBox tboMail;
        private GroupBox gboDatosCliente;
        private GroupBox gboDatosDelEquipo;
        private Label lblNumeroDeSerie;
        private Label lblTipoDeEquipo;
        private ComboBox cboTipo;
        private Label lblDetalleDeFalla;
        private Label lblCategoriaDeFalla;
        private TextBox txtNumeroDeSerie;
        private RichTextBox rtboDetallesFalla;
        private ComboBox cboFalla;
        private GroupBox gboTicket;
        private Label lblPresupuesto;
        private NumericUpDown numericUpDown1;
        private TextBox tboTicket;
        private Label lblNumeroDeTicket;
    }
}