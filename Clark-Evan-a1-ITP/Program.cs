// See https://aka.ms/new-console-template for more information
//Game starts, player is informed
Console.WriteLine("Welcome to the dungeon. In order to escape, you'll have to be very careful to avoid traps.\nYou have escaped your cell and are now in a hallway. You can go left or right.");
int score = 0;
String firstHallway = Console.ReadLine().ToLower();

if (firstHallway.Contains("left"))
{
    //Player is in the left hallway. Chooses to go into a trap door or a blue door.
    score += 1;
    Console.WriteLine("You went left. You then come across blue door and a trap door. Which do you enter?");
    string leftHallway = Console.ReadLine();
    if (leftHallway.Contains("blue"))
    {
        //Player enters pressure plate room and must choose the right pressure plate to pass
        score += 1;
        Console.WriteLine("You went through the blue door and entered a room with three pressure plates. There are symbols on each.\nHere's what they look like:\nLeft: :) Forward: :( Right: :/");
        string pressurePlateRoom = Console.ReadLine().ToLower();
        if (pressurePlateRoom.Contains("right"))
        {
            Console.WriteLine("YOU DIED!\nYou stepped on the pressure plate and got hit with multiple darts.\nScore: " + score);
        }
        else if (pressurePlateRoom.Contains("forward"))
        {
            Console.WriteLine("YOU DIED!\nYou stepped on the pressure plate and got hit with multiple darts.\nScore: " + score);
        }
        else if (pressurePlateRoom.Contains("left"))
        {
            //player is now in the armour stand room, goes left or right
            score = +1;
            Console.WriteLine("You walk past the pressure plate and into a room full of armour stands and a sleeping gaurd!\nYou can walk left, through the armour stands, or right, and climb past some boxes.");
            string armourRoom = Console.ReadLine().ToLower();
            if (armourRoom.Contains("left"))
            {
                Console.WriteLine("YOU DIED!\nWhile walking throught the armour stands, they fell and awoke the gaurd, who killed you immediately.\nScore: " + score);
            }
            else if (armourRoom.Contains("right"))
            {
                //Player enters treasure room and can take or leave treasure
                score = +1;
                Console.WriteLine("You climbed over the boxes and safely avoided the gaurd.\nNow you enter a giant room with an exit and a golden skull Do you leave, or take the skull first?");
                string treasureRoom = Console.ReadLine().ToLower();
                if (treasureRoom.Contains("leave"))
                {
                    //Player escapes dungeon, ending is achieved
                    score += 1;
                    Console.WriteLine("You decide to leave the skull, valuing your life over materialistic gain. You walk out of the dungeon and into a bright, sunny forest.\n YOU WIN! THE END!\nFinal score: " + score);
                }
                else if (treasureRoom.Contains("skull"))
                {
                    Console.WriteLine("YOU DIED!\nAs soon as you picked up the skull, a giant boulder fell out of the ceiling and crushed you.\nFinal score: " + score);
                }
                else
                {
                    Console.WriteLine("Error: input is invalid. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Error: input is invalid. Please try again.");
            }
        }
        else {
            Console.WriteLine("Error: input is invalid. Please try again.\nScore: "+score);
        }
    }
    else if (leftHallway.Contains("trap"))
    {
        //The player enters the trap door and is now in a tunnel full of water. 
        score += 1;
        Console.WriteLine("You go down the trap door and enter a tunnel with knee deep water.\nYou can go into deep water or shallow water.");
        string waterTunnel = Console.ReadLine().ToLower();
        if (waterTunnel.Contains("shallow")) {
            //Player now has to choose between a tunnel and a door
            score += 1;
            Console.WriteLine("You wade though the water until you find some stairs that lead you into a new room.\nYou can go into a door or down a tunnel.");
            string doorTunnelRoom = Console.ReadLine().ToLower();
            if (doorTunnelRoom.Contains("door")) {
                //Player enters statue room, has to choose which button to press
                score += 1;
                Console.WriteLine("You go through the door and enter a room with a giant dragon statue.\nThere are two buttons at the bottom, on has a flame on it, the other has a wave on it. Which do you press?");
                string statueRoom = Console.ReadLine().ToLower();
                if (statueRoom.Contains("wave"))
                {
                    //The player presses the correct button and the ending is achieved.
                    score += 1;
                    Console.WriteLine("You press the wave button. Suddenly, the floor drops out from beneath you, and you fall into a stream of water. You are then swept out of the dungeon, and you swim to a small peaceful island.\nYOU WIN! THE END!\nFinal score: "+score);
                }
                else if (statueRoom.Contains("flame"))
                {
                    Console.WriteLine("YOU DIED!\nYou pressed the flame button, but then the dragon statue shoots fire from it's mouth, burning you to a crisp.\nScore: "+score);
                }
                else
                {
                    Console.WriteLine("Error: input is invalid. Please try again.\nScore: "+score);
                }

            }
            else if (doorTunnelRoom.Contains("tunnel"))
            {
                //Player enters bridge room and decides between stone or wood bridge
                score += 1;
                Console.WriteLine("You enter the tunnel and emerge in a room with a door beyond a giant crevice.\nThere are two bridges. one is made of wood, the other stone. Which do you take?");
                string bridgeRoom = Console.ReadLine().ToLower();
                if (bridgeRoom.Contains("stone"))
                {
                    //player enters the water cave and chooses to take a small or large boat.
                    score += 1;
                    Console.WriteLine("You walk safely across the sturdy stone bridge and enter a cave that exits to the ocean beyond. There are some gaurds patrolling the docks.\nYou can take a big boat or a small boat to escape the cave. Which do you choose?");
                    string waterCave = Console.ReadLine().ToLower();
                    if (waterCave.Contains("small"))
                    {
                        //The player escapes with the boat and the ending is achieved.
                        score += 1;
                        Console.WriteLine("You get on the small boat and set sail. The small boat goes unnoticed by any gaurds. You sail out into the sea, ready for your next adventure.\nYOU WIN THE END!\nFinal score: "+score);
                    }
                    else if (waterCave.Contains("big"))
                    {
                        Console.WriteLine("YOU DIED!\nAs soon as you entered the big boat, you realized that there were gaurds in the boat with you.\nScore: "+ score);
                    }
                    else
                    {
                        Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
                    }
                }
                else if (bridgeRoom.Contains("wood"))
                {
                    Console.Write("YOU DIED! The wooden bridge collapsed as you walked on it and you fell to your doom.\nScore: "+ score);
                }
                else
                {
                    Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
                }
            }
            else
            {
                Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
            }
        }
        else if (waterTunnel.Contains("deep"))
        {
            Console.WriteLine("YOU DIED!\nYou swam in the deep waters before being swallowed by a giant fish.\nScore: "+score);
        }
        else
        {
            Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
        }
    }
    else
    {
        Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
    }
}
else if (firstHallway.Contains("right"))
{
    //player walks down right hallway, chooses between red and green door
    score += 1;
    Console.WriteLine("You walk down the right hallway and come across two doors.\nYou can go in a red door or a green door.");
    string rightHallway = Console.ReadLine().ToLower();
    if (rightHallway.Contains("green"))
    {
        //The player enters the green door and enters leaf room
        score += 1;
        Console.WriteLine("You enter the green door and emerge into a room with a sleeping gaurd.\nYou can go left, on a path full of leaves, or right, on a path with stones.");
        string leafRoom = Console.ReadLine().ToLower();
        if (leafRoom.Contains("right"))
        {
            //Player enters vine room
            score += 1;
            Console.WriteLine("You carefully sneak past the gaurd on the stone path.\nYou then enter a room with a tall wall. reaching down from the wall are two vines. The left one has mushrooms on it, the middle one has flowers, and the right on has thorns.");
            string vineRoom = Console.ReadLine().ToLower();
            if (vineRoom.Contains("middle"))
            {
                //Player enters plant room
                score += 1;
                Console.WriteLine("You climb the vine with flowers and enter a room with a giant plant. It's growing right in front of the exit. It has giant teeth and looks hungry.\nThere are two valves that lead to pipes above the plant. One is purple and has the letter H on it, the other is greenand has an F.");
                string plantRoom = Console.ReadLine().ToLower();
                if (plantRoom.Contains("purple"))
                {
                    //Player kills plant, ending is achieved
                    score += 1;
                    Console.WriteLine("You turn the valve and purple liquid falls onto the plant, causing to wither instantly. The H must have stood for herbicide! You walk out of the dungeon and onto an open field.\nYOU WIN! THE END!\nFinal score: "+score);
                }
                else if (plantRoom.Contains("green"))
                {
                    Console.WriteLine("YOU DIED! You turned the valve and green liquid hit the plant, causing to grow rapidly and eat you. The G must have stood for fertalizer!\nScore: " + score);
                }
                else
                {
                    Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
                }
            }
            else if (vineRoom.Contains("left"))
            {
                Console.WriteLine("YOU DIED! the fungal vine broke and you fell to your doom.\nScore: "+score);
            }
            else if (vineRoom.Contains("right"))
            {
                Console.WriteLine("YOU DIED! The thorny vine injected lethal venom into your hands as you grabbed onto it.\nScore: "+score);
            }
            else
            {
                Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
            }

        }
        else if (leafRoom.Contains("left"))
        {
            Console.WriteLine("YOU DIED! As you walked through the leaves, you stepped on a stick under the leaves causing the gaurd to wake up and kill you.\nScore: "+score);
        }
        else
        {
            Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
        }
    }
    else if (rightHallway.Contains("red"))
    {
        //Player enters gear room and decides to jump on big or small gear
        score += 1;
        Console.WriteLine("You enter the red door and are now in a room full of gears.\nTo get to the next door, you'll have to jump on a big gear or a small gear.");
        string gearRoom = Console.ReadLine().ToLower();
        if (gearRoom.Contains("big")) {
            //Player enters lava room, decides to swing on rope, jump on rocks or cross bridge.
            score += 1;
            Console.WriteLine("You safely cross on the big gear and enter a room with a pit of lava.\nTo cross, you can swing on a rope, jump on some rocks, or cross a bridge.");
            string lavaRoom = Console.ReadLine().ToLower();
            if (lavaRoom.Contains("rock"))
            {
                //Player enters riddle room
                score += 1;
                Console.WriteLine("You quickly jump across the rocks, avoiding the lava. You then enter a room with a sphinx statue.\n'What is 43 - 17?' I asks.\nEnter your answer. (Must be a number).");
                int riddle = int.Parse(Console.ReadLine());
                if (riddle == 26)
                {
                    //Player answers riddle correctly, ending is achieved
                    score += 1;
                    Console.WriteLine("'Correct' The sphinx replies. The sphinx suddenly rumbles to the side and an exit appears. You leave the dungeon through a cave tunnel.\nYOU WIN! THE END!\nFinal Score: "+ score);
                }
                else if (riddle != 26)
                {
                    Console.WriteLine("YOU DIED! The answer was incorrect, and the ceiling lowered and crushed you.\nScore: "+score);
                }
                else
                {
                    Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
                }
            }
        }
        else if (gearRoom.Contains("small"))
        {
            Console.WriteLine("YOU DIED! The small gear became loose and you fell into lava.\nScore: "+score);
        }
        else
        {
            Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
        }
    }
    else
    {
        Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
    }

}
else 
{ 
    Console.WriteLine("Error: input is invalid. Please try again.\nScore: " + score);
}
