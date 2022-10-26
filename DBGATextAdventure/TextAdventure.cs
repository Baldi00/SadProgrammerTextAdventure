using System;
using System.Threading;

namespace DBGATextAdventure
{
	class TextAdventure
	{

		private static int CHAR_INTERVAL = 30;
		private static int PHRASE_INTERVAL = 300;
		static void Main(string[] args)
		{
			string choise;

			Write("Story of a sad programmer\n");
			Write("You are a sad programmer inside your room in front of your computer");
			do
			{
				choise = RequestWhatToDo(new string[] { "leave", "turn on pc" });
				if (choise == "leave")
				{
					Write("You are a sad programmer, you don't have a life, you have nowhere to go");
				}
			} while (choise != "turn on pc");

			Write("You have to wait, your pc is old and slow, you don't have money to buy a modern PC");
			Write("PC is on.");
			Write("You can write a new program that no one will appriciate, but this will take you 3 days.");
			Write("Probably you will be so concentrated that you will forget to eat and drink");
			Write("There's a high probability to die");
			Write("Instead you can play with your new game! It's an old one, you bougth it on Steam for 0.99$");

			choise = RequestWhatToDo(new string [] { "program", "game"});

			if (choise == "program")
			{
				Write("Oh, you are brave.");
			}
			else
			{
				Write("Ok, you choose the easiest way");
				Write("You start playing.");
				for (int i = 0; i < 3; i++) {
					Write("There's an enemy in front of you");
					choise = RequestWhatToDo(new string[] { "shoot", "escape" });

					if (choise == "shoot")
					{
						Write("You missed him! He reaches you and kills you");
					}
					else
					{
						Write("You are too slow, he reaches and kills you");
					}

					if (i != 2)
					{
						Write("Alright, let's retry. This time will get better");
					}
				}
				Write("Damn! It's so hard!");
				Write("You are angry with the game, you hate feeling a noob");
				Write("But hey! You are a sad programmer! Let's write a program that plays for me and show him who is in control!");
			}

			Write("You start to write, you are so fast at writing!");
			Write("After a few hours you need to go to the bathroom but you are exactly in the middle of a");
			Write("function and you are afraid to lose the flow if you leave");
			choise = RequestWhatToDo(new string[] { "bathroom", "resist" });

			if (choise == "resist")
			{
				Write("A few minutes pass. Your can't resist anymore. You don't want to explode. You go to the bathroom.");
			}
			Write("You feel better now. You are lucky and you remember what you were doing. You are not so stupid after all");

			Write("It's dinner time. Your stomach starts emitting sounds. You are a bit tired but you want to create one last");
			Write("feature so you can finally run your program and see if it works");
			choise = RequestWhatToDo(new string[] { "dinner", "continue" });

			if (choise == "dinner")
			{
				Write("You are full now. Your eyes starts closing themselves but you would like to finish your program before going to bed");
				choise = RequestWhatToDo(new string[] { "program", "bed" });
			}
			else
			{
				Write("Your stomach is sad, but at the end it start to get over it. You are not hungry anymore");
			}

			if (choise == "continue" || choise == "program")
			{
				Write("You face an unexpected bug. It's very late and the time for resolving it is unknown");
				choise = RequestWhatToDo(new string[] { "bed", "continue" });
			}

			if (choise == "continue")
			{
				Write("You can't solve it, it's harder than expected. You continue programming all night and don't find out a solution");
				Write("You are angry with the computer. You injured it all time hoping to intimidate it but it didn't work");
				Write("You can't stand its presence anymore. It was your only friend but it betrayed you.");

				choise = RequestWhatToDo(new string[] { "destroy it", "cry" });

				if (choise == "destroy it")
				{
					Write("What did you do?!?! You are a programmer! Your life doesn't have any sense without your PC!");
					Write("You are shocked. You realise what you did. You instantly fall into deep depression");
					Write("You take the paper knife on your table and kill yourself");
					Write("You are dead");
				}
				else if (choise == "cry")
				{
					Write("You flood your room with your tears.");
					Write("You drown.");
					Write("You are dead");
				}
			}
			else if (choise == "bed")
			{
				Write("You can't sleep. Your brain is so active. You continue to think to your program.");
				Write("You finally fall asleep. But your brain is not really over. Nightmares start coming. A strong headache too.");
				Write("You round and round in your bed.");
				Write("You fall");
				Write("You bang your head against the floor...");
				Write("You are dead");
			}

			Write("\n\n\nMoral: Life of a programmer is sad, don't be just a programmer");
			Write("In memory of a sad programmer");
			Console.ReadLine();
		}

		public static void Write(string phrase)
		{
			char[] phraseChars = phrase.ToCharArray();
			foreach(char c in phraseChars)
			{
				Console.Write(c);
				Thread.Sleep(CHAR_INTERVAL);
			}
			Console.WriteLine();
			Thread.Sleep(PHRASE_INTERVAL);
		}

		public static string RequestWhatToDo(string[] accepted)
		{
			string choise;

			do
			{
				string request = "What do you do? (" + String.Join(", ", accepted) + ")";
				Write(request);
				choise = Console.ReadLine().ToLower();
				Console.WriteLine();

				foreach (string s in accepted)
				{
					if (s == choise)
						return choise;
				}

			} while (true);
		}
	}
}