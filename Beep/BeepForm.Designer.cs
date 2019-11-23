namespace Beep
{
  /// <summary>
	/// Main Window
	/// </summary>
	partial class BeepForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
			this.buttonBeep = new System.Windows.Forms.Button();
			this.labelFrequency = new System.Windows.Forms.Label();
			this.labelDuration = new System.Windows.Forms.Label();
			this.labelVolume = new System.Windows.Forms.Label();
			this.trackBarFrequency = new System.Windows.Forms.TrackBar();
			this.trackBarDuration = new System.Windows.Forms.TrackBar();
			this.trackBarVolume = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBeep
			// 
			this.buttonBeep.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBeep.Location = new System.Drawing.Point(12, 165);
			this.buttonBeep.Name = "buttonBeep";
			this.buttonBeep.Size = new System.Drawing.Size(464, 83);
			this.buttonBeep.TabIndex = 6;
			this.buttonBeep.Text = "Beep";
			this.buttonBeep.UseVisualStyleBackColor = true;
			this.buttonBeep.Click += new System.EventHandler(this.ButtonBeep_Click);
			// 
			// labelFrequency
			// 
			this.labelFrequency.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelFrequency.AutoSize = true;
			this.labelFrequency.Location = new System.Drawing.Point(12, 27);
			this.labelFrequency.Name = "labelFrequency";
			this.labelFrequency.Size = new System.Drawing.Size(82, 13);
			this.labelFrequency.TabIndex = 0;
			this.labelFrequency.Text = "frequency in hz:";
			// 
			// labelDuration
			// 
			this.labelDuration.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(12, 76);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(75, 13);
			this.labelDuration.TabIndex = 2;
			this.labelDuration.Text = "duration in ms:";
			// 
			// labelVolume
			// 
			this.labelVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelVolume.AutoSize = true;
			this.labelVolume.Location = new System.Drawing.Point(12, 127);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(41, 13);
			this.labelVolume.TabIndex = 4;
			this.labelVolume.Text = "volume";
			// 
			// trackBarFrequency
			// 
			this.trackBarFrequency.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
			this.trackBarFrequency.LargeChange = 1;
			this.trackBarFrequency.Location = new System.Drawing.Point(100, 12);
			this.trackBarFrequency.Maximum = 17000;
			this.trackBarFrequency.Name = "trackBarFrequency";
			this.trackBarFrequency.Size = new System.Drawing.Size(385, 45);
			this.trackBarFrequency.TabIndex = 1;
			this.trackBarFrequency.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarFrequency.Value = 2400;
			this.trackBarFrequency.Scroll += new System.EventHandler(this.ChangeBeepText_Scroll);
			// 
			// trackBarDuration
			// 
			this.trackBarDuration.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
			this.trackBarDuration.LargeChange = 1;
			this.trackBarDuration.Location = new System.Drawing.Point(100, 63);
			this.trackBarDuration.Maximum = 200;
			this.trackBarDuration.Name = "trackBarDuration";
			this.trackBarDuration.Size = new System.Drawing.Size(385, 45);
			this.trackBarDuration.TabIndex = 3;
			this.trackBarDuration.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarDuration.Value = 100;
			this.trackBarDuration.Scroll += new System.EventHandler(this.ChangeBeepText_Scroll);
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
			this.trackBarVolume.LargeChange = 1;
			this.trackBarVolume.Location = new System.Drawing.Point(100, 114);
			this.trackBarVolume.Maximum = 32767;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(385, 45);
			this.trackBarVolume.TabIndex = 5;
			this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarVolume.Value = 16384;
			this.trackBarVolume.Scroll += new System.EventHandler(this.ChangeBeepText_Scroll);
			// 
			// BeepForm
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 259);
			this.Controls.Add(this.trackBarVolume);
			this.Controls.Add(this.trackBarDuration);
			this.Controls.Add(this.trackBarFrequency);
			this.Controls.Add(this.labelVolume);
			this.Controls.Add(this.labelDuration);
			this.Controls.Add(this.labelFrequency);
			this.Controls.Add(this.buttonBeep);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "BeepForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Beep";
			this.Load += new System.EventHandler(this.BeepForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonBeep;
    private System.Windows.Forms.Label labelFrequency;
    private System.Windows.Forms.Label labelDuration;
    private System.Windows.Forms.Label labelVolume;
    private System.Windows.Forms.TrackBar trackBarFrequency;
    private System.Windows.Forms.TrackBar trackBarDuration;
    private System.Windows.Forms.TrackBar trackBarVolume;
  }
}

