﻿namespace Color_Model_Converter
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
            this.picBox_rgb1 = new System.Windows.Forms.PictureBox();
            this.btn_buscar_imagem = new System.Windows.Forms.Button();
            this.picBox_rgb2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rgb1_para_yiq_para_rgb2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_rgb1
            // 
            this.picBox_rgb1.Location = new System.Drawing.Point(140, 45);
            this.picBox_rgb1.Name = "picBox_rgb1";
            this.picBox_rgb1.Size = new System.Drawing.Size(360, 360);
            this.picBox_rgb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_rgb1.TabIndex = 0;
            this.picBox_rgb1.TabStop = false;
            // 
            // btn_buscar_imagem
            // 
            this.btn_buscar_imagem.AutoSize = true;
            this.btn_buscar_imagem.Location = new System.Drawing.Point(12, 12);
            this.btn_buscar_imagem.Name = "btn_buscar_imagem";
            this.btn_buscar_imagem.Size = new System.Drawing.Size(115, 27);
            this.btn_buscar_imagem.TabIndex = 2;
            this.btn_buscar_imagem.TabStop = false;
            this.btn_buscar_imagem.Text = "Buscar imagem";
            this.btn_buscar_imagem.UseVisualStyleBackColor = true;
            this.btn_buscar_imagem.Click += new System.EventHandler(this.btn_buscar_imagem_Click);
            // 
            // picBox_rgb2
            // 
            this.picBox_rgb2.Location = new System.Drawing.Point(506, 45);
            this.picBox_rgb2.Name = "picBox_rgb2";
            this.picBox_rgb2.Size = new System.Drawing.Size(360, 360);
            this.picBox_rgb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_rgb2.TabIndex = 4;
            this.picBox_rgb2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "RGB 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "RGB 2";
            // 
            // btn_rgb1_para_yiq_para_rgb2
            // 
            this.btn_rgb1_para_yiq_para_rgb2.AutoSize = true;
            this.btn_rgb1_para_yiq_para_rgb2.Location = new System.Drawing.Point(408, 12);
            this.btn_rgb1_para_yiq_para_rgb2.Name = "btn_rgb1_para_yiq_para_rgb2";
            this.btn_rgb1_para_yiq_para_rgb2.Size = new System.Drawing.Size(191, 27);
            this.btn_rgb1_para_yiq_para_rgb2.TabIndex = 8;
            this.btn_rgb1_para_yiq_para_rgb2.TabStop = false;
            this.btn_rgb1_para_yiq_para_rgb2.Text = "RGB1 para YIQ para RGB2";
            this.btn_rgb1_para_yiq_para_rgb2.UseVisualStyleBackColor = true;
            this.btn_rgb1_para_yiq_para_rgb2.Click += new System.EventHandler(this.btn_rgb1_para_yiq_para_rgb2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 438);
            this.Controls.Add(this.btn_rgb1_para_yiq_para_rgb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_rgb2);
            this.Controls.Add(this.btn_buscar_imagem);
            this.Controls.Add(this.picBox_rgb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_rgb1;
        private System.Windows.Forms.Button btn_buscar_imagem;
        private System.Windows.Forms.PictureBox picBox_rgb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rgb1_para_yiq_para_rgb2;
    }
}

