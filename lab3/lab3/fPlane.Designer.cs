namespace lab3
{
    partial class fPlane
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFuelCapacity = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbWingspan = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbMaxSpeed = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasCombatSystem = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFuelCapacity);
            this.groupBox1.Controls.Add(this.tbWeight);
            this.groupBox1.Controls.Add(this.tbWingspan);
            this.groupBox1.Controls.Add(this.tbLength);
            this.groupBox1.Controls.Add(this.tbMaxSpeed);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbFuelCapacity
            // 
            this.tbFuelCapacity.Location = new System.Drawing.Point(268, 202);
            this.tbFuelCapacity.Name = "tbFuelCapacity";
            this.tbFuelCapacity.Size = new System.Drawing.Size(130, 22);
            this.tbFuelCapacity.TabIndex = 11;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(268, 165);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(130, 22);
            this.tbWeight.TabIndex = 10;
            // 
            // tbWingspan
            // 
            this.tbWingspan.Location = new System.Drawing.Point(268, 132);
            this.tbWingspan.Name = "tbWingspan";
            this.tbWingspan.Size = new System.Drawing.Size(130, 22);
            this.tbWingspan.TabIndex = 9;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(268, 98);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(130, 22);
            this.tbLength.TabIndex = 8;
            // 
            // tbMaxSpeed
            // 
            this.tbMaxSpeed.Location = new System.Drawing.Point(268, 66);
            this.tbMaxSpeed.Name = "tbMaxSpeed";
            this.tbMaxSpeed.Size = new System.Drawing.Size(130, 22);
            this.tbMaxSpeed.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(268, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(130, 22);
            this.tbName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ємність бака, л";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Маса, кг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Розмах крила, м";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Довжина, м";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Макс. швидкість, км/год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasCombatSystem);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Бойова система";
            // 
            // chbHasCombatSystem
            // 
            this.chbHasCombatSystem.AutoSize = true;
            this.chbHasCombatSystem.Location = new System.Drawing.Point(33, 33);
            this.chbHasCombatSystem.Name = "chbHasCombatSystem";
            this.chbHasCombatSystem.Size = new System.Drawing.Size(231, 20);
            this.chbHasCombatSystem.TabIndex = 0;
            this.chbHasCombatSystem.Text = "Оснащений бойовою системою";
            this.chbHasCombatSystem.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(550, 45);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(550, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fPlane
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "fPlane";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий літак";
            this.Load += new System.EventHandler(this.fPlane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFuelCapacity;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbWingspan;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbMaxSpeed;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasCombatSystem;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

    }
}