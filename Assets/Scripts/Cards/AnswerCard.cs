using System.Collections;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Cards/Answer")]
    public class AnswerCard : CardType //creature 
    {
        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);

            viz.statsHolder.SetActive(true);
        }
    }
}