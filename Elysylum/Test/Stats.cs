class Stat
  {
    public string name = "John";

    // [0] Torch, [1] Rain Bottle, [2] Produce, [3] Flamethrower, [4] Raincloud, [5] Garden
    public int[] things = {0, 0, 0, 0, 0, 0};

    // -1 = Defeated 0 = Clear, 1 = Soaked, 2 = Sponged, 3 = Barren
    public int affliction = 0;

    public bool tired = false;

    public void statwall() 
    { 
      if(things[0] == 0 && things[1] == 0 && things[2] == 0 && things[3] == 0 && things[4] == 0 && things[5] == 0)
      {
        Console.WriteLine("You currently have no Things.");
      }
      else
      {
        Console.WriteLine("You currently have:");
        if (things[0] != 0)
        {
            Console.WriteLine("Torch " + "[" + things[0] + "]");
        }
        if (things[1] != 0)
        {
            Console.WriteLine("Rain Bottle " + "[" + things[1] + "]");
        }
        if (things[2] != 0)
        {
            Console.WriteLine("Produce " + "[" + things[2] + "]");
        }
        if (things[3] != 0)
        {
            Console.WriteLine("Flamethrower");
        }
        if (things[4] != 0)
        {
            Console.WriteLine("Raincloud");
        }
        if (things[5] != 0)
        {
            Console.WriteLine("Garden");
        }
      }

      if (affliction == 1)
      {
        Console.WriteLine("\nYou are Soaked.");
      }
      if (affliction == 2)
      {
        Console.WriteLine("\nYou are Sponged.");
      }
      if (affliction == 3)
      {
        Console.WriteLine("\nYou are Barren.");
      }

      if (tired == true)
      {
        Console.WriteLine("\nYou feel tired.\n");
      }
      else
      {
        Console.WriteLine("\nYou feel ok.\n");
      }
    } 
  }