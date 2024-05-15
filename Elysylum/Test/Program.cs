Main();

static void Main()
{
    //Intro
    Console.Clear();
    Console.WriteLine("Hello, Welcome to Logan's funny RPG!"); 
    //Initialize
    Stat Player = new Stat();
    TextWall Wall = new TextWall();
    Random rnd = new Random();
    int startingItem = rnd.Next(1, 4); // creates a number between 1 and 3
    bool win = false;
    int day = 1;
    int curse = 0; //1 = Soaked, 2 = Sponged, 3 = Barren
    int enemy = 0; // 1 = Cinder Lizard (Immune to Fire) 2 = Tarp Tardigrade (Immune to Rain) 3 = Solitary Stag (Immune to Produce) 4 = Boss
    string[] dream1 = {"cows", "sheep", "spheres", "cuboids", "bugs", "dogs", "cats", "puppies", "kittens", "frogs", "rain", "cars"};
    string[] dream2 = {"sorrow", "flowers", "fields of grass", "tap water", "rivers", "pumpkins", "porcelain", "pizza dough", "other things", "cabinets", "houses", "highways"};
    Player.name = getPlayerName(); // Initializes playerName in Stats class with a method
    Wall.intro(Player.name);
    Wall.cellspacefirst();
    Player.statwall();
    //Game start
    string[] available = {"Rest", "Search cell", "Talk", "Break out"};
    string[] available2 = {"Fight", "Flee"};
    string choice = inputloop("What would you like to do?", available);
    string choice2 = "Catch";
    while (day < 12 && win == false) //game loop
    {
        if (choice.ToLower().Equals("rest"))
        {
            Wall.Rest(dream1[rnd.Next(0, 12)], dream2[rnd.Next(0, 12)]);
            ++day;
            Player.tired = false;
            Player.affliction = 0;
            startingItem = rnd.Next(1, 4);
            Console.WriteLine("It is now day " + day);
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadLine();
        }
        if (choice.ToLower().Equals("search cell"))
        {
            Console.WriteLine("You search around the cell, your cellmate gives you an affirming look.\n");
            if (startingItem == 0)
            {
                Console.WriteLine("There's nothing of interest, maybe check again tommorow.");
                Console.WriteLine("\nPress enter to continue.");
                Console.ReadLine();
            }
            else
            {
                Wall.loot(startingItem - 1, false);
                ++Player.things[startingItem - 1];
                startingItem = 0;
            }
        }
        if (choice.ToLower().Equals("talk"))
        {
            Console.WriteLine("You get the floating sphere's attention.\n");
            Wall.cellmate(Player.name);
            Console.WriteLine("\nPress enter to continue.");
            Console.ReadLine();
        }
        if (choice.ToLower().Equals("break out"))
        {
            int progress = 1;
            curse = 0;
            while (progress > 0 && win == false) //breakout loop
            {
                int stage = progress;
                Wall.breakout(stage);
                if (stage == 4) // enemy set up
                {
                    curse = 0;
                    enemy = 4;
                }
                else
                {
                    enemy = rnd.Next(1, 4);
                    if (progress > 1)
                    {
                        curse = rnd.Next(1,4);
                        Player.affliction = curse;
                    }
                }
                while (progress == stage) //combat loop
                {
                    choice2 = "invalid";
                    while (choice2.Equals("invalid")) //input loop
                    {
                        Wall.guard(enemy, curse);
                        Player.statwall();
                        choice2 = inputloopcombat("What would you like to do? You can also use a Thing if you have any.", available2, Player.things, Player.affliction);
                        if (choice2.Equals("invalid"))
                        {
                            Console.WriteLine("Invalid answer, please try again.\n");
                        }
                    }
                    if (choice2.ToLower().Equals("fight"))
                    {
                        if (Player.tired == true)
                        {
                            Player.affliction = -1;
                            Wall.defeated(enemy);
                            progress = 0;
                        }
                        else
                        {
                            Wall.takedown(enemy);
                            Player.tired = true;
                            ++progress;
                            if (progress == 5)
                            {
                                win = true;
                            }
                            else
                            {
                                int combatloot = rnd.Next(0, 6);
                                bool already = false;
                                if (combatloot > 2 && Player.things[combatloot] > 0)
                                {
                                    already = true;
                                    Console.WriteLine("Ah.\n");
                                }
                                Wall.loot(combatloot, already);
                                ++Player.things[combatloot];
                            }
                        }
                    }
                    if (choice2.ToLower().Equals("flee"))
                    {
                        Wall.run(enemy);
                        progress = 0;
                    }
                    if (choice2.ToLower().Equals("torch"))
                    {
                        --Player.things[0];
                        Wall.torch(enemy);
                        if (enemy == 2 || enemy == 3)
                        {
                            ++progress;
                            int combatloot = rnd.Next(0, 6);
                            bool already = false;
                            if (combatloot > 2 && Player.things[combatloot] > 0)
                            {
                                already = true;
                                Console.WriteLine("Ah.\n");
                            }
                            Wall.loot(combatloot, already);
                            ++Player.things[combatloot];
                        }
                    }
                    if (choice2.ToLower().Equals("rain bottle"))
                    {
                        --Player.things[1];
                        Wall.bottle(enemy);
                        if (enemy == 1 || enemy == 3)
                        {
                            ++progress;
                            int combatloot = rnd.Next(0, 6);
                            bool already = false;
                            if (combatloot > 2 && Player.things[combatloot] > 0)
                            {
                                already = true;
                                Console.WriteLine("Ah.\n");
                            }
                            Wall.loot(combatloot, already);
                            ++Player.things[combatloot];
                        }
                    }
                    if (choice2.ToLower().Equals("produce"))
                    {
                        --Player.things[2];
                        Wall.produce(enemy);
                        if (enemy == 1 || enemy == 2)
                        {
                            ++progress;
                            int combatloot = rnd.Next(0, 6);
                            bool already = false;
                            if (combatloot > 2 && Player.things[combatloot] > 0)
                            {
                                already = true;
                                Console.WriteLine("Ah.\n");
                            }
                            Wall.loot(combatloot, already);
                            ++Player.things[combatloot];
                        }
                    }
                    if (choice2.ToLower().Equals("flamethrower"))
                    {
                        Wall.flamethrower(enemy);
                        if (enemy == 2 || enemy == 3)
                        {
                            ++progress;
                            int combatloot = rnd.Next(0, 6);
                            bool already = false;
                            if (combatloot > 2 && Player.things[combatloot] > 0)
                            {
                                already = true;
                                Console.WriteLine("Ah.\n");
                            }
                            Wall.loot(combatloot, already);
                            ++Player.things[combatloot];
                        }
                    }
                    if (choice2.ToLower().Equals("raincloud"))
                    {
                        Wall.cloud(enemy);
                        if (enemy == 1 || enemy == 3)
                        {
                            ++progress;
                            int combatloot = rnd.Next(0, 6);
                            bool already = false;
                            if (combatloot > 2 && Player.things[combatloot] > 0)
                            {
                                already = true;
                                Console.WriteLine("Ah.\n");
                            }
                            Wall.loot(combatloot, already);
                            ++Player.things[combatloot];
                        }
                    }
                    if (choice2.ToLower().Equals("garden"))
                    {
                        Wall.garden(enemy);
                        if (enemy == 1 || enemy == 2)
                        {
                            ++progress;
                            int combatloot = rnd.Next(0, 6);
                            bool already = false;
                            if (combatloot > 2 && Player.things[combatloot] > 0)
                            {
                                already = true;
                                Console.WriteLine("Ah.\n");
                            }
                            Wall.loot(combatloot, already);
                            ++Player.things[combatloot];
                        }
                    }
                }
            }
            
        }
        if (Player.affliction == -1)
        {
            ++day;
            Player.tired = false;
            Player.affliction = 0;
            startingItem = rnd.Next(1, 4);
            Player.things[0] = 0;
            Player.things[1] = 0;
            Player.things[2] = 0;
            Player.things[3] = 0;
            Player.things[4] = 0;
            Player.things[5] = 0;
            Console.WriteLine("You wake up back in your cell, all your Things are gone.");
            Console.WriteLine("It is now day " + day);
            Console.WriteLine("\nPress enter to continue.\n");
            Console.ReadLine();
        }
        if (win != true)
        {
            //Loop back
            Wall.cellspace();
            Player.statwall();
            choice = inputloop("What would you like to do?", available);
        }
    }
    if (win == true)
    {
        Console.WriteLine("You step past the exit doors!");
        Console.WriteLine("The realm of elysium falls apart completely, you're returning to your original reality!");
        Console.WriteLine("You feel your soul slingshot across an inconceivable distance at incredible speeds!");
        Console.WriteLine("You quickly find your original body, asleep on your funny little bed! You're safe now.\n");
        if (day == 1)
        {
            Console.WriteLine("You've beaten the Elysylum in a single day!\n");
        }
        else
        {
            Console.WriteLine("You've beaten the Elysylum! It took you " + day + " days to escape.\n");
        }
        Console.WriteLine("You win. Well done " + Player.name + "!");
    }
    else
    {
        Console.WriteLine("A dozen days have gone by, you've lost the motivation to escape.\n");
        Console.WriteLine("You will spend the rest of your days rotting in the Elysylum.\n");
        Console.WriteLine("Game Over.");
    }
}

