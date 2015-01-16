namespace RPG
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.prg_Leben = new System.Windows.Forms.ProgressBar();
            this.Goblin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prg_Leben
            // 
            this.prg_Leben.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prg_Leben.Location = new System.Drawing.Point(447, 518);
            this.prg_Leben.Name = "prg_Leben";
            this.prg_Leben.Size = new System.Drawing.Size(100, 23);
            this.prg_Leben.TabIndex = 1;
            // 
            // Goblin
            // 
            this.Goblin.BackgroundImage = global::RPG.Properties.Resources.Goblins;
            this.Goblin.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goblin.Location = new System.Drawing.Point(12, 258);
            this.Goblin.Name = "Goblin";
            this.Goblin.Size = new System.Drawing.Size(134, 190);
            this.Goblin.TabIndex = 0;
            this.Goblin.Text = "Goblin";
            this.Goblin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Goblin.UseVisualStyleBackColor = true;
            this.Goblin.Click += new System.EventHandler(this.Clicks);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.prg_Leben);
            this.Controls.Add(this.Goblin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goblins";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Goblin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar prg_Leben;
    }
}