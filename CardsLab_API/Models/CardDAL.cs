using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CardsLab_API.Models
{
    public class CardDAL
    {

        public Deck ShuffleCards()
        {
            string url = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();

            Deck deck = JsonConvert.DeserializeObject<Deck>(result);
            return deck;
        }

        public Deck DrawCard(string deckID, int num)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{deckID}/draw/?count={num}";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string result = rd.ReadToEnd();

            Deck deck = JsonConvert.DeserializeObject<Deck>(result);
            return deck;
        }
    }
}
