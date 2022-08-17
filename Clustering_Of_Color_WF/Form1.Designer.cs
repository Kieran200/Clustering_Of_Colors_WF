
namespace Clustering_Of_Color_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Ranging = new System.Windows.Forms.Button();
            this.Txb_Cluster = new System.Windows.Forms.TextBox();
            this.Txb_Object = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pbx_Ranging = new System.Windows.Forms.PictureBox();
            this.Txb_Red = new System.Windows.Forms.TextBox();
            this.Txb_Blue = new System.Windows.Forms.TextBox();
            this.Txb_Green = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Definition = new System.Windows.Forms.Button();
            this.Pbx_Definition = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Ranging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Definition)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Ranging
            // 
            this.Btn_Ranging.Location = new System.Drawing.Point(23, 146);
            this.Btn_Ranging.Name = "Btn_Ranging";
            this.Btn_Ranging.Size = new System.Drawing.Size(179, 29);
            this.Btn_Ranging.TabIndex = 0;
            this.Btn_Ranging.Text = "Ранжировать выборку";
            this.Btn_Ranging.UseVisualStyleBackColor = true;
            this.Btn_Ranging.Click += new System.EventHandler(this.Btn_Ranging_Click);
            // 
            // Txb_Cluster
            // 
            this.Txb_Cluster.Location = new System.Drawing.Point(143, 50);
            this.Txb_Cluster.Name = "Txb_Cluster";
            this.Txb_Cluster.Size = new System.Drawing.Size(125, 27);
            this.Txb_Cluster.TabIndex = 3;
            // 
            // Txb_Object
            // 
            this.Txb_Object.Location = new System.Drawing.Point(12, 50);
            this.Txb_Object.Name = "Txb_Object";
            this.Txb_Object.Size = new System.Drawing.Size(125, 27);
            this.Txb_Object.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите количество объектов и кластеров для выборки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(41, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Объекты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(171, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кластеры";
            // 
            // Pbx_Ranging
            // 
            this.Pbx_Ranging.Location = new System.Drawing.Point(416, 12);
            this.Pbx_Ranging.Name = "Pbx_Ranging";
            this.Pbx_Ranging.Size = new System.Drawing.Size(700, 700);
            this.Pbx_Ranging.TabIndex = 8;
            this.Pbx_Ranging.TabStop = false;
            // 
            // Txb_Red
            // 
            this.Txb_Red.Location = new System.Drawing.Point(79, 242);
            this.Txb_Red.Name = "Txb_Red";
            this.Txb_Red.Size = new System.Drawing.Size(125, 27);
            this.Txb_Red.TabIndex = 9;
            // 
            // Txb_Blue
            // 
            this.Txb_Blue.Location = new System.Drawing.Point(79, 327);
            this.Txb_Blue.Name = "Txb_Blue";
            this.Txb_Blue.Size = new System.Drawing.Size(125, 27);
            this.Txb_Blue.TabIndex = 10;
            // 
            // Txb_Green
            // 
            this.Txb_Green.Location = new System.Drawing.Point(79, 285);
            this.Txb_Green.Name = "Txb_Green";
            this.Txb_Green.Size = new System.Drawing.Size(125, 27);
            this.Txb_Green.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "red";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "blue";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Btn_Definition
            // 
            this.Btn_Definition.Location = new System.Drawing.Point(38, 380);
            this.Btn_Definition.Name = "Btn_Definition";
            this.Btn_Definition.Size = new System.Drawing.Size(144, 29);
            this.Btn_Definition.TabIndex = 15;
            this.Btn_Definition.Text = "определить цвет";
            this.Btn_Definition.UseVisualStyleBackColor = true;
            this.Btn_Definition.Click += new System.EventHandler(this.Btn_Definition_Click);
            // 
            // Pbx_Definition
            // 
            this.Pbx_Definition.Location = new System.Drawing.Point(31, 438);
            this.Pbx_Definition.Name = "Pbx_Definition";
            this.Pbx_Definition.Size = new System.Drawing.Size(353, 273);
            this.Pbx_Definition.TabIndex = 16;
            this.Pbx_Definition.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.Pbx_Definition);
            this.Controls.Add(this.Btn_Definition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txb_Green);
            this.Controls.Add(this.Txb_Blue);
            this.Controls.Add(this.Txb_Red);
            this.Controls.Add(this.Pbx_Ranging);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_Object);
            this.Controls.Add(this.Txb_Cluster);
            this.Controls.Add(this.Btn_Ranging);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Ranging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Definition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ranging;
        private System.Windows.Forms.TextBox Txb_Cluster;
        private System.Windows.Forms.TextBox Txb_Object;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Pbx_Ranging;
        private System.Windows.Forms.TextBox Txb_Red;
        private System.Windows.Forms.TextBox Txb_Blue;
        private System.Windows.Forms.TextBox Txb_Green;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Definition;
        private System.Windows.Forms.PictureBox Pbx_Definition;
    }
}

