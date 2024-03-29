﻿using Chiton;

var map = new CavernMap("input.txt");

Console.WriteLine(
    $"The lowest risk path from the top left to the bottom right has a risk level of: {map.LowestRisk()}");

map = new CavernMap("input.txt", 5);

Console.WriteLine(
    $"The lowest risk path from the top left to the bottom right has a risk level of: {map.LowestRisk()}");
