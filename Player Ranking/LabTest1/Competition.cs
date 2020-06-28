using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1
{
    public interface IRanking
    {
        int PlayerRank { get; set; }
        double ComputeRank(int i);
    }
    public class Player : IRanking
    {
        string playerName;
        double[] playerScore;
        public Player()
        {
            playerName = "";
            playerScore = new double[2];
            PlayerRank = 1;
        }
        public string PlayerName 
        {
            get { return playerName; }
        }
        public double PlayerScore1
        {
            get { return playerScore[0]; }
        }
        public double PlayerScore2 
        { 
            get { return playerScore[1]; }
        }
        public int PlayerRank { get; set; }
        public double ComputeRank(int i)
        {
            if (i == 0)
            {
                if (playerScore[0] >= playerScore[1])
                {
                    return playerScore[0];
                }
                else
                { return playerScore[1]; }
            }
            if (i == 1)
            {
                if (playerScore[0] <= playerScore[1])
                {
                    return playerScore[0];
                }
                else
                { return playerScore[1]; }
            }
            return 0.0;
        }

        public void get_data(int i)
        {
            while (true)
            {
                Console.Write("Enter Player#{0} name: ", i);
                playerName = Console.ReadLine();
                if (playerName == "")
                {
                    Console.WriteLine("Name can't be empty!! Try Again!");
                }
                else
                    break;
            }
            while (true)
            {
                Console.Write("Enter {0}'s score #1: ", playerName);
                try
                {
                    playerScore[0] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!! Try Again!\n", e);
                }
            }
            while (true)
            {
                Console.Write("Enter {0}'s score #2: ", playerName);
                try
                {
                    playerScore[1] = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!! Try Again!\n", e);
                }
            }
        }
    }
    class Competition
    {
        static void Main(string[] args)
        {
            string input;
            int x;
            while (true)
            {
                Console.Write("Enter the number of Players: ");
                input = Console.ReadLine();
                try {
                    Convert.ToInt32(input);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!! Try Again!\n", e);
                }
            }
            x = Convert.ToInt32(input);
            Player[] arr = new Player[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = new Player();
                arr[i].get_data(i + 1);
            }
            for (int i2 = 0; i2 < x; i2++)
            {
                for (int i3 = 0; i3 < x; i3++)
                {
                    if (arr[i2].ComputeRank(0) < arr[i3].ComputeRank(0))
                    {
                        arr[i2].PlayerRank += 1;
                    }
                    else if (arr[i2].ComputeRank(0) == arr[i3].ComputeRank(0))
                    {
                        if (arr[i2].ComputeRank(1) < arr[i3].ComputeRank(1))
                        {
                           arr[i2].PlayerRank += 1;
                        }
                    }
                }
            }
            Application.Run(new showdata(x,arr));
       
        }
    }
}
