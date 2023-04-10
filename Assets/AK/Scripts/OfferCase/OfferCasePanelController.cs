using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AK.OfferCase
{
    public class OfferCasePanelController : MonoBehaviour
    {
        [SerializeField]
        private OfferCasePanelView _offerView;

        [SerializeField]
        private OfferCasePanelModel _offerModel;

        public void SetOfferSO(OfferCaseInfoSO offerCase)
        {
            _offerView.FillView(offerCase);
            _offerModel.CreateItemsGrid(offerCase.Items);
        }

    }
}