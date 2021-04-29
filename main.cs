using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

		// Creating a deck of cards that deals out a certain amount
		// Then asks how many you would like to draw

		// Created a deck object that can hold the 
		Deck newDeck = new Deck();

		newDeck.CreateDeck();

		Deck.ShuffleDeck(newDeck.DrawDeck);

		Deck.ShowDeck(newDeck.DrawDeck).PrintToConsole();

    Console.ReadLine();
  }
}
// ----Classes----

public static class UIHelper
{
	public static void PrintToConsole(this string message)
	{
		Console.WriteLine(message);
	}

	public static void PrintHandToConsole(this string message)
	{
		Console.WriteLine($"Hand: { message }");
	}
}

public static class GameLogic
{
	

	
}

public class Deck : CardModel
{
// Properties
	//public List<Card> DealDeck { get; set; } = new List<Card>();
	public List<CardModel> DrawDeck { get; set; } = new List<CardModel>();
	public List<CardModel> DiscardDeck { get; set; } = new List<CardModel>();

// Methods
	public void CreateDeck()
	{
		for (var i = 0; i < 4; i++)
		{
			for (var j = 0; j < 13; j++)
			{
				DrawDeck.Add(new CardModel { Suit = (CardSuit)i, Value = (CardValue)j });
			}
		}
	}

	public static void ShuffleDeck(List<CardModel> list)
	{
		Random random = new Random();

		for (int i = list.Count - 1; i > 1; i--)
		{
			int rnd = random.Next(i + 1);

			CardModel value = list[rnd];
			list[rnd] = list[i];
			list[i] = value;
			list.Add(value);
		}
	}

	public static string ShowDeck(List<CardModel> list)
	{
		string output = "";

		foreach (var card in list)
		{
			output += $"{ card.Value } of { card.Suit }\n";
		}

		return output;
	}

	public void DealCards()
	{

	}
}