static string getPlayerName() // Loops an inquery until anything but a blank space is recieved.
{
    for (String i = ""; i.Equals("");)
    {
        Console.WriteLine("\nWhat is your character's name?\n");
        i = Console.ReadLine();
        Console.Clear();
        if (!i.Equals(""))
        {
            return i; // Returns valid input
        }
        else
        {
            Console.WriteLine("Invalid name, please try again.");
        }
    }
    return "Catch"; // This can't happen, but the bug fixer wanted a return statement outside of the loop
}

static string inputloop(string question, string[] options)
{
    for (bool t = false; t == false;)
    {
        Console.WriteLine(question + "\n");
        for (int l = 0; l < options.Length; l++)
        {
            Console.WriteLine(options[l]);
        }
        Console.WriteLine("");
        string a = Console.ReadLine();
        for (int l = 0; l < options.Length; ++l)
        {
            if (a.ToLower() == options[l].ToLower())
            {
                Console.Clear();
                return a;
            }
        }
        Console.Clear();
        Console.WriteLine("Invalid answer, please try again.\n");
    }
    return "Catch"; // This can't happen, but the bug fixer wanted a return statement outside of the loop
}

static string inputloopcombat(string question, string[] options, int[] items, int state){
    for (bool t = false; t == false;)
    {
        Console.WriteLine(question + "\n");
        for (int l = 0; l < options.Length; l++)
        {
            Console.WriteLine(options[l]);
        }
        Console.WriteLine("");
        string a = Console.ReadLine();
        Console.Clear();
        for (int l = 0; l < options.Length; ++l)
        {
            if (a.ToLower() == options[l].ToLower())
            {
                return a;
            }
        }
        if (a.ToLower().Equals("torch"))
            {
                if (state == 1)
                {
                    Console.WriteLine("You are Soaked, you cannot use Torches.\n");
                }
                if (items[0] == 0)
                {
                    Console.WriteLine("You do not possess any Torches.\n");
                }
                if (state != 1 && items[0] > 0)
                {
                    return a;
                }
            }
        if (a.ToLower().Equals("rain bottle"))
            {
                if (state == 2)
                {
                    Console.WriteLine("You are Sponged, you cannot use Rain Bottles.\n");
                }
                if (items[1] == 0)
                {
                    Console.WriteLine("You do not possess any Rain Bottles.\n");
                }
                if (state != 2 && items[1] > 0)
                {
                    return a;
                }
            }
        if (a.ToLower().Equals("produce"))
            {
                if (state == 3)
                {
                    Console.WriteLine("You are Barren, you cannot use Produce.\n");
                }
                if (items[2] == 0)
                {
                    Console.WriteLine("You do not possess any Produce.\n");
                }
                if (state != 3 && items[2] > 0)
                {
                    return a;
                }
            }
        if (a.ToLower().Equals("flamethrower"))
            {
                if (state == 1)
                {
                    Console.WriteLine("You are Soaked, you cannot use your Flamethrower.\n");
                }
                if (items[3] == 0)
                {
                    Console.WriteLine("You do not possess a flamethrower.\n");
                }
                if (state != 1 && items[3] > 0)
                {
                    return a;
                }
            }
        if (a.ToLower().Equals("raincloud"))
            {
                if (state == 2)
                {
                    Console.WriteLine("You are Sponged, you cannot use your Raincloud.\n");
                }
                if (items[4] == 0)
                {
                    Console.WriteLine("You do not possess a Raincloud.\n");
                }
                if (state != 2 && items[4] > 0)
                {
                    return a;
                }
            }
        if (a.ToLower().Equals("garden"))
            {
                if (state == 3)
                {
                    Console.WriteLine("You are Barren, you cannot use your Garden.\n");
                }
                if (items[5] == 0)
                {
                    Console.WriteLine("You do not possess a Garden.\n");
                }
                if (state != 3 && items[5] > 0)
                {
                    return a;
                }
            }
        return "invalid";
    }
    return "Catch"; // This can't happen, but the bug fixer wanted a return statement outside of the loop
}