using SA;
using System.Collections;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Cards/Question")]
    public class QuestionCard : CardType // spell
    {
        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);

            viz.statsHolder.SetActive(false); //in video it's false but we want to show answer so true
        }
    }
}