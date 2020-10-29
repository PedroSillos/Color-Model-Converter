namespace Color_Model_Converter
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
            this.picBox_yqi1 = new System.Windows.Forms.PictureBox();
            this.picBox_rgb2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_rgb1_para_yig = new System.Windows.Forms.Button();
            this.btn_yig_para_rgb2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_yqi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_rgb1
            // 
            this.picBox_rgb1.Location = new System.Drawing.Point(136, 32);
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
            // picBox_yqi1
            // 
            this.picBox_yqi1.Location = new System.Drawing.Point(502, 32);
            this.picBox_yqi1.Name = "picBox_yqi1";
            this.picBox_yqi1.Size = new System.Drawing.Size(360, 360);
            this.picBox_yqi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_yqi1.TabIndex = 3;
            this.picBox_yqi1.TabStop = false;
            // 
            // picBox_rgb2
            // 
            this.picBox_rgb2.Location = new System.Drawing.Point(868, 32);
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
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "RGB 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(668, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "YIQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1027, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "RGB 2";
            // 
            // btn_rgb1_para_yig
            // 
            this.btn_rgb1_para_yig.AutoSize = true;
            this.btn_rgb1_para_yig.Location = new System.Drawing.Point(442, 398);
            this.btn_rgb1_para_yig.Name = "btn_rgb1_para_yig";
            this.btn_rgb1_para_yig.Size = new System.Drawing.Size(116, 27);
            this.btn_rgb1_para_yig.TabIndex = 8;
            this.btn_rgb1_para_yig.TabStop = false;
            this.btn_rgb1_para_yig.Text = "RGB1 para YIG";
            this.btn_rgb1_para_yig.UseVisualStyleBackColor = true;
            this.btn_rgb1_para_yig.Click += new System.EventHandler(this.btn_rgb1_para_yig_Click);
            // 
            // btn_yig_para_rgb2
            // 
            this.btn_yig_para_rgb2.AutoSize = true;
            this.btn_yig_para_rgb2.Location = new System.Drawing.Point(809, 398);
            this.btn_yig_para_rgb2.Name = "btn_yig_para_rgb2";
            this.btn_yig_para_rgb2.Size = new System.Drawing.Size(116, 27);
            this.btn_yig_para_rgb2.TabIndex = 9;
            this.btn_yig_para_rgb2.TabStop = false;
            this.btn_yig_para_rgb2.Text = "YIG para RGB2";
            this.btn_yig_para_rgb2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 514);
            this.Controls.Add(this.btn_yig_para_rgb2);
            this.Controls.Add(this.btn_rgb1_para_yig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_rgb2);
            this.Controls.Add(this.picBox_yqi1);
            this.Controls.Add(this.btn_buscar_imagem);
            this.Controls.Add(this.picBox_rgb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_yqi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_rgb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_rgb1;
        private System.Windows.Forms.Button btn_buscar_imagem;
        private System.Windows.Forms.PictureBox picBox_yqi1;
        private System.Windows.Forms.PictureBox picBox_rgb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_rgb1_para_yig;
        private System.Windows.Forms.Button btn_yig_para_rgb2;
    }
}

