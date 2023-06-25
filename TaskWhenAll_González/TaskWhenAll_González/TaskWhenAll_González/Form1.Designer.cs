namespace Concurrencias._3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadingGIF = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCharge = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingGIF
            // 
            this.LoadingGIF.Image = ((System.Drawing.Image)(resources.GetObject("LoadingGIF.Image")));
            this.LoadingGIF.Location = new System.Drawing.Point(34, 136);
            this.LoadingGIF.Name = "LoadingGIF";
            this.LoadingGIF.Size = new System.Drawing.Size(161, 115);
            this.LoadingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingGIF.TabIndex = 14;
            this.LoadingGIF.TabStop = false;
            this.LoadingGIF.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(72, 292);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(78, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCharge
            // 
            this.BtnCharge.Location = new System.Drawing.Point(72, 86);
            this.BtnCharge.Name = "BtnCharge";
            this.BtnCharge.Size = new System.Drawing.Size(78, 23);
            this.BtnCharge.TabIndex = 12;
            this.BtnCharge.Text = "Login";
            this.BtnCharge.UseVisualStyleBackColor = true;
            this.BtnCharge.Click += new System.EventHandler(this.BtnCharge_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(34, 39);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(160, 20);
            this.NameTxt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 340);
            this.ControlBox = false;
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.LoadingGIF);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnCharge);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox LoadingGIF;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnCharge;
        private System.Windows.Forms.TextBox NameTxt;
    }
}

