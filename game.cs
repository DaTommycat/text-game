using System;

public class Program
{
	public static void Main()
	{
		string input = "10101";
		string[] History = new string[50];
		int inventory = 0;
		string inputString = "";
		string location = "gameStart";
		Game obj = new Game();
		obj.GameMenu();
		inputString = Console.ReadLine();
		obj.GameName();
		inputString = Console.ReadLine();
		string name = inputString;
		obj.GameStart();
		inputString = Console.ReadLine();
		obj.GameIntro(name);
		inputString = Console.ReadLine();
		obj.GameStartingPoint();
		inputString = Console.ReadLine();
		obj.LocationStart();
		int loopCheck = 0;
		while (inputString != "End Program")
		{
			
			if (location == "gameStart" && input == "10101")
			{
				loopCheck = 0;
				obj.LocationStart();
				input = Console.ReadLine();
			}

			if (location == "gameStart" && input == "1")
			{
				loopCheck = 0;
				location = "storage";
				input = "10101";
			}

			if (location == "gameStart" && input == "2")
			{
				loopCheck = 0;
				location = "Town Hall";
				input = "10101";
			}

			if (location == "Town Hall" && input == "10101")
			{
				loopCheck = 0;
				obj.TownHall();
				input = Console.ReadLine();
			}

			if (location == "Town Hall" && input == "1")
			{
				loopCheck = 0;
				location = "gameStart";
				input = "10101";
			}

			if (location == "storage" && input == "10101")
			{
				loopCheck = 0;
				obj.HomeStorage();
				input = Console.ReadLine();
			}

			if (input == "1" && location == "storage" && History[0] != "Inv")
			{
				loopCheck = 0;
				obj.Storage();
				inventory = 1;
				History[0] = "Inv";
				input = Console.ReadLine();
				input = "10101";
			}

			if (input == "1" && location == "storage" && History[0] == "Inv")
			{
				loopCheck = 0;
				Console.WriteLine("You have already taken the backpack! (Type anything to continue.)");
				input = Console.ReadLine();
				input = "10101";
			}

			if (input == "inv" && inventory == 1)
			{
				loopCheck = 0;
				obj.InventoryShow();
				input = Console.ReadLine();
				input = "10101";
			}

			if (input == "2" && location == "storage")
			{
				loopCheck = 0;
				location = "gameStart";
				input = "10101";
			}

			if (input == "2" && location == "Town Hall")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}

			if (input == "10101" && location == "Item Store")
			{
				loopCheck = 0;
				obj.ItemStore();
				input = Console.ReadLine();
			}

			if (input == "1" && location == "Item Store")
			{
				loopCheck = 0;
				location = "Town Hall";
				input = "10101";
			}

			if (input == "3" && location == "Item Store")
			{
				loopCheck = 0;
				location = "Item Store Hall";
				input = "10101";
			}

			if (input == "10101" && location == "Item Store Hall")
			{
				loopCheck = 0;
				obj.ItemStoreHall();
				input = Console.ReadLine();
			}

			if (input == "2" && location == "Item Store Hall" && History[3] != "Green Book")
			{
				loopCheck = 0;
				location = "Item Store Hall Dialogue";
				input = "10101";
			}
			
			if (input == "2" && location == "Item Store Hall" && History[3] == "Green Book")
			{
				loopCheck = 0;
				location = "Item Store Hall Dialogue BookFound";
				input = "10101";
			}
			
			if (input == "10101" && location == "Item Store Hall Dialogue BookFound" && History[4] != "10 Coins")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogueBookFound();
				input = Console.ReadLine();
				obj.tenCoinsInventory();
				input = Console.ReadLine();
				location = "Item Store Hall";
				input = "10101";
				History[4] = "10 Coins";
			}
			
			if (input == "10101" && location == "Item Store Hall Dialogue BookFound" && History[4] == "10 Coins")
			{
				loopCheck = 0;
				obj.PanicGuyDialogueNONEED();
				input = Console.ReadLine();
				location = "Item Store Hall";
				input = "10101";
			}

