
namespace WFA_11_11_2021_Sinema_Otomasyonu
{
    partial class Form3
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
            this.listViewIzleyiler = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErkekIzleyiciSayisi = new System.Windows.Forms.Label();
            this.lblBayanIzleyiciSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamIzleyiciSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewIzleyiler
            // 
            this.listViewIzleyiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewIzleyiler.HideSelection = false;
            this.listViewIzleyiler.Location = new System.Drawing.Point(0, 29);
            this.listViewIzleyiler.Name = "listViewIzleyiler";
            this.listViewIzleyiler.Size = new System.Drawing.Size(800, 421);
            this.listViewIzleyiler.TabIndex = 4;
            this.listViewIzleyiler.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErkekIzleyiciSayisi);
            this.panel1.Controls.Add(this.lblBayanIzleyiciSayisi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblToplamIzleyiciSayisi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 3;
            // 
            // lblErkekIzleyiciSayisi
            // 
            this.lblErkekIzleyiciSayisi.AutoSize = true;
            this.lblErkekIzleyiciSayisi.Location = new System.Drawing.Point(622, 9);
            this.lblErkekIzleyiciSayisi.Name = "lblErkekIzleyiciSayisi";
            this.lblErkekIzleyiciSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblErkekIzleyiciSayisi.TabIndex = 5;
            this.lblErkekIzleyiciSayisi.Text = "label5";
            // 
            // lblBayanIzleyiciSayisi
            // 
            this.lblBayanIzleyiciSayisi.AutoSize = true;
            this.lblBayanIzleyiciSayisi.Location = new System.Drawing.Point(393, 9);
            this.lblBayanIzleyiciSayisi.Name = "lblBayanIzleyiciSayisi";
            this.lblBayanIzleyiciSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblBayanIzleyiciSayisi.TabIndex = 4;
            this.lblBayanIzleyiciSayisi.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(492, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Erkek İzleyici Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bayan İzleyici Sayısı:";
            // 
            // lblToplamIzleyiciSayisi
            // 
            this.lblToplamIzleyiciSayisi.AutoSize = true;
            this.lblToplamIzleyiciSayisi.Location = new System.Drawing.Point(150, 9);
            this.lblToplamIzleyiciSayisi.Name = "lblToplamIzleyiciSayisi";
            this.lblToplamIzleyiciSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblToplamIzleyiciSayisi.TabIndex = 1;
            this.lblToplamIzleyiciSayisi.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam İzleyici Sayısı:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewIzleyiler);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewIzleyiler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErkekIzleyiciSayisi;
        private System.Windows.Forms.Label lblBayanIzleyiciSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamIzleyiciSayisi;
        private System.Windows.Forms.Label label1;
    }
}