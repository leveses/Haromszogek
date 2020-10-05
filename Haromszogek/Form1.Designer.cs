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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_haromszoglista = new System.Windows.Forms.ListBox();
            this.btn_torol = new System.Windows.Forms.Button();
            this.btn_fajlbol = new System.Windows.Forms.Button();
            this.ofd_megnyitas = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Háromszög oldalai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "C:";
            // 
            // tb_a_oldal
            // 
            this.tb_a_oldal.Location = new System.Drawing.Point(46, 46);
            this.tb_a_oldal.Name = "tb_a_oldal";
            this.tb_a_oldal.Size = new System.Drawing.Size(100, 29);
            this.tb_a_oldal.TabIndex = 4;
            // 
            // tb_c_oldal
            // 
            this.tb_c_oldal.Location = new System.Drawing.Point(46, 132);
            this.tb_c_oldal.Name = "tb_c_oldal";
            this.tb_c_oldal.Size = new System.Drawing.Size(100, 29);
            this.tb_c_oldal.TabIndex = 5;
            // 
            // tb_b_oldal
            // 
            this.tb_b_oldal.Location = new System.Drawing.Point(46, 88);
            this.tb_b_oldal.Name = "tb_b_oldal";
            this.tb_b_oldal.Size = new System.Drawing.Size(100, 29);
            this.tb_b_oldal.TabIndex = 6;
            // 
            // btn_kilepes
            // 
            this.btn_kilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilepes.Location = new System.Drawing.Point(333, 212);
            this.btn_kilepes.Name = "btn_kilepes";
            this.btn_kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_kilepes.TabIndex = 7;
            this.btn_kilepes.Text = "Kilépés";
            this.btn_kilepes.UseVisualStyleBackColor = true;
            this.btn_kilepes.Click += new System.EventHandler(this.btn_kilepes_Click);
            // 
            // btn_szamol
            // 
            this.btn_szamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_szamol.Location = new System.Drawing.Point(232, 84);
            this.btn_szamol.Name = "btn_szamol";
            this.btn_szamol.Size = new System.Drawing.Size(89, 40);
            this.btn_szamol.TabIndex = 8;
            this.btn_szamol.Text = "Számolás";
            this.btn_szamol.UseVisualStyleBackColor = true;
            this.btn_szamol.Click += new System.EventHandler(this.btn_szamol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.btn_szamol);
            this.panel1.Controls.Add(this.tb_b_oldal);
            this.panel1.Controls.Add(this.tb_c_oldal);
            this.panel1.Controls.Add(this.tb_a_oldal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 174);
            this.panel1.TabIndex = 9;
            // 
            // lb_haromszoglista
            // 
            this.lb_haromszoglista.FormattingEnabled = true;
            this.lb_haromszoglista.ItemHeight = 24;
            this.lb_haromszoglista.Location = new System.Drawing.Point(402, 13);
            this.lb_haromszoglista.Name = "lb_haromszoglista";
            this.lb_haromszoglista.Size = new System.Drawing.Size(391, 172);
            this.lb_haromszoglista.TabIndex = 10;
            this.lb_haromszoglista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_torol
            // 
            this.btn_torol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_torol.Location = new System.Drawing.Point(611, 212);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(75, 23);
            this.btn_torol.TabIndex = 11;
            this.btn_torol.Text = "Törlés";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // btn_fajlbol
            // 
            this.btn_fajlbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_fajlbol.Location = new System.Drawing.Point(55, 212);
            this.btn_fajlbol.Name = "btn_fajlbol";
            this.btn_fajlbol.Size = new System.Drawing.Size(75, 23);
            this.btn_fajlbol.TabIndex = 9;
            this.btn_fajlbol.Text = "Beolvasás";
            this.btn_fajlbol.UseVisualStyleBackColor = true;
            this.btn_fajlbol.Click += new System.EventHandler(this.btn_fajlbol_Click);
            // 
            // ofd_megnyitas
            // 
            this.ofd_megnyitas.FileName = "openFileDialog1";
            this.ofd_megnyitas.Filter = "TextFiles|*txt";
            this.ofd_megnyitas.InitialDirectory = "C:\\Users\\c16bodaz\\source\\repos\\Haromszogek\\Haromszogek\\bin\\Debug";
            // 
            // frm_fo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 261);
            this.Controls.Add(this.btn_fajlbol);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.lb_haromszoglista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_kilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_fo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Háromszög";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lb_haromszoglista;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_fajlbol;
        private System.Windows.Forms.OpenFileDialog ofd_megnyitas;
    }
}

