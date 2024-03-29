using System;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class AdventureGame
{
    public static string playerName = "Timmy";
    public static string goatName = " ";
    public static string horseName = " ";
    public static string choice = " ";
    public static double money = 0.00;
    public static bool hasSeenPoster = false;
    public static bool hasSeenScratches = false;
    public static bool hasCompass = false;
    public static bool hasRope = false;
    public static bool hasSandwiches = false;
    public static bool hasMilk = false;
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Adventure Game, Traveller!");
        Thread.Sleep(2500);
        Console.WriteLine("Actually, what's your name? So I don't have to call you 'Traveller' the whole time.");
        Console.WriteLine("To enter an answer, simply type it into the console and press 'enter'. Try it now!");
        playerName = Console.ReadLine();
        Console.WriteLine("Well done! It's very nice to meet you, {0}. Now, let your story begin...", playerName);
        Console.WriteLine("");
        Thread.Sleep(4000);
        opening();

    }

    static void opening()
    {
        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ opening ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Thread.Sleep(2500);
        Console.WriteLine("Your home is tucked away in a dark, quiet corner of The Forest. Inside, you've got ");
        Console.WriteLine("collections of souvenirs from old holidays, various CDs, DVDs and video games as well as ");
        Console.WriteLine("plenty of components, textiles and tools from all of your various side projects. ");
        Thread.Sleep(6000);
        Console.WriteLine("Everything and everyone you've ever needed is here. Accompanied soley by a goat named... crap, what's his name?");
        Thread.Sleep(3000);
        Console.WriteLine("Enter your goat's name like you did with your own just now. ");
        goatName = Console.ReadLine();
        Console.WriteLine($"Oh, yeah, it's coming back to me now. Accompanied solely by a petite goat named {goatName} and a dark, tall horse named... erm...errr...");
        Thread.Sleep(3000);
        Console.WriteLine("Help me out here! Gimme a name!");
        horseName = Console.ReadLine();
        Console.WriteLine($"Aaaaaaaah, yes, {horseName}. Look, it's been a while and I'm not good with names, ok?! Anyways, accompanied solely by a ");
        Console.WriteLine("petite goat named {0} and a dark horse named {1}, you live contently at the cottage. It's never lonely, nothing bad ever", goatName, horseName);
        Console.WriteLine("happens. It's plain, but perfect. ");
        Thread.Sleep(6000);
        Console.WriteLine("");
        Console.WriteLine("Hey, remember when I said that everything you've ever needed was here? Well, that was a slight exaggeration, it seems.");
        Thread.Sleep(4000);
        Console.WriteLine("You swing open the fridge door with enthusiasm, eyes glistening with anticipation of a nice, cold strawberry milkshake to refresh you on this hot summer's day.");
        Thread.Sleep(2500);
        Console.WriteLine("...");
        Thread.Sleep(2500);
        Console.WriteLine("But there is no milk...");
        Thread.Sleep(3000);
        Console.WriteLine("Forget the strawberries- the only taste in your mouth now is bitter disappointment. ");
        Thread.Sleep(3000);
        Console.WriteLine("No worry! There is a solution! Three miles west, there is a small market. It should have milk, along with any");
        Console.WriteLine("other supplies and accessories you may desire. On {0}back, it should be around a forty-five minute journey. You up for it? ", horseName);
        Thread.Sleep(1000);
        Console.WriteLine("Yes / No");
        Thread.Sleep(3000);
        Console.WriteLine("Oh, right! This is your first decision. To make a choice, just type in one of the options and press 'enter', like you've been");
        Console.WriteLine("doing already. Make sure what you type is exactly the same as the option says- capitals matter. Otherwise, an option will be selected for you.");
        Thread.Sleep(6000);
        Console.WriteLine("That'd be lame. ");
        Thread.Sleep(3000);
        Console.WriteLine("Alright, what'll it be, {0}?", playerName);
        Thread.Sleep(1000);
        Console.WriteLine("Yes / No");
        choice = Console.ReadLine();
        while (choice != "Yes")
        {
            Console.WriteLine("That's not the answer I expected! I'll ask again; Do you want to go and get some milk?");
            Thread.Sleep(1000);
            Console.WriteLine("Yes / No");
            choice = Console.ReadLine();
        }
        Console.WriteLine("That's the spirit! But before you go, you ought to find some money. The milk should cost about £2.50. Do you want to bring only enough to pay for the milk in case ");
        Console.WriteLine("you lose it, or bring some extra for...some reason?");
        Thread.Sleep(1000);
        Console.WriteLine("Bring enough / Bring extra");
        choice = Console.ReadLine();
        if (choice == "Bring extra")
        {
            Console.WriteLine("You dig out an extra... £10. Now you're ready for anything!");
            money = money + 12.50;
        }
        else
        {
            Console.WriteLine("You play it safe and stick to the £2.50.");
            money = money + 2.50;
        }
        Thread.Sleep(3000);
        Console.WriteLine("You pull on a thin, viridescent shirt, some trousers equipped with multiple decently-sized pockets and some thick-soled boots before fitting the saddle on {0}. You look totally kick-ass. ", horseName);
        Thread.Sleep(2000);
        Console.WriteLine($"You also plop {goatName} in your pouch so he doesn't feel left out.");
        Console.WriteLine("Take one final look at the cottage, {0}- it might be a while until you return... (oooOOOooo)", playerName);
        Console.WriteLine("");
        Thread.Sleep(6000);
        Console.WriteLine("Press enter when you're ready to continue to the next part. ");
        Console.ReadLine();
        journeyToMarket();
    }

    static void journeyToMarket()
    {
        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ to the market ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Thread.Sleep(3000);
        Console.WriteLine("The Forest is quite a tranquil place to live. That's why you love it so much. Thoughout your years spent here, you've never caught more than a couple of people");
        Console.WriteLine("wandering about. The only noise you ever here is the soft sound of branches swaying in the breeze or of small critters scuttering about in the leaflitter.");
        Thread.Sleep(8000);
        Console.WriteLine("Today is different, though. You've travelled this route hundreds of times, so you're pretty certain something's up. It's... unnverving... but you can't quite put your");
        Console.WriteLine("finger on what has changed. ");
        Thread.Sleep(6000);
        Console.WriteLine("");
        Console.WriteLine("There is still about fifteen minutes left of the journey before you get to the village. Do you continue to where you were going or stop and have a poke around?");
        Thread.Sleep(1000);
        Console.WriteLine("Continue / Poke around");
        choice = Console.ReadLine();
        if (choice == "Poke around")
        {
            Console.WriteLine("Curiosity never hurt anyone, right? And you know this place pretty well. Should be fine to have a looksie. After dismounting {0}, you creep around, studying the ground", horseName);
            Console.WriteLine("carefully for inconsistencies. Strangely enough, you do notice something. There seems to be... litter. Who could have left it? There are a few tins of food, some foil, ");
            Console.WriteLine("and even some rope. After searching the trees nearby, you notice there are some scratch marks on the bark. Was there a struggle? ", horseName);
            Thread.Sleep(10000);
            hasSeenScratches = true;
            Console.WriteLine("Next you check the lake. You approach it hesitantly, afraid of what you might discover. ");
            Thread.Sleep(2500);
            Console.WriteLine("");
            Console.WriteLine("Your heart almost stops as you catch sight of something floating in the water, but after closer inspection you realise it is a piece of paper. Do you want to pick up the paper?");
            Thread.Sleep(1000);
            Console.WriteLine("Pick up piece of paper / Leave");
            choice = Console.ReadLine();
            if (choice == "Pick up piece of paper")
            {
                hasSeenPoster = true;
                Console.WriteLine("You pick it up, obviously. Who wouldn't? ");
                Thread.Sleep(2500);
                Console.WriteLine("*gasps* What is it?");
                Thread.Sleep(2500);
                Console.WriteLine("...");
                Thread.Sleep(2500);
                Console.WriteLine("...");
                Thread.Sleep(2500);
                Console.WriteLine("... the suspense is killing me...");
                Thread.Sleep(2500);
                Console.WriteLine("It's a wanted- no, a missing poster, specked with a dark, brownish fluid. There is an illustration of a girl on the front, unnamed, with long, dark, matted hair. Freckles are ");
                Console.WriteLine("scattered across her dark brown skin like stars, and a birthmark covers the right of her face. There's a long, thin scar that cuts across one of her eyes, too. I wonder where it came from.");
                Thread.Sleep(8000);
                Console.WriteLine("");
                Console.WriteLine("She is beautiful. ");
                Thread.Sleep(4000);
                Console.WriteLine("Your heart breaks at the thought of where she could be right now, alone. Scared. Lost. No-one deserves this.");
                Console.WriteLine("");
                Thread.Sleep(5000);
                Console.WriteLine("You pull yourself out of your thoughts and put the poster in your pocket. There's an address on there, too. It just so happens that it is a house in the market village, ");
                Console.WriteLine($"so if you wanted to you could head over and ask about who this mysterious lady is, what happened to her. For now, though, you get back on {horseName} and continue ");
                Console.WriteLine("towards the market. ");
                Thread.Sleep(3000);
                Console.WriteLine("Press Enter to head to the next bit. ");
                Console.ReadLine();
                marketVisit();
            }
            else
            {
                Console.WriteLine("This is totally not your business. All you need right now is a milkshake, not a whole-ass mystery. You get back on {0} and continue towards the market. ", horseName);
                Thread.Sleep(1000);
                marketVisit();
            }
        }
        else
        {
            Console.WriteLine("It's probably nothing. And if it isn't nothing, it's probably dangerous. You get back on {0} and continue towards the market. Better safe than sorry. ", horseName); Thread.Sleep(1000);
            Thread.Sleep(1000);
            marketVisit();
        }
    }

    static void marketVisit()
    {
        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ off to the shops! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Thread.Sleep(2500);
        Console.WriteLine($"Finally, you have arrived, {playerName}! You get off and leave {horseName} at a stable but keep {goatName} with you in his pouch. Time to go shopping. You've got £{money: 0.00} with you right");
        Console.WriteLine("now. You could go straight to the milk, or check around at what else is available. Your choice.");
        Thread.Sleep(1000);
        Console.WriteLine("Buy milk / Browse");
        choice = Console.ReadLine();
        if (choice == "Browse") { browse(); }
        else
        {
            money = money - 2.50;
            hasMilk = true;
            Console.WriteLine("All you can think about right now is that sweet milkshake. You book it to the stall and exchange your money for some of that gorgeous white cow juice. ");
            Thread.Sleep(3000);
            Console.WriteLine($"You have £{money: 0.00} left. Do you want to look around now?");
            Thread.Sleep(1000);
            Console.WriteLine("Look around / Leave");
            choice = Console.ReadLine();
            if (choice == "Look around") { browse(); }
            else
            {
                Console.WriteLine("You judge that it is best to head straight home. Boring, but okAy i gUeSs uR tHe pLaYeR fiNe iF yOu wAnT tO bE boRinG");
                Thread.Sleep(3000);
                Console.WriteLine("Press Enter to continue to the next part. ");
                Console.ReadLine();
                afterMarket();
            }
        }





        static void browse()
        {
            Console.WriteLine("You've got time. The milk ain't got legs, it's not going anywhere. You take a look around. ");
            Thread.Sleep(3000);
            Console.WriteLine("On one side of the street you can see a couple of things for sale. There is a compass for £3.00, some rope for £2.80 and some sandwiches for 50p. ");
            Thread.Sleep(4000);
            if (hasSeenPoster == true)
            {
                Console.WriteLine("Of course, you might want to see if anyone around here knows something about the girl on that poster you found, or what-slash-who made those");
                Console.WriteLine("scratch marks behind or left that stuff. ");
                Thread.Sleep(6000);
                Console.WriteLine("Do you want to make a purchase? Or maybe do some detective work?");
                Thread.Sleep(1000);
                Console.WriteLine("Compass / Rope / Sandwiches / Ask around about the scratches and missing girl / Go to address on poster");
            }
            else if (hasSeenScratches == true)
            {
                Console.WriteLine("Of course you might want to see if anyone knows anything about all that stuff that got left behind in The Forest or what-slash-who made those");
                Console.WriteLine("scratch marks.");
                Thread.Sleep(6000);
                Console.WriteLine("Do you want to make a purchase? Or maybe do some detective work?");
                Thread.Sleep(1000);
                Console.WriteLine("Compass / Rope / Sandwiches / Ask around about the scratches");
            }
            else
            {
                Console.WriteLine("Do you want to make a purchase?");
                Thread.Sleep(1000);
                Console.WriteLine("Compass / Rope / Sandwiches / Keep money");

            }
            choice = Console.ReadLine();
            if (choice != "Ask around about the scratches" && choice != "Ask around about the scratches and missing girl" && choice != "Go to address on poster")
            {
                purchases();
            }
            else if (choice != "Go to address on poster")
            {
                askQuestionsAtTheMarket();
            }
            else
            {
                afterMarket();
            }
        }




        static void purchases()
        {
            while (choice != "Stop shopping")
            {
                if (choice == "Compass" && hasCompass == false)
                {
                    double possibleMoney = money - 3.00;
                    if (possibleMoney > 0)
                    {
                        money = money - 3.00;
                        Console.WriteLine("You buy the compass. You tuck it away on your coat and say thanks to the shopkeeper. ");
                        hasCompass = true;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for this right now. ");
                    }

                }
                else if (choice == "Compass")
                {
                    Console.WriteLine("You already have this. ");
                }
                else if (choice == "Rope" && hasRope == false)
                {
                    double possibleMoney = money - 2.80;
                    if (possibleMoney > 0)
                    {
                        money = money - 2.80;
                        Console.WriteLine("You buy the rope. You tuck it away on your coat and say thanks to the shopkeeper. ");
                        hasRope = true;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for this right now. ");
                    }
                }
                else if (choice == "Rope")
                {
                    Console.WriteLine("You already have this. ");
                }
                else if (choice == "Sandwiches" && hasSandwiches == false)
                {
                    double possibleMoney = money - 0.50;
                    if (possibleMoney > 0)
                    {
                        money = money - 0.50;
                        Console.WriteLine("You buy the sandwiches. You tuck them away on your coat and say thanks to the shopkeeper. ");
                        hasSandwiches = true;
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money for this right now. ");
                    }

                }
                else if (choice == "Sandwiches")
                {
                    Console.WriteLine("You already have these. ");
                }
                Thread.Sleep(3000);
                Console.WriteLine($"You have £{money:0.00} left over. Would you like to buy anything else? Bare in mind that you can only purchase any of these items once. ");
                Thread.Sleep(1000);
                Console.WriteLine("Compass / Rope / Sandwiches / Stop shopping");
                choice = Console.ReadLine();
                if (choice != "Compass" && choice != "Rope" && choice != "Sandwiches")
                {
                    choice = "Stop shopping";
                }
            }
            if (hasMilk == true)
            {
                Console.WriteLine("Now you've finished with your shopping spree, you have a chance to check out any of the clues you've discovered. Or you can just leave.");
                Thread.Sleep(1000);
                if (hasSeenScratches == true && hasSeenPoster == true)
                {
                    Console.WriteLine("Ask around about the scratches and missing girl / Go to address on poster / Leave");
                    choice = Console.ReadLine();
                    if (choice == "Ask around about the scratches and missing girl")
                    {
                        Console.WriteLine("Time to put on your detective hat! ");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press Enter to continue. ");
                        Console.ReadLine();
                        askQuestionsAtTheMarket();
                    }
                    else if (choice == "Go to address on poster")
                    {
                        Console.WriteLine("Time to put on your detective hat! ");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press Enter to continue. ");
                        Console.ReadLine();
                        goToAddressOnPoster();
                    }
                    else
                    {
                        Console.WriteLine("Time to get going, then. There isn't anything left to do here. ");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press Enter to continue. ");
                        Console.ReadLine();
                        afterMarket();
                    }
                }
                else if (hasSeenScratches == true)
                {
                    Console.WriteLine("Ask around about the scratches / Leave");
                    choice = Console.ReadLine();
                    if (choice == "Ask around about the scratches")
                    {
                        Console.WriteLine("Time to put on your detective hat! ");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press Enter to continue. ");
                        Console.ReadLine();
                        askQuestionsAtTheMarket();
                    }
                    else
                    {
                        Console.WriteLine("Time to get going, then. ");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press Enter to continue. ");
                        Console.ReadLine();
                        afterMarket();
                    }

                }
                else
                {
                    Console.WriteLine("You leave the market and begin the journey home. ");
                    afterMarket();
                }
            }
            else
            {
                money -= 2.50;
                Console.WriteLine("You go ahead and get the milk for £2.50. You have £{0} left. ", money);
                if (hasSeenScratches == true && hasSeenPoster == true)
                {
                    Console.WriteLine("You've still got a chance to ask about anything you found. Or you could just leave. ");
                    Console.WriteLine("Ask around about the scratches and missing girl / Go to address on poster / Leave");
                    choice = Console.ReadLine();
                    if (choice == "Ask around about the scratches and missing girl")
                    {
                        askQuestionsAtTheMarket();
                    }
                    else if (choice == "Go to address on poster")
                    {
                        goToAddressOnPoster();
                    }
                    else
                    {
                        afterMarket();
                    }
                }
                else if (hasSeenScratches == true)
                {
                    Console.WriteLine("You've still got a chance to ask about anything you found. Or you could just leave. ");
                    Console.WriteLine("Ask around about the scratches / Leave");
                    choice = Console.ReadLine();
                    if (choice == "Ask about the scratches")
                    {
                        askQuestionsAtTheMarket();
                    }
                    else
                    {
                        Console.WriteLine("Time to go then. Boring, but okAy i gUeSs uR tHe pLaYeR");
                        Thread.Sleep(3000);
                        Console.WriteLine("Press Enter to proceed. ");
                        Console.ReadLine();
                        afterMarket();
                    }
                }
                else
                {
                    Console.WriteLine("You leave the market and begin the journey home. ");
                    afterMarket();
                }
            }
        }
    }


    static void askQuestionsAtTheMarket()
    {
        Console.WriteLine($"Time to put on your detective hat, {playerName}!");
        Console.WriteLine("The market is bustling with activity. The streets are scattered with vendors and hagglers, and the roads are filled with children playfully running around with each other. ");
        Thread.Sleep(6000);
        Console.WriteLine("Across the street, an old woman is stood with her head buried in a chunky book. The cover is damp and the ink is smudged, concealing its title from view. Her crooked nose ");
        Console.WriteLine("sticks out at an angle, dripping with snot, and her mouth hangs slack, overflowing with drool.");
        Thread.Sleep(7000);
        Console.WriteLine("She doesn't really seem... present. If she wasn't standing I'd have assumed she was dead, as her chest is almost completely still and her posture is entirely rigid.");
        Thread.Sleep(5000);
        Console.WriteLine("");
        Console.WriteLine("Could she know anything?");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine("A younger man sits by the roadside, frantically emptying his pockets and his bags. Has he lost something?");
        Thread.Sleep(4500);
        Console.WriteLine("Packets of important-looking papers, bunches of fruit and plenty of household items roll around on the ground as he rummages though his bag, but as he gathers his things to ");
        Console.WriteLine("leave, a photo drops out of his pocket. He must not notice, because he doesn't go back for it- he just paces down the street again. ");
        Thread.Sleep(7200);
        Console.WriteLine("");
        Console.WriteLine("He probably didn't do that on purpose. Could be nice to return it to him. ");
        Thread.Sleep(3000);
        Console.WriteLine("");
        Console.WriteLine("In the distance, you can also make out a bunch of kids playing around in leaflitter while a very small, frail girl lies by herself by a tree. She's looking at them wistfully,");
        Console.WriteLine("and seems a little lost, sad maybe. ");
        Thread.Sleep(6000);
        Console.WriteLine($"Who do you approach, {playerName}? Bare in mind you might not get a chance to talk to them all.");
        Thread.Sleep(1000);
        Console.WriteLine("Old woman / Young man / Child");
        choice = Console.ReadLine();
        if(choice == "Old woman")
        {
            oldWoman();
        }
        //if (hasSeenPoster == true)
        //{
            //hasAllClues();
        //}
        //else
        //{
            //hasOneClue();
        //}
    }

    static void oldWoman()
    {
        Console.WriteLine("You approach the ancient lady, quietly hoping you don't give her a heart attack from the shock of interaction. You half-smile at her as you near, but it isn't really a full ");
        Console.WriteLine("I'm-loving-life-smile so much as an unenthusiastic, polite one to signal you're not 'one of those' young people. The one you always save for old folk. ");
        Thread.Sleep(4000);
        Console.WriteLine("The woman is directly in front of you now, although she hasn't acknowledged you at all. Rude. Or does she need help?");
        Thread.Sleep(3000);
        Console.WriteLine("I guess you should probably say... something. I don't know how to handle this situation lol pick one.");
        Thread.Sleep(1000);
        Console.WriteLine("'Good day to you, ma'am. How do you do?' / 'Sup, lady, you alright? Are you even alive?' / 'You seen this girl before?'");
        Console.ReadLine();
        Console.WriteLine("You almost see a twitch in the woman's eyes. I almost see it, too. But no response. Poor soul. ");
        Thread.Sleep(4000);
        Console.WriteLine("You peel away in defeat, and yo-");
        Thread.Sleep(1000);
        Console.WriteLine("With a horrific 'SNAP!' the old woman's head turns sharply to face you. ");
        Thread.Sleep(1000);
        Console.WriteLine("Her once dull, lifeless eyes roll back so impossibly far that only the whites are visible, and her dry, spit-covered mouth widens with several more spine-chilling cracks");
        Console.WriteLine("and releases a blood-curdling screech. ");
        Console.WriteLine("You want to move. No, you NEED to move. But you're paralysed, either from fear or as the result of another strange.");
    }
    static void hasAllClues()
    {

    }

    static void hasOneClue()
    {

    }

    static void goToAddressOnPoster()
    {

    }


    static void afterMarket()
    {

    }
}
