/*
 Classe que aplica as alterações, chamadas e controles da tela de login (Loginview)


    *.Width/ *.Height - Dimensões do elemento
    *
    *PROPRIEDADES / ATRIBUTOS / VARIÁVEIS / PARAMETROS
    *-PROPRIEDADE/ATRIBUTO -está dentro da classe
    *-VARIAVEL dentro do método/função
    *-parâmetro dentro do parentese
    *
    *Convert. - Método de conversão de tipo de dados de classe system
    *   ToInt32() - converte para inteiros 
    *   ToFloat() - converte para decimal float
    *   Tobool() - converte para lógico
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lanchonete_T92
{
    public class LoginController
    {
        private Form form;

        //Método Construtor - é executado automaticamente ao criar um objeto de classe
        public LoginController(Form form)

        {

            //envia o form para o atributo da classe
            this.form = form;

            TamanhoTela();

  
        }
        private void TamanhoTela()
        {
            // form.Width le o tamanho da tela
            // form.Width = 100 definido a largura da tela 
            form.Width = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f);
            form.Height = Convert.ToInt32(Config.tamanhoTela[0] * 0.6f * 0.56f);

            //tamanahio da imagem lateral 
            int largLateral = Convert.ToInt32(form.Width * 0.3f);
            int altLateral = Convert.ToInt32(largLateral * 1.53f);

            form.Controls.Find("imagemLateral", true)[0].Size = new Size(45, 40);
            form.Controls.Find("imagemLateral", true)[0].Size = new Size(largLateral, altLateral);
        }
    }
}