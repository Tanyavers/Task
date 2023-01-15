// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
string[] initArr = new string[] {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Denmark"};
string[] result = new string[initArr.Length];
int resLen = 0;
for (int i = 0; i < initArr.Length - 1; i++){
    if(initArr[i].Length <= 3){
        result[resLen++] = initArr[i];
    }
}

Array.Resize(ref result, resLen);
Console.Write(String.Join(", ", result));
