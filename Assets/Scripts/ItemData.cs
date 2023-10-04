using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ItemScriptable/ItemData", order = 0)]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private string itemName;
    public string ItemName { get { return itemName; } set { itemName = value; } }

    public ItemEffectType itemEffectType;

    [SerializeField]
    private int itemValue;

    // �� ������ ����
    public int ItemValue { get { return itemValue; } set { itemValue = value; } }

    //// �����ϴ� ������
    //public GameObject itemPrefab;

    public enum ItemEffectType
    {
        IncreaseHP,
        IncreaseTime,
        EnableAttack
    }
}
