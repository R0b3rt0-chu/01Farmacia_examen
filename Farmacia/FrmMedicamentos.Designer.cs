namespace Farmacia
{
    partial class FrmMedicamentos
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
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnNuevoMedicamento = new System.Windows.Forms.Button();
            this.btnEliminarMedicamento = new System.Windows.Forms.Button();
            this.btnCancelarMedicamento = new System.Windows.Forms.Button();
            this.btnEditarMedicamento = new System.Windows.Forms.Button();
            this.btnGuardarMedicamento = new System.Windows.Forms.Button();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.PanelSuperior.SuspendLayout();
            this.PanelContenido.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelSuperior.Controls.Add(this.lblTitulo);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(984, 200);
            this.PanelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Medicamentos";
            // 
            // PanelContenido
            // 
            this.PanelContenido.AutoScroll = true;
            this.PanelContenido.BackColor = System.Drawing.Color.White;
            this.PanelContenido.Controls.Add(this.PanelLateral);
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(0, 200);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(984, 411);
            this.PanelContenido.TabIndex = 1;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.LightGray;
            this.PanelLateral.Controls.Add(this.btnActualizarStock);
            this.PanelLateral.Controls.Add(this.btnNuevoMedicamento);
            this.PanelLateral.Controls.Add(this.btnGuardarMedicamento);
            this.PanelLateral.Controls.Add(this.btnEditarMedicamento);
            this.PanelLateral.Controls.Add(this.btnCancelarMedicamento);
            this.PanelLateral.Controls.Add(this.btnEliminarMedicamento);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(250, 411);
            this.PanelLateral.TabIndex = 0;
            // 
            // btnNuevoMedicamento
            // 
            this.btnNuevoMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMedicamento.Location = new System.Drawing.Point(0, 6);
            this.btnNuevoMedicamento.Name = "btnNuevoMedicamento";
            this.btnNuevoMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnNuevoMedicamento.TabIndex = 0;
            this.btnNuevoMedicamento.Text = "Nuevo";
            this.btnNuevoMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(0, 179);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnEliminarMedicamento.TabIndex = 1;
            this.btnEliminarMedicamento.Text = "Eliminar";
            this.btnEliminarMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMedicamento
            // 
            this.btnCancelarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMedicamento.Location = new System.Drawing.Point(0, 234);
            this.btnCancelarMedicamento.Name = "btnCancelarMedicamento";
            this.btnCancelarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnCancelarMedicamento.TabIndex = 2;
            this.btnCancelarMedicamento.Text = "Cancelar";
            this.btnCancelarMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnEditarMedicamento
            // 
            this.btnEditarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMedicamento.Location = new System.Drawing.Point(0, 123);
            this.btnEditarMedicamento.Name = "btnEditarMedicamento";
            this.btnEditarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnEditarMedicamento.TabIndex = 3;
            this.btnEditarMedicamento.Text = "Editar";
            this.btnEditarMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMedicamento
            // 
            this.btnGuardarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedicamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMedicamento.Location = new System.Drawing.Point(0, 66);
            this.btnGuardarMedicamento.Name = "btnGuardarMedicamento";
            this.btnGuardarMedicamento.Size = new System.Drawing.Size(180, 40);
            this.btnGuardarMedicamento.TabIndex = 4;
            this.btnGuardarMedicamento.Text = "Guardar";
            this.btnGuardarMedicamento.UseVisualStyleBackColor = true;
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarStock.Location = new System.Drawing.Point(0, 289);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(180, 40);
            this.btnActualizarStock.TabIndex = 5;
            this.btnActualizarStock.Text = "Actualizar Stock";
            this.btnActualizarStock.UseVisualStyleBackColor = true;
            // 
            // FrmMedicamentos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PanelSuperior);
            this.Name = "FrmMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMedicamentos";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelContenido.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button btnNuevoMedicamento;
        private System.Windows.Forms.Button btnGuardarMedicamento;
        private System.Windows.Forms.Button btnEditarMedicamento;
        private System.Windows.Forms.Button btnCancelarMedicamento;
        private System.Windows.Forms.Button btnEliminarMedicamento;
        private System.Windows.Forms.Button btnActualizarStock;
    }
}