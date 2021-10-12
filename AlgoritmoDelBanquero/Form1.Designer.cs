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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaximos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese no. de los procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese no. de los recursos";
            // 
            // txtNoProcesos
            // 
            this.txtNoProcesos.Location = new System.Drawing.Point(709, 44);
            this.txtNoProcesos.Name = "txtNoProcesos";
            this.txtNoProcesos.Size = new System.Drawing.Size(100, 20);
            this.txtNoProcesos.TabIndex = 2;
            // 
            // txtNoRecursos
            // 
            this.txtNoRecursos.Location = new System.Drawing.Point(709, 101);
            this.txtNoRecursos.Name = "txtNoRecursos";
            this.txtNoRecursos.Size = new System.Drawing.Size(100, 20);
            this.txtNoRecursos.TabIndex = 3;
            // 
            // btnCrearArray
            // 
            this.btnCrearArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArray.Location = new System.Drawing.Point(638, 142);
            this.btnCrearArray.Name = "btnCrearArray";
            this.btnCrearArray.Size = new System.Drawing.Size(75, 34);
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
            this.dgvAsignados.Location = new System.Drawing.Point(109, 220);
            this.dgvAsignados.Name = "dgvAsignados";
            this.dgvAsignados.Size = new System.Drawing.Size(542, 150);
            this.dgvAsignados.TabIndex = 5;
            // 
            // dgvMaximos
            // 
            this.dgvMaximos.AllowUserToAddRows = false;
            this.dgvMaximos.AllowUserToDeleteRows = false;
            this.dgvMaximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaximos.Location = new System.Drawing.Point(694, 220);
            this.dgvMaximos.Name = "dgvMaximos";
            this.dgvMaximos.Size = new System.Drawing.Size(542, 150);
            this.dgvMaximos.TabIndex = 6;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(632, 627);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(86, 30);
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
            this.dgvDisponibles.Location = new System.Drawing.Point(405, 442);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.Size = new System.Drawing.Size(542, 150);
            this.dgvDisponibles.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asignados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(941, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maximos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Disponibles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

