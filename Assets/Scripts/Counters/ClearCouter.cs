using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCouter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
        } 
        else
        {
            if (player.HasKitchenObject())
            {
                if (player.GetKitchenObject() is PlateKitchenObject)
                {

                }
            } 
            else
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

}
