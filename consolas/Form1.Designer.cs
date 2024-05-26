namespace consolas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxCONSOLA = new System.Windows.Forms.TextBox();
            this.textBoxCOMPAÑIA = new System.Windows.Forms.TextBox();
            this.textBoxGENERACION = new System.Windows.Forms.TextBox();
            this.dateTimePickerFECHA = new System.Windows.Forms.DateTimePicker();
            this.buttongrabar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONSOLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENERACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "COMPAÑIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA_LANZAMIENTO";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(231, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxCONSOLA
            // 
            this.textBoxCONSOLA.Location = new System.Drawing.Point(231, 94);
            this.textBoxCONSOLA.Name = "textBoxCONSOLA";
            this.textBoxCONSOLA.Size = new System.Drawing.Size(100, 22);
            this.textBoxCONSOLA.TabIndex = 6;
            // 
            // textBoxCOMPAÑIA
            // 
            this.textBoxCOMPAÑIA.Location = new System.Drawing.Point(231, 136);
            this.textBoxCOMPAÑIA.Name = "textBoxCOMPAÑIA";
            this.textBoxCOMPAÑIA.Size = new System.Drawing.Size(100, 22);
            this.textBoxCOMPAÑIA.TabIndex = 7;
            // 
            // textBoxGENERACION
            // 
            this.textBoxGENERACION.Location = new System.Drawing.Point(231, 227);
            this.textBoxGENERACION.Name = "textBoxGENERACION";
            this.textBoxGENERACION.Size = new System.Drawing.Size(100, 22);
            this.textBoxGENERACION.TabIndex = 8;
            // 
            // dateTimePickerFECHA
            // 
            this.dateTimePickerFECHA.Location = new System.Drawing.Point(202, 180);
            this.dateTimePickerFECHA.Name = "dateTimePickerFECHA";
            this.dateTimePickerFECHA.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerFECHA.TabIndex = 9;
            this.dateTimePickerFECHA.ValueChanged += new System.EventHandler(this.dateTimePickerFECHA_ValueChanged);
            // 
            // buttongrabar
            // 
            this.buttongrabar.Location = new System.Drawing.Point(536, 52);
            this.buttongrabar.Name = "buttongrabar";
            this.buttongrabar.Size = new System.Drawing.Size(136, 45);
            this.buttongrabar.TabIndex = 10;
            this.buttongrabar.Text = "INSERTAR";
            this.buttongrabar.UseVisualStyleBackColor = true;
            this.buttongrabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "BORRAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "ACTUALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "INSERTAR modelo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttongrabar);
            this.Controls.Add(this.dateTimePickerFECHA);
            this.Controls.Add(this.textBoxGENERACION);
            this.Controls.Add(this.textBoxCOMPAÑIA);
            this.Controls.Add(this.textBoxCONSOLA);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxCONSOLA;
        private System.Windows.Forms.TextBox textBoxCOMPAÑIA;
        private System.Windows.Forms.TextBox textBoxGENERACION;
        private System.Windows.Forms.DateTimePicker dateTimePickerFECHA;
        private System.Windows.Forms.Button buttongrabar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

