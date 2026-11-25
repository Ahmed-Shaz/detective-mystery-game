using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Detective_Mystery_Game
{
    internal class Program
    {
       public static string playerName = "";
       public static string filePath = "Player Activity.txt";
       public static void Main()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("||Detective Mystery Game||");  //Game name
            Console.WriteLine("==========================\n");

            Console.WriteLine("Please Enter Your Name below:"); //Asking from user his name.
            playerName = Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Detective: {playerName}\n"); //Appear the name od user.
                Console.WriteLine("Choose a case");
                Console.WriteLine("A. Stolen Cycle from Backyard."); //1st case.
                Console.WriteLine("B. Lost Wallet at Railway Station."); //2nd case.
                Console.WriteLine("Z. Exit."); //If user wants to exit.

                char choice = ReadOption(new char[] { 'A', 'B', 'Z' }); //3 options initially.
                if (choice == 'A') //A for 1st case.
                    StolenCycleCase();
                else if (choice == 'B') //B for 2nd case.
                    LostWalletCase();
                else
                    break;
            }
        }

        //=================FIRST CASE===========STOLEN CYCLE=========================
       public static void StolenCycleCase()
        {
            Console.Clear();
            int clues = 0;

            //Short story for understanding the case.
            Console.WriteLine("Case: Stolen Cycle from Backyard\n");
            Console.WriteLine("A cycle was stolen overnight from a backyard\n" +
                "The lock is missing and footprints are found near the fence. \n" +
                "A neighbor heard noices late at night.\n");

            //Questions begin from user. This case has around 10 questions.
            Console.WriteLine("\n1) What will you check 1st?"); //1st question. A is Correct.

            Console.WriteLine("A. BackYard ground.           B. House Door.");
            Console.WriteLine("C. Ignore Area.               D. Leave Case.");

            char q1 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });

            if (q1 == 'A')
            {
                clues++;
                Console.WriteLine("\nFootprints Found."); //Clue for 2nd stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }

            Console.WriteLine("\n2) What do you do next?"); //2nd question. B is correct.
            Console.WriteLine("A. Erase Footprints.          B. Follow Footprints.");
            Console.WriteLine("C. Ignore Footprints.         D. Go Home.");

            char q2 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q2 == 'B')
            {
                clues++;
                Console.WriteLine("\nFootprints lead to fence."); //Clue for 3rd stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }

            Console.WriteLine("\n3) Fence looks damaged. Action?"); //3rs question. C is correct.
            Console.WriteLine("A. Fix Fence.       B. Ignore Fence");
            Console.WriteLine("C. Inspect Fence.   D. Leave");

            char q3 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q3 == 'C')
            {
                clues++;
                Console.WriteLine("\nFence was jumped Over."); //Clue for 4th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;

            }

            Console.WriteLine("\n4) What Next?"); //4th question. D is correct.
            Console.WriteLine("A. Close Case.           B. Sleep.");
            Console.WriteLine("C. Ignore Neighbor       D. Talk to Neighbor.");

            char q4 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q4 == 'D')
            {
                clues++;
                Console.WriteLine("\nNeighbor saw a boy."); //Clue for 5th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }
            Console.WriteLine("\n5) When was suspect seen?"); //5th question. A is correct.
            Console.WriteLine("A.Midnight          B.Morning");
            Console.WriteLine("C.Afternoon         D.Evening");

            char q5 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q5 == 'A')
            {
                clues++;
                Console.WriteLine("\nTime Confirmed."); //Clue for 6th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }

            Console.WriteLine("\n6) Where do you search?"); //6th question. B is correct.
            Console.WriteLine("A. School.        B. Nearby park.");
            Console.WriteLine("C. Market.        D. Police Station.");

            char q6 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q6 == 'B')
            {
                clues++;
                Console.WriteLine("\nCycle Spotted."); //Clue for 7th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues); 
                return;
            }

            Console.WriteLine("\n7) What do you check?"); //7th question. C is correct.
            Console.WriteLine("A. Nothing              B. Color Only");
            Console.WriteLine("C. Serial Number.       D. Ride it.");

            char q7 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q7 == 'C')
            {
                clues++;
                Console.WriteLine("\nSerial Matches."); //Clue for 8th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }

            Console.WriteLine("\n8) Suspect Nearby. Action?"); //8th question. D is correct
            Console.WriteLine("A. Shout.         B. Ignore him");
            Console.WriteLine("C. Run away.      D. Question him.");

            char q8 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q8 == 'D')
            {
                clues++;
                Console.WriteLine("\nHe looks Nervous."); //Clue for 9th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }

            Console.WriteLine("\n9) Suspect admits theft. What now?"); //9th question. A is correct
            Console.WriteLine("A. Recover Cycle.                 B. Let him go");
            Console.WriteLine("C. Ignore Confession.             D. Leave.");

            char q9 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q9 == 'A')
            {
                clues++;
                Console.WriteLine("\n========Cycle Recovered.=========="); //Clue for 10th stage.
            }
            else
            {
                FailCase("Stolen Cycle", clues);
                return;
            }

            Console.WriteLine("\n10) Final step?"); //10th question. B is correct
            Console.WriteLine("A. Reopen case.            B. Close case.");
            Console.WriteLine("C. Distroy Evidence.       D. Quit job.");
             
            char q10 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if
                (q10 == 'B') EndCase("Stolen Cycle", clues);

            else

                FailCase("Stolen Cycle", clues);
                              //=============End of case 1======================


        }

        //=================2ND CASE===========LOST WALLET=========================
       public static void LostWalletCase()
        {
            Console.Clear();
            int clues = 0;

            //Short story to understand the case situation.
            Console.WriteLine("CASE: Lost Wallet at railway Station.");
            Console.WriteLine("A traveler lost his wallet  at a crowded railway station. \n" +
                "The Wallet contains important documents and cash.\n");

            //Question begins, This case has around 10questions.
            Console.WriteLine("\n1) Where do you start?"); //1st question. A is correct.
            Console.WriteLine("A. Platform.      B. Exit gate.");
            Console.WriteLine("C. Parking.       D. Ignore.");

            char q1 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q1 == 'A')
            {
                clues++;
                Console.WriteLine("\nCrowded area checked."); //Clue for 2nd stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n2) What do you check?"); //2nd question. B is correct.
            Console.WriteLine("A. Trash.     B. CCTV.");
            Console.WriteLine("C. Nothing.   D. Leave.");

            char q2 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q2 == 'B')
            {
                clues++;
                Console.WriteLine("\nWallet seen on Camera."); //Clue for 3rd stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n3) CCTV shows a man picking Wallet. action?"); //3rd question. C is correct.
            Console.WriteLine("A. Arrset Random.     B. Ignore.");
            Console.WriteLine("C. Track him.         D. Quit.");

            char q3 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q3 == 'C')
            {
                clues++;
                Console.WriteLine("\nSuspect tracked"); //Clue for 4th stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n4) Where does suspect go?"); //4th question. D is correct.
            Console.WriteLine("A. Shop.        B. Train.");
            Console.WriteLine("C. Give up.     D. Ticket Counter.");

            char q4 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q4 == 'D')
            {
                clues++;
                Console.WriteLine("\nStaff  Informed"); //Clue for 5th stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n5) Staff Suggests?"); //5th question. A is correct.
            Console.WriteLine("A. Lost & Found.      B. Police.");
            Console.WriteLine("C. Ignore.            D. Wait.");

            char q5 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q5 == 'A')
            {
                clues++;
                Console.WriteLine("\nOffice Located."); //Clue for 6th stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n6) What do you check in Wallet?"); //6th question. B is correct.
            Console.WriteLine("A. Money Only.      B. ID card.");
            Console.WriteLine("C. Nothing.         D. Take it.");

            char q6 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q6 == 'B')
            {
                clues++;
                Console.WriteLine("Owner Identified"); //Clue for 7th stage.
            }
            else
            {
                FailCase("\nLost Wallet", clues);
                return;

            }

            Console.WriteLine("\n7) What next?"); //7th question. C is correct.
            Console.WriteLine("A. Ignore.          B. Keep Wallet.");
            Console.WriteLine("C. Call owner.      D. Throw Wallet.");

            char q7 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q7 == 'C')
            {
                clues++;
                Console.WriteLine("\nOwner Contacted"); //Clue for 8th stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n8) Owner arrives. Action?"); //8th question. D is correct.
            Console.WriteLine("A. Leave.     B. Give Wallet.");
            Console.WriteLine("C. Delay.     D. Verify Identity.");

            char q8 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q8 == 'D')
            {
                clues++;
                Console.WriteLine("\nIdentity Confirmed"); //Clue for 9th stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n9) What do you do?"); //9th question. A is correct.
            Console.WriteLine("A. Return Wallet.    B. Keep Wallet.");
            Console.WriteLine("C. Ignore.           D. Lose.");

            char q9 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q9 == 'A')
            {
                clues++;
                Console.WriteLine("\n=====Wallet returned====="); //Clue for 10th stage.
            }
            else
            {
                FailCase("Lost Wallet", clues);
                return;

            }

            Console.WriteLine("\n10) Final Step?"); //10th question. B is correct.
            Console.WriteLine("A. Reopen case.    B. Close case.");
            Console.WriteLine("C. Quit Job.       D. Ignore.");

            char q10 = ReadOption(new char[] { 'A', 'B', 'C', 'D' });
            if (q10 == 'B') EndCase("Lost Wallet", clues);
            else FailCase("Lost Wallet", clues);
            //=============End Case 2=============
        }
          //============Method for stick into A B C D options and Z for Exit.
       public static char ReadOption(char[] valid)
        {
            while (true)
            {
                Console.Write("\nEnter Option (Z to Exit): ");
                string input = Console.ReadLine().ToUpper();

                if (input == "Z")
                    Environment.Exit(0);
                 if (input.Length == 1 && Array.Exists(valid, v => v == input[0]))
                    return input[0];

                Console.WriteLine("\nInvalid Option. Choose the correct option.");
            }
        }
         //==========Method for results after finishing the case in middle or after completing.
       public static void EndCase(string caseName, int  clues)
        {
            Console.WriteLine("\nCase Solved");
            Console.WriteLine($"Clues collected: {clues}");

            SaveToFile(caseName, "Solved", clues);
            Console.WriteLine("Press ENTER to continue or Z to Exit");

            if (Console.ReadLine().ToUpper() == "Z")
                Environment.Exit(0);
        }
         //=======Method for failcase if somebody failed to solve the case.
       public static void FailCase(string caseName, int clues)
        {
            Console.WriteLine("\nCase Failed");
            Console.WriteLine($"Clues Collected: {clues}");

            SaveToFile(caseName, "Failed", clues);
            Console.WriteLine("Press ENTER to continue or Z to exit");
            if (Console.ReadLine().ToUpper() == "Z")
                Environment.Exit(0);

        }
         /*======Method to make a file to save the date of the player. i.e Name,Case he chosed,
          * clues he found and date and time.*/
          
       public static void SaveToFile(string caseName, string results, int clues)
        {
            File.AppendAllText(filePath,
                $"Name: {playerName}\nCase: {caseName}\nResults:{results}\nClues: {clues}\nDate: {DateTime.Now}");
                
        }
            



    }
}


