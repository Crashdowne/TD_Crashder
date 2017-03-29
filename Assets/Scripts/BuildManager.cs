using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private GameObject towerToBuild;

    public GameObject basicTowerPrefab;
    public GameObject cannonTowerPrefab;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public GameObject GetTowerToBuild ()
    {
        return towerToBuild;
    }

    public void SetTowerToBuild (GameObject tower)
    {
        towerToBuild = tower;
    }
}
