using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451_Database_UI.Utility
{
    public abstract class CustomFormatter
    {
        public static string TipBuilder(string userID, string date, string likes, string text)
        {
            string returnString = $"User ID: {userID}{Environment.NewLine}";
            returnString += $"Date: {date}{Environment.NewLine}";
            returnString += $"Likes: {likes}{Environment.NewLine}";
            returnString += $"{text}{Environment.NewLine}";
            returnString += $"______________________________________________{Environment.NewLine}";
            return returnString;
        }
        public static string TipBuilder(string[] tipInfo)
        {
            if (tipInfo.Length != 4) return "Comment failed to load";
            return TipBuilder(tipInfo[0], tipInfo[1], tipInfo[2], tipInfo[3]);
        }
    }
}
