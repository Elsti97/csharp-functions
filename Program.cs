Console.Write("Quanti numeri vuoi inserire? ");
int input = Convert.ToInt32(Console.ReadLine() ?? "");

// Array vari e funzione stampa riutilizzata
int[] numeri = new int[input];
for (int i = 0; i < input; i++)
{
    Console.Write("Inserisci numero: ");
    numeri[i] = Convert.ToInt32(Console.ReadLine() ?? "");
}

Console.Write("Array originale: ");
printArray(numeri);

int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
Console.Write("Array al quadrato: ");
printArray(numeriAlQuadrato);

Console.Write("Prova dell'array originale non modificato: ");
printArray(numeri);

int somma = sommaElementiArray(numeri);
Console.WriteLine("La somma è: " + somma);

int sommaQuadrato = sommaElementiArray(numeriAlQuadrato);
Console.WriteLine("La somma dei quadrati è: " + sommaQuadrato);
Console.WriteLine();



// Funzione stampa array
void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

// Funzione calcolo quadrato
int Quadrato(int numeroSingolo)
{
    return numeroSingolo * numeroSingolo;
}

// Funzione Array in stringa
string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

// Funzione elevazione al quadrato di array clonato
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int[] risultato = new int[copiaArray.Length];
    for (int i = 0; i < copiaArray.Length; i++)
    {
        risultato[i] = Quadrato(copiaArray[i]);
    }
    return risultato;
}

// Funzione somma di un array
int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}


// BONUS BONUS

int[] extraArray = {10, 11, 12, 15, 24, 34, 4, 5, 6};
int minimo = TrovaNumeroMinimo(extraArray);
Console.WriteLine("Il numero più piccolo nell'array extra è: " + minimo);

int minimo2 = TrovaMinimo(extraArray);
Console.WriteLine("Il numero più piccolo nell'array extra è (NO FOR): " + minimo2);

int TrovaNumeroMinimo(int[] array)
{

    int minimo = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimo)
        {
            minimo = array[i];
        }
    }

    return minimo;
}

int TrovaMinimo(int[] array)
{

    if (array.Length is 1)
    {
        return array[0];
    }
    else
    {
        int num1 = array[0];
        int num2 = TrovaMinimo(array.Skip(1).ToArray());

        return num1 < num2 ? num1 : num2;
    }

   

    
}
