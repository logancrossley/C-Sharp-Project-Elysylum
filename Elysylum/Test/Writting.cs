class TextWall
  {

    public int advice = 0;

    public void intro(string nameInsert) 
    {
      Console.WriteLine("Welcome, " + nameInsert + ", to the Elysylum, the one asylum in elysium.");
      Console.WriteLine("A euclidean panopticon for those caught dreamwalking, a felony of cosmic proportions.");
      Console.WriteLine("Why you're here is a mystery, as you never intended to do such a thing.\n");
      Console.WriteLine("Press enter to continue.");
      Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Throughout this journey you will be presented choices and collect Things.");
      Console.WriteLine("Type the name of any given choice or Thing to perform/use it when presented with the option.");
      Console.WriteLine("Sometimes you'll be under the effects of an Affliction, which inhibit the use of certain Things.");
      Console.WriteLine("Use your Things wisely.\n");
      Console.WriteLine("Press enter to continue.");
      Console.ReadLine();
      Console.Clear();
    }

    public void cellspacefirst() 
    {
      Console.Clear();
      Console.WriteLine("You are currently in your cell.\n");
      Console.WriteLine("Since you're foreign to elysium, it isn't exactly tailored to hold you.");
      Console.WriteLine("One of the walls are misaligned, you could easily slip out through there.");
      Console.WriteLine("However, the panopticon tower would surely make the guards alert.\n");
      Console.WriteLine("Press enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
      Console.WriteLine("Your cellmate seems to be some kind of large spherical entity.");
      Console.WriteLine("It floats around the cell, occasionally bounding off a wall");
      Console.WriteLine("Perhaps conversing with it could give you an idea of what to do.\n");
      Console.WriteLine("Press enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
      
    }

    public void cellspace() 
    {
      Console.Clear();
      Console.WriteLine("You are currently in your cell.");
      Console.WriteLine("You could slip out, but the guards would become alert");
      Console.WriteLine("Your cellmate still floats around aimlessly.\n");
      
    }
    public void Rest(string adlib1, string adlib2) 
    {
      Console.Clear();
      Console.WriteLine("You lay down on your bed, it's deliberately uncomfortable.");
      Console.WriteLine("You somehow manage to slip into a state of sleep, dreaming of " + adlib1 + " and " + adlib2 + ".");
      Console.WriteLine("After an unknown amount of time you wake up, feeling slightly better\n");
    }

    public void loot(int reward, bool already) 
    {
      // [0] Torch, [1] Rain Bottle, [2] Produce, [3] Flamethrower, [4] Raincloud, [5] Garden
      if (reward == 0)
      {
        Console.WriteLine("You found a Torch!");
      }
      if (reward == 1)
      {
        Console.WriteLine("You found a Rain Bottle!");
      }
      if (reward == 2)
      {
        Console.WriteLine("You found some fresh Produce!");
      }
      if (reward == 3)
      {
        if (already == true)
        {
          Console.WriteLine("You found another Flamethrower.");
          Console.WriteLine("You don't need another one, you pass it.");
        }
        else
        {
          Console.WriteLine("You found a rusty old Flamethrower!");
        }
      }
      if (reward == 4)
      {
        if (already == true)
        {
          Console.WriteLine("You found another Raincloud.");
          Console.WriteLine("You don't need another one, you pass it.");
        }
        else
        {
          Console.WriteLine("You found a Raincloud!");
        }
      }
      if (reward == 5)
      {
        if (already == true)
        {
          Console.WriteLine("You found another Garden.");
          Console.WriteLine("You don't need another one, you pass it.");
        }
        else
        {
          Console.WriteLine("You found a Garden!");
        }
      }
      Console.WriteLine("\nPress enter to continue.");
      Console.ReadLine();
      Console.Clear();
    }

    public void cellmate(string yourName) 
    {
      ++advice;
      if (advice == 1)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"Greetings, " + yourName + ". I am Felonious Bolus. I'll provide you hints when you talk to me.\"");
        Console.WriteLine("\"For starters, losing combat means losing your Things, avoid being defeated at all costs.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 2)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"There are three forces in this world, Things are capable of asserting a specific force.\"");
        Console.WriteLine("\"Those forces are Fire, Rain, and Produce.\"");
        Console.WriteLine("\"Some Things are expended when used, others you can use as many times as you want.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 3)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"There are three Afflictions in this world, each one restricts a certain force.\"");
        Console.WriteLine("\"Soaked will restrict Fire, Sponged will restrict Rain, and Barren will restrict Produce.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 4)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"Rest only when you're tired, days will only progress when you Rest.\"");
        Console.WriteLine("\"If 12 days go by, you will lose the motivation to escape.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 5)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"Fighting will guarantee a victory, but it will make you tired.\"");
        Console.WriteLine("\"Choosing to fight while you are tired will result in your defeat.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 6)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"There are three types of guards, each one resists a certain force.\"");
        Console.WriteLine("\"Pay attention to their description and use common sense.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 7)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"To fully escape, you'll need to consecutively defeat three randomized guards.\"");
        Console.WriteLine("\"And then you'll need to defeat the Boss.\"");
        Console.WriteLine("\"Stock up on Things before making a full escape attempt.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 8)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"Every guard after the first will apply a random Affliction to you when starting combat.\"");
        Console.WriteLine("\"Afflictions are mutually exclusive, you can only be Afflicted by one at a time.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 9)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"A random Thing will appear in this cell when you sleep.\"");
        Console.WriteLine("\"Only expect to find consumable Things though.\"");
        Console.WriteLine("It floats away");
      }
      if (advice == 10)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"If you're certain you can't win combat, don't fret to flee.\"");
        Console.WriteLine("\"Fleeing from combat has a 100% success rate.\"");
        Console.WriteLine("It floats away");
        advice = 0;
      }
      if (advice == 11)
      {
        Console.WriteLine("It floats closer to you");
        Console.WriteLine("\"I have shared with you everything I know.\"");
        Console.WriteLine("\"I'll restart my dialogue incase you missed anything.\"");
        Console.WriteLine("It floats away");
        advice = 0;
      }
    }

    public void guard(int type, int afflict) 
    {
      if (type == 1)
      {
        Console.WriteLine("Approaching you rapidly and rabidly is a Cinder Lizard!");
        Console.WriteLine("A tall reptilian golem of dusty coal, clouds of ash and tiny embers flicker around it.");
        Console.WriteLine("It is decked with an arsenal of obsidian gear, including a large baton.\n");
      }
      if (type == 2)
      {
        Console.WriteLine("Staring you down is an upscaled Tarp Tardigrade!");
        Console.WriteLine("It's skin composed of polyurethane coated polyester, it's protruding humanoid limbs are plastic and elsatic.");
        Console.WriteLine("It floats above you, ready to strike.\n");
      }
      if (type == 3)
      {
        Console.WriteLine("Standing proudly before you is a Solitary Stag!");
        Console.WriteLine("It glares at you while munching on a tuff of nondescript foliage.");
        Console.WriteLine("It starts to gallop around you, it's hooves making resounding thuds.\n");
      }
      if (type == 4)
      {
        Console.WriteLine("The Warden glares at you menacingly!");
        Console.WriteLine("He comes equiped in a dusty old turnout coat.");
        Console.WriteLine("He carries an umbrella in his left hand, a chinchilla in his right.\n");
      }
      if (afflict == 1)
      {
        Console.WriteLine("Using a free hand, they open a portal besides them!");
        Console.WriteLine("Out from the opaque portal shoots several jets of water, drenching your entire being!\n");
        Console.WriteLine("You have suffered an Affliction: Soaked.\n");

      }
      if (afflict == 2)
      {
        Console.WriteLine("They chant something in a guttural language, it almost sounds like throat singing.");
        Console.WriteLine("Before you know it, several spectral sponges appear infront of you at a high velocity!\n");
        Console.WriteLine("You have suffered an Affliction: Sponged.\n");

      }
      if (afflict == 3)
      {
        Console.WriteLine("Their intense gaze feels like it's weighing you down, you feel weak.");
        Console.WriteLine("Your plots of land become unfruitful, you can no longer have a bountiful harvest.\n");
        Console.WriteLine("You have suffered an Affliction: Barren.\n");

      }
    }

    public void defeated(int guard) 
    {
      if (guard == 1)
      {
        Console.WriteLine("You lunge forward trying to disarm the creature!");
        Console.WriteLine("It easily maneuvers around you and in one swift motion, trips you with it's obsidian baton!");
        Console.WriteLine("As you hit the cold floor, your vision blurs into nothing.");
      }
      if (guard == 2)
      {
        Console.WriteLine("You try your best to tackle the thing out of the air!");
        Console.WriteLine("It weaves through your lethargic lurch and takes the opportunity to attack!");
        Console.WriteLine("It beams a dams worth of unsolicited information into your unguarded psyche!");
        Console.WriteLine("Your head feels like it's melting from the overload of knowledge! You pass out then and there.");
      }
      if (guard == 3)
      {
        Console.WriteLine("The stag is too fast, you try to strike but you only hit it's after image!");
        Console.WriteLine("It slams into you head first! It's bioluminescent antlers gouge your body.");
        Console.WriteLine("The pain is overwhelming, you know this run has ended as you begin to lose consciousness.");
      }
      if (guard == 4)
      {
        Console.WriteLine("You try to hit the warden in the face, but you were too slow!");
        Console.WriteLine("He stabs you with the point of his umbrella! YEOWCH!");
        Console.WriteLine("If that wasn't bad enough, his chinchilla leaps out of his hand and drop kicks you!");
        Console.WriteLine("He cackles out an obnoxious laugh before you pass out. You were so close.");
      }
      Console.WriteLine("\n...\nAn unknown amount of time passes...");
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void takedown(int guard) 
    {
      if (guard == 1)
      {
        Console.WriteLine("Quick on your feet, you outjuke the lizard, it's baton hits the floor and shatters!");
        Console.WriteLine("Mustering all your strength, you cup your hands together and give the lizard a mean elbow.");
        Console.WriteLine("It spins in the air for a second before crashing down on the floor, it's bittle armor shattered.");
        Console.WriteLine("You quickly step over it, pressing on with your escape!");
      }
      if (guard == 2)
      {
        Console.WriteLine("Like a spring out of suspension, you turn yourself into a projectile!");
        Console.WriteLine("You slam into the tardigrade like a cannonabll!");
        Console.WriteLine("That really did it, it's flight pattern has become directionless and clumsy!");
        Console.WriteLine("While it's disoriented, you run under it and press on with your escape!");
      }
      if (guard == 3)
      {
        Console.WriteLine("You extend a leg ahead of the stag and before you know it, it's tripped over you!");
        Console.WriteLine("Ungracefully, it somersaults into a wall!");
        Console.WriteLine("It's antlers are now lodged, its's stuck! You take the oppurtunity and keep going!");
      }
      if (guard == 4)
      {
        Console.WriteLine("You punch the warden in his face! It doesn't look like he was expecting that.");
        Console.WriteLine("You're no boxer, but that hit seemed to really do a number on him!");
        Console.WriteLine("He falls to the floor, it seems like you broke his nose!\n");
        Console.WriteLine("\"Arghh! Fine! Leave dreamwalker, we've put up with your ruckus long enough.\"");
        Console.WriteLine("\nHe crawls away, leaving the exit unguarded.");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void run(int guard) 
    {
      if (guard == 1)
      {
        Console.WriteLine("The lizard hisses at you as you make your escape, but it does not pursue.");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tardigrade just watches as you run from it, remaining right where it was.");
      }
      if (guard == 3)
      {
        Console.WriteLine("Though the stag could easily catch up to you, it recognizes an honest retreat, it lets you go.");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden crosses his arms as he watches you flee.");
        Console.WriteLine("\"You made the right choice.\"");
      }
      Console.WriteLine("You make it back to your cell safe and sound, the alarms have stopped.");
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void torch(int guard) 
    {
      Console.WriteLine("You throw a torch, exerting the force of fire!\n");
      if (guard == 1)
      {
        Console.WriteLine("The searing flames from the torch don't seem to have any kind of effect on the lizard.");
        Console.WriteLine("In fact it seems to amuse them, they wave their baton in the air, as if to taunt you.");
        Console.WriteLine("Your torch burns up completely, you're down a Thing, but the lizard is giving you another shot.");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tardigrade's tarps start to melt and fuse together, the the resulting smell is unpleasant.");
        Console.WriteLine("The tardigrade hisses in pain before floating away in retreat, you've won.");
      }
      if (guard == 3)
      {
        Console.WriteLine("The stag's fur easily ignites, causing it to gallop and bleat frantically!");
        Console.WriteLine("It does eventually manage to put itself out, but it is no longer interested in stopping you!");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden's turnout coat protects him from the intense heat!");
        Console.WriteLine("The warden laughs, he's taunting you.");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void bottle(int guard) 
    {
      Console.WriteLine("You uncork the bottle, exerting the force of rain!\n");
      if (guard == 1)
      {
        Console.WriteLine("There's a squealing noise as the lizard's body sublimates into steam!");
        Console.WriteLine("The sight is actually pretty brutal, but nevertheless, you've won this particular encounter.");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tarps of the tardigrade essentially act as a slick raincoat!");
        Console.WriteLine("The rain is wasted, that attempt was fruitless!");
        Console.WriteLine("The tardigrade waits to see what you'll do next.");
      }
      if (guard == 3)
      {
        Console.WriteLine("The stag's fur is wet and soggy now, slowing it's movements and making it shiver!");
        Console.WriteLine("It doesn't feel like fighting you anymore, it gallops away, seemingly very upset!");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden opens his umbrella and protects himself from the water!");
        Console.WriteLine("\"That all you got?\"");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void produce(int guard) 
    {
      Console.WriteLine("You unleash your produce upon them!\n");
      if (guard == 1)
      {
        Console.WriteLine("The lizard tries to bat away the waves of produce with it's baton, but is unsuccessful!");
        Console.WriteLine("The waves of fruits and vegetables overwhelm the lizard, rendering it prone!");
        Console.WriteLine("It has lost the will to fight you!");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tardigrade tries it's best to utalize it's telekinesis to deflect them!");
        Console.WriteLine("It's no use! The sheer amount of veggies you threw at this thing knock it out of the air!");
        Console.WriteLine("There's a resounding crash landing, the tardigrade is out of sight!");
      }
      if (guard == 3)
      {
        Console.WriteLine("The stag's eyes light up at the sight!");
        Console.WriteLine("Effortlessly it chomps and rips through all of the produce with it's strong teeth!");
        Console.WriteLine("It looks at you expectingly, it seems the produce efforts have simply fed the thing!");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden's chinchilla zips back and forth, gobbling all the produce!");
        Console.WriteLine("\"Hah! What now dreamwalker!?\"");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void flamethrower(int guard) 
    {
      Console.WriteLine("You spew a powerful wall of flames at them!\n");
      if (guard == 1)
      {
        Console.WriteLine("The lizard, although suprised, doesn't seem to be affected by them.");
        Console.WriteLine("The coals that make up the body of the lizard now glow a bright red!");
        Console.WriteLine("The lizard keeps approaching, the flames essentially had the same effect as a small breeze.");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tardigrade was NOT ready for that.");
        Console.WriteLine("It makes a horrified noise before being completely burnt up into nothing but ashes!");
        Console.WriteLine("Brutal.");
      }
      if (guard == 3)
      {
        Console.WriteLine("You completely incinerate the poor thing...");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden's turnout coat shields him from the wall of flames!");
        Console.WriteLine("\"Hah! Fat chance dreamwalker!\"");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void cloud(int guard) 
    {
      Console.WriteLine("You summon your raincloud, exerting a harsh storm of rain!\n");
      if (guard == 1)
      {
        Console.WriteLine("The lizard makes a horrified squeal before being completely evaporated!");
        Console.WriteLine("Even the obsidian weaponry and equipment start to crumble into nothing under the rain.");
        Console.WriteLine("As the storm dies down, nothing from the lizard remains.");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tarps of the tardigrade essentially act as a slick raincoat!");
        Console.WriteLine("The rain slides off the thing, that attempt was fruitless!");
        Console.WriteLine("The tardigrade waits to see what you'll do next.");
      }
      if (guard == 3)
      {
        Console.WriteLine("The stag, not wanting to get wet, quickly flees the scene!");
        Console.WriteLine("That was easy!");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden opens his umbrella and protects himself from the storm!");
        Console.WriteLine("\"Hah! Get countered dreamwalker!\"");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void garden(int guard) 
    {
      Console.WriteLine("You apply the fruits of your labor to the situation!\n");
      if (guard == 1)
      {
        Console.WriteLine("The lizard hisses at the various stalks and stems, seemingly disgusted!");
        Console.WriteLine("It drops it's baton to the ground and stomps it's feet before turning and leaving!");
        Console.WriteLine("How rude...");
      }
      if (guard == 2)
      {
        Console.WriteLine("The tardigrade is stunned! It can't move!");
        Console.WriteLine("It's seemingly extremely impressed by your vast and plentiful harvest!");
        Console.WriteLine("It lets you past it as a sign of respect!");
      }
      if (guard == 3)
      {
        Console.WriteLine("The stag's eyes light up at the sight!");
        Console.WriteLine("It is now even more motivated to take you down! It can't WAIT to confiscate your garden!");
        Console.WriteLine("It seems like the garden wasn't of any use here.");
      }
      if (guard == 4)
      {
        Console.WriteLine("The warden is unimpressed.");
        Console.WriteLine("\"Your garden is useless here dreamwalker, turn back now!\"");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }

    public void breakout(int progress) 
    {
      if (progress == 1)
      {
        Console.WriteLine("You slip through the misaligned wall and sprint through the Elysylum!");
        Console.WriteLine("A blaring noise emanates from the panopticon watch tower! You've been spotted!\n");
        Console.WriteLine("Almost immediately a prison guard appears, blocking your path!");
      }
      if (progress == 2)
      {
        Console.WriteLine("Up and down the twisting hallways you sprint!");
        Console.WriteLine("You kick down several doors, vault over railways and leap across floating platforms!");
        Console.WriteLine("The blaring alarms become more and more intense the further you go!");
        Console.WriteLine("It seems like the security is ramping up! A tougher looking prison guard routes ahead of you!");
        Console.WriteLine("You'll need to defeat them in order to keep progressing!");
      }
      if (progress == 3)
      {
        Console.WriteLine("Another security room is ahead, strange devices are being deployed to slow you down!");
        Console.WriteLine("You manage to shake most of them off, but the distraction allows another guard to catch up to you!");
        Console.WriteLine("Prepare youself!");
      }
      if (progress == 4)
      {
        Console.WriteLine("You're unstoppable! You're almost out of here, you can see the light pouring through the exit!");
        Console.WriteLine("The strange realm of elysium starts unfolding as you get closer! Your about to be free!");
        Console.WriteLine("There's but one last obstacle, the big boss himself!\n");
        Console.WriteLine("\"I cann't let you escape, dreamwalker. Your place is here, turn back now!\"");
      }
      Console.WriteLine("\nPress enter to continue.\n");
      Console.ReadLine();
      Console.Clear();
    }
  }