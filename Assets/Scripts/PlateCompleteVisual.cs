using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class PlateCompleteVisual : MonoBehaviour
    {


        [Serializable]
        public struct KitchenObjectSO_GameObject
        {

            public KitchenObjectSO kitchenObjectSO;
            public GameObject gameObject;

        }


        [SerializeField] private PlateKitchenObject plateKitchenObject;
        [SerializeField] private List<KitchenObjectSO_GameObject> kitchenObjectSOGameObjectList;


        private void Start()
        {
            //plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;

            foreach (KitchenObjectSO_GameObject kitchenObjectSOGameObject in kitchenObjectSOGameObjectList)
            {
                kitchenObjectSOGameObject.gameObject.SetActive(false);
            }
        }

        private void PlateKitchenObject_OnIngredientAdded(object sender)
        {
            foreach (KitchenObjectSO_GameObject kitchenObjectSOGameObject in kitchenObjectSOGameObjectList)
            {
                //if (kitchenObjectSOGameObject.kitchenObjectSO == e.kitchenObjectSO)
                {
                    kitchenObjectSOGameObject.gameObject.SetActive(true);
                }
            }
        }

    }
}