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
        Transform kitchaoObjectTransform = Instantiate(kitchenObjectSO.prefab);
        kitchaoObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);

        OnPlayGrabbedObject?.Invoke(this, EventArgs.Empty);
    }

}
