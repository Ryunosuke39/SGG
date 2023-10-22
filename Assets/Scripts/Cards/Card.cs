using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public string CardName;
        public string cardLevel;
        public Sprite art;
        public string cardDetail;
    }
}

