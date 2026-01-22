// Step 1: Ask player for name (and remember it)
Console.WriteLine("Hello there traveller, what is your name?");
string playerName = Console.ReadLine();

// Step 2: Ask player for sum of held gold (currency)
Console.WriteLine("How much gold do you have on you, traveller?");
string heldGold = Console.ReadLine();

// Step 3+: Tell player about sword, do they wish to purchase?
Console.WriteLine("I have a 'bronze sword' for sale for 15 gold coins.");
Console.WriteLine("Do you wish to purchase it?");
string doPurchaseSword = Console.ReadLine();
if (doPurchaseSword == "yes")
{
    // 3a buy sword
    if (/* has enough gold */)
    {
        // deduct cost
        // inform player of remaining gold
    }
    else
    {
        // not enough gold
    }
}
else
{
    Console.WriteLine($"Farewell on your travels, {playerName}.");
}
// Test our variables for our own sanity
//Console.WriteLine("Name: " + playerName + ", Gold: " + heldGold);
//Console.WriteLine($"Name: {playerName}, Gold: {heldGold}.");