/*  
    1- Mostrar o valor total (fixo)
    2- Pedir para digital o número de parcelas
    3- Informar o valor da parcela
    */

const double TOTAL_VALUE = 152.60;
Console.WriteLine($"O valor total é de: R$ {TOTAL_VALUE}");
Console.WriteLine("Informe o número de parcelas");
string? installments = Console.ReadLine();
int installmentsConverted = Convert.ToInt32(installments);
Console.WriteLine($"Você informou {installmentsConverted} parcela(s)");
double installmentAmount = TOTAL_VALUE / installmentsConverted;
Console.WriteLine($"O valor da parcela é de: R$ {installmentAmount.ToString("N2")}");