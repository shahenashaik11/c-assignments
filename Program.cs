using System;

namespace ConsoleApp7
{
    class Team
    {
        string teamname;
        int teamid;
        public void inputteam()
        {
            Console.WriteLine("enter the Team name");
            teamname = Console.ReadLine();
            Console.WriteLine("enter the Team ID");
            teamid = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();



        }
        public void outputteam()
        {
            Console.WriteLine("NAME OF TEAM IS:" + teamname);
            Console.WriteLine("Team ID IS:" + teamid);

        }


    }
    class Player
    {
        public string playername;
        int playerid, score;
        public void inputplayer()
        {
            Console.WriteLine("enter the player name");
            playername = Console.ReadLine();
            Console.WriteLine("enter the player ID");
            playerid = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Enter the score");
            score = Convert.ToInt32(Console.ReadLine());



        }
        public void outputplayer()
        {
            Console.WriteLine("NAME OF PLAYER IS:" + playername);
            Console.WriteLine("PLAYER ID IS:" + playerid);
            Console.WriteLine("SCORE IS:" + score);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Team t1 = new Team();
            t1.inputteam();
            t1.outputteam();

            Team t2 = new Team();
            t2.inputteam();
            t2.outputteam();
        }

    }
}
