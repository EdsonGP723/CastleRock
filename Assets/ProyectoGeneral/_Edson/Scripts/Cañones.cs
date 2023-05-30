using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañones : MonoBehaviour
{
    [SerializeField] private float StartCorrutina;
    public Bullet BulletPrefab;

    [SerializeField] Transform StartPoint;

    private Transform target;

    private Coroutine Shoot;

    // Update is called once per frame
    void Update()
    {
        if (Shoot != null) return;
        target = FindObjectOfType<AIEnemy>().transform;
       Shoot = StartCoroutine(Shooting());
        
    }

    IEnumerator Shooting()
    {
        var bullet = Instantiate(BulletPrefab, StartPoint);
        bullet.Init(StartPoint, target);
        yield return new WaitForSeconds(StartCorrutina);
        Shoot = null;
    }
}
