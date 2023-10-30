using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] EnemyBase _base;
    [SerializeField] bool isPlayerUnit;
    [SerializeField] int level;
 
    public Enemy Enemy {get; set; }
    public void Setup()
    {
        Enemy = new Enemy(_base, level);
        if (isPlayerUnit)
            GetComponent<Image>().sprite = Enemy.Base.BackSprite;
        else
            GetComponent<Image>().sprite = Enemy.Base.FrontSprite;
    }
}
