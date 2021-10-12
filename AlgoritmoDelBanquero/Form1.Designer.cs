namespace AlgoritmoDelBanquero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoProcesos = new System.Windows.Forms.TextBox();
            this.txtNoRecursos = new System.Windows.Forms.TextBox();
            this.btnCrearArray = new System.Windows.Forms.Button();
            this.dgvAsignados = new System.Windows.Forms.DataGridView();
            this.dgvMaximos = new System.Windows.Forms.DataGridView();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaximos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese no. de los procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese no. de los recursos";
            // 
            // txtNoProcesos
            // 
            this.txtNoProcesos.Location = new System.Drawing.Point(325, 35);
            this.txtNoProcesos.Name = "txtNoProcesos";
            this.txtNoProcesos.Size = new System.Drawing.Size(100, 20);
            this.txtNoProcesos.TabIndex = 2;
            // 
            // txtNoRecursos
            // 
            this.txtNoRecursos.Location = new System.Drawing.Point(325, 92);
            this.txtNoRecursos.Name = "txtNoRecursos";
            this.txtNoRecursos.Size = new System.Drawing.Size(100, 20);
            this.txtNoRecursos.TabIndex = 3;
            // 
            // btnCrearArray
            // 
            this.btnCrearArray.Location = new System.Drawing.Point(484, 59);
            this.btnCrearArray.Name = "btnCrearArray";
            this.btnCrearArray.Size = new System.Drawing.Size(75, 23);
            this.btnCrearArray.TabIndex = 4;
            this.btnCrearArray.Text = "Aceptar";
            this.btnCrearArray.UseVisualStyleBackColor = true;
            this.btnCrearArray.Click += new System.EventHandler(this.btnCrearArray_Click);
            // 
            // dgvAsignados
            // 
            this.dgvAsignados.AllowUserToAddRows = false;
            this.dgvAsignados.AllowUserToDeleteRows = false;
            this.dgvAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignados.Location = new System.Drawing.Point(41, 166);
            this.dgvAsignados.Name = "dgvAsignados";
            this.dgvAsignados.Size = new System.Drawing.Size(542, 150);
            this.dgvAsignados.TabIndex = 5;
            // 
            // dgvMaximos
            // 
            this.dgvMaximos.AllowUserToAddRows = false;
            this.dgvMaximos.AllowUserToDeleteRows = false;
            this.dgvMaximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaximos.Location = new System.Drawing.Point(41, 342);
            this.dgvMaximos.Name = "dgvMaximos";
            this.dgvMaximos.Size = new System.Drawing.Size(542, 150);
            this.dgvMaximos.TabIndex = 6;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(608, 265);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 7;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Location = new System.Drawing.Point(41, 523);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.Size = new System.Drawing.Size(542, 150);
            this.dgvDisponibles.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.dgvMaximos);
            this.Controls.Add(this.dgvAsignados);
            this.Controls.Add(this.btnCrearArray);
            this.Controls.Add(this.txtNoRecursos);
            this.Controls.Add(this.txtNoProcesos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaximos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoProcesos;
        private System.Windows.Forms.TextBox txtNoRecursos;
        private System.Windows.Forms.Button btnCrearArray;
        private System.Windows.Forms.DataGridView dgvAsignados;
        private System.Windows.Forms.DataGridView dgvMaximos;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dgvDisponibles;
    }
}

