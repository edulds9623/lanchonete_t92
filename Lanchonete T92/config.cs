/*
 *  na POO existem 04 pilares:
 *  
 *      -Encapsulamento
 *      -proteção dos dados na aplicação (acesso)
 *      -private é visivel apenas na classe (arquivo)
 *      -public é visivel de qualquer forma 
 *      
 *      
 *      
 *      -Abstração
 *      -Herança
 *      -Polimorfismo
 * 
 * 
 * Classe static que armazena as configurações da aplicação.
 *          -cores
 *          -fontes
 *          -credenciais BD
 *          
 *          
 *         Classes no C#
 *              Exixtem:
 *                  -classes "normais" - para usá la precisa de um objeto 
 *                  -classes static - não precisam de objetos (nome seguro)
 *                  
 *                 no C# tudo é private (privado).
 *      
 */


using System.Windows.Forms;

namespace Lanchonete_T92
{

    public class Config
    {
        //Atributos - váriaveis da classe é visivel de qualquer membro da classe



        // armazena o tema atual 0 claro / 1 escuro
        public static int tema = 0;



        // ler o tamanho do monitor do usuário
        public static int[] tamanhoTela =
            { Screen.PrimaryScreen.Bounds.Width,
            Screen.PrimaryScreen.Bounds.Height };
    }

}