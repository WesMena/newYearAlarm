namespace ricardoNewYearAlarm
{
    partial class NewYearAlarm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.starterLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 133);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current:";
            // 
            // currentLbl
            // 
            this.currentLbl.AutoSize = true;
            this.currentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLbl.Location = new System.Drawing.Point(115, 51);
            this.currentLbl.Name = "currentLbl";
            this.currentLbl.Size = new System.Drawing.Size(57, 20);
            this.currentLbl.TabIndex = 2;
            this.currentLbl.Text = "label2";
            this.currentLbl.Click += new System.EventHandler(this.currentLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starter:";
            // 
            // starterLbl
            // 
            this.starterLbl.AutoSize = true;
            this.starterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starterLbl.Location = new System.Drawing.Point(369, 51);
            this.starterLbl.Name = "starterLbl";
            this.starterLbl.Size = new System.Drawing.Size(57, 20);
            this.starterLbl.TabIndex = 4;
            this.starterLbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds since start:";
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLbl.Location = new System.Drawing.Point(280, 107);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(57, 20);
            this.secondsLbl.TabIndex = 6;
            this.secondsLbl.Text = "label2";
            // 
            // NewYearAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 305);
            this.Controls.Add(this.secondsLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.starterLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "NewYearAlarm";
            this.Text = "New Year Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label starterLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label secondsLbl;
    }
}