			if (input == "1" && location == "Item Store Hall")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}

			if (input == "10101" && location == "Item Store Hall Dialogue" && History[3] != "Green Book")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogue();
				input = Console.ReadLine();
			}

			if (input == "4" && location == "Item Store Hall Dialogue1" || input == "4" && location == "Item Store Hall Dialogue" || input == "4" && location == "Item Store Hall Dialogue2")
			{
				loopCheck = 0;
				location = "Item Store Hall";
				input = "10101";
			}

			if (input == "2" && location == "Item Store Hall Dialogue Worth")
			{
				loopCheck = 0;
				location = "Item Store Hall";
				input = "10101";
			}

			if (input == "1" && location == "Item Store Hall Dialogue")
			{
				loopCheck = 0;
				location = "Item Store Hall Dialogue1";
				input = "10101";
			}

			if (input == "2" && location == "Item Store Hall Dialogue")
			{
				loopCheck = 0;
				location = "Item Store Hall Dialogue2";
				input = "10101";
			}

			if (input == "10101" && location == "Item Store Hall Dialogue1")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogue1();
				input = Console.ReadLine();
			}

			if (input == "10101" && location == "Item Store Hall Dialogue2")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogue2();
				input = Console.ReadLine();
			}

			if (input == "3" && location == "Item Store Hall Dialogue2" || input == "3" && location == "Item Store Hall Dialogue1" || input == "3" && location == "Item Store Hall Dialogue")
			{
				loopCheck = 0;
				location = "Item Store Hall DialogueMean";
				input = "10101";
			}

			if (input == "10101" && location == "Item Store Hall DialogueMean")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogueSucksToBeYou();
				input = Console.ReadLine();
				location = "Item Store Hall";
				input = "10101";
			}

			if (input == "1" && location == "Item Store Hall Dialogue1" || input == "1" && location == "Item Store Hall Dialogue2")
			{
				loopCheck = 0;
				location = "Item Store Hall Dialogue Worth";
				input = "10101";
			}

			if (input == "10101" && location == "Item Store Hall Dialogue Worth")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogueworthit();
				input = Console.ReadLine();
			}

			if (location == "Item Store Hall Dialogue Worth" && input == "1" || location == "Item Store Hall Dialogue1" && input == "2" || location == "Item Store Hall Dialogue2" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store Hall Dialogue Description";
				input = "10101";
			}

			if (location == "Item Store Hall Dialogue Description" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Hall";
				input = "10101";
			}

			if (location == "Item Store Hall Dialogue Description" && input == "10101")
			{
				loopCheck = 0;
				obj.ItemStoreHallDialogueBookDescription();
				input = Console.ReadLine();
			}

			if (location == "Item Store" && input == "2" && History[4] != "10 Coins")
			{
				loopCheck = 0;
				location = "Item Store Clerk";
				input = "10101";
			}
			
				if (location == "Item Store" && input == "2" && History[4] == "10 Coins")
			{
				loopCheck = 0;
				location = "Item Store Clerk KeyBuy";
				input = "10101";
			}
			
			if (location == "Item Store Clerk KeyBuy" && input == "10101")
			{
				loopCheck = 0;
				obj.ItemStoreClerkKeyBuy();
				input = Console.ReadLine();
			}
			
			if (location == "Item Store Clerk KeyBuy" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}

			if (location == "Item Store Clerk KeyBuy" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Clerk KeyBought";
				input = "10101";
			}
			
			if (location == "Item Store Clerk KeyBought" && input == "10101" && History[5] != "key")
			{
				loopCheck = 0;
				obj.ItemStoreClerk10KeyBought();
				input = Console.ReadLine();
				History[5] = "key";
				location = "Item Store";
				input = "10101";
			}
			
			if (location == "Item Store Clerk KeyBought" && input == "10101" && History[5] == "key")
			{
				loopCheck = 0;
				obj.ItemStoreClerkKeyBoughtAlready();
				input = Console.ReadLine();
				location = "Item Store";
				input = "10101";
			}
			
			if (location == "Item Store Clerk" && input == "10101")
			{	
				loopCheck = 0;
				obj.ItemStoreClerk();
				input = Console.ReadLine();
			}

			if (location == "Item Store Clerk" && input == "3" || location == "Item Store Clerk Look" && input == "2" || location == "Item Store Clerk Cheap" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}

			if (location == "Item Store Clerk Cheap" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}

			if (location == "Item Store Clerk" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Clerk Look";
				input = "10101";
			}

			if (location == "Item Store Clerk Look" && input == "10101")
			{
				loopCheck = 0;
				obj.ItemStoreClerkWierdLooks();
				input = Console.ReadLine();
			}

			if (location == "Item Store Clerk" && input == "2" || location == "Item Store Clerk Look" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Clerk Cheap";
				input = "10101";
			}

			if (location == "Item Store Clerk Cheap" && input == "10101")
			{
				loopCheck = 0;
				obj.ItemStoreClerkCheapItems();
				input = Console.ReadLine();
			}

			if (location == "Item Store Clerk Cheap" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Clerk Cheap 10 Coins";
				input = "10101";
			}

			if (location == "Item Store Clerk Cheap 10 Coins" && input == "10101")
			{
				loopCheck = 0;
				obj.ItemStoreClerk10Coins();
				input = Console.ReadLine();
				location = "Item Store";
				input = "10101";
			}

			if (location == "Item Store Hall" && input == "3")
			{
				loopCheck = 0;
				location = "Item Store Potions";
				input = "10101";
			}

			if (location == "Item Store Potions" && input == "10101")
			{
				loopCheck = 0;
				obj.ItemStorePotions();
				input = Console.ReadLine();
			}

			if (location == "Item Store Potions" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store Hall";
				input = "10101";
			}

			if (location == "Item Store Potions" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStorePotionDialogue();
				input = Console.ReadLine();
			}

			if (location == "Item Store Potions Dialogue" && input == "3")
			{
				loopCheck = 0;
				location = "Item Store Potions";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue" && input == "2" || location == "Item Store Potions Dialogue Function" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue Cost";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Function" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store Potions";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue Function";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Cost" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStorePotionDialoguePotionCost();
				input = Console.ReadLine();
			}

			if (location == "Item Store Potions Dialogue Function" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStorePotionDialoguePotionFunction();
				input = Console.ReadLine();
			}

			if (location == "Item Store Potions Dialogue Cost" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue Free";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Free" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStorePotionDialogueFree();
				input = Console.ReadLine();
			}

			if (location == "Item Store Potions Dialogue Cost" && input == "2" && History[0] != "Inv" || location == "Item Store Potions Dialogue Free" && input == "1" && History[0] != "Inv")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue ItemFail";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Cost" && input == "2" && History[0] == "Inv" && History[1] != "ItemStorePotionSip")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue ItemWin";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Free" && input == "1" && History[0] == "Inv" && History[1] != "ItemStorePotionSip")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue ItemWin";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Cost" && input == "2" && History[0] == "Inv" && History[1] == "ItemStorePotionSip")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue ItemSip";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue Free" && input == "1" && History[0] == "Inv" && History[1] == "ItemStorePotionSip")
			{
				loopCheck = 0;
				location = "Item Store Potions Dialogue ItemSip";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue ItemFail" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStorePotionDialogueItemCollectFail();
				input = Console.ReadLine();
				location = "Item Store Potions";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue ItemWin" && input == "10101")
			{
				loopCheck = 0;
				History[1] = "ItemStorePotionSip";
				obj.itemStorePotionDialogueItemCollectSuccess();
				input = Console.ReadLine();
				location = "Item Store Potions";
				input = "10101";
			}

			if (location == "Item Store Potions Dialogue ItemSip" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStorePotionDialogue1sip();
				input = Console.ReadLine();
				location = "Item Store Potions";
				input = "10101";
			}

			if (location == "Item Store" && input == "4")
			{
				loopCheck = 0;
				location = "Item Store Upstairs";
				input = "10101";
			}

			if (location == "Item Store Upstairs" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStoreUpstairs();
				input = Console.ReadLine();
			}

			if (location == "Item Store Upstairs" && input == "1")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}

			if (location == "Item Store Upstairs" && input == "2" && History[1] != "ItemStorePotionSip")
			{
				loopCheck = 0;
				location = "Item Store Upstairs Dark SpotNOSIP";
				input = "10101";
			}

			if (location == "Item Store Upstairs" && input == "2" && History[1] == "ItemStorePotionSip")
			{
				loopCheck = 0;
				location = "Item Store Upstairs Dark SpotSIP";
				input = "10101";
			}

			if (location == "Item Store Upstairs Dark SpotSIP" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStoreUpstairsDarkSpotSIP();
				input = Console.ReadLine();
			}
			
			if (location == "Item Store Green Book" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStoreUpstairsDarkSpotSIPGreenBook();
				input = Console.ReadLine();
				History[3] = "Green Book";
				location = "Item Store Upstairs";
				input = "10101";
			}
			
			if (location == "Item Store Upstairs Dark SpotSIP" && input == "2")
			{
				loopCheck = 0;
				location = "Item Store";
				input = "10101";
			}
			
			if (location == "Item Store Upstairs Dark SpotSIP" && input == "1" && History[3] != "Green Book")
			{
				loopCheck = 0;
				location = "Item Store Green Book";
				input = "10101";
			}

			if (location == "Item Store Upstairs Dark SpotSIP" && input == "1" && History[3] == "Green Book")
			{
				loopCheck = 0;
				location = "Item Store Green Book Taken";
				input = "10101";
			}

			if (location == "Item Store Green Book Taken" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStoreUpstairsDarkSpotSIPGreenBookTaken();
				input = Console.ReadLine();
				location = "Item Store Upstairs";
				input = "10101";
			}

			if (location == "Item Store Upstairs Dark SpotNOSIP" && input == "10101")
			{
				loopCheck = 0;
				obj.itemStoreUpstairsDarkSpot();
				input = Console.ReadLine();
				location = "Item Store";
				input = "10101";
			}
			
			if (location == "Town Hall" && input == "3")
			{
				loopCheck = 0;
				location = "Town Gate";
				input = "10101";
				
			}
			
			if (location == "Town Gate" && input == "10101")
			{
				loopCheck = 0;
				obj.TownEntrance();
				input = Console.ReadLine();
			}
			
			if (location == "Town Gate" && input == "1")
			{
				loopCheck = 0;
				location = "Town Hall";
				input = "10101";
			}
			
			if (location == "Town Gate" && input == "2")
			{
				loopCheck = 0;
				location = "Town Gate Dialogue1";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue1" && input == "10101")
			{
				loopCheck = 0;
				obj.TownEntranceGuardDialogue();
				input = Console.ReadLine();
			}
			
			if (location == "Town Gate Dialogue1" && input == "1")
			{
				loopCheck = 0;
				location = "Town Gate Dialogue Ynot";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue Ynot" && input == "10101")
			{
				loopCheck = 0;
				obj.TownEntranceGuardDialogueYnot();
				input = Console.ReadLine();
			}
			
			if (location == "Town Gate Dialogue Ynot" && input == "2")
			{
				loopCheck = 0;
				location = "Town Gate";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue Ynot" && input == "1")
			{
				loopCheck = 0;
				location = "Town Gate Dialogue ReasonYnot";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue ReasonYnot" && input == "10101")
			{
				loopCheck = 0;
				obj.TownEntranceGuardDialogueReasonWhyNot();
				input = Console.ReadLine();
			}
			
			if (location == "Town Gate Dialogue ReasonYnot" && input == "1")
			{
				loopCheck = 0;
				location = "Town Gate";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue1" && input == "4")
			{
				loopCheck = 0;
				location = "Town Gate";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue1" && input == "2")
			{
				loopCheck = 0;
				location = "Town Gate Dialogue ReasonYnot";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue1" && input == "3")
			{
				loopCheck = 0;
				location = "Town Gate Dialogue insulting";
				input = "10101";
			}
			
			if (location == "Town Gate Dialogue insulting" && input == "10101")
			{
				loopCheck = 0;
				obj.TownEntranceGuardInsulting();
				input = Console.ReadLine();
			}
			
			if (location == "Town Gate Dialogue insulting" && input == "1")
			{
				loopCheck = 0;
				location = "Town Gate";
				input = "10101";
			}
			
			if (location == "Town Gate" && input == "3" && History[5] != "key")
			{
				loopCheck = 0;
				location = "Town Gate Locked";
				input = "10101";
			}
			
			if (location == "Town Gate Locked" && input == "10101")
			{
				loopCheck = 0;
				obj.TownEntranceGateLocked();
				input = Console.ReadLine();
				location = "Town Gate";
				input = "10101";
			}
			 
			if (location == "Town Gate" && input == "3" && History[5] == "key")
			{
				loopCheck = 0;
				location = "Town Gate Open";
				input = "10101";
			}
			
			loopCheck++;
			if (loopCheck == 3)
			{
				Console.WriteLine("Please write down one of the options.");
				input = Console.ReadLine();
				loopCheck = 0;
			}
		}
	}
}

public class Game
{
	public string itemConfirm = "false";
	string[] inventory = new string[50];
	public void GameMenu()
	{
		Console.WriteLine("                               ===== TEXTWORLD. =====");
		Console.WriteLine("              ( *^-^)ρ(*╯^╰)                                <( ￣^￣)(θ(θ☆( >_<)");
		Console.WriteLine("ヾ(≧▽≦*)o                                                                        (っ °Д °;)っ");
		Console.WriteLine("            ╚(•⌂•)╝             Type anything to begin.                  (▀̿Ĺ̯▀̿ ̿)");
		Console.WriteLine("                   o(￣┰￣*)ゞ                             ༼ つ ◕_◕ ༽つ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
	}

	public void GameName()
	{
		Console.Clear();
		Console.WriteLine("Please choose your name?");
	}

	public void GameStart()
	{
		Console.Clear();
		Console.WriteLine("█████ █████ █████ █████ █████");
		Console.WriteLine("█       █   █   █ █   █   █  ");
		Console.WriteLine("█████   █   █████ █████   █  ");
		Console.WriteLine("    █   █   █   █ █  █    █  ");
		Console.WriteLine("█████   █   █   █ █   █   █  ");
		Console.WriteLine("Type anything to continue through the overdramatic starting screen.");
	}

	public void GameIntro(string a)
	{
		Console.Clear();
		Console.WriteLine("You, " + a + ", aren't like the other emoticons.");
		Console.WriteLine("You're supposed to be a bunch of symbols, but you're... an emoji...?");
		Console.WriteLine("Type any number shown to speak");
		Console.WriteLine("1 → 'Who is saying that?'");
		Console.WriteLine("2 → 'Why am I not like the others?'");
		Console.WriteLine("3 → 'STOP DISCRIMINATING ME.'");
	}

	public void GameStartingPoint()
	{
		Console.Clear();
		Console.WriteLine("You wake up and realize you were talking to yourself. There is nobody there.");
		Console.WriteLine("Type anything to continue.");
	}

	public void LocationStart()
	{
		Console.Clear();
		Console.WriteLine("Location: Home.");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|            Storage           Exit|");
		Console.WriteLine("| 🙂           ◘                ◘  ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("You wake up in your house. The door to exit is in front of you.");
		Console.WriteLine("There is another door that leads to the storage of your house.");
		Console.WriteLine("Your bed is behind you.");
		Console.WriteLine("1 → Go to the storage room.");
		Console.WriteLine("2 → Go to the exit.");
	}

	public void HomeStorage()
	{
		Console.Clear();
		Console.WriteLine("Location: Home storage.");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|          Chest       Storage exit|");
		Console.WriteLine("| 🙂        ◚                ◘  ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("You are now in the storage. It's quite dark in here.");
		Console.WriteLine("There is a chest in front of you holding items.");
		Console.WriteLine("The exit is further back.");
		Console.WriteLine("1 → Open your storage.");
		Console.WriteLine("2 → Go to the exit.");
	}

	public void Storage()
	{
		Console.WriteLine("You find a backpack and some gloves, you put both on.");
		Console.WriteLine("-- Inventory unlocked (Type 'inv' at any time to see what is in your backpack.) --");
		Console.WriteLine("Type anything to continue.");
	}

	public void InventoryShow()
	{
		int inventoryCount = 0;
		int inventoryItemCount = 0;
		Console.WriteLine("Inventory:");
		while (inventoryCount != inventory.Length)
		{
			if (inventory[inventoryCount] != null)
			{
				Console.WriteLine(inventory[inventoryCount]);
				inventoryItemCount++;
			}

			inventoryCount++;
		}

		if (inventoryItemCount == 0)
		{
			Console.WriteLine("Your backpack is empty. (Type anything to continue.)");
		}
	}

	public void TownHall()
	{
		Console.Clear();
		Console.WriteLine("Location: Town Hall.");
		Console.WriteLine("|                                  ");
		Console.WriteLine("|   ooOo                      oOo        oOoo  ");
		Console.WriteLine("|            Item Store            ");
		Console.WriteLine("|     Home      ——                  ");
		Console.WriteLine("|     ___      |  |                ");
		Console.WriteLine("| 🙂 |  |     |   |                ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("");
		Console.WriteLine("You are now in the middle of the town hall. The bright sky is clear with little clouds scattered around.");
		Console.WriteLine("An item store is farther back, with two floors. There's a worn out sign in tiny letters saying 'item store'.");
		Console.WriteLine("Further ahead are more buildings, and behind you is the exit to the village.");
		Console.WriteLine("");
		Console.WriteLine("1 → Return home.");
		Console.WriteLine("2 → Go to item store.");
		Console.WriteLine("3 → Go back to the village entrance.");
		Console.WriteLine("4 → Go further into the village.");
	}
	
	public void TownFurther()
	{
		Console.Clear();
		Console.WriteLine("Location: Town Center.");
		Console.WriteLine("|                                  ");
		Console.WriteLine("|   ooOo                      oOo        oOoo  ");
		Console.WriteLine("|            Item Store            ");
		Console.WriteLine("|     Home      ——                  ");
		Console.WriteLine("|     ___      |  |                ");
		Console.WriteLine("| 🙂 |  |     |   |                ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("");
		Console.WriteLine("You are now in the middle of the town hall. The bright sky is clear with little clouds scattered around.");
		Console.WriteLine("An item store is farther back, with two floors. There's a worn out sign in tiny letters saying 'item store'.");
		Console.WriteLine("Further ahead are more buildings, and behind you is the exit to the village.");
		Console.WriteLine("");
		Console.WriteLine("1 → Return home.");
		Console.WriteLine("2 → Go to item store.");
		Console.WriteLine("3 → Go back to the village entrance.");
		Console.WriteLine("4 → Go further into the village.");
	}
	
	public void TownEntrance()
	{
		Console.Clear();
		Console.WriteLine("Location: Town Gate.");
		Console.WriteLine("|                                  ");
		Console.WriteLine("|           ooOo      ooO          ");
		Console.WriteLine("|                                  ");
		Console.WriteLine("|                                  ");
		Console.WriteLine("|                                  ");
		Console.WriteLine("| 🙂                      (▀̿Ĺ̯▀̿ ̿)   ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("");
		Console.WriteLine("You are now in front of the town gate that separates this town from the outside. It is a lot more quiet and peaceful out in the edge of the village.");
		Console.WriteLine("There is a guard standing next to the gate door.");
		Console.WriteLine("");
		Console.WriteLine("1 → Return to main area.");
		Console.WriteLine("2 → Talk to guard.");
		Console.WriteLine("3 → Try to leave the village through the gate door.");
	}
	
	public void TownEntranceGateLocked()
	{
		Console.Clear();
		Console.WriteLine("The gate is locked. If only you had a key...");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}
	
	public void TownEntranceGateOpen()
	{
		Console.Clear();
		Console.WriteLine("You unlocked the gate with the key to get through. The guard locks it back as you leave the village.");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}
	
	public void TownEntranceGuardDialogue()
	{
		Console.Clear();
		
		Console.WriteLine("              (▀̿Ĺ̯▀̿ ̿)               ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'What do you want, buddy?'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Am I allowed to go through here'");
		Console.WriteLine("2 → 'What is the gate for?'");
		Console.WriteLine("3 → 'You look stupid with those ugly sunglasses!'");
		Console.WriteLine("4 → Stop talking.");
	}
	
	public void TownEntranceGuardDialogueYnot()
	{
		Console.Clear();
		
		Console.WriteLine("              (▀̿Ĺ̯▀̿ ̿)               ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Unless you have a gate key, no.'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Why not?'");
		Console.WriteLine("2 → 'Stop talking.'");
	}
	
	public void TownEntranceGuardDialogueReasonWhyNot()
	{
		Console.Clear();	
		
		Console.WriteLine("              (▀̿Ĺ̯▀̿ ̿)               ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'This town gate is here to protect the citizens from the dangerous creatures outside.'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Stop talking.'");
	}

	public void TownEntranceGuardInsulting()
	{
		Console.Clear();
		
		Console.WriteLine("              (▀̿Ĺ̯▀̿ ̿)               ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'This always how you talk to strangers?'");
		Console.WriteLine();
		Console.WriteLine("1 → Stop talking.");
	}
	
	public void ItemStore()
	{
		Console.Clear();
		Console.WriteLine("Location: Item Store.");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                 _|               |");
		Console.WriteLine("|               _|                 |");
		Console.WriteLine("| exit        _|                   |");
		Console.WriteLine("|  ◘  🙂   _|     ┳━┳ ノ( ゜-゜ノ)");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("You are now in the item store of the village. The clerk gives you a weird look.");
		Console.WriteLine("To your right there are stairs leading to the second floor. You also see a hall leading to another section item store.");
		Console.WriteLine("The exit is further back.");
		Console.WriteLine("");
		Console.WriteLine("1 → Exit the shop.");
		Console.WriteLine("2 → Talk to the clerk.");
		Console.WriteLine("3 → Go to the hall to your right.");
		Console.WriteLine("4 → Go to the floor above.");
	}

	public void ItemStoreHall()
	{
		Console.Clear();
		Console.WriteLine("Location: Item Store Hall.");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine(" ___________________________________");
		Console.WriteLine("◪      ◪      ◪      ◪      ◪      ◪   ");
		Console.WriteLine("  🙂                       (っ °Д °;)っ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("");
		Console.WriteLine("You are now in the item store hall. Light from the windows illuminate the shelves, which are full of books.");
		Console.WriteLine("Near the end of the hall is a person frantically walking in circles.");
		Console.WriteLine("You also see a section that says 'potions' in another direction.");
		Console.WriteLine("");
		Console.WriteLine("1 → Go back to the item store entrance.");
		Console.WriteLine("2 → Talk to the frantic person.");
		Console.WriteLine("3 → Go to the 'potions' section.");
	}

	public void ItemStoreHallDialogue()
	{
		Console.Clear();
		Console.WriteLine("(ノ '°_°;)っ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Where did I leave it...?' he mutters to himself.");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Hey, you good?'");
		Console.WriteLine("2 → 'You need any help?'");
		Console.WriteLine("3 → 'Shush, this is a library.'");
		Console.WriteLine("4 → Stop talking.");
	}

	public void ItemStoreHallDialogue1()
	{
		Console.Clear();
		Console.WriteLine("(っ´°_°;)⊃");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Nah, man. I left my book right over here and now I can't find it.'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Is it really worth making a big deal about?'");
		Console.WriteLine("2 → 'What does it look like? Maybe I can help you find it.'");
		Console.WriteLine("3 → Sucks to be you, LOL!.");
		Console.WriteLine("4 → Stop talking.");
	}

	public void ItemStoreHallDialogue2()
	{
		Console.Clear();
		Console.WriteLine("(っ´°_°;)⊃");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Yeah, I can't find my book.'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Is it really worth making a big deal about?'");
		Console.WriteLine("2 → 'What does it look like? Maybe I can help you find it.'");
		Console.WriteLine("3 → Sucks to be you, LOL!");
		Console.WriteLine("4 → Stop talking.");
	}

	public void ItemStoreHallDialogueSucksToBeYou()
	{
		Console.Clear();
		Console.WriteLine("(っ Ǒ_ó;)ノ");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'...'");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}

	public void ItemStoreHallDialogueworthit()
	{
		Console.Clear();
		Console.WriteLine("(っ´°Д °;)⊃");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Well, I owe someone it and he'll kill me if I don't find it!'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'What does it look like? Maybe I can help you find it.'");
		Console.WriteLine("2 → Stop talking.");
	}
	
	public void ItemStoreHallDialogueBookFound()
	{
		Console.Clear();
		Console.WriteLine("(っ´°∀ °;)⊃");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Hey, thanks for finding my green book! Here's 10 coins.'");
		Console.WriteLine("");
		Console.WriteLine("1 → Take 10 coins");
	}

	public void ItemStoreHallDialogueBookDescription()
	{
		Console.Clear();
		Console.WriteLine("(っ´°∀ °;)⊃");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("");
		Console.WriteLine("'Oh, thanks. Well, the book is called Great Green, and it's the color green. If you find it, I'll give you 10 coins!'");
		Console.WriteLine("");
		Console.WriteLine("1 → 'Thanks.'");
	}

	public void ItemStoreClerk()
	{
		Console.Clear();
		Console.WriteLine("ノ( ゜-゜ノ)");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("He is still giving you a weird look.");
		Console.WriteLine();
		Console.WriteLine("1 → 'Why are you giving me weird looks'.");
		Console.WriteLine("2 → 'What kinda cheap items you got?'");
		Console.WriteLine("3 → Stop talking.");
	}
	
	public void ItemStoreClerkKeyBuy()
	{
		Console.Clear();
		Console.WriteLine("ノ( ゜-゜ノ)");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("He is still giving you a weird look.");
		Console.WriteLine();	
		Console.WriteLine("1 → I wanna buy that key with my 10 coins!");
		Console.WriteLine("2 → Stop talking.");
	}
	
	public void ItemStoreClerk10KeyBought()
	{
		Console.Clear();
		Console.WriteLine("You have obtained the key.");
		Console.WriteLine();
		Console.WriteLine("-- Key has been added to your inventory. --");
		Console.WriteLine("Type anything to continue.");
	}

	public void ItemStoreClerkKeyBoughtAlready()
	{
		Console.Clear();
		Console.WriteLine("ノ(￣_￣*ノ)");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("'You've already bought a key'");
		Console.WriteLine();
		Console.WriteLine("1 → Stop Talking");
	}
	
	public void ItemStoreClerkWierdLooks()
	{
		Console.Clear();
		Console.WriteLine("ノ(￣_￣*ノ)");
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("'My bad there, I didn't think that emojis really existed until now.'");
		Console.WriteLine();
		Console.WriteLine("1 → 'What kinda cheap items you got?'");
		Console.WriteLine("2 → Stop talking.");
	}

	public void ItemStoreClerkCheapItems()
	{
		Console.Clear();
		Console.WriteLine("ノ( ゜-゜ノ)");
		Console.WriteLine("");
		Console.WriteLine();
		Console.WriteLine("'Um... I guess there's this weird key thing. Might be worth something, but it's more or less a gamble. Costs 10 coins.'");
		Console.WriteLine();
		int invCount = 0;
		itemConfirm = "false";
		while (invCount < 50)
		{
			if (inventory[invCount] == "10 coins")
			{
				itemConfirm = "true";
				break;
			}

			invCount++;
		}

		if (itemConfirm == "false")
		{
			Console.WriteLine("1 → 'I don't have 10 coins.'");
		}

		Console.WriteLine("2 → Stop talking.");
	}

	public void ItemStoreClerk10Coins()
	{
		if (itemConfirm == "false")
		{
			Console.Clear();
			Console.WriteLine("ノ( ゜-゜ノ)");
			Console.WriteLine("");
			Console.WriteLine();
			Console.WriteLine("'K...'");
			Console.WriteLine();
			itemConfirm = "false";
			{
				Console.WriteLine("Type anything to continue.'");
			}
		}
	}

	public void ItemStorePotions()
	{
		Console.Clear();
		Console.WriteLine("Location: Item Store Potion Section.");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                                  |");
		Console.WriteLine("|                   ◪▫             ");
		Console.WriteLine("| 🙂               ┳━┳  ƪˋ(￣┰￣*)");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("You now see shelves of glowing potions. They appear to be smoking from the top, making them seem quite hot.");
		Console.WriteLine("The hall you came from is behind you. There is also an old man with a cane behind the counter. The counter is holding a smoking hot green potion laying on its side.");
		Console.WriteLine("");
		Console.WriteLine("1 → Try to buy some potions from the old man.");
		Console.WriteLine("2 → Go back to the hall.");
	}

	public void itemStorePotionDialogue()
	{
		Console.Clear();
		Console.WriteLine(" ƪˋ(￣┰￣*)");
		Console.WriteLine("");
		Console.WriteLine();
		Console.WriteLine("'Heh, heh... How can I help you?'");
		Console.WriteLine();
		Console.WriteLine("1 → 'What does that potion on the desk do?'");
		Console.WriteLine("2 → 'How much does it cost to buy the potion on the desk?'");
		Console.WriteLine("3 → Stop talking.");
	}

	public void itemStorePotionDialoguePotionFunction()
	{
		Console.Clear();
		Console.WriteLine(" ƪԅ(￣┰￣*ԅ)");
		Console.WriteLine("");
		Console.WriteLine();
		Console.WriteLine("'Oh, that?  Heh, heh... It's a potion that lets you see in the dark!'");
		Console.WriteLine();
		Console.WriteLine("1 → 'How much does it cost to buy the potion on the desk?'");
		Console.WriteLine("2 → Stop talking.");
	}

	public void itemStorePotionDialoguePotionCost()
	{
		Console.Clear();
		Console.WriteLine(" ƪԅ(￣┰￣*ԅ)");
		Console.WriteLine("");
		Console.WriteLine();
		Console.WriteLine("'The potion that leads you see in the dark? Well, it's free! Heh, heh...'");
		Console.WriteLine();
		Console.WriteLine("1 → 'Why is it free?'");
		Console.WriteLine("2 → 'I'll take it!'");
	}

	public void itemStorePotionDialogueFree()
	{
		Console.Clear();
		Console.WriteLine(" ƪˋ(￣┰￣*)");
		Console.WriteLine("");
		Console.WriteLine();
		Console.WriteLine("'Because the potion is just way too hot! Nobody can carry it, so nobody wants it. Also... heh... It only works when you are in the shop.'");
		Console.WriteLine();
		Console.WriteLine("1 → 'I'll take it!'");
	}

	public void itemStorePotionDialogue1sip()
	{
		Console.Clear();
		Console.WriteLine(" ƪˋ(￣┰￣*)");
		Console.WriteLine("");
		Console.WriteLine();
		Console.WriteLine("'Hey... One sip is enough!'");
		Console.WriteLine();
		Console.WriteLine("Type anything to continue.");
	}

	public void itemStorePotionDialogueItemCollectFail()
	{
		Console.Clear();
		Console.WriteLine("You attempt to grab the potion, but it burns your hands and you quickly let go of it.");
		Console.WriteLine("Type anything to continue.");
	}

	public void itemStorePotionDialogueItemCollectSuccess()
	{
		Console.Clear();
		Console.WriteLine("You can now take the potion as you have the gloves on that you found from the storage room of your house.");
		Console.WriteLine("You notice a text on it saying effects are permanent with only a small sip. You take a small sip and put it back where it was.");
		Console.WriteLine("Type anything to continue.");
	}

	public void itemStoreUpstairs()
	{
		Console.Clear();
		Console.WriteLine("Location: Item Store Second Floor.");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                      ( ･･)人(･･ )                  ");
		Console.WriteLine("|           (･･ )           ( ･･)                                     ");
		Console.WriteLine("|                                  ┌( ´_ゝ` )┐                        ");
		Console.WriteLine("|                                                      ( ´･･)ﾉ(._.`)   ");
		Console.WriteLine("|  _|   🙂               (σ｀д′)σ              ⊟⊟▬⊟⊟              (°ー°〃)  ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("You are now up the stairs. You see a few customers here and there chattering and looking at products.");
		Console.WriteLine("A few people seemed to be giving concerned looks at a dark spot on the shelf for some reason.");
		Console.WriteLine("Behind you is the stairs leading back down.");
		Console.WriteLine("");
		Console.WriteLine("1 → Go back downstairs.");
		Console.WriteLine("2 → Investigate the dark spot people are looking at.");
	}

	public void itemStoreUpstairsDarkSpot()
	{
		Console.Clear();
		Console.WriteLine("Location: Item Store Second Floor");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                   ┌( ´_ゝ` )┐         ( ´･･)ﾉ(._.`)            ");
		Console.WriteLine("|   🙂    (σ｀д′)σ             ⊟⊟▬⊟⊟              (°ー°〃)    ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("'There's so many books in there I can't see! How will I find my book?' one of them cries.");
		Console.WriteLine("Looking at the dark spot, you can barely make out what looks like a LOT of books within there.");
		Console.WriteLine();
		Console.WriteLine("Type anything to go back downstairs.");
	}

	public void itemStoreUpstairsDarkSpotSIP()
	{
		Console.Clear();
		Console.WriteLine("Location: Item Store Second Floor");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                                                                ");
		Console.WriteLine("|                   ┌( ´_ゝ` )┐         ( ´･･)ﾉ(._.`)            ");
		Console.WriteLine("|   🙂    (σ｀д′)σ             ⊟⊟▬⊟⊟              (°ー°〃)    ");
		Console.WriteLine("____________________________________");
		Console.WriteLine();
		Console.WriteLine("'There's so many books in there I can't see! How will I find my book?' one of them cries.");
		Console.WriteLine("Looking at the dark spot, you can easily see what is in there... likely because you drank the night vision potion.");
		Console.WriteLine(" On the top, you see a green book labelled 'Great Green'.");
		Console.WriteLine();
		Console.WriteLine("1 → Take the green book");
		Console.WriteLine("2 → Go back downstairs.");
	}	

	public void itemStoreUpstairsDarkSpotSIPGreenBook()
	{
		Console.Clear();
		Console.WriteLine("You collect the green book. Suddenly, as you collect it, another green book falls there at the exact same spot.");
		Console.WriteLine("-- Item Collected: Green Book. --");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}
	
	public void itemStoreUpstairsDarkSpotSIPGreenBookTaken()
	{
		Console.Clear();
		Console.WriteLine("You have already collected a green book!");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}
	
	public void tenCoinsInventory()
	{
		Console.Clear();
		Console.WriteLine("-- 10 coins has been added to your inventory. --");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}
	
	public void PanicGuyDialogueNONEED()
	{
		Console.Clear();
		Console.WriteLine("You have no reason to talk to him.");
		Console.WriteLine("");
		Console.WriteLine("Type anything to continue.");
	}
	
}		
