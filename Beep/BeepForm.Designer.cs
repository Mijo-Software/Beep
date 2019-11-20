namespace Beep
{
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
			this.btnBeep = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.trackBarFrequency = new System.Windows.Forms.TrackBar();
			this.trackBarDuration = new System.Windows.Forms.TrackBar();
			this.trackBarVolume = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBeep
			// 
			this.btnBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBeep.Location = new System.Drawing.Point(12, 165);
			this.btnBeep.Name = "btnBeep";
			this.btnBeep.Size = new System.Drawing.Size(464, 83);
			this.btnBeep.TabIndex = 0;
			this.btnBeep.Text = "Beep";
			this.btnBeep.UseVisualStyleBackColor = true;
			this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "frequency in hz:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "duration in ms:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "volume";
			// 
			// trackBarFrequency
			// 
			this.trackBarFrequency.LargeChange = 1;
			this.trackBarFrequency.Location = new System.Drawing.Point(100, 12);
			this.trackBarFrequency.Maximum = 17000;
			this.trackBarFrequency.Name = "trackBarFrequency";
			this.trackBarFrequency.Size = new System.Drawing.Size(385, 45);
			this.trackBarFrequency.TabIndex = 4;
			this.trackBarFrequency.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarFrequency.Value = 2400;
			this.trackBarFrequency.Scroll += new System.EventHandler(this.trackBarFrequency_Scroll);
			// 
			// trackBarDuration
			// 
			this.trackBarDuration.LargeChange = 1;
			this.trackBarDuration.Location = new System.Drawing.Point(100, 63);
			this.trackBarDuration.Maximum = 200;
			this.trackBarDuration.Name = "trackBarDuration";
			this.trackBarDuration.Size = new System.Drawing.Size(385, 45);
			this.trackBarDuration.TabIndex = 5;
			this.trackBarDuration.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarDuration.Value = 100;
			this.trackBarDuration.Scroll += new System.EventHandler(this.trackBarDuration_Scroll);
			// 
			// trackBarVolume
			// 
			this.trackBarVolume.LargeChange = 1;
			this.trackBarVolume.Location = new System.Drawing.Point(100, 114);
			this.trackBarVolume.Maximum = 32767;
			this.trackBarVolume.Name = "trackBarVolume";
			this.trackBarVolume.Size = new System.Drawing.Size(385, 45);
			this.trackBarVolume.TabIndex = 6;
			this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarVolume.Value = 16384;
			this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
			// 
			// BeepForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 259);
			this.Controls.Add(this.trackBarVolume);
			this.Controls.Add(this.trackBarDuration);
			this.Controls.Add(this.trackBarFrequency);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBeep);
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

    private System.Windows.Forms.Button btnBeep;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar trackBarFrequency;
    private System.Windows.Forms.TrackBar trackBarDuration;
    private System.Windows.Forms.TrackBar trackBarVolume;
  }
}

