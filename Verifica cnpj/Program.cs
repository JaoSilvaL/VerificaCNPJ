//UM CNPJ MESMO QUE PASSE PELA VERIFICAÇÃO, NÃO SIGNIFICA QUE ELE EXISTA, ESSE COD É SOMENTE PARA VERIFICAR SE ELE PODE SER CONSIDERADO "FUNCIONAL".
//EXPLOSÃO DE FOFURA A SEGUIR #FOFOKWAI
//cute UwU
int soma = 0;
int soma2 = 0;
string cnpj0;
int verifica1;
int verifica2;
bool repeticao=false;

Console.Write("INSIRA O CNPJ PARA SER VERIFICADO...:");
cnpj0 = Console.ReadLine();

string cnpj = cnpj0.Replace(".", "").Replace("/", "").Replace("-", "");

for (int i = 0; i < cnpj.Length; i++)
{
    if (cnpj[i] == i) { repeticao = true; }
}

int cnpjV1= Convert.ToInt32(cnpj[12].ToString());
int cnpjV2 = Convert.ToInt32(cnpj[13].ToString());
//A PARTIR DAQUI FICA FEIO, NÃO CUTE :(
int[] mult1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
int[] mult2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

for (int i =0; i <12; i++)
{
    soma += Convert.ToInt32(cnpj[i].ToString()) * mult1[i];
}

int resto = soma % 11;
if (resto < 2) { verifica1 = 0; }
else { verifica1 =11-resto; }
for (int i =0; i <13; i++)

{
    soma2 += Convert.ToInt32(cnpj[i].ToString()) * mult2[i];
}

int resto2= soma2 % 11;
if (resto2 < 2) { verifica2 = 0; }
else { verifica2 = 11 - resto2; }

//PARTE MAIS CUTI CUTI DO CODIGO

if(repeticao== true || cnpj =="00000000000000"|| cnpj.Length != 14) 
{    Console.WriteLine("CNPJ INVALIDO");
}
else
{
    if (verifica1 == cnpjV1 && verifica2 == cnpjV2)
    {
        Console.WriteLine("CNPJ VALIDO");
    }
    else
    {
        Console.WriteLine("CNPJ INVALIDO");
    }
}
