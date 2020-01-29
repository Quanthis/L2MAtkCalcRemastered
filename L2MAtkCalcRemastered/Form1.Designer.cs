namespace L2MAtkCalcRemastered
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ApoCaster = new System.Windows.Forms.Button();
            this.OwnMAttack = new System.Windows.Forms.TextBox();
            this.ApoCasterResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsApoCasterBlessed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ApoCaster
            // 
            this.ApoCaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApoCaster.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.ApoCaster;
            this.ApoCaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApoCaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApoCaster.Location = new System.Drawing.Point(100, 100);
            this.ApoCaster.Name = "ApoCaster";
            this.ApoCaster.Size = new System.Drawing.Size(77, 77);
            this.ApoCaster.TabIndex = 0;
            this.ApoCaster.UseVisualStyleBackColor = true;
            this.ApoCaster.Click += new System.EventHandler(this.button1_Click);
            // 
            // OwnMAttack
            // 
            this.OwnMAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OwnMAttack.ForeColor = System.Drawing.Color.Black;
            this.OwnMAttack.Location = new System.Drawing.Point(910, 800);
            this.OwnMAttack.Name = "OwnMAttack";
            this.OwnMAttack.Size = new System.Drawing.Size(100, 20);
            this.OwnMAttack.TabIndex = 1;
            this.OwnMAttack.Text = "0";
            this.OwnMAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApoCasterResult
            // 
            this.ApoCasterResult.Location = new System.Drawing.Point(100, 200);
            this.ApoCasterResult.Name = "ApoCasterResult";
            this.ApoCasterResult.Size = new System.Drawing.Size(77, 20);
            this.ApoCasterResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apocalypse Caster";
            // 
            // IsApoCasterBlessed
            // 
            this.IsApoCasterBlessed.AutoSize = true;
            this.IsApoCasterBlessed.Location = new System.Drawing.Point(100, 61);
            this.IsApoCasterBlessed.Name = "IsApoCasterBlessed";
            this.IsApoCasterBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsApoCasterBlessed.TabIndex = 5;
            this.IsApoCasterBlessed.Text = "Blessed";
            this.IsApoCasterBlessed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.Shot00113;
            this.ClientSize = new System.Drawing.Size(1904, 962);
            this.Controls.Add(this.IsApoCasterBlessed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApoCasterResult);
            this.Controls.Add(this.OwnMAttack);
            this.Controls.Add(this.ApoCaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "L2MAtkCalc 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApoCaster;
        private System.Windows.Forms.TextBox OwnMAttack;
        private System.Windows.Forms.Label ApoCasterResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox IsApoCasterBlessed;
    }
}

