using lab3.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Deck
    {
        //private List<CombatCard> combatCards;
        //private List<SpecialCard> SpecialCards;
        private List<Card.Card> cards;

        public Deck()
        {

        }

        //public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }

        public List<Card.Card> Cards { get => cards; set => cards = value; }
        
        //public List<SpecialCard> SpecialCards1 { get => SpecialCards; set => SpecialCards = value; }


        //public void AddCombatCard(CombatCard combatCard) { throw new NotImplementedException(); }
        //public void AddSpecialCard(SpecialCard specialCard) { throw new NotImplementedException(); }

        public void AddCard(Card.Card card) { throw new NotImplementedException(); }

        //public void DestroyCombatCard(int cardId) { throw new NotImplementedException(); }
        //public void DestroySpecialCard(int cardId) { throw new NotImplementedException(); }

        public void DestroyCard(int cardId) { throw new NotImplementedException(); }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
