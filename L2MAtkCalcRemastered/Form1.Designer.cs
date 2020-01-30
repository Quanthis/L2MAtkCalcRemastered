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
            this.ApocalypseCaster = new System.Windows.Forms.Label();
            this.IsApocalypseCasterBlessed = new System.Windows.Forms.CheckBox();
            this.HavingSigil = new System.Windows.Forms.RadioButton();
            this.NotHavingSigil = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ApoRettributer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ApoRettributerResult = new System.Windows.Forms.Label();
            this.ApocalypseRettributer = new System.Windows.Forms.Label();
            this.IsApocalypseRettributerBlessed = new System.Windows.Forms.CheckBox();
            this.SpCaster = new System.Windows.Forms.Button();
            this.IsSpecterCasterBlessed = new System.Windows.Forms.CheckBox();
            this.SpecterCaster = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpectCasterResult = new System.Windows.Forms.Label();
            this.SpRettriButer = new System.Windows.Forms.Button();
            this.IsSpecterRettributerBlessed = new System.Windows.Forms.CheckBox();
            this.SpecterRettributer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpecterRettributerResult = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
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
            this.OwnMAttack.MaxLength = 15;
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
            // ApocalypseCaster
            // 
            this.ApocalypseCaster.AutoSize = true;
            this.ApocalypseCaster.Location = new System.Drawing.Point(100, 81);
            this.ApocalypseCaster.Name = "ApocalypseCaster";
            this.ApocalypseCaster.Size = new System.Drawing.Size(95, 13);
            this.ApocalypseCaster.TabIndex = 4;
            this.ApocalypseCaster.Text = "Apocalypse Caster";
            // 
            // IsApocalypseCasterBlessed
            // 
            this.IsApocalypseCasterBlessed.AutoSize = true;
            this.IsApocalypseCasterBlessed.Location = new System.Drawing.Point(100, 61);
            this.IsApocalypseCasterBlessed.Name = "IsApocalypseCasterBlessed";
            this.IsApocalypseCasterBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsApocalypseCasterBlessed.TabIndex = 5;
            this.IsApocalypseCasterBlessed.Text = "Blessed";
            this.IsApocalypseCasterBlessed.UseVisualStyleBackColor = true;
            this.IsApocalypseCasterBlessed.CheckedChanged += new System.EventHandler(this.IsApoCasterBlessed_CheckedChanged);
            // 
            // HavingSigil
            // 
            this.HavingSigil.Location = new System.Drawing.Point(910, 835);
            this.HavingSigil.Name = "HavingSigil";
            this.HavingSigil.Size = new System.Drawing.Size(100, 20);
            this.HavingSigil.TabIndex = 6;
            this.HavingSigil.Text = "I have a sigil";
            this.HavingSigil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HavingSigil.UseVisualStyleBackColor = true;
            this.HavingSigil.CheckedChanged += new System.EventHandler(this.HavingSigil_CheckedChanged);
            // 
            // NotHavingSigil
            // 
            this.NotHavingSigil.Checked = true;
            this.NotHavingSigil.Location = new System.Drawing.Point(900, 870);
            this.NotHavingSigil.Name = "NotHavingSigil";
            this.NotHavingSigil.Size = new System.Drawing.Size(120, 20);
            this.NotHavingSigil.TabIndex = 7;
            this.NotHavingSigil.TabStop = true;
            this.NotHavingSigil.Text = "I dont\' have a sigil";
            this.NotHavingSigil.UseVisualStyleBackColor = true;
            this.NotHavingSigil.CheckedChanged += new System.EventHandler(this.NotHavingSigil_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Save";
            // 
            // ApoRettributer
            // 
            this.ApoRettributer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ApoRettributer.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.ApoRetri;
            this.ApoRettributer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApoRettributer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApoRettributer.Location = new System.Drawing.Point(250, 96);
            this.ApoRettributer.Name = "ApoRettributer";
            this.ApoRettributer.Size = new System.Drawing.Size(80, 80);
            this.ApoRettributer.TabIndex = 9;
            this.ApoRettributer.UseVisualStyleBackColor = true;
            this.ApoRettributer.Click += new System.EventHandler(this.ApoRettributer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Result: ";
            // 
            // ApoRettributerResult
            // 
            this.ApoRettributerResult.Location = new System.Drawing.Point(250, 200);
            this.ApoRettributerResult.Name = "ApoRettributerResult";
            this.ApoRettributerResult.Size = new System.Drawing.Size(77, 20);
            this.ApoRettributerResult.TabIndex = 11;
            // 
            // ApocalypseRettributer
            // 
            this.ApocalypseRettributer.AutoSize = true;
            this.ApocalypseRettributer.Location = new System.Drawing.Point(250, 81);
            this.ApocalypseRettributer.Name = "ApocalypseRettributer";
            this.ApocalypseRettributer.Size = new System.Drawing.Size(114, 13);
            this.ApocalypseRettributer.TabIndex = 12;
            this.ApocalypseRettributer.Text = "Apocalypse Rettributer";
            // 
            // IsApocalypseRettributerBlessed
            // 
            this.IsApocalypseRettributerBlessed.AutoSize = true;
            this.IsApocalypseRettributerBlessed.Location = new System.Drawing.Point(250, 61);
            this.IsApocalypseRettributerBlessed.Name = "IsApocalypseRettributerBlessed";
            this.IsApocalypseRettributerBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsApocalypseRettributerBlessed.TabIndex = 13;
            this.IsApocalypseRettributerBlessed.Text = "Blessed";
            this.IsApocalypseRettributerBlessed.UseVisualStyleBackColor = true;
            this.IsApocalypseRettributerBlessed.CheckedChanged += new System.EventHandler(this.IsApocalypseRettributerBlessed_CheckedChanged);
            // 
            // SpCaster
            // 
            this.SpCaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpCaster.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.SpecterCaster1;
            this.SpCaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpCaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpCaster.Location = new System.Drawing.Point(400, 100);
            this.SpCaster.Name = "SpCaster";
            this.SpCaster.Size = new System.Drawing.Size(77, 77);
            this.SpCaster.TabIndex = 14;
            this.SpCaster.UseVisualStyleBackColor = true;
            this.SpCaster.Click += new System.EventHandler(this.SpCaster_Click);
            // 
            // IsSpecterCasterBlessed
            // 
            this.IsSpecterCasterBlessed.AutoSize = true;
            this.IsSpecterCasterBlessed.Location = new System.Drawing.Point(400, 61);
            this.IsSpecterCasterBlessed.Name = "IsSpecterCasterBlessed";
            this.IsSpecterCasterBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsSpecterCasterBlessed.TabIndex = 15;
            this.IsSpecterCasterBlessed.Text = "Blessed";
            this.IsSpecterCasterBlessed.UseVisualStyleBackColor = true;
            this.IsSpecterCasterBlessed.CheckedChanged += new System.EventHandler(this.IsSpecterCasterBlessed_CheckedChanged);
            // 
            // SpecterCaster
            // 
            this.SpecterCaster.AutoSize = true;
            this.SpecterCaster.Location = new System.Drawing.Point(400, 81);
            this.SpecterCaster.Name = "SpecterCaster";
            this.SpecterCaster.Size = new System.Drawing.Size(77, 13);
            this.SpecterCaster.TabIndex = 16;
            this.SpecterCaster.Text = "Specter Caster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Result: ";
            // 
            // SpectCasterResult
            // 
            this.SpectCasterResult.Location = new System.Drawing.Point(400, 200);
            this.SpectCasterResult.Name = "SpectCasterResult";
            this.SpectCasterResult.Size = new System.Drawing.Size(77, 20);
            this.SpectCasterResult.TabIndex = 18;
            // 
            // SpRettriButer
            // 
            this.SpRettriButer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SpRettriButer.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.SpecterRetri;
            this.SpRettriButer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpRettriButer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpRettriButer.Location = new System.Drawing.Point(550, 100);
            this.SpRettriButer.Name = "SpRettriButer";
            this.SpRettriButer.Size = new System.Drawing.Size(73, 76);
            this.SpRettriButer.TabIndex = 19;
            this.SpRettriButer.UseVisualStyleBackColor = true;
            this.SpRettriButer.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IsSpecterRettributerBlessed
            // 
            this.IsSpecterRettributerBlessed.AutoSize = true;
            this.IsSpecterRettributerBlessed.Location = new System.Drawing.Point(550, 61);
            this.IsSpecterRettributerBlessed.Name = "IsSpecterRettributerBlessed";
            this.IsSpecterRettributerBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsSpecterRettributerBlessed.TabIndex = 20;
            this.IsSpecterRettributerBlessed.Text = "Blessed";
            this.IsSpecterRettributerBlessed.UseVisualStyleBackColor = true;
            this.IsSpecterRettributerBlessed.CheckedChanged += new System.EventHandler(this.IsSpecterRettributerBlessed_CheckedChanged);
            // 
            // SpecterRettributer
            // 
            this.SpecterRettributer.AutoSize = true;
            this.SpecterRettributer.Location = new System.Drawing.Point(550, 81);
            this.SpecterRettributer.Name = "SpecterRettributer";
            this.SpecterRettributer.Size = new System.Drawing.Size(93, 13);
            this.SpecterRettributer.TabIndex = 21;
            this.SpecterRettributer.Text = "SpecterRettributer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Result: ";
            // 
            // SpecterRettributerResult
            // 
            this.SpecterRettributerResult.Location = new System.Drawing.Point(550, 200);
            this.SpecterRettributerResult.Name = "SpecterRettributerResult";
            this.SpecterRettributerResult.Size = new System.Drawing.Size(77, 20);
            this.SpecterRettributerResult.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.Shot00113;
            this.ClientSize = new System.Drawing.Size(1904, 962);
            this.Controls.Add(this.SpecterRettributerResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpecterRettributer);
            this.Controls.Add(this.IsSpecterRettributerBlessed);
            this.Controls.Add(this.SpRettriButer);
            this.Controls.Add(this.SpectCasterResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecterCaster);
            this.Controls.Add(this.IsSpecterCasterBlessed);
            this.Controls.Add(this.SpCaster);
            this.Controls.Add(this.IsApocalypseRettributerBlessed);
            this.Controls.Add(this.ApocalypseRettributer);
            this.Controls.Add(this.ApoRettributerResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApoRettributer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NotHavingSigil);
            this.Controls.Add(this.HavingSigil);
            this.Controls.Add(this.IsApocalypseCasterBlessed);
            this.Controls.Add(this.ApocalypseCaster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApoCasterResult);
            this.Controls.Add(this.OwnMAttack);
            this.Controls.Add(this.ApoCaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "L2MAtkCalc 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApoCaster;
        private System.Windows.Forms.Label ApoCasterResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApocalypseCaster;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        protected System.Windows.Forms.RadioButton HavingSigil;
        protected System.Windows.Forms.RadioButton NotHavingSigil;
        protected internal System.Windows.Forms.TextBox OwnMAttack;
        private System.Windows.Forms.Button ApoRettributer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ApoRettributerResult;
        private System.Windows.Forms.Label ApocalypseRettributer;
        private System.Windows.Forms.Button SpCaster;
        private System.Windows.Forms.CheckBox IsApocalypseCasterBlessed;
        private System.Windows.Forms.CheckBox IsSpecterCasterBlessed;
        private System.Windows.Forms.Label SpecterCaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SpectCasterResult;
        private System.Windows.Forms.CheckBox IsApocalypseRettributerBlessed;
        private System.Windows.Forms.Button SpRettriButer;
        private System.Windows.Forms.CheckBox IsSpecterRettributerBlessed;
        private System.Windows.Forms.Label SpecterRettributer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SpecterRettributerResult;
    }
}

