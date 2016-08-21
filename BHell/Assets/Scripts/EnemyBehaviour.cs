﻿using UnityEngine;
using System.Collections;
[System.Serializable]
public class Shooting //sibling class?????????????????????????
{
    public float fireDuration;   // how long we fire
    public float fireRate;    //during this duration, how often we fire
    public float fireWait;  //how long we wait in between firetimes

    private float nextFire = 0.0f;//keep track of when next fire is ready

    public float getNextFire()
    {
        return nextFire;
    }
    public void setNextFire(float next)
    {
        this.nextFire = next;
    }
}
public class EnemyBehaviour : MonoBehaviour
{
    public GameObject primaryProjectile;
    public Transform primaryFireSpawn;
    public Shooting primaryFire;
    protected GameObject target;


}