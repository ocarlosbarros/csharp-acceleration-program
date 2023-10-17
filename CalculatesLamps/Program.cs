/*  Escreva um algoritmo para calcular e exibir o número de lâmpadas 
    necessárias para iluminar determinado cômodo de uma residência.

    Entrada de dados: a potência da lâmpada utilizada (em watts) 
    e as dimensões (largura e comprimento, em metros) do cômodo.
    OBS: Considere que a potência necessária é de 18 watts por metro quadrado.

    Processamento:
    1. Calcula quantos metros quadrados possui o cômodo multiplicando width por length.
    2. Calcula o quociente X dividindo a potência da lâmpada que será utilizada por 18, quantidade necessária para iluminar 1 metro quadrado.
    3. Calcula a quantidade de lâmpadas necessárias dividindo o total de metros quadrados do cômodo pelo quociente X.

    Saída de Dados: Uma mensagem coerente e bem formatada deve ser exibida 
    na tela do Console para a pessoa que utiliza o programa e forneceu 
    os dados de entrada.
    */

Console.WriteLine("Bem Vindo(a) ao programa: Calcula  Lâmpada");
Console.WriteLine("Informe o nome do cômodo: ");
string convenient = Console.ReadLine() ?? throw new ArgumentException("Convenient cannot be null");

Console.WriteLine("Informe em metros a largura deste cômodo: ");
decimal width = decimal.Parse(Console.ReadLine() ?? throw new ArgumentException("Width cannot be null"));

Console.WriteLine("Informe em metros o comprimento deste cômodo ");
decimal length = decimal.Parse(Console.ReadLine() ?? throw new ArgumentException("Length cannot be null"));

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada");
int power = int.Parse(Console.ReadLine() ?? throw new ArgumentException("Power cannot be null"));

decimal squareMeter = width * length;
decimal quotienX = power / 18M;
decimal totalLightBulbs = squareMeter/ quotienX;

Console.WriteLine($"Para iluminar o cômodo: {convenient} com {squareMeter.ToString("N2")} metros quadrados será necessário a instalação de {totalLightBulbs.ToString("N2")} lâmpada(s)");