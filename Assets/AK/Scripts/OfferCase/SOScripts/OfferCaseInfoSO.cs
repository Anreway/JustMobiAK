using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AK.OfferCase
{
    [CreateAssetMenu(fileName = "OfferCaseInfoSO", menuName = "ScriptableObjects/OfferCaseInfoSO", order = 1)]
    public class OfferCaseInfoSO : ScriptableObject
    {
        [Title("Visual")]
        public string Title;

        public Sprite Icon;

        [Space]
        [TextArea(7, 20)]
        public string Description;

        [OnValueChanged("UpdateItemListInEditor")]
        public List<OfferCaseItemSO> Items;

        [Title("Prices")]
        [OnValueChanged("UpdatePriceInEditor")]
        public float Price;

        [OnValueChanged("UpdatePriceInEditor")]
        [Range(0f,1f)]
        public float Discount;

        [OnValueChanged("UpdatePriceInEditor")]
        [SerializeField]
        private bool _isCustomPriceAfterDiscount;

        [ShowIf("_isCustomPriceAfterDiscount")]
        [OnValueChanged("UpdatePriceInEditor")]
        [SerializeField]
        private float _customPriceAfterDiscount;

        [OnValueChanged("UpdatePriceInEditor")]
        public string PricePostfix;

        [Space]
        [DisplayAsString]
        [SerializeField]
        private string _priceAfterDiscount;

        public bool WithDiscount
        {
            get
            {
                if (Discount > 0 || _isCustomPriceAfterDiscount) return true;
                else return false;
            }
        }

        public float PriceAfterDiscount
        {
            get
            {
                if (_isCustomPriceAfterDiscount)
                    return _customPriceAfterDiscount;
                else
                    return Price * (1 - Discount);
            }
        }

#if UNITY_EDITOR
        private void UpdatePriceInEditor()
        {
            _priceAfterDiscount = ":  "+ PriceAfterDiscount + PricePostfix;
        }

        private void UpdateItemListInEditor()
        {
            if(Items.Count > 6)
            {
                for(int i = 5; i< Items.Count; i++)
                {
                    Items.RemoveAt(i);
                }
            }
        }

#endif

    }

}