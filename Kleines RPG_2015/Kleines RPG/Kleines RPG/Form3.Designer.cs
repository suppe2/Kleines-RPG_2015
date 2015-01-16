namespace RPG
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btn_ja = new System.Windows.Forms.Button();
            this.btn_nein = new System.Windows.Forms.Button();
            this.tbx_Frage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ja
            // 
            this.btn_ja.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ja.Location = new System.Drawing.Point(36, 114);
            this.btn_ja.Name = "btn_ja";
            this.btn_ja.Size = new System.Drawing.Size(79, 41);
            this.btn_ja.TabIndex = 0;
            this.btn_ja.Text = "JA";
            this.btn_ja.UseCompatibleTextRendering = true;
            this.btn_ja.UseVisualStyleBackColor = true;
            this.btn_ja.Visible = false;
            this.btn_ja.Click += new System.EventHandler(this.btn_ja_Click);
            // 
            // btn_nein
            // 
            this.btn_nein.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nein.Location = new System.Drawing.Point(160, 114);
            this.btn_nein.Name = "btn_nein";
            this.btn_nein.Size = new System.Drawing.Size(79, 41);
            this.btn_nein.TabIndex = 1;
            this.btn_nein.Text = "NEIN";
            this.btn_nein.UseVisualStyleBackColor = true;
            this.btn_nein.Visible = false;
            this.btn_nein.Click += new System.EventHandler(this.btn_nein_Click);
            // 
            // tbx_Frage
            // 
            this.tbx_Frage.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbx_Frage.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Frage.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbx_Frage.Location = new System.Drawing.Point(36, 25);
            this.tbx_Frage.Multiline = true;
            this.tbx_Frage.Name = "tbx_Frage";
            this.tbx_Frage.ReadOnly = true;
            this.tbx_Frage.Size = new System.Drawing.Size(219, 53);
            this.tbx_Frage.TabIndex = 2;
            this.tbx_Frage.Text = "Neustart?";
            this.tbx_Frage.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RPG.Properties.Resources.dark_souls_you_died;
            this.ClientSize = new System.Drawing.Size(300, 241);
            this.Controls.Add(this.tbx_Frage);
            this.Controls.Add(this.btn_nein);
            this.Controls.Add(this.btn_ja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tot";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ja;
        private System.Windows.Forms.Button btn_nein;
        private System.Windows.Forms.TextBox tbx_Frage;
    }
}