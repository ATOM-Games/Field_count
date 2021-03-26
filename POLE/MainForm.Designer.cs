namespace POLE
{
    partial class MAINform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAINform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pravka = new System.Windows.Forms.ToolStripMenuItem();
            this.Proverit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cleane = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Pravka});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(195, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPoleToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(48, 20);
            this.File.Text = "Файл";
            // 
            // NewPoleToolStripMenuItem
            // 
            this.NewPoleToolStripMenuItem.Name = "NewPoleToolStripMenuItem";
            this.NewPoleToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.NewPoleToolStripMenuItem.Text = "Новое поле";
            this.NewPoleToolStripMenuItem.Click += new System.EventHandler(this.NewPole_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Pravka
            // 
            this.Pravka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Proverit,
            this.Cleane});
            this.Pravka.Enabled = false;
            this.Pravka.Name = "Pravka";
            this.Pravka.Size = new System.Drawing.Size(59, 20);
            this.Pravka.Text = "Правка";
            // 
            // Proverit
            // 
            this.Proverit.Name = "Proverit";
            this.Proverit.Size = new System.Drawing.Size(134, 22);
            this.Proverit.Text = "Проверить";
            this.Proverit.Click += new System.EventHandler(this.Proverit_Click);
            // 
            // Cleane
            // 
            this.Cleane.Name = "Cleane";
            this.Cleane.Size = new System.Drawing.Size(134, 22);
            this.Cleane.Text = "Очистить";
            this.Cleane.Click += new System.EventHandler(this.Cleane_Click);
            // 
            // MAINform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(195, 199);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MAINform";
            this.Text = "Програмулька";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void GetVoidButt() {
            this.BUT = new System.Windows.Forms.Button[YY, XX];
            for (YYYY = 0; YYYY < YY; YYYY++)
            {
                for (XXXX = 0; XXXX < XX; XXXX++)
                {
                    this.BUT[YYYY, XXXX] = new System.Windows.Forms.Button();
                    this.Controls.Add(this.BUT[YYYY, XXXX]);
                    this.BUT[YYYY, XXXX].Location = new System.Drawing.Point(10 + 20 * XXXX, 30 + 20 * YYYY);
                    this.BUT[YYYY, XXXX].Name = "BUT";
                    this.BUT[YYYY, XXXX].Size = new System.Drawing.Size(20, 20);
                    this.BUT[YYYY, XXXX].TabIndex = 0;
                    this.BUT[YYYY, XXXX].Text = "";
                    this.BUT[YYYY, XXXX].BackColor = System.Drawing.Color.White;
                    this.BUT[YYYY, XXXX].MouseClick += new System.Windows.Forms.MouseEventHandler(this.PoleClick);
                }
            }
        }



        #endregion

        private System.Windows.Forms.Button[,] BUT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem NewPoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Pravka;
        private System.Windows.Forms.ToolStripMenuItem Proverit;
        private System.Windows.Forms.ToolStripMenuItem Cleane;
    }
}

