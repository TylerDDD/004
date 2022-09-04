// Задача номер 29 -----------------------------------------

int[] GetBinaryArray (int size)
{
int[] array = new int [size]; 
for (int i = 0; i < array.Length; i++)
{ 
     array[i] = new Random().Next(1000);
}
     return array;


}
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] resultArray = GetBinaryArray(sizeArray);
Console.WriteLine($"Результат: [ {string.Join(";", resultArray)}]"); 


// Задача номер 27 ------------------------------------------

/* Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber); */

// Задача номер 25 ------------------------------------------

/* int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);  */


