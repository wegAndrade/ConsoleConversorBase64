﻿using System;


namespace ConsoleConversorBase64
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o caminho do arquivo para conversão:");
            string path = Console.ReadLine();
            byte[] arquivoByte = System.IO.File.ReadAllBytes(path);
            string arqbase64 = System.Convert.ToBase64String(arquivoByte);

            Console.WriteLine(arqbase64);
            System.Windows.Forms.Clipboard.SetText(arqbase64);

            Console.ReadLine();

        }
    }
}
