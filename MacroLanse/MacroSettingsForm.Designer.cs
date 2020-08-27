namespace MacroLanse
{
    partial class MacroSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroSettingsForm));
            this.InputPressTimeout = new System.Windows.Forms.NumericUpDown();
            this.LabelPressTimeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputPressTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPressTimeout
            // 
            this.InputPressTimeout.Location = new System.Drawing.Point(161, 28);
            this.InputPressTimeout.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.InputPressTimeout.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.InputPressTimeout.Name = "InputPressTimeout";
            this.InputPressTimeout.Size = new System.Drawing.Size(120, 28);
            this.InputPressTimeout.TabIndex = 1;
            this.InputPressTimeout.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LabelPressTimeout
            // 
            this.LabelPressTimeout.AutoSize = true;
            this.LabelPressTimeout.Location = new System.Drawing.Point(12, 30);
            this.LabelPressTimeout.Name = "LabelPressTimeout";
            this.LabelPressTimeout.Size = new System.Drawing.Size(131, 24);
            this.LabelPressTimeout.TabIndex = 2;
            this.LabelPressTimeout.Text = "Press Timeout";
            // 
            // MacroSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 124);
            this.Controls.Add(this.LabelPressTimeout);
            this.Controls.Add(this.InputPressTimeout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacroSettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.InputPressTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown InputPressTimeout;
        private System.Windows.Forms.Label LabelPressTimeout;
    }
}