using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class SlotManager : MonoBehaviour
{
    [SerializeField] private List<Slot> slotPrefabs;
    [SerializeField] private Item itemPrefab;
    [SerializeField] private Transform slotParent, itemParent;


    private void Start()
    {
        Spawn();
    }
    void Spawn()
    {

        var randomSet = slotPrefabs.OrderBy(s=>Random.value).Take(3).ToList();

        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedSlot = Instantiate(randomSet[i], slotParent.GetChild(i).position,Quaternion.identity);

            var spawnedItem = Instantiate(itemPrefab, itemParent.GetChild(i).position, Quaternion.identity);
            spawnedItem.Init(spawnedSlot);
        }
    }
}