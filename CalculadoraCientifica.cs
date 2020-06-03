namespace Aula09Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {

        private string[] valores;
        private float val {get;set;}
        private float soma;
        public void CalcularMedia(string txtConsole){

            valores = txtConsole.Split(",");

            for (int i = 0; i < valores.Length; i++)
            {
                val = float.Parse(valores[i]);
                soma+= val;
            }
            
            resultado = soma / valores.Length;
        }

        public void ManipularCalculos(string entradaUsuario){
            string[] entrada = entradaUsuario.Split(' ');

            num1=float.Parse (entrada[0]);
            operador = entrada[1];
            num2 = float.Parse(entrada[2]);

            switch (operador)
            {
                default:
                Somar();
                break;

                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "x":
                Multiplicar();
                break;

                case "/":
                Dividir();
                break;
            }
        }
    }
}