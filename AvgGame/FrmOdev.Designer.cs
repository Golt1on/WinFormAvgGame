namespace Odev_06._04
{
    partial class FrmOdev06_04
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
            this.lbl_exp = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exp.Location = new System.Drawing.Point(89, 68);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(501, 25);
            this.lbl_exp.TabIndex = 11;
            this.lbl_exp.Text = "Choose 2 numbers between 0 and 5000 for playing";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_result.Location = new System.Drawing.Point(233, 270);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(213, 16);
            this.lbl_result.TabIndex = 10;
            this.lbl_result.Text = "You Will See The Result Here";
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Lime;
            this.btn_Play.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Play.Location = new System.Drawing.Point(301, 202);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(75, 47);
            this.btn_Play.TabIndex = 9;
            this.btn_Play.Text = "Play :)";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_num2.Location = new System.Drawing.Point(352, 160);
            this.txt_num2.Multiline = true;
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(94, 25);
            this.txt_num2.TabIndex = 8;
            this.txt_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_num1
            // 
            this.txt_num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_num1.Location = new System.Drawing.Point(236, 160);
            this.txt_num1.Multiline = true;
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(94, 25);
            this.txt_num1.TabIndex = 7;
            this.txt_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(244, 142);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(75, 16);
            this.lbl_num1.TabIndex = 12;
            this.lbl_num1.Text = "1st Number";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(360, 142);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(80, 16);
            this.lbl_num2.TabIndex = 13;
            this.lbl_num2.Text = "2nd Number";
            // 
            // FrmOdev06_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(666, 348);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_exp);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmOdev06_04";
            this.Text = "Odev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
    }
}

