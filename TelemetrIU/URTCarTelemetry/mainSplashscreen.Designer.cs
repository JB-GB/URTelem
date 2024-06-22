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
            this.tbxDBUser = new System.Windows.Forms.TextBox();
            this.tbxDBPass = new System.Windows.Forms.TextBox();
            this.chbxShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 160);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(278, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxSerialPorts
            // 
            this.cbxSerialPorts.FormattingEnabled = true;
            this.cbxSerialPorts.Location = new System.Drawing.Point(89, 50);
            this.cbxSerialPorts.Name = "cbxSerialPorts";
            this.cbxSerialPorts.Size = new System.Drawing.Size(125, 21);
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
            this.btnUpdateSerialPorts.Location = new System.Drawing.Point(220, 50);
            this.btnUpdateSerialPorts.Name = "btnUpdateSerialPorts";
            this.btnUpdateSerialPorts.Size = new System.Drawing.Size(70, 21);
            this.btnUpdateSerialPorts.TabIndex = 4;
            this.btnUpdateSerialPorts.Text = "Actualizar";
            this.btnUpdateSerialPorts.UseVisualStyleBackColor = true;
            this.btnUpdateSerialPorts.Click += new System.EventHandler(this.btnUpdateSerialPorts_Click);
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
            this.btnStartDB.Location = new System.Drawing.Point(246, 106);
            this.btnStartDB.Name = "btnStartDB";
            this.btnStartDB.Size = new System.Drawing.Size(40, 23);
            this.btnStartDB.TabIndex = 6;
            this.btnStartDB.Text = "DB";
            this.btnStartDB.UseVisualStyleBackColor = true;
            this.btnStartDB.Click += new System.EventHandler(this.btnStartDB_Click);
            // 
            // tbxDBUser
            // 
            this.tbxDBUser.Location = new System.Drawing.Point(12, 108);
            this.tbxDBUser.Name = "tbxDBUser";
            this.tbxDBUser.Size = new System.Drawing.Size(228, 20);
            this.tbxDBUser.TabIndex = 7;
            this.tbxDBUser.Text = "Usuario";
            // 
            // tbxDBPass
            // 
            this.tbxDBPass.Location = new System.Drawing.Point(12, 134);
            this.tbxDBPass.Name = "tbxDBPass";
            this.tbxDBPass.Size = new System.Drawing.Size(253, 20);
            this.tbxDBPass.TabIndex = 8;
            this.tbxDBPass.Text = "Contrasena";
            this.tbxDBPass.UseSystemPasswordChar = true;
            // 
            // chbxShowPass
            // 
            this.chbxShowPass.AutoSize = true;
            this.chbxShowPass.Location = new System.Drawing.Point(271, 137);
            this.chbxShowPass.Name = "chbxShowPass";
            this.chbxShowPass.Size = new System.Drawing.Size(15, 14);
            this.chbxShowPass.TabIndex = 10;
            this.chbxShowPass.UseVisualStyleBackColor = true;
            this.chbxShowPass.CheckedChanged += new System.EventHandler(this.chbxShowPass_CheckedChanged);
            // 
            // mainSplashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 191);
            this.Controls.Add(this.chbxShowPass);
            this.Controls.Add(this.tbxDBPass);
            this.Controls.Add(this.tbxDBUser);
            this.Controls.Add(this.btnStartDB);
            this.Controls.Add(this.lblIndDB);
            this.Controls.Add(this.btnUpdateSerialPorts);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblIndSerial);
            this.Controls.Add(this.cbxSerialPorts);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox tbxDBUser;
        private System.Windows.Forms.TextBox tbxDBPass;
        private System.Windows.Forms.CheckBox chbxShowPass;
    }
}

