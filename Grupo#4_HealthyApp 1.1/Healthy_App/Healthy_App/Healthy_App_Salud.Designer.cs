using System;

namespace Healthy_App
{
    partial class Healthy_App_Salud
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Healthy_App_Salud));
            this.btnInicioSalud = new System.Windows.Forms.Button();
            this.btnSaludsalud = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnIngresarSalud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.healthy_AppDataSet1 = new Healthy_App.Healthy_AppDataSet1();
            this.healthy_AppDataSet = new Healthy_App.Healthy_AppDataSet();
            this.tableAdapterManager = new Healthy_App.Healthy_AppDataSetTableAdapters.TableAdapterManager();
            this.healthy_AppDataSet2 = new Healthy_App.Healthy_AppDataSet2();
            this.saludTableAdapter = new Healthy_App.Healthy_AppDataSet2TableAdapters.saludTableAdapter();
            this.dtgDataSalud = new System.Windows.Forms.DataGridView();
            this.iDUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDataSaludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthy_AppDataSet3 = new Healthy_App.Healthy_AppDataSet3();
            this.sp_DataSaludTableAdapter = new Healthy_App.Healthy_AppDataSet3TableAdapters.sp_DataSaludTableAdapter();
            this.btnEliminarDatos = new System.Windows.Forms.Button();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnIMC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataSalud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSaludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicioSalud
            // 
            this.btnInicioSalud.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSalud.Location = new System.Drawing.Point(225, 6);
            this.btnInicioSalud.Name = "btnInicioSalud";
            this.btnInicioSalud.Size = new System.Drawing.Size(108, 31);
            this.btnInicioSalud.TabIndex = 1;
            this.btnInicioSalud.Text = "INICIO";
            this.btnInicioSalud.UseVisualStyleBackColor = true;
            this.btnInicioSalud.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSaludsalud
            // 
            this.btnSaludsalud.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludsalud.Location = new System.Drawing.Point(373, 6);
            this.btnSaludsalud.Name = "btnSaludsalud";
            this.btnSaludsalud.Size = new System.Drawing.Size(108, 31);
            this.btnSaludsalud.TabIndex = 3;
            this.btnSaludsalud.Text = "SALUD";
            this.btnSaludsalud.UseVisualStyleBackColor = true;
            this.btnSaludsalud.Click += new System.EventHandler(this.btnSaludsalud_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.Location = new System.Drawing.Point(697, 6);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(64, 31);
            this.btn_CerrarSesion.TabIndex = 5;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(21, 112);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(206, 24);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Registrar Peso (KG): ";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(240, 110);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(121, 29);
            this.txtPeso.TabIndex = 7;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(42, 171);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(75, 24);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "Fecha:";
            // 
            // btnIngresarSalud
            // 
            this.btnIngresarSalud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresarSalud.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarSalud.FlatAppearance.BorderSize = 0;
            this.btnIngresarSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarSalud.Location = new System.Drawing.Point(140, 205);
            this.btnIngresarSalud.Name = "btnIngresarSalud";
            this.btnIngresarSalud.Size = new System.Drawing.Size(179, 48);
            this.btnIngresarSalud.TabIndex = 10;
            this.btnIngresarSalud.Text = "Ingresar";
            this.btnIngresarSalud.UseVisualStyleBackColor = false;
            this.btnIngresarSalud.Click += new System.EventHandler(this.btnIngresarSalud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(140, 247);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(179, 40);
            this.btnRefrescar.TabIndex = 14;
            this.btnRefrescar.Text = "Recargar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // healthy_AppDataSet1
            // 
            this.healthy_AppDataSet1.DataSetName = "Healthy_AppDataSet1";
            this.healthy_AppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // healthy_AppDataSet
            // 
            this.healthy_AppDataSet.DataSetName = "Healthy_AppDataSet";
            this.healthy_AppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.create_accountTableAdapter = null;
            this.tableAdapterManager.login_appTableAdapter = null;
            this.tableAdapterManager.saludTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Healthy_App.Healthy_AppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // healthy_AppDataSet2
            // 
            this.healthy_AppDataSet2.DataSetName = "Healthy_AppDataSet2";
            this.healthy_AppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saludTableAdapter
            // 
            this.saludTableAdapter.ClearBeforeFill = true;
            // 
            // dtgDataSalud
            // 
            this.dtgDataSalud.AllowUserToAddRows = false;
            this.dtgDataSalud.AllowUserToDeleteRows = false;
            this.dtgDataSalud.AutoGenerateColumns = false;
            this.dtgDataSalud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDataSalud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsuarioDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dtgDataSalud.DataSource = this.spDataSaludBindingSource;
            this.dtgDataSalud.Location = new System.Drawing.Point(415, 62);
            this.dtgDataSalud.Name = "dtgDataSalud";
            this.dtgDataSalud.ReadOnly = true;
            this.dtgDataSalud.RowHeadersWidth = 62;
            this.dtgDataSalud.Size = new System.Drawing.Size(330, 391);
            this.dtgDataSalud.TabIndex = 15;
            // 
            // iDUsuarioDataGridViewTextBoxColumn
            // 
            this.iDUsuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.iDUsuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDUsuarioDataGridViewTextBoxColumn.Name = "iDUsuarioDataGridViewTextBoxColumn";
            this.iDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUsuarioDataGridViewTextBoxColumn.Width = 68;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "peso";
            this.pesoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso (Kg)";
            this.pesoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn.Width = 78;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 50F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 67;
            // 
            // spDataSaludBindingSource
            // 
            this.spDataSaludBindingSource.DataMember = "sp_DataSalud";
            this.spDataSaludBindingSource.DataSource = this.healthy_AppDataSet3;
            // 
            // healthy_AppDataSet3
            // 
            this.healthy_AppDataSet3.DataSetName = "Healthy_AppDataSet3";
            this.healthy_AppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_DataSaludTableAdapter
            // 
            this.sp_DataSaludTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarDatos
            // 
            this.btnEliminarDatos.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDatos.Location = new System.Drawing.Point(13, 410);
            this.btnEliminarDatos.Name = "btnEliminarDatos";
            this.btnEliminarDatos.Size = new System.Drawing.Size(167, 34);
            this.btnEliminarDatos.TabIndex = 16;
            this.btnEliminarDatos.Text = "Eliminar Datos";
            this.btnEliminarDatos.UseVisualStyleBackColor = true;
            this.btnEliminarDatos.Click += new System.EventHandler(this.btnEliminarDatos_Click);
            // 
            // dtmFecha
            // 
            this.dtmFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtmFecha.CalendarFont = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFecha.Location = new System.Drawing.Point(165, 173);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(196, 20);
            this.dtmFecha.TabIndex = 17;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBienvenida.Location = new System.Drawing.Point(-4, -2);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(136, 26);
            this.lblBienvenida.TabIndex = 18;
            this.lblBienvenida.Text = "BIENVENIDO";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(140, 282);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(179, 49);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnIMC
            // 
            this.btnIMC.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.Location = new System.Drawing.Point(515, 6);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(108, 31);
            this.btnIMC.TabIndex = 20;
            this.btnIMC.Text = "IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // Healthy_App_Salud
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Healthy_App.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 486);
            this.ControlBox = false;
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.btnEliminarDatos);
            this.Controls.Add(this.dtgDataSalud);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarSalud);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btnSaludsalud);
            this.Controls.Add(this.btnInicioSalud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Healthy_App_Salud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALUD";
            this.Load += new System.EventHandler(this.Healthy_App_Salud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataSalud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDataSaludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthy_AppDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSaludsalud_Click(object sender, EventArgs e)
        {
            Healthy_App_Salud salud = new Healthy_App_Salud();
            salud.Show();
        }

        #endregion

        private System.Windows.Forms.Button btnInicioSalud;
        private System.Windows.Forms.Button btnSaludsalud;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnIngresarSalud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefrescar;
        private Healthy_AppDataSet healthy_AppDataSet;
        private Healthy_AppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Healthy_AppDataSet1 healthy_AppDataSet1;
        private Healthy_AppDataSet2 healthy_AppDataSet2;
        private Healthy_AppDataSet2TableAdapters.saludTableAdapter saludTableAdapter;
        private System.Windows.Forms.DataGridView dtgDataSalud;
        private System.Windows.Forms.BindingSource spDataSaludBindingSource;
        private Healthy_AppDataSet3 healthy_AppDataSet3;
        private Healthy_AppDataSet3TableAdapters.sp_DataSaludTableAdapter sp_DataSaludTableAdapter;
        private System.Windows.Forms.Button btnEliminarDatos;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnIMC;
    }
}