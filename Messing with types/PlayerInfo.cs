using System;
using System.IO;
using System.Linq;

namespace Messing_with_types
{
    public class PlayerInfo
    {
        public PlayerInfo(int ID, string password)
        {
            if (userInfoID().Item2 != -1 && password == userInfoID().Item4)
            {
                playerID = ID;
                playerUsername = userInfoID().Item1;
                playerDisplayname = userInfoID().Item3;
                playerPassword = userInfoID().Item4;
                playerLevelInfo = new LevelInfo(this);
                loggedin = false;
            }
            else
            {
                playerID = -1;
                playerUsername = "-1";
                playerDisplayname = "-1";
                playerPassword = "-1";
                loggedin = false;
            }
        }
        public PlayerInfo(string Username, string password)
        {
            if (userInfoUsername().Item2 != -1 && password == userInfoID().Item4)
            {
                playerID = userInfoUsername().Item2;
                playerUsername = userInfoID().Item1;
                playerDisplayname = userInfoID().Item3;
                playerPassword = userInfoID().Item4;
                playerLevelInfo = new LevelInfo(this);
                loggedin = false;
            }
            else
            {
                playerID = -1;
                playerUsername = "-1";
                playerDisplayname = "-1";
                playerPassword = "-1";
                loggedin = false;
            }
        }

        private string playerUsername { get; set; }
        private string playerDisplayname { get; set; }
        private string playerPassword { get; set; }

        private int playerID { get; set; }

        private bool loggedin { get; set; }

        private LevelInfo playerLevelInfo { get; set; }
        private DateTime timeLoggedin { get; set; }

        public string Displayname { get { return playerDisplayname; } }
        public int ID { get { return playerID; } }
        public bool isLoggedin { get { return loggedin; } }
        public LevelInfo levelInfo { get { return playerLevelInfo; } }

        private Tuple<string, int, string, string, int> userInfoID()
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
        private Tuple<string, int, string, string, int> userInfoUsername()
        {
            if (File.Exists("Players"))
            {
                foreach (string line in File.ReadAllLines("Players"))
                {
                    string[] userInfo = seperate(4, '|', line);

                    if (userInfo[0] != "-1" && userInfo[0] == playerUsername)
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
            if (loggedin == false)
            {
                loggedin = true;
                timeLoggedin = DateTime.UtcNow;
            }
        }
        public void logout()
        {
            if (loggedin == true)
            {
                loggedin = false;
                timeLoggedin = DateTime.MinValue;
            }
        }

        public static bool createUser(string Username, string Password)
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

        public class LevelInfo
        {
            public LevelInfo(PlayerInfo playerinfo)
            {
                playerInfo = playerinfo;
                playerPoints = playerInfo.userInfoID().Item5;
                playerLevel = getLevel();
            }

            private PlayerInfo playerInfo { get; set; }
            private int playerPoints { get; set; }
            private int playerLevel { get; set; }
            private int playerRank { get; set; }

            public int points { get { return playerPoints; } }
            public int level { get { return playerLevel; } }
            public int rank { get { return playerRank; } }

            private int getLevel()
            {
                var levelInfo = getLevelInfo();

                if (levelInfo.Item1 == points)
                {
                    return levelInfo.Item3;
                }
                else if (levelInfo.Item1 < points && (levelInfo.Item4 - levelInfo.Item3) * levelInfo.Item3 + levelInfo.Item1 > points)
                {
                    int diference = points - levelInfo.Item1;
                    return (diference / levelInfo.Item3) + levelInfo.Item3;
                }
                return -1;
            }

            public void setPoints(int newPoints)
            {
                if (File.Exists("Players"))
                {
                    File.WriteAllLines("Players", File.ReadAllLines("Players").Select(line =>
                    {
                        if (line.StartsWith(playerInfo.playerDisplayname + "|" + playerInfo.playerID)) return $"{playerInfo.playerUsername}|{playerInfo.playerID}|{playerInfo.playerDisplayname}|{playerInfo.playerPassword}|{newPoints}";
                        return line;
                    }));
                    playerLevel = getLevel();
                    playerPoints = newPoints;
                    playerRank = getLevelInfo().Item3;

                }
            }

            private Tuple<int, int, int, int> getLevelInfo()
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
}