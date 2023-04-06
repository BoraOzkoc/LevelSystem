using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int level;
    private List<GameObject> levelList = new List<GameObject>();
    private void Start()
    {
        GetLevels();
        
        InstantiateLevel();
    }

    private void GetLevels()
    {
        levelList = Resources.LoadAll<GameObject>("Levels").ToList();

    }

    private void InstantiateLevel()
    {
        Instantiate(levelList[level]);
    }
}
