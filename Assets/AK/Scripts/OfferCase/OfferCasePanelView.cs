using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Sirenix.OdinInspector;

namespace AK.OfferCase
{
    public class OfferCasePanelView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _nameTMP;

        [SerializeField]
        private TMP_Text _descriptionTMP;

        [SerializeField]
        private Image _iconImage;

        [SerializeField]
        private GameObject _discountVisual;

        [SerializeField]
        private TMP_Text _discountAmountTMP;

        [SerializeField]
        private TMP_Text _priceWithoutDiscountTMP;

        [SerializeField]
        private TMP_Text _priceTMP;

        [Button]
        public void FillView(OfferCaseInfoSO _offerSO)
        {
            _nameTMP.text = _offerSO.Title;

            _descriptionTMP.text = _offerSO.Description;

            _iconImage.sprite = _offerSO.Icon;

            if (_offerSO.WithDiscount)
            {
                _discountVisual.SetActive(true);

                _discountAmountTMP.text = (_offerSO.Discount * 100).ToString() + "%";
                _priceWithoutDiscountTMP.text = _offerSO.Price.ToString();
                _priceTMP.text = _offerSO.PriceAfterDiscount.ToString();
            }
            else
            {
                _discountVisual.SetActive(false);

                _priceTMP.text = _offerSO.PriceAfterDiscount.ToString();
            }
        }
    }
}