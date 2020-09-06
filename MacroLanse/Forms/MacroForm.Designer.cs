namespace MacroLanse.Forms
{
    partial class MacroForm
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
            this.labelKeyCode = new System.Windows.Forms.Label();
            this.labelTimeoutDuration = new System.Windows.Forms.Label();
            this.comboKeyCode = new System.Windows.Forms.ComboBox();
            this.numTimeoutDuration = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKeyCode
            // 
            this.labelKeyCode.AutoSize = true;
            this.labelKeyCode.Location = new System.Drawing.Point(98, 21);
            this.labelKeyCode.Name = "labelKeyCode";
            this.labelKeyCode.Size = new System.Drawing.Size(93, 24);
            this.labelKeyCode.TabIndex = 3;
            this.labelKeyCode.Text = "KeyCode:";
            // 
            // labelTimeoutDuration
            // 
            this.labelTimeoutDuration.AutoSize = true;
            this.labelTimeoutDuration.Location = new System.Drawing.Point(32, 63);
            this.labelTimeoutDuration.Name = "labelTimeoutDuration";
            this.labelTimeoutDuration.Size = new System.Drawing.Size(159, 24);
            this.labelTimeoutDuration.TabIndex = 4;
            this.labelTimeoutDuration.Text = "Timeout Duration:";
            // 
            // comboKeyCode
            // 
            this.comboKeyCode.FormattingEnabled = true;
            this.comboKeyCode.Location = new System.Drawing.Point(197, 18);
            this.comboKeyCode.Name = "comboKeyCode";
            this.comboKeyCode.Size = new System.Drawing.Size(120, 30);
            this.comboKeyCode.TabIndex = 5;
            // 
            // numTimeoutDuration
            // 
            this.numTimeoutDuration.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTimeoutDuration.Location = new System.Drawing.Point(197, 63);
            this.numTimeoutDuration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTimeoutDuration.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numTimeoutDuration.Name = "numTimeoutDuration";
            this.numTimeoutDuration.Size = new System.Drawing.Size(120, 28);
            this.numTimeoutDuration.TabIndex = 6;
            this.numTimeoutDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 118);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 34);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(289, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(86, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MacroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 174);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numTimeoutDuration);
            this.Controls.Add(this.comboKeyCode);
            this.Controls.Add(this.labelTimeoutDuration);
            this.Controls.Add(this.labelKeyCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacroForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Macro";
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKeyCode;
        private System.Windows.Forms.Label labelTimeoutDuration;
        private System.Windows.Forms.ComboBox comboKeyCode;
        private System.Windows.Forms.NumericUpDown numTimeoutDuration;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}