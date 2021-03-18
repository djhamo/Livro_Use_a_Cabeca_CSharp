using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeckCards;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += name + " acabou de entrar no jogo." + Environment.NewLine;
        }
        public IEnumerable<Values> PullOutBooks() 
        { 
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
			{
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
			    {
                    if (cards.Peek(card).Value == value)
                        howMany++;
			 
			    }
                if (howMany == 4) {
                    books.Add(value);
                    for (int card = (cards.Count - 1); card >= 0; card--)
                        cards.Deal(card);
                }
			 
			}
            return books;
        }
        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck valuesIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + " tem " + valuesIHave.Count + " " 
                + Card.Plural(value) + Environment.NewLine;
            return valuesIHave;

        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            AskForACard(players, myIndex, stock, GetRandomValue());
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, DeckCards.Values value)
        {
            textBoxOnForm.Text += Name + " pergunta se alguém tem " + value  + Environment.NewLine;

            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
			{
                if (i != myIndex) {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count > 0)
                        cards.Add(CardsGiven.Deal());
                }
			 
			}
            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text += Name + " tem que comprar da pilha." + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
    }
}
