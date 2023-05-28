namespace Ufo
{
    partial class MoveForm
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
            this.MovePanel = new System.Windows.Forms.Panel();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.accuracyTB = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.xStartTB = new System.Windows.Forms.TextBox();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepTB = new System.Windows.Forms.TextBox();
            this.moveBtn = new System.Windows.Forms.Button();
            this.graphBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yStartTB = new System.Windows.Forms.TextBox();
            this.yEndTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xEndTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.minRadiusTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxRadiusTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stepRadiusTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MovePanel
            // 
            this.MovePanel.Location = new System.Drawing.Point(-3, 1);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(824, 628);
            this.MovePanel.TabIndex = 0;
            this.MovePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovePanel_Paint);
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Location = new System.Drawing.Point(861, 9);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(66, 17);
            this.accuracyLabel.TabIndex = 0;
            this.accuracyLabel.Text = "Accuracy";
            // 
            // accuracyTB
            // 
            this.accuracyTB.Location = new System.Drawing.Point(854, 29);
            this.accuracyTB.Name = "accuracyTB";
            this.accuracyTB.Size = new System.Drawing.Size(100, 22);
            this.accuracyTB.TabIndex = 1;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(861, 63);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(70, 17);
            this.startLabel.TabIndex = 2;
            this.startLabel.Text = "StartPoint";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(862, 117);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(65, 17);
            this.endLabel.TabIndex = 3;
            this.endLabel.Text = "EndPoint";
            // 
            // xStartTB
            // 
            this.xStartTB.Location = new System.Drawing.Point(852, 83);
            this.xStartTB.Name = "xStartTB";
            this.xStartTB.Size = new System.Drawing.Size(27, 22);
            this.xStartTB.TabIndex = 4;
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(862, 172);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(37, 17);
            this.stepLabel.TabIndex = 6;
            this.stepLabel.Text = "Step";
            // 
            // stepTB
            // 
            this.stepTB.Location = new System.Drawing.Point(854, 192);
            this.stepTB.Name = "stepTB";
            this.stepTB.Size = new System.Drawing.Size(100, 22);
            this.stepTB.TabIndex = 7;
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(852, 230);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(102, 36);
            this.moveBtn.TabIndex = 8;
            this.moveBtn.Text = "Move";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // graphBtn
            // 
            this.graphBtn.Location = new System.Drawing.Point(851, 414);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(102, 38);
            this.graphBtn.TabIndex = 9;
            this.graphBtn.Text = "Create graph";
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // yStartTB
            // 
            this.yStartTB.Location = new System.Drawing.Point(927, 85);
            this.yStartTB.Name = "yStartTB";
            this.yStartTB.Size = new System.Drawing.Size(27, 22);
            this.yStartTB.TabIndex = 12;
            // 
            // yEndTB
            // 
            this.yEndTB.Location = new System.Drawing.Point(927, 149);
            this.yEndTB.Name = "yEndTB";
            this.yEndTB.Size = new System.Drawing.Size(27, 22);
            this.yEndTB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(904, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            // 
            // xEndTB
            // 
            this.xEndTB.Location = new System.Drawing.Point(852, 147);
            this.xEndTB.Name = "xEndTB";
            this.xEndTB.Size = new System.Drawing.Size(27, 22);
            this.xEndTB.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(839, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Radius for graph";
            // 
            // minRadiusTB
            // 
            this.minRadiusTB.Location = new System.Drawing.Point(865, 316);
            this.minRadiusTB.Name = "minRadiusTB";
            this.minRadiusTB.Size = new System.Drawing.Size(100, 22);
            this.minRadiusTB.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(827, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Min";
            // 
            // maxRadiusTB
            // 
            this.maxRadiusTB.Location = new System.Drawing.Point(864, 344);
            this.maxRadiusTB.Name = "maxRadiusTB";
            this.maxRadiusTB.Size = new System.Drawing.Size(100, 22);
            this.maxRadiusTB.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Step";
            // 
            // stepRadiusTB
            // 
            this.stepRadiusTB.Location = new System.Drawing.Point(864, 373);
            this.stepRadiusTB.Name = "stepRadiusTB";
            this.stepRadiusTB.Size = new System.Drawing.Size(100, 22);
            this.stepRadiusTB.TabIndex = 23;
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 626);
            this.Controls.Add(this.stepRadiusTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxRadiusTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minRadiusTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yEndTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xEndTB);
            this.Controls.Add(this.yStartTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.stepTB);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.xStartTB);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.accuracyTB);
            this.Controls.Add(this.accuracyLabel);
            this.Controls.Add(this.MovePanel);
            this.Name = "MoveForm";
            this.Text = "UfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.TextBox accuracyTB;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.TextBox xStartTB;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.TextBox stepTB;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yStartTB;
        private System.Windows.Forms.TextBox yEndTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xEndTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minRadiusTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxRadiusTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stepRadiusTB;
    }
}

