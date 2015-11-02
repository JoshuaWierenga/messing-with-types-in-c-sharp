using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Messing_with_types
{
    public class PlayerInfo
    {
        private static List<int> users = new List<int>();
        private static List<int> usersLoggedon = new List<int>();

        public PlayerInfo(int ID)
        {
            if (userInfo(ID).Item2 != -1)
            {
                playerID = ID;
                playerUsername = userInfo(playerID).Item1;
                playerDisplayname = userInfo(playerID).Item3;
                playerPassword = userInfo(playerID).Item4;
                playerLevel = getLevel(userInfo(playerID).Item5);
                playerPoints = userInfo(playerID).Item5;
                playerRank = getLevelInfo(playerLevel).Item3;
                loggedin = false;
                users.Add(playerID);
            }
            else
            {
                playerID = -1;
                playerUsername = "-1";
                playerDisplayname = "-1";
                playerPassword = "-1";
                playerLevel = -1;
                playerPoints = -1;
                playerRank = -1;
                loggedin = false;
            }
        }
        public PlayerInfo(string Username)
        {
            if (userInfo(Username).Item2 != -1)
            {
                playerID = userInfo(Username).Item2;
                playerUsername = userInfo(playerID).Item1;
                playerDisplayname = userInfo(playerID).Item3;
                playerPassword = userInfo(playerID).Item4;
                playerLevel = getLevel(userInfo(playerID).Item5);
                playerPoints = userInfo(playerID).Item5;
                playerRank = getLevelInfo(playerLevel).Item3;
                loggedin = false;
                users.Add(playerID);
            }
            else
            {
                playerID = -1;
                playerUsername = "-1";
                playerDisplayname = "-1";
                playerPassword = "-1";
                playerLevel = -1;
                playerPoints = -1;
                playerRank = -1;
                loggedin = false;
            }
        }

        private string playerUsername { get; set; }
        private int playerID { get; set; }
        private string playerDisplayname { get; set; }
        private string playerPassword { get; set; }
        private int playerLevel { get; set; }
        private int playerPoints { get; set; }
        private int playerRank { get; set; }

        private bool loggedin { get; set; }
        private bool passwordstatus { get; set; }
        private DateTime timeLoggedin { get; set; }

        public int ID { get { return playerID; } }
        public string Displayname { get { return playerDisplayname; } }
        public int Level { get { return playerLevel; } }
        public int Points { get { return playerPoints; } }
        public int Rank { get { return playerRank; } }
        public bool isLoggedin { get { return loggedin; } }

        private Tuple<string, int, string, string, int> userInfo(int playerID)
        {
            if (File.Exists("Players"))
            {
                foreach (string line in File.ReadAllLines("Players"))
                {
                    string[] userInfo = seperate(4, '|', line);

                    if (userInfo[0] != "-1" && int.Parse(userInfo[1]) == playerID)
                    {
                        return Tuple.Create(userInfo[0], int.Parse(userInfo[1]), userInfo[2], userInfo[3], int.Parse(userInfo[4]));
                    }
                }
            }
            return Tuple.Create("-1", -1, "-1", "-1", -1);
        }

        private Tuple<string, int, string, string, int> userInfo(string Username)
        {
            if (File.Exists("Players"))
            {
                foreach (string line in File.ReadAllLines("Players"))
                {
                    string[] userInfo = seperate(4, '|', line);

                    if (userInfo[0] != "-1" && userInfo[0] == Username)
                    {
                        return Tuple.Create(userInfo[0], int.Parse(userInfo[1]), userInfo[2], userInfo[3], int.Parse(userInfo[4]));
                    }
                }
            }
            return Tuple.Create("-1", -1, "-1", "-1", -1);
        }

        private static string[] seperate(int number, char seperator, string line)
        {
            string[] returned = new string[5];

            int i = 0;

            int error = 0;

            int length = line.Length;

            foreach (char c in line)
            {
                if (i != number)
                {
                    if (error > length || number > 5)
                    {
                        returned[0] = "-1";
                        return returned;
                    }
                    else if (c == seperator)
                    {
                        returned[i] = line.Remove(line.IndexOf(c));
                        line = line.Remove(0, line.IndexOf(c) + 1);
                        i++;
                    }
                    error++;

                    if (error == length && i != number)
                    {
                        returned[0] = "-1";
                        return returned;
                    }
                }
                else
                {
                    returned[i] = line;
                }
            }
            return returned;
        }

        public void login()
        {
            if (loggedin == false && passwordstatus == true)
            {
                loggedin = true;
                usersLoggedon.Add(playerID);
                timeLoggedin = DateTime.UtcNow;
            }
        }
        public void logout()
        {
            if (loggedin == true)
            {
                loggedin = false;
                usersLoggedon.Remove(playerID);
                timeLoggedin = DateTime.MinValue;
            }
        }

        public bool checkPassword(string password)
        {
            if (playerPassword == password)
            {
                passwordstatus = true;
                return true;
            }
            return false;
        }

        internal static bool createUser(string Username, string Password)
        {
            if (Username == "" || Username == "-1") { return false; }

            if (File.Exists("Players"))
            {
                bool match = false;
                foreach (string line in File.ReadAllLines("Players"))
                {
                    string[] userInfo = seperate(4, '|', line);

                    if (userInfo[0] == Username)
                    {
                        match = true;
                    }
                }
                if (match == false)
                {
                    int currentID = File.ReadLines("Players").Count();
                    StreamWriter PlayerFile = File.AppendText("Players");
                    PlayerFile.WriteLine($"{Username}|{currentID}|{Username}|{Password}|0");
                    PlayerFile.Close();
                    return true;
                }
            }
            return false;
        }

        public void setPoints(int newPoints)
        {
            Console.WriteLine(newPoints);
            if (File.Exists("Players"))
            {
                File.WriteAllLines("Players", File.ReadAllLines("Players").Select(line =>
                    {
                        if (line.StartsWith(playerUsername + "|" + playerID)) return $"{playerUsername}|{playerID}|{playerDisplayname}|{playerPassword}|{newPoints}";
                        return line;
                    }));
                playerLevel = getLevel(newPoints);
                playerPoints = newPoints;
                playerRank = getLevelInfo(playerLevel).Item3;

            }
        }

        private static int getLevel(int points)
        {
            var levelInfo = getLevelInfo(points);
            Console.WriteLine(levelInfo.Item1);
            Console.WriteLine(levelInfo.Item2);
            Console.WriteLine(levelInfo.Item3);
            Console.WriteLine(levelInfo.Item4);

            if (levelInfo.Item1 == points)
            {
                return levelInfo.Item3;
            }
            else if (levelInfo.Item1 < points && (levelInfo.Item4 - levelInfo.Item3) * levelInfo.Item3 + levelInfo.Item1 > points)
            {
                int times = 0;
                for (var i = levelInfo.Item1; i <= points; i += 1)
                {
                    Console.WriteLine(times);
                    if (i == points) return times / levelInfo.Item3 + levelInfo.Item3;
                    else times++;
                }
            }
            return -1;
        }

        private static Tuple<int, int, int, int> getLevelInfo(int points)
        {
            if (points == 0) return Tuple.Create(1, 0, 1, 2);

            int oldlevel = 1;
            int newlevel = 2;
            int nextlevel = 0;
            int temppoints = 0;
            bool finished = false;

            while (finished == false)
            {
                int currentpoints = (newlevel - oldlevel) * oldlevel + temppoints;

                int temp = newlevel;
                while (temp >= 10)
                {
                    temp /= 10;
                }

                if (temp == 1 || temp == 5) nextlevel *= 2;
                else if (temp == 2) nextlevel = Convert.ToInt32(newlevel * 2.5m);


                Console.WriteLine(currentpoints);
                Console.WriteLine(points);
                Console.WriteLine($"Does {currentpoints} = {points}?");
                Console.WriteLine($"Or is {currentpoints} below {points} and is {(nextlevel - newlevel) * newlevel + currentpoints} above {points}?");
                if (currentpoints == points || currentpoints < points && (nextlevel - newlevel) * newlevel + currentpoints > points)
                {
                    finished = true;
                    return Tuple.Create(currentpoints, oldlevel, newlevel, nextlevel);
                }
                else
                {
                    temppoints = currentpoints;
                    oldlevel = newlevel;

                    if (temp == 1 || temp == 5) newlevel *= 2;
                    else if (temp == 2) newlevel = Convert.ToInt32(newlevel * 2.5m);
                }
            }
            return Tuple.Create(-1, -1, -1, -1);
        }
    }
}