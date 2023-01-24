namespace oop_lab21_animation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pepe_1_label = new System.Windows.Forms.Label();
            this.pepe_2_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pepe_1_label
            // 
            this.pepe_1_label.AutoSize = true;
            this.pepe_1_label.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pepe_1_label.Location = new System.Drawing.Point(12, 9);
            this.pepe_1_label.Name = "pepe_1_label";
            this.pepe_1_label.Size = new System.Drawing.Size(62, 21);
            this.pepe_1_label.TabIndex = 0;
            this.pepe_1_label.Text = "Pepe 1";
            // 
            // pepe_2_label
            // 
            this.pepe_2_label.AutoSize = true;
            this.pepe_2_label.Font = new System.Drawing.Font("Ink Free", 10.2F, System.Drawing.FontStyle.Bold);
            this.pepe_2_label.Location = new System.Drawing.Point(80, 9);
            this.pepe_2_label.Name = "pepe_2_label";
            this.pepe_2_label.Size = new System.Drawing.Size(67, 21);
            this.pepe_2_label.TabIndex = 1;
            this.pepe_2_label.Text = "Pepe 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 584);
            this.Controls.Add(this.pepe_2_label);
            this.Controls.Add(this.pepe_1_label);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1076, 631);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Pepe);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pepe_1_label;
        private System.Windows.Forms.Label pepe_2_label;
    }
}

