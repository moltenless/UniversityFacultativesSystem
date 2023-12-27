namespace UniversityFacultativesSystem
{
    partial class DeaneryForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deaneryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityFacultativesSystem.Properties.Resources.education_computer_school_graduate_cap_monitor_icon_1496801;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // deaneryButton
            // 
            this.deaneryButton.BackColor = System.Drawing.Color.AliceBlue;
            this.deaneryButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.deaneryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.deaneryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.deaneryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.deaneryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deaneryButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deaneryButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.deaneryButton.Location = new System.Drawing.Point(159, 448);
            this.deaneryButton.Name = "deaneryButton";
            this.deaneryButton.Size = new System.Drawing.Size(160, 52);
            this.deaneryButton.TabIndex = 2;
            this.deaneryButton.Tag = "1";
            this.deaneryButton.Text = "Деканат";
            this.deaneryButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.closeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.closeButton.Location = new System.Drawing.Point(770, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 29);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.Close);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.minimizeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.minimizeButton.Location = new System.Drawing.Point(737, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 29);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.Minimize);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(219, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Система факультативів університету";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(130, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 69);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вас вітає застосунок для роботи з факультативами.\r\nДля входа у систему виберіть р" +
    "оль:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeaneryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(810, 557);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deaneryButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeaneryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button deaneryButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}