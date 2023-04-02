using System;
using Ur10;

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

string trimmed = input.Trim();

string name = "Aleks";
string replaced = trimmed.Replace("%name%", name);

FileUtils.WriteStringToFile("profile.txt", replaced);

string contents = FileUtils.ReadStringFromFile("profile.txt");
Console.WriteLine(contents);

string template = FileUtils.ReadStringFromFile("template.txt");
string result = template.Replace("???", replaced);

FileUtils.WriteStringToFile("newFile.txt", result);

Console.WriteLine("Готово, я спать");