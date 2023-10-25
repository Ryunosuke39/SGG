using SA;
using System.Collections;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Cards/Question")]
    public class QuestionCard : CardType
    {
        public override void OnSetType(CardViz viz)
        {
            viz.statsHolder.SetActive(false);
        }
    }
}