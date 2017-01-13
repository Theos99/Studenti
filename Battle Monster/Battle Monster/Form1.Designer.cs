namespace Battle_Monster
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAttackMns1 = new System.Windows.Forms.Button();
            this.buttonHealMns2 = new System.Windows.Forms.Button();
            this.pictureBoxMonster1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMonster2 = new System.Windows.Forms.PictureBox();
            this.buttonHealMns1 = new System.Windows.Forms.Button();
            this.buttonAttackMns2 = new System.Windows.Forms.Button();
            this.labelNameMonster1 = new System.Windows.Forms.Label();
            this.labelNameMonster2 = new System.Windows.Forms.Label();
            this.labelHpMns1 = new System.Windows.Forms.Label();
            this.labelHpMns2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAttackMns1
            // 
            this.buttonAttackMns1.Location = new System.Drawing.Point(12, 276);
            this.buttonAttackMns1.Name = "buttonAttackMns1";
            this.buttonAttackMns1.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackMns1.TabIndex = 0;
            this.buttonAttackMns1.Text = "Attack";
            this.buttonAttackMns1.UseVisualStyleBackColor = true;
            this.buttonAttackMns1.Click += new System.EventHandler(this.buttonAttackMns1_Click);
            // 
            // buttonHealMns2
            // 
            this.buttonHealMns2.Location = new System.Drawing.Point(288, 276);
            this.buttonHealMns2.Name = "buttonHealMns2";
            this.buttonHealMns2.Size = new System.Drawing.Size(75, 23);
            this.buttonHealMns2.TabIndex = 1;
            this.buttonHealMns2.Text = "Heal";
            this.buttonHealMns2.UseVisualStyleBackColor = true;
            this.buttonHealMns2.Click += new System.EventHandler(this.buttonHealMns2_Click);
            // 
            // pictureBoxMonster1
            // 
            this.pictureBoxMonster1.Location = new System.Drawing.Point(12, 81);
            this.pictureBoxMonster1.Name = "pictureBoxMonster1";
            this.pictureBoxMonster1.Size = new System.Drawing.Size(156, 189);
            this.pictureBoxMonster1.TabIndex = 2;
            this.pictureBoxMonster1.TabStop = false;
            // 
            // pictureBoxMonster2
            // 
            this.pictureBoxMonster2.Location = new System.Drawing.Point(207, 81);
            this.pictureBoxMonster2.Name = "pictureBoxMonster2";
            this.pictureBoxMonster2.Size = new System.Drawing.Size(156, 189);
            this.pictureBoxMonster2.TabIndex = 3;
            this.pictureBoxMonster2.TabStop = false;
            // 
            // buttonHealMns1
            // 
            this.buttonHealMns1.Location = new System.Drawing.Point(93, 276);
            this.buttonHealMns1.Name = "buttonHealMns1";
            this.buttonHealMns1.Size = new System.Drawing.Size(75, 23);
            this.buttonHealMns1.TabIndex = 4;
            this.buttonHealMns1.Text = "Heal";
            this.buttonHealMns1.UseVisualStyleBackColor = true;
            this.buttonHealMns1.Click += new System.EventHandler(this.buttonHealMns1_Click);
            // 
            // buttonAttackMns2
            // 
            this.buttonAttackMns2.Location = new System.Drawing.Point(207, 276);
            this.buttonAttackMns2.Name = "buttonAttackMns2";
            this.buttonAttackMns2.Size = new System.Drawing.Size(75, 23);
            this.buttonAttackMns2.TabIndex = 5;
            this.buttonAttackMns2.Text = "Attack";
            this.buttonAttackMns2.UseVisualStyleBackColor = true;
            this.buttonAttackMns2.Click += new System.EventHandler(this.buttonAttackMns2_Click);
            // 
            // labelNameMonster1
            // 
            this.labelNameMonster1.AutoSize = true;
            this.labelNameMonster1.Location = new System.Drawing.Point(38, 9);
            this.labelNameMonster1.Name = "labelNameMonster1";
            this.labelNameMonster1.Size = new System.Drawing.Size(101, 13);
            this.labelNameMonster1.TabIndex = 6;
            this.labelNameMonster1.Text = "labelNameMonster1";
            // 
            // labelNameMonster2
            // 
            this.labelNameMonster2.AutoSize = true;
            this.labelNameMonster2.Location = new System.Drawing.Point(235, 9);
            this.labelNameMonster2.Name = "labelNameMonster2";
            this.labelNameMonster2.Size = new System.Drawing.Size(101, 13);
            this.labelNameMonster2.TabIndex = 7;
            this.labelNameMonster2.Text = "labelNameMonster2";
            // 
            // labelHpMns1
            // 
            this.labelHpMns1.AutoSize = true;
            this.labelHpMns1.Location = new System.Drawing.Point(12, 257);
            this.labelHpMns1.Name = "labelHpMns1";
            this.labelHpMns1.Size = new System.Drawing.Size(35, 13);
            this.labelHpMns1.TabIndex = 8;
            this.labelHpMns1.Text = "label1";
            // 
            // labelHpMns2
            // 
            this.labelHpMns2.AutoSize = true;
            this.labelHpMns2.Location = new System.Drawing.Point(204, 257);
            this.labelHpMns2.Name = "labelHpMns2";
            this.labelHpMns2.Size = new System.Drawing.Size(35, 13);
            this.labelHpMns2.TabIndex = 9;
            this.labelHpMns2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 367);
            this.Controls.Add(this.labelHpMns2);
            this.Controls.Add(this.labelHpMns1);
            this.Controls.Add(this.labelNameMonster2);
            this.Controls.Add(this.labelNameMonster1);
            this.Controls.Add(this.buttonAttackMns2);
            this.Controls.Add(this.buttonHealMns1);
            this.Controls.Add(this.pictureBoxMonster2);
            this.Controls.Add(this.pictureBoxMonster1);
            this.Controls.Add(this.buttonHealMns2);
            this.Controls.Add(this.buttonAttackMns1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAttackMns1;
        private System.Windows.Forms.Button buttonHealMns2;
        private System.Windows.Forms.PictureBox pictureBoxMonster1;
        private System.Windows.Forms.PictureBox pictureBoxMonster2;
        private System.Windows.Forms.Button buttonHealMns1;
        private System.Windows.Forms.Button buttonAttackMns2;
        private System.Windows.Forms.Label labelNameMonster1;
        private System.Windows.Forms.Label labelNameMonster2;
        private System.Windows.Forms.Label labelHpMns1;
        private System.Windows.Forms.Label labelHpMns2;
    }
}

