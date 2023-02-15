using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumOfSustenance { get; private set; }

    //public UnityEvent<PlayerInventory> OnSustenanceCollected;

    public void SustenanceCollected()
    {
        NumOfSustenance++;
        //OnSustenanceCollected.Invoke(this);
    }
}