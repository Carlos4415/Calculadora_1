// Este programa implementa uma calculadora simples que solicita dois números e um operador (+, -, *, /).  
// Com base no operador fornecido, o programa realiza a operação correspondente e exibe o resultado.  
// Ele trata divisões por zero e entradas inválidas para garantir um funcionamento seguro.
double numero1 = 5;
double numero2 = 4;
char operacao = '+';
double resultado = 0;

switch (operacao)
{
    case '+':
        resultado = numero1 + numero2;
        break;
    case '-':
        resultado = numero1 - numero2;
        break;
    case '*':
        resultado = numero1 * numero2;
        break;
    case '/':
        resultado = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Operação inválida.");
        return;
}

Console.WriteLine($"Resultado da operação: {resultado}");