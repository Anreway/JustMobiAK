using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Sirenix.OdinInspector;

namespace AK.OfferCase
{
    public class OfferCaseItemSetter : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _nameTMP;

        [SerializeField]
        private TMP_Text _countTMP;

        [SerializeField]
        private Image _iconImage;

        [Button]
        public void Set(OfferCaseItemSO itemSO)
        {
            _nameTMP.text = itemSO.Name;

            _countTMP.text = itemSO.Count.ToString();

            _iconImage.sprite = itemSO.Icon;
        }
    }

}