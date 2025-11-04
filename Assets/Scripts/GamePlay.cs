
//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}


//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}
//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {

//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}
v
//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }



//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }


//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//   }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {
//                plateKitchenObject = null; 
//                return true;
//            }
//            else
//            {
//                plateKitchenObject = null;
//                return false;
//            }
//        }


//        public static KitchenObject SpawnKitchenObject(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectq(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectư(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectv(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject8(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecth(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectl(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectm(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectb(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectc(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectj(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjectf(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject4(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject3(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject9(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject0(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObject32(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }

//        public static KitchenObject SpawnKitchenObjecteqw(KitchenObjectSO kitchenObjectSO, IKitchenObjectParent kitchenObjectParent)
//        {
//            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);

//            KitchenObject kitchenObject = kitchenObjectTransform.GetComponent<KitchenObject>();

//            kitchenObject.SetKitchenObjectParent(kitchenObjectParent);

//            return kitchenObject;
//        }
//    }
//}

//using UnityEngine;

//namespace Assets.Scripts
//{
//    internal class PlayerConliisen  : MonoBehaviour 
//    {
//        [SerializeField] private KitchenObjectSO kitchenObjectSO;

//        private IKitchenObjectParent kitchenObjectParent;

//        public KitchenObjectSO GetKitchenObjectSO()
//        {
//            return kitchenObjectSO;
//        }

//        public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
//        {
//            if (this.kitchenObjectParent != null)
//            {
//                this.kitchenObjectParent.ClearKitchenObject();

//            }
//            this.kitchenObjectParent = kitchenObjectParent;
//            if (kitchenObjectParent.HasKitchenObject())
//            {
//                Debug.LogError("IKitchenObjectParent already has a kitchenObject!");
//            }
//            kitchenObjectParent.SetKitchenObject(this);
//            transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
//            transform.localPosition = Vector3.zero;

//        }

//        public IKitchenObjectParent GetKitchenObjectParent()
//        {
//            return kitchenObjectParent;
//        }

//        public void DestroySelf()
//        {
//            kitchenObjectParent.ClearKitchenObject();

//            Destroy(gameObject);
//        }

//        public bool TryGetPlate(out PlateKitchenObject plateKitchenObject)
//        {
//            if (this is PlateKitchenObject)
//            {

//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}

//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;

//public class PlayerAnimator : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    private const string IS_WALKING = "IsWalking";

//    [SerializeField] private Player player;

//    private Animator animator;
//    private void Awake()
//    {
//        animator = GetComponent<Animator>();

//    }
//    private void Update()
//    {
//        animator.SetBool(IS_WALKING, player.IsWalking());
//    }
//}//    using UnityEngine;