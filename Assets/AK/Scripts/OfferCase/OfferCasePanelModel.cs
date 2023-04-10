using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AK.OfferCase
{
    public class OfferCasePanelModel : MonoBehaviour
    {
        [SerializeField]
        private Transform _visualObject;

        [SerializeField]
        private OfferCaseItemSetter _offerItemSetterPrefab;

        [SerializeField]
        private Transform _offerItemsParent;

        public void CreateItemsGrid(List<OfferCaseItemSO> items)
        {
            ClearUpGrid();

            foreach(OfferCaseItemSO item in items)
            {
                var setter = Instantiate(_offerItemSetterPrefab, _offerItemsParent);
                setter.Set(item);
            }
        }

        private void ClearUpGrid()
        {
            foreach(Transform item in _offerItemsParent)
            {
                Destroy(item.gameObject);
            }
        }
    }
}