using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    EnemyBase _base;
    int level;
    public int HP { get; set; }

    // Store the moves that the  Enemy knows
    public List<Move> Moves { get; set; }

    public Enemy(EnemyBase eBase, int eLevel)
    {
        _base = eBase;
        level = eLevel;
        HP = eBase.MaxHp;

        // Generate and count moves based on level
        // Moves = new List<Move>();
        // foreach (var move in _base.LearnableMoves)
        // {
        //     if (move.level <= level)
        //         Moves.Add(new Move(move.Base));
        //     if (Moves.Count >= 4)
        //         break;
        // }
    }

    // Stat Calculatuion (Based from Pokemon)
    public int Attack
    {
        get { return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5; }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5; }
    }
    public int SpDefense
    {
        get { return Mathf.FloorToInt((_base.SpDefense * level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }
    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.Attack * level) / 100f) + 10; }
    }
}
