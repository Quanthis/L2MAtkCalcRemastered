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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ApoCaster = new System.Windows.Forms.Button();
            this.OwnMAttack = new System.Windows.Forms.TextBox();
            this.ApocalypseCasterResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApocalypseCaster = new System.Windows.Forms.Label();
            this.IsApocalypseCasterBlessed = new System.Windows.Forms.CheckBox();
            this.HavingSigil = new System.Windows.Forms.RadioButton();
            this.NotHavingSigil = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.ApoRettributer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ApocalypseRettributerResult = new System.Windows.Forms.Label();
            this.ApocalypseRettributer = new System.Windows.Forms.Label();
            this.IsApocalypseRettributerBlessed = new System.Windows.Forms.CheckBox();
            this.SpCaster = new System.Windows.Forms.Button();
            this.IsSpecterCasterBlessed = new System.Windows.Forms.CheckBox();
            this.SpecterCaster = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecterCasterResult = new System.Windows.Forms.Label();
            this.SpRettriButer = new System.Windows.Forms.Button();
            this.IsSpecterRettributerBlessed = new System.Windows.Forms.CheckBox();
            this.SpecterRettributer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SpecterRettributerResult = new System.Windows.Forms.Label();
            this.AmaCaster = new System.Windows.Forms.Button();
            this.AmaranthineCaster = new System.Windows.Forms.Label();
            this.IsAmaranthineCasterBlessed = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmaranthineCasterResult = new System.Windows.Forms.Label();
            this.AmaRettributer = new System.Windows.Forms.Button();
            this.AmaranthineRettributer = new System.Windows.Forms.Label();
            this.IsAmaranthineRettributerBlessed = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmaranthineRettributerResult = new System.Windows.Forms.Label();
            this.WhereToInsertMAttack = new System.Windows.Forms.ToolTip(this.components);
            this.WhereToClickForCalcs = new System.Windows.Forms.ToolTip(this.components);
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
            this.WhereToClickForCalcs.SetToolTip(this.ApoCaster, "Apocalypse Caster");
            this.ApoCaster.UseVisualStyleBackColor = true;
            this.ApoCaster.Click += new System.EventHandler(this.ApoCaster_Click);
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
            this.WhereToInsertMAttack.SetToolTip(this.OwnMAttack, "I need this information to provide you with actual truth");
            // 
            // ApocalypseCasterResult
            // 
            this.ApocalypseCasterResult.Location = new System.Drawing.Point(100, 200);
            this.ApocalypseCasterResult.Name = "ApocalypseCasterResult";
            this.ApocalypseCasterResult.Size = new System.Drawing.Size(77, 20);
            this.ApocalypseCasterResult.TabIndex = 2;
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
            this.Save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(35, 22);
            this.Save.Text = "Save";
            this.Save.ToolTipText = "Saves to HTML File and opens it";
            this.Save.Click += new System.EventHandler(this.Save_Click);
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
            this.WhereToClickForCalcs.SetToolTip(this.ApoRettributer, "Apocalypse Rettributer");
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
            // ApocalypseRettributerResult
            // 
            this.ApocalypseRettributerResult.Location = new System.Drawing.Point(250, 200);
            this.ApocalypseRettributerResult.Name = "ApocalypseRettributerResult";
            this.ApocalypseRettributerResult.Size = new System.Drawing.Size(77, 20);
            this.ApocalypseRettributerResult.TabIndex = 11;
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
            this.WhereToClickForCalcs.SetToolTip(this.SpCaster, "Specter Caster");
            this.SpCaster.UseVisualStyleBackColor = true;
            this.SpCaster.Click += new System.EventHandler(this.SpCaster_Click);
            // 
            // IsSpecterCasterBlessed
            // 
            this.IsSpecterCasterBlessed.AutoSize = true;
            this.IsSpecterCasterBlessed.Location = new System.Drawing.Point(400, 61);
            this.IsSpecterCasterBlessed.Name = "IsSpecterCasterBlessed";
            this.IsSpecterCasterBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsSpecterCasterBlessed.TabIndex = 16;
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
            this.SpecterCaster.TabIndex = 15;
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
            // SpecterCasterResult
            // 
            this.SpecterCasterResult.Location = new System.Drawing.Point(400, 200);
            this.SpecterCasterResult.Name = "SpecterCasterResult";
            this.SpecterCasterResult.Size = new System.Drawing.Size(77, 20);
            this.SpecterCasterResult.TabIndex = 18;
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
            this.WhereToClickForCalcs.SetToolTip(this.SpRettriButer, "Specter Rettributer");
            this.SpRettriButer.UseVisualStyleBackColor = true;
            this.SpRettriButer.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IsSpecterRettributerBlessed
            // 
            this.IsSpecterRettributerBlessed.AutoSize = true;
            this.IsSpecterRettributerBlessed.Location = new System.Drawing.Point(550, 61);
            this.IsSpecterRettributerBlessed.Name = "IsSpecterRettributerBlessed";
            this.IsSpecterRettributerBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsSpecterRettributerBlessed.TabIndex = 21;
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
            this.SpecterRettributer.TabIndex = 20;
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
            // AmaCaster
            // 
            this.AmaCaster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AmaCaster.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.AmaranthineCaster;
            this.AmaCaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AmaCaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmaCaster.Location = new System.Drawing.Point(700, 100);
            this.AmaCaster.Name = "AmaCaster";
            this.AmaCaster.Size = new System.Drawing.Size(71, 74);
            this.AmaCaster.TabIndex = 24;
            this.WhereToClickForCalcs.SetToolTip(this.AmaCaster, "Amaranthine Caster");
            this.AmaCaster.UseVisualStyleBackColor = true;
            this.AmaCaster.Click += new System.EventHandler(this.AmaCaster_Click);
            // 
            // AmaranthineCaster
            // 
            this.AmaranthineCaster.AutoSize = true;
            this.AmaranthineCaster.Location = new System.Drawing.Point(700, 81);
            this.AmaranthineCaster.Name = "AmaranthineCaster";
            this.AmaranthineCaster.Size = new System.Drawing.Size(99, 13);
            this.AmaranthineCaster.TabIndex = 25;
            this.AmaranthineCaster.Text = "Amaranthine Caster";
            // 
            // IsAmaranthineCasterBlessed
            // 
            this.IsAmaranthineCasterBlessed.AutoSize = true;
            this.IsAmaranthineCasterBlessed.Location = new System.Drawing.Point(700, 61);
            this.IsAmaranthineCasterBlessed.Name = "IsAmaranthineCasterBlessed";
            this.IsAmaranthineCasterBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsAmaranthineCasterBlessed.TabIndex = 26;
            this.IsAmaranthineCasterBlessed.Text = "Blessed";
            this.IsAmaranthineCasterBlessed.UseVisualStyleBackColor = true;
            this.IsAmaranthineCasterBlessed.CheckedChanged += new System.EventHandler(this.IsAmaranthineCasterBlessed_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(700, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Result: ";
            // 
            // AmaranthineCasterResult
            // 
            this.AmaranthineCasterResult.Location = new System.Drawing.Point(700, 200);
            this.AmaranthineCasterResult.Name = "AmaranthineCasterResult";
            this.AmaranthineCasterResult.Size = new System.Drawing.Size(77, 20);
            this.AmaranthineCasterResult.TabIndex = 28;
            // 
            // AmaRettributer
            // 
            this.AmaRettributer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AmaRettributer.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.AmaranthineRetributer;
            this.AmaRettributer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AmaRettributer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AmaRettributer.Location = new System.Drawing.Point(850, 100);
            this.AmaRettributer.Name = "AmaRettributer";
            this.AmaRettributer.Size = new System.Drawing.Size(72, 72);
            this.AmaRettributer.TabIndex = 29;
            this.WhereToClickForCalcs.SetToolTip(this.AmaRettributer, "Amaranthine Rettributer");
            this.AmaRettributer.UseVisualStyleBackColor = true;
            this.AmaRettributer.Click += new System.EventHandler(this.AmaRettributer_Click);
            // 
            // AmaranthineRettributer
            // 
            this.AmaranthineRettributer.AutoSize = true;
            this.AmaranthineRettributer.Location = new System.Drawing.Point(850, 81);
            this.AmaranthineRettributer.Name = "AmaranthineRettributer";
            this.AmaranthineRettributer.Size = new System.Drawing.Size(118, 13);
            this.AmaranthineRettributer.TabIndex = 30;
            this.AmaranthineRettributer.Text = "Amaranthine Rettributer";
            // 
            // IsAmaranthineRettributerBlessed
            // 
            this.IsAmaranthineRettributerBlessed.AutoSize = true;
            this.IsAmaranthineRettributerBlessed.Location = new System.Drawing.Point(850, 61);
            this.IsAmaranthineRettributerBlessed.Name = "IsAmaranthineRettributerBlessed";
            this.IsAmaranthineRettributerBlessed.Size = new System.Drawing.Size(63, 17);
            this.IsAmaranthineRettributerBlessed.TabIndex = 31;
            this.IsAmaranthineRettributerBlessed.Text = "Blessed";
            this.IsAmaranthineRettributerBlessed.UseVisualStyleBackColor = true;
            this.IsAmaranthineRettributerBlessed.CheckedChanged += new System.EventHandler(this.IsAmaranthineRettributerBlessed_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Result: ";
            // 
            // AmaranthineRettributerResult
            // 
            this.AmaranthineRettributerResult.Location = new System.Drawing.Point(850, 200);
            this.AmaranthineRettributerResult.Name = "AmaranthineRettributerResult";
            this.AmaranthineRettributerResult.Size = new System.Drawing.Size(77, 20);
            this.AmaranthineRettributerResult.TabIndex = 33;
            // 
            // WhereToInsertMAttack
            // 
            this.WhereToInsertMAttack.AutoPopDelay = 5000;
            this.WhereToInsertMAttack.InitialDelay = 1000;
            this.WhereToInsertMAttack.IsBalloon = true;
            this.WhereToInsertMAttack.ReshowDelay = 100;
            this.WhereToInsertMAttack.ToolTipTitle = "Insert your magical attack here";
            // 
            // WhereToClickForCalcs
            // 
            this.WhereToClickForCalcs.AutomaticDelay = 1000;
            this.WhereToClickForCalcs.AutoPopDelay = 1000;
            this.WhereToClickForCalcs.InitialDelay = 1000;
            this.WhereToClickForCalcs.IsBalloon = true;
            this.WhereToClickForCalcs.ReshowDelay = 200;
            this.WhereToClickForCalcs.ToolTipTitle = "Click here to perform calculations for this item: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L2MAtkCalcRemastered.Properties.Resources.Shot00113;
            this.ClientSize = new System.Drawing.Size(1904, 962);
            this.Controls.Add(this.AmaranthineRettributerResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IsAmaranthineRettributerBlessed);
            this.Controls.Add(this.AmaranthineRettributer);
            this.Controls.Add(this.AmaRettributer);
            this.Controls.Add(this.AmaranthineCasterResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IsAmaranthineCasterBlessed);
            this.Controls.Add(this.AmaranthineCaster);
            this.Controls.Add(this.AmaCaster);
            this.Controls.Add(this.SpecterRettributerResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpecterRettributer);
            this.Controls.Add(this.IsSpecterRettributerBlessed);
            this.Controls.Add(this.SpRettriButer);
            this.Controls.Add(this.SpecterCasterResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpecterCaster);
            this.Controls.Add(this.IsSpecterCasterBlessed);
            this.Controls.Add(this.SpCaster);
            this.Controls.Add(this.IsApocalypseRettributerBlessed);
            this.Controls.Add(this.ApocalypseRettributer);
            this.Controls.Add(this.ApocalypseRettributerResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApoRettributer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NotHavingSigil);
            this.Controls.Add(this.HavingSigil);
            this.Controls.Add(this.IsApocalypseCasterBlessed);
            this.Controls.Add(this.ApocalypseCaster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApocalypseCasterResult);
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
        private System.Windows.Forms.Label ApocalypseCasterResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApocalypseCaster;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save;
        protected System.Windows.Forms.RadioButton HavingSigil;
        protected System.Windows.Forms.RadioButton NotHavingSigil;
        protected internal System.Windows.Forms.TextBox OwnMAttack;
        private System.Windows.Forms.Button ApoRettributer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ApocalypseRettributerResult;
        private System.Windows.Forms.Label ApocalypseRettributer;
        private System.Windows.Forms.Button SpCaster;
        private System.Windows.Forms.CheckBox IsApocalypseCasterBlessed;
        private System.Windows.Forms.CheckBox IsSpecterCasterBlessed;
        private System.Windows.Forms.Label SpecterCaster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SpecterCasterResult;
        private System.Windows.Forms.CheckBox IsApocalypseRettributerBlessed;
        private System.Windows.Forms.Button SpRettriButer;
        private System.Windows.Forms.CheckBox IsSpecterRettributerBlessed;
        private System.Windows.Forms.Label SpecterRettributer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SpecterRettributerResult;
        private System.Windows.Forms.Button AmaCaster;
        private System.Windows.Forms.Label AmaranthineCaster;
        private System.Windows.Forms.CheckBox IsAmaranthineCasterBlessed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AmaranthineCasterResult;
        private System.Windows.Forms.Button AmaRettributer;
        private System.Windows.Forms.Label AmaranthineRettributer;
        private System.Windows.Forms.CheckBox IsAmaranthineRettributerBlessed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AmaranthineRettributerResult;
        private System.Windows.Forms.ToolTip WhereToInsertMAttack;
        private System.Windows.Forms.ToolTip WhereToClickForCalcs;
    }
}

