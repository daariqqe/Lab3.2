namespace lab3
{
    partial class fMain
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
            this.tbPlaneInfo = new System.Windows.Forms.TextBox();
            this.btnAddPlane = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPlaneInfo
            // 
            this.tbPlaneInfo.Location = new System.Drawing.Point(12, 12);
            this.tbPlaneInfo.Multiline = true;
            this.tbPlaneInfo.Name = "tbPlaneInfo";
            this.tbPlaneInfo.ReadOnly = true;
            this.tbPlaneInfo.Size = new System.Drawing.Size(659, 426);
            this.tbPlaneInfo.TabIndex = 0;
            // 
            // btnAddPlane
            // 
            this.btnAddPlane.Location = new System.Drawing.Point(677, 11);
            this.btnAddPlane.Name = "btnAddPlane";
            this.btnAddPlane.Size = new System.Drawing.Size(120, 25);
            this.btnAddPlane.TabIndex = 1;
            this.btnAddPlane.Text = "Додати літак";
            this.btnAddPlane.UseVisualStyleBackColor = true;
            this.btnAddPlane.Click += new System.EventHandler(this.btnAddPlane_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPlane);
            this.Controls.Add(this.tbPlaneInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторно робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlaneInfo;
        private System.Windows.Forms.Button btnAddPlane;
        private System.Windows.Forms.Button btnClose;
    }
}

