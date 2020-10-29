using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Model_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void limpar_Tela()
        {
            //zera a imagem, caso usem o botão dnv
            picBox_rgb1.Image = null;
            picBox_yqi1.Image = null;
            picBox_rgb2.Image = null;

            /*
            //zera o chat, caso usem o botão dnv
            chart_imagem_cortada.Series["Cortada"].Points.Clear();
            chart_imagem_alterada.Series["Cortada"].Points.Clear();
            */
        }

        private void btn_buscar_imagem_Click(object sender, EventArgs e)
        {
            //abre o open file dialog
            OpenFileDialog dialog_carregar_imagem = new OpenFileDialog();
            dialog_carregar_imagem.Filter = "Image |*.png;*.jpg;*.jpeg";
            if (dialog_carregar_imagem.ShowDialog() == DialogResult.OK)
            {
                limpar_Tela();
                Bitmap imagem_original = new Bitmap(dialog_carregar_imagem.FileName);
                picBox_rgb1.Image = imagem_original;
            }
            else
            {
                picBox_rgb1.Image = null;
            }
        }

        private void a()
        {
            int largura = picBox_rgb1.Image.Width;
            int altura = picBox_rgb1.Image.Height;
            Bitmap imagem_cortada = new Bitmap(largura, altura);
        }

        private void btn_rgb1_para_yig_Click(object sender, EventArgs e)
        {
            a();
        }
    }
}
