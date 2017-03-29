using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildNode : MonoBehaviour
{
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosistion ()
    {
        return transform.position;
    }

    void OnMouseDown()
    { 
        GameObject towerToBuild = buildManager.GetTowerToBuild();

        if (towerToBuild == null)
        {
            Debug.Log("no tower selected");
            return;
        }

        towerToBuild = (GameObject)Instantiate(towerToBuild, transform.position, Quaternion.identity);
    }

}
