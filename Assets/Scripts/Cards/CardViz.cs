using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SA
{
    public class CardViz : MonoBehaviour
    {
        public TMP_Text title;
        public TMP_Text cardLevel;
        public Image art;
        public TMP_Text detail;

        public Card card;

        private void Start()
        {
            LoadCard(card);
        }

        public void LoadCard(Card c)
        {
            if (c == null)
                return;

            card = c;
            title.text = c.CardName;
            cardLevel.text = c.cardLevel;
            art.sprite = c.art;
            detail.text = c.cardDetail;
        }
    }
}