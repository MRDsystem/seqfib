// See https://aka.ms/new-console-template for more information

int numeroProcurado = 8; 
int numeroAnterior = 0;
int numeroCorrente = 1;
string mensagemResultado;

while (numeroCorrente < numeroProcurado)
{
    int proximoNumero = numeroAnterior + numeroCorrente;
    numeroAnterior = numeroCorrente;
    numeroCorrente = proximoNumero;
}

if(numeroCorrente == numeroProcurado)
{
    mensagemResultado = $"O número {numeroProcurado} pertence à sequência de Fibonacci.";
}
else
{
    mensagemResultado = $"O número {numeroProcurado} não pertence à sequência de Fibonacci.";
}

Console.WriteLine(mensagemResultado);
