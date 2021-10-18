namespace WindowsFormsApp1
{
    partial class NOCHE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOCHE));
            this.bt_apagar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.cb_tiempo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_apagar
            // 
            this.bt_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_apagar.ForeColor = System.Drawing.Color.White;
            this.bt_apagar.Location = new System.Drawing.Point(215, 55);
            this.bt_apagar.Name = "bt_apagar";
            this.bt_apagar.Size = new System.Drawing.Size(121, 35);
            this.bt_apagar.TabIndex = 0;
            this.bt_apagar.Text = "Apagar";
            this.bt_apagar.UseVisualStyleBackColor = false;
            this.bt_apagar.Click += new System.EventHandler(this.bt_apagar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(215, 96);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(121, 35);
            this.bt_cancelar.TabIndex = 1;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // cb_tiempo
            // 
            this.cb_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tiempo.FormattingEnabled = true;
            this.cb_tiempo.Location = new System.Drawing.Point(59, 60);
            this.cb_tiempo.Name = "cb_tiempo";
            this.cb_tiempo.Size = new System.Drawing.Size(150, 28);
            this.cb_tiempo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutos:";
            // 
            // lb_tiempo
            // 
            this.lb_tiempo.AutoSize = true;
            this.lb_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_tiempo.Location = new System.Drawing.Point(182, 134);
            this.lb_tiempo.Name = "lb_tiempo";
            this.lb_tiempo.Size = new System.Drawing.Size(66, 24);
            this.lb_tiempo.TabIndex = 4;
            this.lb_tiempo.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(130, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "kevinlopez00001@gmail.com";
            // 
            // NOCHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(449, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tiempo);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_apagar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NOCHE";
            this.Text = "NOCHE";
            this.Load += new System.EventHandler(this.NOCHE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_apagar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.ComboBox cb_tiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

