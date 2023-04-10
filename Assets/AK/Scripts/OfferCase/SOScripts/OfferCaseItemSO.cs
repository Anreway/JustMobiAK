using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AK.OfferCase
{
    [CreateAssetMenu(fileName = "OfferCaseItemSO", menuName = "ScriptableObjects/OfferCaseItemSO", order = 1)]
    public class OfferCaseItemSO : ScriptableObject
    {
        public string Name;

        public Sprite Icon;

        public int Count;
    }
}