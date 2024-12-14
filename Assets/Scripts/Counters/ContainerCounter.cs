using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;   

    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);

            OnPlayGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
    }

}
