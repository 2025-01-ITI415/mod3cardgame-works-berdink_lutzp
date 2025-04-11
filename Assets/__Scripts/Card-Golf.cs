using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGolf : Card
{
    public int id;
    public int rank;
    public int suit;
    public bool isFaceUp = false;

    // Constructor
    public CardGolf(int id, int rank, int suit)
    {
        this.id = id;
        this.rank = rank;
        this.suit = suit;
    }

    // Method to flip the card
    public void Flip()
    {
        isFaceUp = !isFaceUp;
    }
}
