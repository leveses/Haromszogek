namespace Haromszogek
{
    partial class frm_fo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_a_oldal = new System.Windows.Forms.TextBox();
            this.tb_c_oldal = new System.Windows.Forms.TextBox();
            this.tb_b_oldal = new System.Windows.Forms.TextBox();
            this.btn_kilepes = new System.Windows.Forms.Button();
            this.btn_szamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Háromszög oldalai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "C:";
            // 
            // tb_a_oldal
            // 
            this.tb_a_oldal.Location = new System.Drawing.Point(55, 59);
            this.tb_a_oldal.Name = "tb_a_oldal";
            this.tb_a_oldal.Size = new System.Drawing.Size(100, 29);
            this.tb_a_oldal.TabIndex = 4;
            // 
            // tb_c_oldal
            // 
            this.tb_c_oldal.Location = new System.Drawing.Point(55, 145);
            this.tb_c_oldal.Name = "tb_c_oldal";
            this.tb_c_oldal.Size = new System.Drawing.Size(100, 29);
            this.tb_c_oldal.TabIndex = 5;
            // 
            // tb_b_oldal
            // 
            this.tb_b_oldal.Location = new System.Drawing.Point(55, 101);
            this.tb_b_oldal.Name = "tb_b_oldal";
            this.tb_b_oldal.Size = new System.Drawing.Size(100, 29);
            this.tb_b_oldal.TabIndex = 6;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilepes.Location = new System.Drawing.Point(159, 226);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 7;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.btn_kilepes_Click);
            // 
            // btn_szamol
            // 
            this.btn_szamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_szamol.Location = new System.Drawing.Point(272, 59);
            this.btn_szamol.Name = "btn_szamol";
            this.btn_szamol.Size = new System.Drawing.Size(75, 23);
            this.btn_szamol.TabIndex = 8;
            this.btn_szamol.Text = "Számolás";
            this.btn_szamol.UseVisualStyleBackColor = true;
            this.btn_szamol.Click += new System.EventHandler(this.btn_szamol_Click);
            // 
            // frm_fo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_szamol);
            this.Controls.Add(this.btn_kilepes);
            this.Controls.Add(this.tb_b_oldal);
            this.Controls.Add(this.tb_c_oldal);
            this.Controls.Add(this.tb_a_oldal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_fo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Háromszög";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_a_oldal;
        private System.Windows.Forms.TextBox tb_c_oldal;
        private System.Windows.Forms.TextBox tb_b_oldal;
        private System.Windows.Forms.Button btn_kilepes;
        private System.Windows.Forms.Button btn_szamol;
    }
}

