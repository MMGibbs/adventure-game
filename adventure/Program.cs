using System;
using System.Xml.Serialization;

public class AdventureGame
{
    public static string playerName = " ";
    public static string goatName = " ";
    public static string horseName = " ";
    public static string choice = " ";
    public static double money = 0;
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Adventure Game, Traveller!");
        Console.WriteLine("Actually, what's your name? So I don't have to call you 'Traveller' the whole time.");
        Console.WriteLine("To enter an answer, simply type it into the console and press 'enter'. Try it now!");
        playerName = Console.ReadLine();
        Console.WriteLine("Well done! It's very nice to meet you, {0}. Now, let your story begin...", playerName);
        Console.WriteLine("");
        opening();

    }

    static void opening()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~opening~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("");
        Console.WriteLine("Your home is tucked away in a dark, quiet corner of The Forest. Inside, you have a ");
        Console.WriteLine("collection of souvenirs from your previous adventures, various CDs, DVDs and video games lying around ");
        Console.WriteLine("on the floor and plenty of components, textiles and tools from all of your renovation and creative projects. ");
        Console.WriteLine("Everything and everyone you've ever needed is here. Accompanied soley by a goat named... crap, what's his name?");
        Console.WriteLine("Enter your goat's name like you did with your own just now. ");
        goatName = Console.ReadLine();
        Console.WriteLine("Oh, yeah, it's coming back to me now. Accompanied solely by a petite goat named {0} and a dark, tall horse named... erm...errr...", goatName);
        Console.WriteLine("Help me out here! Gimme a name!");
        horseName = Console.ReadLine();
        Console.WriteLine("Aaaaaaaah, yes, {0}. Look, it's been a while and I'm not good with names, ok?! Anyways, accompanied solely by a ", horseName);
        Console.WriteLine("petite goat named {0} and a dark horse named {1}, you live contently at the cottage. It's never lonely, nothing bad ever", goatName, horseName);
        Console.WriteLine("happens. It's plain, but perfect. ");
        Console.WriteLine("");
        Console.WriteLine("Hey, remember when I said that everything you've ever needed was here? Well, that was a slight exaggeration, it seems.");
        Console.WriteLine("You swing open the fridge door with enthusiasm, eyes glistening with anticipation of a nice, cold strawberry milkshake to refresh you on this hot summer's day.");
        Console.WriteLine("But there is no milk.");
        Console.WriteLine("Forget the strawberries- the only taste in your mouth now is bitter disappointment. ");
        Console.WriteLine("No worry! There is a solution! Three miles west, there is a small market. It should have milk, along with many");
        Console.WriteLine("other supplies and accessories you may desire. On {0}back, it should be around a forty-five minute journey. You up for it? ", horseName);
        Console.WriteLine("Yes / No");
        Console.WriteLine("Oh, right! This is your first decision. To make a choice, just type in one of the options and press 'enter', like you've been");
        Console.WriteLine("doing already. Make sure what you type is exactly the same as the option says- capitals matter. Otherwise, an option will be selected for you.");
        Console.WriteLine("That'd be lame. ");
        Console.WriteLine("Alright, what'll it be, {0}?", playerName);
        Console.WriteLine("Yes / No");
        choice = Console.ReadLine();
        while(choice != "Yes")
        {
            Console.WriteLine("That's not the answer I expected! I'll ask again; Do you want to go and get some milk?");
            Console.WriteLine("Yes / No");
            choice = Console.ReadLine();
        }
        Console.WriteLine("That's the spirit! But before you go, you ought to find some money. The milk should cost about £2.50. Do you want to bring only enough to play for the milk in case ");
        Console.WriteLine("you lose it, or bring some extra for...some reason?");
        Console.WriteLine("Bring enough / Bring extra");
        choice = Console.ReadLine();
        if(choice == "Bring extra")
        {
            Console.WriteLine("You dig out an extra... £10. Now you're ready for anything!");
            money = money + 12.50;
        }
        else
        {
            Console.WriteLine("You play it safe and stick to the £2.50.");
            money = money + 2.50;
        }
        Console.WriteLine("You pull on a shirt and thick-soled boots before fitting the saddle on {0}. You look totally kick-ass. You also plop {1} in a pouch so he doesn't feel left out.", horseName, goatName);
        Console.WriteLine("Take one final look at the cottage, {0}- it might be a while until you return... (oooOOOooo)", playerName);
    }
}
