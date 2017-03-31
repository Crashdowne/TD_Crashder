using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseBasicTower()
    {
        Debug.Log("Basic");
        buildManager.SetTowerToBuild(buildManager.basicTowerPrefab);
    }

    public void PurchaseCannonTower()
    {
        Debug.Log("Cannon");
        buildManager.SetTowerToBuild(buildManager.cannonTowerPrefab);
    }

    public void PurchaseMissleTower()
    {
        Debug.Log("Missle");
        buildManager.SetTowerToBuild(buildManager.missleTowerPrefab);
    }
}
