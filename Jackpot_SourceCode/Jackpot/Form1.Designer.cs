namespace Jackpot
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.resim3 = new System.Windows.Forms.PictureBox();
      this.resim2 = new System.Windows.Forms.PictureBox();
      this.resim1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label_1 = new System.Windows.Forms.Label();
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.label_2 = new System.Windows.Forms.Label();
      this.label_3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown_bahis = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label_jeton = new System.Windows.Forms.Label();
      this.label_sonuc = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resim3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resim2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resim1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bahis)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.resim3);
      this.panel1.Controls.Add(this.resim2);
      this.panel1.Controls.Add(this.resim1);
      this.panel1.Location = new System.Drawing.Point(55, 132);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(301, 106);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(-54, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(373, 2);
      this.label1.TabIndex = 1;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // resim3
      // 
      this.resim3.BackColor = System.Drawing.Color.DarkGoldenrod;
      this.resim3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resim3.BackgroundImage")));
      this.resim3.Location = new System.Drawing.Point(221, -576);
      this.resim3.Name = "resim3";
      this.resim3.Size = new System.Drawing.Size(66, 1728);
      this.resim3.TabIndex = 0;
      this.resim3.TabStop = false;
      // 
      // resim2
      // 
      this.resim2.BackColor = System.Drawing.Color.DarkGoldenrod;
      this.resim2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resim2.BackgroundImage")));
      this.resim2.Location = new System.Drawing.Point(116, -576);
      this.resim2.Name = "resim2";
      this.resim2.Size = new System.Drawing.Size(66, 1728);
      this.resim2.TabIndex = 0;
      this.resim2.TabStop = false;
      // 
      // resim1
      // 
      this.resim1.BackColor = System.Drawing.Color.DarkGoldenrod;
      this.resim1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resim1.BackgroundImage")));
      this.resim1.Location = new System.Drawing.Point(11, -576);
      this.resim1.Name = "resim1";
      this.resim1.Size = new System.Drawing.Size(66, 1728);
      this.resim1.TabIndex = 0;
      this.resim1.TabStop = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Olive;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button1.Location = new System.Drawing.Point(290, 340);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 43);
      this.button1.TabIndex = 1;
      this.button1.Text = "Çevir";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 50;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label_1
      // 
      this.label_1.BackColor = System.Drawing.Color.Transparent;
      this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label_1.ForeColor = System.Drawing.Color.YellowGreen;
      this.label_1.Location = new System.Drawing.Point(60, 250);
      this.label_1.Name = "label_1";
      this.label_1.Size = new System.Drawing.Size(84, 43);
      this.label_1.TabIndex = 2;
      this.label_1.Text = "...";
      this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // timer2
      // 
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // label_2
      // 
      this.label_2.BackColor = System.Drawing.Color.Transparent;
      this.label_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label_2.ForeColor = System.Drawing.Color.YellowGreen;
      this.label_2.Location = new System.Drawing.Point(159, 250);
      this.label_2.Name = "label_2";
      this.label_2.Size = new System.Drawing.Size(89, 43);
      this.label_2.TabIndex = 2;
      this.label_2.Text = "...";
      this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label_3
      // 
      this.label_3.BackColor = System.Drawing.Color.Transparent;
      this.label_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label_3.ForeColor = System.Drawing.Color.YellowGreen;
      this.label_3.Location = new System.Drawing.Point(263, 250);
      this.label_3.Name = "label_3";
      this.label_3.Size = new System.Drawing.Size(87, 43);
      this.label_3.TabIndex = 2;
      this.label_3.Text = "...";
      this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
      this.label2.Location = new System.Drawing.Point(34, 386);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(214, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "Copyright 2012 - Mustafa Çakıcı (glikoz@live.com)";
      // 
      // numericUpDown_bahis
      // 
      this.numericUpDown_bahis.Location = new System.Drawing.Point(116, 363);
      this.numericUpDown_bahis.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
      this.numericUpDown_bahis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown_bahis.Name = "numericUpDown_bahis";
      this.numericUpDown_bahis.Size = new System.Drawing.Size(49, 20);
      this.numericUpDown_bahis.TabIndex = 5;
      this.numericUpDown_bahis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numericUpDown_bahis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numericUpDown_bahis.ValueChanged += new System.EventHandler(this.numericUpDown_bahis_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label3.Location = new System.Drawing.Point(43, 343);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Toplam Jeton:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label4.Location = new System.Drawing.Point(43, 366);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(70, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Bahis Miktarı:";
      // 
      // label_jeton
      // 
      this.label_jeton.BackColor = System.Drawing.Color.Transparent;
      this.label_jeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label_jeton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label_jeton.Location = new System.Drawing.Point(121, 340);
      this.label_jeton.Name = "label_jeton";
      this.label_jeton.Size = new System.Drawing.Size(74, 13);
      this.label_jeton.TabIndex = 6;
      this.label_jeton.Text = "0";
      // 
      // label_sonuc
      // 
      this.label_sonuc.BackColor = System.Drawing.Color.Transparent;
      this.label_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label_sonuc.Location = new System.Drawing.Point(55, 307);
      this.label_sonuc.Name = "label_sonuc";
      this.label_sonuc.Size = new System.Drawing.Size(301, 16);
      this.label_sonuc.TabIndex = 7;
      this.label_sonuc.Text = "Bahis Miktarını Belirleyin ve Çevirin";
      this.label_sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // linkLabel1
      // 
      this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
      this.linkLabel1.LinkColor = System.Drawing.Color.White;
      this.linkLabel1.Location = new System.Drawing.Point(322, 4);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(75, 13);
      this.linkLabel1.TabIndex = 8;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Nasıl Oynanır?";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Brown;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(407, 407);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label_sonuc);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label_jeton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numericUpDown_bahis);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label_3);
      this.Controls.Add(this.label_2);
      this.Controls.Add(this.label_1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.panel1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Super Slots Jackpot";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resim3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resim2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resim1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bahis)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox resim1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label_1;
    private System.Windows.Forms.PictureBox resim2;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Label label_2;
    private System.Windows.Forms.Label label_3;
    private System.Windows.Forms.PictureBox resim3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown_bahis;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label_jeton;
    private System.Windows.Forms.Label label_sonuc;
    private System.Windows.Forms.LinkLabel linkLabel1;
  }
}

