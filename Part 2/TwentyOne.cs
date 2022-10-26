using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		
		Deck deck = new Deck();
		deck = Shuffle(deck);
		
		foreach (Card card in deck.Cards)
		{
		 Console.WriteLine(card.Face + " of " + card.Suit);
		}
		Console.WriteLine(deck.Cards.Count);
}
	
	public static Deck Shuffle(Deck deck)
	{
	   List<Card> tempList = new List<Card>();
		Random random = new Random();
		
		while (deck.Cards.Count > 0)
		{
		 int randomIndex = random.Next(0, deck.Cards.Count);
			tempList.Add(deck.Cards[randomIndex]);
			deck.Cards.RemoveAt(randomIndex);
		}
		deck.Cards = tempList;
		return deck;
	   
	}
}


public class Card
{
    public Card()
	{
		Suit = "Spades";
		Face = "Two";
	}
	public string Suit { get; set; } // property of data type string called 'suit', you can get or set this
    public string Face { get; set; }
}

public class Deck
{
	public Deck()
	{
	    Cards = new List<Card>(); //create card list
		List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //create suit list
		List<string> Faces = new List<string>() //create face list
		{
			"two", "Three", "Four", "Five", "Six", "Seven", 
			"Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
		};
		
		foreach (string face in Faces) //for each item in faces, we loop through 4 times
		{
			foreach (string suit in Suits) //during each loop we create a card and assign a suit and face
			{
			    Card card = new Card();
				card.Suit = suit;
				card.Face = face;
				Cards.Add(card); //card gets added to Card list
				
			}
	}
		
	}
	public List<Card> Cards { get; set; }
}