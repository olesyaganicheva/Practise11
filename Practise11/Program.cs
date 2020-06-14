using System;

namespace Практика__Здание_11_836
{
    class Практика__Здание_11
    {
        //Один из простейших способов шифровки текста состоит в табличной замене каждого 
        //символа другим символом—его шифром.Выбрать некоторую таблицу, разработать способ
        ////ее представления, затем 
        //а) зашифровать данный текст; 
        //б) расшифровать данный текст.
        static void Main(string[] args)
        {
            char[,] polybiusSquare = {
                {'а', 'б', 'в', 'г', 'д', 'е', 'ё'},
                {'ж', 'з', 'и', 'й', 'к', 'л', 'м'},
                {'н', 'о', 'п', 'р', 'с', 'т', 'у'},
                {'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ'},
                {'ы', 'ь', 'э', 'ю', 'я', '0', '1'},
                {'2','3', '4', '5', '6', '7', '8'},
                {'9', ' ', ',', '.', '!', '?', ';'}
            };


            Console.Write("Введите сообщение рускими буквами для шифровки: ");
            string encryption = Console.ReadLine();
            string newString = "";
            string decryption = "";



            for (int i = 0; i < encryption.Length; i++)
            {
                for (int j = 0; j < polybiusSquare.GetLength(0); j++)
                {
                    for (int k = 0; k < polybiusSquare.GetLength(1); k++)
                    {
                        if (Char.ToLower(polybiusSquare[j, k]) == encryption[i] || Char.ToUpper(polybiusSquare[j, k]) == encryption[i])
                        {
                            newString += (Convert.ToString(j + 1) + Convert.ToString(k + 1) + " ");
                            decryption += (Convert.ToString(j) + Convert.ToString(k));
                            break;
                        }
                    }
                }

            }
            Console.WriteLine("Зашифрованный текст: " + newString);


            string new_message1 = "";
            for (int a = 0; a < decryption.Length; a += 2)
            {
                new_message1 += polybiusSquare[Convert.ToInt32(decryption[a].ToString()), Convert.ToInt32(decryption[a + 1].ToString())];
            }

            Console.WriteLine("Расшифрованный текст: " + new_message1);

            Console.ReadKey();
        }
    }
}
