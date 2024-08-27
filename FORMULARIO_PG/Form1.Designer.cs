namespace FORMULARIO_PG
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.rbtmujer = new System.Windows.Forms.RadioButton();
            this.rbthombre = new System.Windows.Forms.RadioButton();
            this.gbxsexo = new System.Windows.Forms.GroupBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblestatura = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.gbxsexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(72, 66);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Location = new System.Drawing.Point(72, 98);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(58, 13);
            this.lblapellidos.TabIndex = 1;
            this.lblapellidos.Text = "Apellidos";
            // 
            // rbtmujer
            // 
            this.rbtmujer.AutoSize = true;
            this.rbtmujer.Location = new System.Drawing.Point(165, 32);
            this.rbtmujer.Name = "rbtmujer";
            this.rbtmujer.Size = new System.Drawing.Size(56, 17);
            this.rbtmujer.TabIndex = 2;
            this.rbtmujer.TabStop = true;
            this.rbtmujer.Text = "Mujer";
            this.rbtmujer.UseVisualStyleBackColor = true;
            // 
            // rbthombre
            // 
            this.rbthombre.AutoSize = true;
            this.rbthombre.Location = new System.Drawing.Point(21, 32);
            this.rbthombre.Name = "rbthombre";
            this.rbthombre.Size = new System.Drawing.Size(66, 17);
            this.rbthombre.TabIndex = 3;
            this.rbthombre.TabStop = true;
            this.rbthombre.Text = "hombre";
            this.rbthombre.UseVisualStyleBackColor = true;
            // 
            // gbxsexo
            // 
            this.gbxsexo.Controls.Add(this.rbthombre);
            this.gbxsexo.Controls.Add(this.rbtmujer);
            this.gbxsexo.Location = new System.Drawing.Point(75, 244);
            this.gbxsexo.Name = "gbxsexo";
            this.gbxsexo.Size = new System.Drawing.Size(311, 130);
            this.gbxsexo.TabIndex = 4;
            this.gbxsexo.TabStop = false;
            this.gbxsexo.Text = "Genero";
            this.gbxsexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(72, 132);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(114, 13);
            this.lbltelefono.TabIndex = 5;
            this.lbltelefono.Text = "Número Telefonico";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(72, 161);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(36, 13);
            this.lbledad.TabIndex = 6;
            this.lbledad.Text = "Edad";
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Location = new System.Drawing.Point(72, 191);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(54, 13);
            this.lblestatura.TabIndex = 7;
            this.lblestatura.Text = "Estatura";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(75, 380);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(210, 380);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(220, 66);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(220, 98);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(100, 20);
            this.txtapellidos.TabIndex = 11;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(220, 125);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 12;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(220, 161);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 13;
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(220, 191);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 20);
            this.txtestatura.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(556, 603);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.gbxsexo);
            this.Controls.Add(this.lblapellidos);
            this.Controls.Add(this.lblnombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "FORMULARIO DE ESTEBAN";
            this.gbxsexo.ResumeLayout(false);
            this.gbxsexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.RadioButton rbtmujer;
        private System.Windows.Forms.RadioButton rbthombre;
        private System.Windows.Forms.GroupBox gbxsexo;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtestatura;
    }
}

