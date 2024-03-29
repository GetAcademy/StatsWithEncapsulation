﻿/*
 * 1: Objekt med begge variablene
 * 2: Trekke ut metoder og flytte inn i klassen
 * 3: Innkapsling
 * 4: Endre implementasjon
 */

using StatsWithEncapsulation;

var stats = new Stats();
while (true)
{
    Console.Write("Skriv et tall (eller blankt for å avslutte): ");
    var numberStr = Console.ReadLine();
    if(string.IsNullOrEmpty(numberStr))break;
    var number = Convert.ToInt32(numberStr);
    stats.AddNumber(number);
    Console.WriteLine(
        $"Antall tall: {stats.NumberCount} " +
        $"Sum: {stats.Sum} " +
        $"Snitt: {stats.Mean}");
}