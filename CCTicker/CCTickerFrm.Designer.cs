namespace CCTicker
{
  partial class CCTickerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCTickerFrm));
            this.lblDecredUSDValue = new System.Windows.Forms.Label();
            this.lblDecredUSDValueDisplay = new System.Windows.Forms.Label();
            this.tmrDecred = new System.Windows.Forms.Timer(this.components);
            this.lblBitcoinUSDValue = new System.Windows.Forms.Label();
            this.lblBitcoinUSDValueDisplay = new System.Windows.Forms.Label();
            this.lblHTTPException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDecredUSDValue
            // 
            this.lblDecredUSDValue.AutoSize = true;
            this.lblDecredUSDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecredUSDValue.ForeColor = System.Drawing.Color.Lime;
            this.lblDecredUSDValue.Location = new System.Drawing.Point(7, 10);
            this.lblDecredUSDValue.Name = "lblDecredUSDValue";
            this.lblDecredUSDValue.Size = new System.Drawing.Size(207, 13);
            this.lblDecredUSDValue.TabIndex = 0;
            this.lblDecredUSDValue.Text = "DECRED\'S CURRENT USD VALUE";
            // 
            // lblDecredUSDValueDisplay
            // 
            this.lblDecredUSDValueDisplay.AutoSize = true;
            this.lblDecredUSDValueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecredUSDValueDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDecredUSDValueDisplay.Location = new System.Drawing.Point(12, 34);
            this.lblDecredUSDValueDisplay.Name = "lblDecredUSDValueDisplay";
            this.lblDecredUSDValueDisplay.Size = new System.Drawing.Size(196, 46);
            this.lblDecredUSDValueDisplay.TabIndex = 2;
            this.lblDecredUSDValueDisplay.Text = "$$$$$$$$";
            // 
            // tmrDecred
            // 
            this.tmrDecred.Interval = 600000;
            this.tmrDecred.Tick += new System.EventHandler(this.tmrDecred_Tick);
            // 
            // lblBitcoinUSDValue
            // 
            this.lblBitcoinUSDValue.AutoSize = true;
            this.lblBitcoinUSDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoinUSDValue.ForeColor = System.Drawing.Color.Lime;
            this.lblBitcoinUSDValue.Location = new System.Drawing.Point(8, 99);
            this.lblBitcoinUSDValue.Name = "lblBitcoinUSDValue";
            this.lblBitcoinUSDValue.Size = new System.Drawing.Size(206, 13);
            this.lblBitcoinUSDValue.TabIndex = 3;
            this.lblBitcoinUSDValue.Text = "BITCOIN\'S CURRENT USD VALUE";
            // 
            // lblBitcoinUSDValueDisplay
            // 
            this.lblBitcoinUSDValueDisplay.AutoSize = true;
            this.lblBitcoinUSDValueDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoinUSDValueDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblBitcoinUSDValueDisplay.Location = new System.Drawing.Point(12, 126);
            this.lblBitcoinUSDValueDisplay.Name = "lblBitcoinUSDValueDisplay";
            this.lblBitcoinUSDValueDisplay.Size = new System.Drawing.Size(196, 46);
            this.lblBitcoinUSDValueDisplay.TabIndex = 4;
            this.lblBitcoinUSDValueDisplay.Text = "$$$$$$$$";
            // 
            // lblHTTPException
            // 
            this.lblHTTPException.AutoSize = true;
            this.lblHTTPException.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTTPException.ForeColor = System.Drawing.Color.Yellow;
            this.lblHTTPException.Location = new System.Drawing.Point(7, 186);
            this.lblHTTPException.Name = "lblHTTPException";
            this.lblHTTPException.Size = new System.Drawing.Size(215, 16);
            this.lblHTTPException.TabIndex = 5;
            this.lblHTTPException.Text = "! Error refreshing. Click here to retry!";
            this.lblHTTPException.Visible = false;
            this.lblHTTPException.Click += new System.EventHandler(this.lblHTTPException_Click);
            // 
            // CCTickerFrm
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(227, 215);
            this.ControlBox = false;
            this.Controls.Add(this.lblHTTPException);
            this.Controls.Add(this.lblBitcoinUSDValueDisplay);
            this.Controls.Add(this.lblBitcoinUSDValue);
            this.Controls.Add(this.lblDecredUSDValueDisplay);
            this.Controls.Add(this.lblDecredUSDValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CCTickerFrm";
            this.Opacity = 0.7D;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDecredUSDValue;
    private System.Windows.Forms.Label lblDecredUSDValueDisplay;
    private System.Windows.Forms.Timer tmrDecred;
    private System.Windows.Forms.Label lblBitcoinUSDValue;
    private System.Windows.Forms.Label lblBitcoinUSDValueDisplay;
    private System.Windows.Forms.Label lblHTTPException;
  }
}

