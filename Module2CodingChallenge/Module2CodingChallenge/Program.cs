using Module2CodingChallenge;

// Create a new Polygon object and a new Square object
Polygon polygon = new Polygon(3); // A triangle
Polygon pentagon = new Polygon(5); // A pentagon
Polygon hexagon = new Polygon(6); // A hexagon
Square square = new Square(4.5f); // A square
Triangle triangle = new Triangle(3.5f); // A triangle

//Create a new Player with one life and add points to the player's score
Player player = new Player("Frankenstein", 1, 20);
player.AddPoints(100);

//Display the player's score
Console.WriteLine("Welcome to the game!\nYour score is " + player.GetScore() + "\nYou have " + player.healthLeft + " health left\n" + player.GetLivesLeft() + " lives left!");

//Kill off the player's character
player.Kill();

//Let the player know their character was killed
Console.WriteLine("An orc attacked you. Sorry, you were killed. You have "
    + player.GetLivesLeft() + " lives left!");
