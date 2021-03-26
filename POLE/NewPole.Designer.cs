namespace POLE
{
    partial class NewPole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPole));
            this.XXX = new System.Windows.Forms.NumericUpDown();
            this.YYY = new System.Windows.Forms.NumericUpDown();
            this.CreatePole = new System.Windows.Forms.Button();
            this.Otmena = new System.Windows.Forms.Button();
            this.la = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XXX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YYY)).BeginInit();
            this.SuspendLayout();
            // 
            // XXX
            // 
            this.XXX.Location = new System.Drawing.Point(40, 36);
            this.XXX.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.XXX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.XXX.Name = "XXX";
            this.XXX.Size = new System.Drawing.Size(129, 20);
            this.XXX.TabIndex = 0;
            this.XXX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // YYY
            // 
            this.YYY.Location = new System.Drawing.Point(175, 36);
            this.YYY.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.YYY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.YYY.Name = "YYY";
            this.YYY.Size = new System.Drawing.Size(129, 20);
            this.YYY.TabIndex = 1;
            this.YYY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreatePole
            // 
            this.CreatePole.Location = new System.Drawing.Point(40, 63);
            this.CreatePole.Name = "CreatePole";
            this.CreatePole.Size = new System.Drawing.Size(129, 23);
            this.CreatePole.TabIndex = 2;
            this.CreatePole.Text = "Создать";
            this.CreatePole.UseVisualStyleBackColor = true;
            this.CreatePole.Click += new System.EventHandler(this.CreatePole_Click);
            // 
            // Otmena
            // 
            this.Otmena.Location = new System.Drawing.Point(175, 63);
            this.Otmena.Name = "Otmena";
            this.Otmena.Size = new System.Drawing.Size(129, 23);
            this.Otmena.TabIndex = 3;
            this.Otmena.Text = "Отмена";
            this.Otmena.UseVisualStyleBackColor = true;
            this.Otmena.Click += new System.EventHandler(this.Otmena_Click);
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(75, 15);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(186, 13);
            this.la.TabIndex = 4;
            this.la.Text = "Ширина                                  Высота";
            // 
            // NewPole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(351, 107);
            this.Controls.Add(this.la);
            this.Controls.Add(this.Otmena);
            this.Controls.Add(this.CreatePole);
            this.Controls.Add(this.YYY);
            this.Controls.Add(this.XXX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPole";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Новое поле";
            ((System.ComponentModel.ISupportInitialize)(this.XXX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YYY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown XXX;
        private System.Windows.Forms.NumericUpDown YYY;
        private System.Windows.Forms.Button CreatePole;
        private System.Windows.Forms.Button Otmena;
        private System.Windows.Forms.Label la;
    }
}