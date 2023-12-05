using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    [Header("Item Target")]
    public Transform hatPoint; 
    public Transform rHandPoint;
    public Transform lHandPoint;
    
    [Header("Loadout")]
    public GameObject hatItem;
    public GameObject rHandItem;
    public GameObject lHandItem;

    [Header("Intentory")]
    public GameObject[] items;

    private void Start()
    {
        //Instantiate(hatItem, hatPoint.position, hatItem.transform.rotation, hatPoint);
        //Instantiate(rHandItem, rHandPoint.position, rHandItem.transform.rotation, rHandPoint);
        //Instantiate(lHandItem, lHandPoint.position, lHandItem.transform.rotation, lHandPoint);
    }

    void OnGUI()
    {
        GUI.contentColor = Color.black;
        GUI.Label(new Rect(10, 10, 100, 200), "How to use");

        GUI.Label(new Rect(10, 200, 100, 200), "1. Gun \n2. Flashlight \n3. Ammo \n4. Rock \n5. Top Hat");
    }
}
