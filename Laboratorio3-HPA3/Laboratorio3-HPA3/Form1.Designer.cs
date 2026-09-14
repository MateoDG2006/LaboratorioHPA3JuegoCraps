namespace Laboratorio3_HPA3
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
            components = new System.ComponentModel.Container();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            lblTitulo = new Label();
            lblID = new Label();
            txtID = new TextBox();
            lblNombres = new Label();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            txtApellidos = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblSalario = new Label();
            txtSalario = new TextBox();
            lblFechaNacimiento = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            dgvdatos = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(864, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 22);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.ToolTipText = "Agregar un nuevo colaborador";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(211, 21);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de Colaboradores";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(20, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 2;
            lblID.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(160, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(220, 23);
            txtID.TabIndex = 1;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(20, 113);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(59, 15);
            lblNombres.TabIndex = 4;
            lblNombres.Text = "Nombres:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(160, 110);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(220, 23);
            txtNombres.TabIndex = 2;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(20, 148);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(59, 15);
            lblApellidos.TabIndex = 6;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(160, 145);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(220, 23);
            txtApellidos.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(20, 183);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(160, 180);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(220, 23);
            txtCorreo.TabIndex = 4;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(20, 218);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(45, 15);
            lblSalario.TabIndex = 10;
            lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(160, 215);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(220, 23);
            txtSalario.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(20, 253);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(106, 15);
            lblFechaNacimiento.TabIndex = 12;
            lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(160, 249);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(220, 23);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // dgvdatos
            // 
            dgvdatos.AllowUserToAddRows = false;
            dgvdatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Location = new Point(20, 290);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.ReadOnly = true;
            dgvdatos.RowHeadersWidth = 25;
            dgvdatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdatos.Size = new Size(824, 210);
            dgvdatos.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 521);
            Controls.Add(dgvdatos);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtNombres);
            Controls.Add(lblNombres);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(lblTitulo);
            Controls.Add(toolStrip1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio 3 - Registro de Colaboradores";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private Label lblTitulo;
        private Label lblID;
        private TextBox txtID;
        private Label lblNombres;
        private TextBox txtNombres;
        private Label lblApellidos;
        private TextBox txtApellidos;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblSalario;
        private TextBox txtSalario;
        private Label lblFechaNacimiento;
        private DateTimePicker dtpFechaNacimiento;
        private DataGridView dgvdatos;
        private ErrorProvider errorProvider1;
    }
}
