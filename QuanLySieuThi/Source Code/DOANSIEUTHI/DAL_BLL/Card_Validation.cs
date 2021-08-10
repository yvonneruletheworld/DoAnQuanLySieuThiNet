using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace DAL_BLL
{
    public class Card_Validation
    {
        public string cardCheck (string BIN)
        {
            if (BIN == null)
                return null;
            else
            {
                return GetCardType(BIN).ToString(); 
            }    
        }
        public DataTable getDataFormHtml (string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var body = doc.DocumentNode.SelectNodes("//table//tr").ToList();

            var table = new DataTable("BankBIN");

            table.Columns.Add("stt");
            table.Columns.Add("name");
            table.Columns.Add("bin");
            var rows = body.Select(tr => tr
               .Elements("td")
               .Select(td => td.InnerText.Trim())
               .ToArray());
            for (int i = 3; i < 26; i ++)
            {
                table.Rows.Add(rows.ElementAt(i));
            }
            return table;
        }

        public enum CardType
        {
            Unknown = 0,
            MasterCard = 1,
            VISA = 2,
            National = 3
        }

        // Class to hold credit card type information
        private class CardTypeInfo
        {
            public CardTypeInfo(string regEx, int length, CardType type)
            {
                RegEx = regEx;
                Length = length;
                Type = type;
            }

            public string RegEx { get; set; }
            public int Length { get; set; }
            public CardType Type { get; set; }
        }

        // Array of CardTypeInfo objects.
        // Used by GetCardType() to identify credit card types.
        private static CardTypeInfo[] _cardTypeInfo =
        {
          new CardTypeInfo("^(51|52|53|54|55)", 16, CardType.MasterCard),
          new CardTypeInfo("^(4)", 16, CardType.VISA),
          new CardTypeInfo("^(4)", 13, CardType.VISA),
          new CardTypeInfo("^(9704)", 16, CardType.National)
        };

        public static CardType GetCardType(string cardNumber)
        {
            foreach (CardTypeInfo info in _cardTypeInfo)
            {
                if (cardNumber.Length == info.Length &&
                    Regex.IsMatch(cardNumber, info.RegEx))
                    return info.Type;
            }

            return CardType.Unknown;
        }
    }
}
