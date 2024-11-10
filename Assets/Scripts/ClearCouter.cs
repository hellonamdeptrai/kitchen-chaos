using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCouter : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform conuterTopPoint;

    private KitchenObject kitchenObject;

    public void Interact(Player player)
    {
        if (kitchenObject == null)
        {
            Transform kitchaoObjectTransform = Instantiate(kitchenObjectSO.prefab, conuterTopPoint);
            kitchaoObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        }
        else
        {
            kitchenObject.SetKitchenObjectParent(player);
        }
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return conuterTopPoint;
    } 
    
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    } 
    
    public KitchenObject GetKitchenObject() { 
        return kitchenObject;
    }
    
    public void ClearKitchenObject()
    {
        kitchenObject = null;
    } 
    
    public bool HasKitchenObject() { 
        return kitchenObject != null;
    }
}
