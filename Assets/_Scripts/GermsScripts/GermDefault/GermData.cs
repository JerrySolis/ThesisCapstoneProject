using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Germs", order =1)]
public class GermData : ScriptableObject
{
    public string Name;
    public int HP;
    public int Damage;
    public float Speed;



}
