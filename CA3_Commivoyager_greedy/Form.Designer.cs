namespace CA3_Commivoyager_greedy
{
    partial class fmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.gbExact = new System.Windows.Forms.GroupBox();
            this.gbGreedy = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMatrix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(12, 12);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.Size = new System.Drawing.Size(367, 367);
            this.dgvMatrix.TabIndex = 0;
            // 
            // gbExact
            // 
            this.gbExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbExact.Location = new System.Drawing.Point(386, 12);
            this.gbExact.Name = "gbExact";
            this.gbExact.Size = new System.Drawing.Size(208, 108);
            this.gbExact.TabIndex = 1;
            this.gbExact.TabStop = false;
            this.gbExact.Text = "Exact algorythm";
            // 
            // gbGreedy
            // 
            this.gbGreedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbGreedy.Location = new System.Drawing.Point(386, 126);
            this.gbGreedy.Name = "gbGreedy";
            this.gbGreedy.Size = new System.Drawing.Size(208, 108);
            this.gbGreedy.TabIndex = 2;
            this.gbGreedy.TabStop = false;
            this.gbGreedy.Text = "Greedy algorythm";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.Info;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRandom.Location = new System.Drawing.Point(511, 297);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(83, 38);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.SystemColors.Info;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTask.Location = new System.Drawing.Point(465, 341);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(40, 38);
            this.btnTask.TabIndex = 4;
            this.btnTask.Text = "?";
            this.btnTask.UseVisualStyleBackColor = false;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(511, 341);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(83, 38);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            // 
            // nudSize
            // 
            this.nudSize.BackColor = System.Drawing.SystemColors.Info;
            this.nudSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSize.Location = new System.Drawing.Point(465, 300);
            this.nudSize.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(40, 32);
            this.nudSize.TabIndex = 6;
            this.nudSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(606, 391);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.gbGreedy);
            this.Controls.Add(this.gbExact);
            this.Controls.Add(this.dgvMatrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commivoyager dilemma: exact and greedy algorythms";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.GroupBox gbExact;
        private System.Windows.Forms.GroupBox gbGreedy;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudSize;
    }
}

