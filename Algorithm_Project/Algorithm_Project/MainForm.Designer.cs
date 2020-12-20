namespace Algorithm_Project
{
    partial class MainForm
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
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError1 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.labedistance = new System.Windows.Forms.Label();
            this.buttonVisualization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirst.Location = new System.Drawing.Point(17, 109);
            this.textBoxFirst.Multiline = true;
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(250, 100);
            this.textBoxFirst.TabIndex = 0;
            this.textBoxFirst.TextChanged += new System.EventHandler(this.textBoxFirst_TextChanged);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirst.Location = new System.Drawing.Point(20, 75);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(138, 32);
            this.labelFirst.TabIndex = 1;
            this.labelFirst.Text = "First string";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecond.Location = new System.Drawing.Point(314, 75);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(172, 32);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "Second string";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecond.Location = new System.Drawing.Point(311, 109);
            this.textBoxSecond.Multiline = true;
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(250, 100);
            this.textBoxSecond.TabIndex = 2;
            this.textBoxSecond.TextChanged += new System.EventHandler(this.textBoxSecond_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(152)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(167)))), ((int)(((byte)(236)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(17, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(207, 246);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(184, 32);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result distance:";
            this.labelResult.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Damerau-Levenshtein distance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelError1
            // 
            this.labelError1.AutoSize = true;
            this.labelError1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError1.ForeColor = System.Drawing.Color.Red;
            this.labelError1.Location = new System.Drawing.Point(19, 205);
            this.labelError1.Name = "labelError1";
            this.labelError1.Size = new System.Drawing.Size(150, 25);
            this.labelError1.TabIndex = 7;
            this.labelError1.Text = "Fill the text box";
            this.labelError1.Visible = false;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(312, 205);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(150, 25);
            this.labelError2.TabIndex = 8;
            this.labelError2.Text = "Fill the text box";
            this.labelError2.Visible = false;
            // 
            // labedistance
            // 
            this.labedistance.AutoSize = true;
            this.labedistance.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labedistance.ForeColor = System.Drawing.Color.Green;
            this.labedistance.Location = new System.Drawing.Point(387, 241);
            this.labedistance.Name = "labedistance";
            this.labedistance.Size = new System.Drawing.Size(32, 37);
            this.labedistance.TabIndex = 9;
            this.labedistance.Text = "0";
            this.labedistance.Visible = false;
            // 
            // buttonVisualization
            // 
            this.buttonVisualization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(152)))));
            this.buttonVisualization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisualization.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisualization.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVisualization.Location = new System.Drawing.Point(461, 246);
            this.buttonVisualization.Name = "buttonVisualization";
            this.buttonVisualization.Size = new System.Drawing.Size(100, 32);
            this.buttonVisualization.TabIndex = 10;
            this.buttonVisualization.Text = "Show";
            this.buttonVisualization.UseVisualStyleBackColor = false;
            this.buttonVisualization.Visible = false;
            this.buttonVisualization.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(579, 294);
            this.Controls.Add(this.buttonVisualization);
            this.Controls.Add(this.labedistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.labelError1);
            this.Controls.Add(this.labelError2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damerau-Levenshtein distance by Kapustianskyi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError1;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.Label labedistance;
        private System.Windows.Forms.Button buttonVisualization;
    }
}

