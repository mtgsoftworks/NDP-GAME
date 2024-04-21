using System.Windows.Forms;

namespace NDP_GAME
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gecen_sure_label = new System.Windows.Forms.Label();
            this.kalan_can_label = new System.Windows.Forms.Label();
            this.Puan_label = new System.Windows.Forms.Label();
            this.Seviye_label = new System.Windows.Forms.Label();
            this.oyuncu_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.oyuncu_label);
            this.panel1.Controls.Add(this.Seviye_label);
            this.panel1.Controls.Add(this.Puan_label);
            this.panel1.Controls.Add(this.kalan_can_label);
            this.panel1.Controls.Add(this.gecen_sure_label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 101);
            this.panel1.TabIndex = 0;
            // 
            // gecen_sure_label
            // 
            this.gecen_sure_label.AutoSize = true;
            this.gecen_sure_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gecen_sure_label.Location = new System.Drawing.Point(25, 30);
            this.gecen_sure_label.Name = "gecen_sure_label";
            this.gecen_sure_label.Size = new System.Drawing.Size(194, 29);
            this.gecen_sure_label.TabIndex = 0;
            this.gecen_sure_label.Text = "Geçen Süre (sn):";
            // 
            // kalan_can_label
            // 
            this.kalan_can_label.AutoSize = true;
            this.kalan_can_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalan_can_label.Location = new System.Drawing.Point(291, 30);
            this.kalan_can_label.Name = "kalan_can_label";
            this.kalan_can_label.Size = new System.Drawing.Size(129, 29);
            this.kalan_can_label.TabIndex = 1;
            this.kalan_can_label.Text = "Kalan Can:";
            // 
            // Puan_label
            // 
            this.Puan_label.AutoSize = true;
            this.Puan_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puan_label.Location = new System.Drawing.Point(528, 30);
            this.Puan_label.Name = "Puan_label";
            this.Puan_label.Size = new System.Drawing.Size(74, 29);
            this.Puan_label.TabIndex = 2;
            this.Puan_label.Text = "Puan:";
            // 
            // Seviye_label
            // 
            this.Seviye_label.AutoSize = true;
            this.Seviye_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seviye_label.Location = new System.Drawing.Point(754, 30);
            this.Seviye_label.Name = "Seviye_label";
            this.Seviye_label.Size = new System.Drawing.Size(91, 29);
            this.Seviye_label.TabIndex = 3;
            this.Seviye_label.Text = "Seviye:";
            // 
            // oyuncu_label
            // 
            this.oyuncu_label.AutoSize = true;
            this.oyuncu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyuncu_label.Location = new System.Drawing.Point(987, 30);
            this.oyuncu_label.Name = "oyuncu_label";
            this.oyuncu_label.Size = new System.Drawing.Size(100, 29);
            this.oyuncu_label.TabIndex = 4;
            this.oyuncu_label.Text = "Oyuncu:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(243, 194);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(994, 314);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 565);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Seviye_label;
        private Label Puan_label;
        private Label kalan_can_label;
        private Label gecen_sure_label;
        private Label oyuncu_label;
        private Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

