namespace URTCarTelemetry
{
    partial class mainSplashscreen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxSerialPorts = new System.Windows.Forms.ComboBox();
            this.lblIndSerial = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUpdateSerialPorts = new System.Windows.Forms.Button();
            this.lblIndDB = new System.Windows.Forms.Label();
            this.btnStartDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(187, 192);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // cbxSerialPorts
            // 
            this.cbxSerialPorts.FormattingEnabled = true;
            this.cbxSerialPorts.Location = new System.Drawing.Point(89, 50);
            this.cbxSerialPorts.Name = "cbxSerialPorts";
            this.cbxSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cbxSerialPorts.TabIndex = 1;
            // 
            // lblIndSerial
            // 
            this.lblIndSerial.AutoSize = true;
            this.lblIndSerial.Location = new System.Drawing.Point(12, 53);
            this.lblIndSerial.Name = "lblIndSerial";
            this.lblIndSerial.Size = new System.Drawing.Size(71, 13);
            this.lblIndSerial.TabIndex = 2;
            this.lblIndSerial.Text = "Interfaz Serial";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(203, 26);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Bienvenido!\r\nCarga la configuracion que quieras utilizar";
            // 
            // btnUpdateSerialPorts
            // 
            this.btnUpdateSerialPorts.Location = new System.Drawing.Point(216, 50);
            this.btnUpdateSerialPorts.Name = "btnUpdateSerialPorts";
            this.btnUpdateSerialPorts.Size = new System.Drawing.Size(61, 21);
            this.btnUpdateSerialPorts.TabIndex = 4;
            this.btnUpdateSerialPorts.Text = "Actualizar";
            this.btnUpdateSerialPorts.UseVisualStyleBackColor = true;
            // 
            // lblIndDB
            // 
            this.lblIndDB.AutoSize = true;
            this.lblIndDB.Location = new System.Drawing.Point(13, 84);
            this.lblIndDB.Name = "lblIndDB";
            this.lblIndDB.Size = new System.Drawing.Size(227, 13);
            this.lblIndDB.TabIndex = 5;
            this.lblIndDB.Text = "El estatus de la DB es X. Haz clic para iniciarla";
            // 
            // btnStartDB
            // 
            this.btnStartDB.Location = new System.Drawing.Point(246, 79);
            this.btnStartDB.Name = "btnStartDB";
            this.btnStartDB.Size = new System.Drawing.Size(40, 23);
            this.btnStartDB.TabIndex = 6;
            this.btnStartDB.Text = "Retry";
            this.btnStartDB.UseVisualStyleBackColor = true;
            // 
            // mainSplashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnStartDB);
            this.Controls.Add(this.lblIndDB);
            this.Controls.Add(this.btnUpdateSerialPorts);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblIndSerial);
            this.Controls.Add(this.cbxSerialPorts);
            this.Controls.Add(this.btnStart);
            this.Name = "mainSplashscreen";
            this.Text = "Initializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbxSerialPorts;
        private System.Windows.Forms.Label lblIndSerial;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUpdateSerialPorts;
        private System.Windows.Forms.Label lblIndDB;
        private System.Windows.Forms.Button btnStartDB;
    }
}

