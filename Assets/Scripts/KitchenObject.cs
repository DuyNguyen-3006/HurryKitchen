using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private IKitchenObjectParen kitchenObjectParent;
    public KitchenObjectSO GetKitchenObjectso()
    {
        return kitchenObjectSO;
    }
    public void SetKitchenObjectParent(IKitchenObjectParen kitchenObjectParent)
    {
        if(this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.ClearKitchenObject();
        }
        this.kitchenObjectParent = kitchenObjectParent;

        if (kitchenObjectParent.HasKitchenObject())
        {
            Debug.LogError("IKitchenObjectParen already has a KitchenObject!");
        }
        kitchenObjectParent.SetKitchenObject(this);

        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero; 
    }
    public IKitchenObjectParen GetKitchenObjectParent()
    {
        return kitchenObjectParent;
    }
}