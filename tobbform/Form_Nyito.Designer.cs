
namespace tobbform
{
    partial class Form_Nyito
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
            this.listBox_gyumolcsok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanulókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módositásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_gyumolcsok
            // 
            this.listBox_gyumolcsok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_gyumolcsok.FormattingEnabled = true;
            this.listBox_gyumolcsok.ItemHeight = 20;
            this.listBox_gyumolcsok.Location = new System.Drawing.Point(22, 88);
            this.listBox_gyumolcsok.Name = "listBox_gyumolcsok";
            this.listBox_gyumolcsok.Size = new System.Drawing.Size(760, 324);
            this.listBox_gyumolcsok.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(246, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kivalasztott gyümölcs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanulókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanulókToolStripMenuItem
            // 
            this.tanulókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módositásToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.tanulókToolStripMenuItem.Name = "tanulókToolStripMenuItem";
            this.tanulókToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.tanulókToolStripMenuItem.Text = "Gyümölcsök";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módositásToolStripMenuItem
            // 
            this.módositásToolStripMenuItem.Name = "módositásToolStripMenuItem";
            this.módositásToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.módositásToolStripMenuItem.Text = "Módositás";
            this.módositásToolStripMenuItem.Click += new System.EventHandler(this.módositásToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 424);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBox_gyumolcsok);
            this.Controls.Add(this.label1);
            this.Name = "Form_Nyito";
            this.Text = "Form_Nyito";
            this.Load += new System.EventHandler(this.Form_Nyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_gyumolcsok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanulókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módositásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
    }
}

