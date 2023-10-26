﻿using System.Collections;
using UnityEngine;

namespace SA.GameStates
{
    [CreateAssetMenu(menuName = "State")]
    public class State : ScriptableObject
    {
        public Action[] actions;

        public void Tick(float d)
        {
            for (int i = 0;  i < actions.Length; i++)
            {
                actions[i].Execute(d);
            }
        }
    }
}