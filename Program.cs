using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TheAdventurerGuild
{
    class Program
    {
        static void Main(string[] args)
        {
           DataDisplay.WriteData(DataDialogue.RetrieveData("dialogue", "Intro.askName"));
           GameState.CharName = PlayerInput.ParseInput();
           //Console.WriteLine(GameState.CharName);
           DataDisplay.WriteData(DataDialogue.RetrieveData("dialogue", "Intro.welcome"));

           
        }
    }
}

//Lists
/*
List<string> inventory = new List<string>();

string[] weapons = new string[] { "sword", "axe", "bow" };
Console.WriteLine("Welcome to my game. What is your name?");
string playerName = Console.ReadLine();
Console.WriteLine($"Welcome {playerName}! Let us begin our adventure. You are a knight waking from a troubled slumber. As you roll from the bed, (still wearing the tunic from the night before tsk tsk) You reach for your weapon. Do you grab the axe, bow or sword?");
string weaponChoice = Console.ReadLine();

isWeapon(weaponChoice);
Console.WriteLine($"As you exit your room, you bump into your friend, the mighty dwarf Gamli. \"{playerName}! Good to see you my friend! Have you decided which contract we are taking today?\" ");
Console.WriteLine("Right, the contracts...faint recollection of the previous days business begin to emerge from the ether that is your minds eye. Perhaps one too many dwarven ales? \"Could you remind me of the contracts?\"");
Console.WriteLine("Sure! There was baker Bilibo with his vermin issue, Faerin the blacksmith and his iron supplier trouble and Frank the fletcher. Not sure what his deal is. Which of our esteemed patrons would you like to visit today?");
string questChoice = Console.ReadLine();
switch (questChoice)
{
    case "Bilibo":
        Console.WriteLine("Great choice! We can get breakfast while we are there! I wonder where those rodents are?");
        BiliboStory();
        break;

    case "Faerin":
        Console.WriteLine("Good idea, I can get my axe sharpened while we are there!");
        if (weaponChoice == "axe")
        {
            Console.WriteLine("Maybe you could get him to look at yours as well, pretty soon you'll have a bloody hammer!");
            FaerinStory();
        }
        else
        {
            Console.WriteLine("A fine choice. Let us proceed!");
            FaerinStory();
        }
        break;

    case "Frank":
        if (weaponChoice == "bow")
        {
            Console.WriteLine("Looking to stock up on arrows are you? Let us proceed!");
            FrankStory ();
        }
        else
        {
            Console.WriteLine("A fine choice. Let us proceed!");
        }
        break;
}


//Methods
void isWeapon(string weapon)
{
    if (weapon == "sword")
    {
        Console.WriteLine("The fine blade of stabbing, not sure how it earned that name.");
        inventory.Add("sword");
    }
    else if (weapon == "axe")
    {
        Console.WriteLine("The axe of Never Sharpened. However when you swing as hard as you do that doesn't really matter does it?");
        inventory.Add("axe");
    }
    else if (weapon == "bow")
    {
        Console.WriteLine("The bow of shooty stabby. Legend has it the wielder never misses. A legend indeed.");
        inventory.Add("bow");
    }
}

//Story Methods
void BiliboStory()
{
    Console.WriteLine($"The walk to Bilibos shop is luckily as short jaunt from the Adventures Guildhall. With your {weaponChoice} secured and your companion by your side you arrive at the bakers.");
    Console.WriteLine($"{playerName}! I'm so glad to see you! Please come in, did anyone see you standing outside?");
    Console.WriteLine($"As you walk into the closed bakery the smell of fresh baked bread wafts from the kitcken. The sound of a growling stomach can be heard as a helper brings out a tray of fresh pastrys for the days clients. Was that your stomach or has Gamli not eaten yet this morning as well?");
    Console.WriteLine($"Not wasting a moment the animated baker launches into his spiel. \"I've got an infestation in me basement. Those bloody rats have taken hold and I can't get them out. I've tried poison, i've tried traps. I even sent Sam down there with a club to bash 'em on the bloody head. They are too fierce and in to great a number. I need you to clear them out\'.");
    Console.WriteLine($"The thought of the poison and bashed rats has a remarkable effect as the sound of grumbling stomachs quickly subsides. \'Not a problem Bilabo, it'll be the standard rate of 15 silver per hour, with a 3 hour minimum. Gamli and I will have that problem cleared out in no time.\'");
    Console.WriteLine($"15 silver! I thought the highway men weren't allowed in the city walls. Fine, fine I need this done. Don't dally, this shouldn't take more than 3 hours!");
    Console.WriteLine($"");
}
void FaerinStory()
{

}
void FrankStory()
{

}

*/