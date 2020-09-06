namespace MacroLanse.Forms
{
    partial class MacroBuilderForm
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
            this.dgvMacros = new System.Windows.Forms.DataGridView();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnInsertMacro = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboMacroSet = new System.Windows.Forms.ComboBox();
            this.labelMacroSet = new System.Windows.Forms.Label();
            this.btnNewMacroSet = new System.Windows.Forms.Button();
            this.btnDeleteMacroSet = new System.Windows.Forms.Button();
            this.labelSeparator1 = new System.Windows.Forms.Label();
            this.btnRenameMacroSet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeoutDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMacros
            // 
            this.dgvMacros.AllowUserToAddRows = false;
            this.dgvMacros.AllowUserToDeleteRows = false;
            this.dgvMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMacros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.KeyCode,
            this.TimeoutDuration});
            this.dgvMacros.Location = new System.Drawing.Point(12, 140);
            this.dgvMacros.MultiSelect = false;
            this.dgvMacros.Name = "dgvMacros";
            this.dgvMacros.ReadOnly = true;
            this.dgvMacros.RowTemplate.Height = 30;
            this.dgvMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMacros.ShowCellToolTips = false;
            this.dgvMacros.ShowEditingIcon = false;
            this.dgvMacros.Size = new System.Drawing.Size(419, 331);
            this.dgvMacros.TabIndex = 0;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(437, 234);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(49, 52);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(437, 306);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(49, 52);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnInsertMacro
            // 
            this.btnInsertMacro.Location = new System.Drawing.Point(292, 477);
            this.btnInsertMacro.Name = "btnInsertMacro";
            this.btnInsertMacro.Size = new System.Drawing.Size(94, 38);
            this.btnInsertMacro.TabIndex = 3;
            this.btnInsertMacro.Text = "Insert";
            this.btnInsertMacro.UseVisualStyleBackColor = true;
            this.btnInsertMacro.Click += new System.EventHandler(this.btnInsertMacro_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(392, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboMacroSet
            // 
            this.comboMacroSet.FormattingEnabled = true;
            this.comboMacroSet.Location = new System.Drawing.Point(198, 19);
            this.comboMacroSet.Name = "comboMacroSet";
            this.comboMacroSet.Size = new System.Drawing.Size(233, 30);
            this.comboMacroSet.TabIndex = 5;
            // 
            // labelMacroSet
            // 
            this.labelMacroSet.AutoSize = true;
            this.labelMacroSet.Location = new System.Drawing.Point(12, 22);
            this.labelMacroSet.Name = "labelMacroSet";
            this.labelMacroSet.Size = new System.Drawing.Size(157, 24);
            this.labelMacroSet.TabIndex = 6;
            this.labelMacroSet.Text = "Select Macro Set:";
            // 
            // btnNewMacroSet
            // 
            this.btnNewMacroSet.Location = new System.Drawing.Point(12, 65);
            this.btnNewMacroSet.Name = "btnNewMacroSet";
            this.btnNewMacroSet.Size = new System.Drawing.Size(94, 38);
            this.btnNewMacroSet.TabIndex = 7;
            this.btnNewMacroSet.Text = "New";
            this.btnNewMacroSet.UseVisualStyleBackColor = true;
            this.btnNewMacroSet.Click += new System.EventHandler(this.btnNewMacroSet_Click);
            // 
            // btnDeleteMacroSet
            // 
            this.btnDeleteMacroSet.Location = new System.Drawing.Point(112, 65);
            this.btnDeleteMacroSet.Name = "btnDeleteMacroSet";
            this.btnDeleteMacroSet.Size = new System.Drawing.Size(94, 38);
            this.btnDeleteMacroSet.TabIndex = 8;
            this.btnDeleteMacroSet.Text = "Delete";
            this.btnDeleteMacroSet.UseVisualStyleBackColor = true;
            this.btnDeleteMacroSet.Click += new System.EventHandler(this.btnDeleteMacroSet_Click);
            // 
            // labelSeparator1
            // 
            this.labelSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator1.Location = new System.Drawing.Point(12, 121);
            this.labelSeparator1.Name = "labelSeparator1";
            this.labelSeparator1.Size = new System.Drawing.Size(474, 2);
            this.labelSeparator1.TabIndex = 9;
            // 
            // btnRenameMacroSet
            // 
            this.btnRenameMacroSet.Location = new System.Drawing.Point(337, 65);
            this.btnRenameMacroSet.Name = "btnRenameMacroSet";
            this.btnRenameMacroSet.Size = new System.Drawing.Size(94, 38);
            this.btnRenameMacroSet.TabIndex = 10;
            this.btnRenameMacroSet.Text = "Rename";
            this.btnRenameMacroSet.UseVisualStyleBackColor = true;
            this.btnRenameMacroSet.Click += new System.EventHandler(this.btnRenameMacroSet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(112, 477);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 50;
            // 
            // KeyCode
            // 
            this.KeyCode.DataPropertyName = "CodeName";
            this.KeyCode.HeaderText = "Key Code";
            this.KeyCode.Name = "KeyCode";
            this.KeyCode.ReadOnly = true;
            this.KeyCode.Width = 60;
            // 
            // TimeoutDuration
            // 
            this.TimeoutDuration.DataPropertyName = "TimeoutDuration";
            this.TimeoutDuration.HeaderText = "Time-out Duration";
            this.TimeoutDuration.Name = "TimeoutDuration";
            this.TimeoutDuration.ReadOnly = true;
            this.TimeoutDuration.Width = 90;
            // 
            // MacroBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 527);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRenameMacroSet);
            this.Controls.Add(this.labelSeparator1);
            this.Controls.Add(this.btnDeleteMacroSet);
            this.Controls.Add(this.btnNewMacroSet);
            this.Controls.Add(this.labelMacroSet);
            this.Controls.Add(this.comboMacroSet);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsertMacro);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.dgvMacros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MacroBuilderForm";
            this.Text = "Macro Builder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMacros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMacros;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnInsertMacro;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboMacroSet;
        private System.Windows.Forms.Label labelMacroSet;
        private System.Windows.Forms.Button btnNewMacroSet;
        private System.Windows.Forms.Button btnDeleteMacroSet;
        private System.Windows.Forms.Label labelSeparator1;
        private System.Windows.Forms.Button btnRenameMacroSet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeoutDuration;
    }
}