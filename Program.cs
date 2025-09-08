// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using HeyRed.Mime;

namespace GetMime
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine($"Usage: GetMime.exe <path-to-file>");
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"File not found: {args[0]}");
                return;
            }
            
            var result = MimeGuesser.GuessMimeType(args[0]);
            Console.WriteLine("Guessed mime type : " + result);
            return;
        }
    }
}