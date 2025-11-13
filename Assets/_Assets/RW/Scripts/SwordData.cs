using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName ="New Sword Data", menuName ="Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField] private string swordName;
    [SerializeField] private string swordDescription;
    [SerializeField] private Sprite icon;
    [SerializeField] private int goldCost;
    [SerializeField] private int attckDamage;

    //Function to return the data of the sword
    public string SwordName
    {
        get
        {
            return swordName;
        }
    }

    public string Description
    {
        get
        {
            return swordDescription;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;    
        }
    }

    public int GoldCost
    {
        get
        {
            return goldCost;
        }
    }

    public int AttckDamage
    {
        get
        {
            return attckDamage;
        }
    }
}
