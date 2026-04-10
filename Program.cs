﻿string fraseDigitada, fraseMemeToNervoso;
Console.Write("Voce que esta atras desta tela, oque achas de mim? ");
fraseDigitada = Console.ReadLine()!;

fraseMemeToNervoso =
    $"{fraseDigitada.Remove(10)}... NÃO, PERA.\nTô nervoso";

Console.WriteLine(fraseMemeToNervoso);