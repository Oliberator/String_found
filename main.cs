using System;
using System.Collections.Generic;

class MainClass {

 public static void Main (string[] args) {
   // Позволим пользователю ввести строку самостоятельно
    Console.Write("Введи какие-нибудь буковки: ");
    string userStr = Console.ReadLine();
    Console.WriteLine(Found(userStr));
  }

  static char Found(string str)
  {
    // Обращение к каждому символу в строке, удаление повторяющихся букв с помощью метода Replace(удалением это не совсем корректно называть, по сути элемент заменяется на пустое значение)
    while (str.IndexOf(str[0], 1) != -1) { 
      str = str.Replace(str[0].ToString(), ""); 
    }
    char result = str[0];
    return result; 
  }
}