using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform initialPos, target, fireball;
    public float speed;

    private void Awake()
    {
        fireball = transform;
    }

    void Update()
    {
        StartCoroutine(BulletBehaviour());
    }

    public void Init(Transform initialPos, Transform target)
    {
        this.initialPos = initialPos;
        this.target = target;
    }

    IEnumerator BulletBehaviour()
    {
        float t = 0;
       

        while (t < 1)
        {
            float distance = Vector3.Distance(initialPos.position, target.position);
            float finalSpeed = distance / speed;

            t += Time.deltaTime / finalSpeed;

            float y = Mathf.Sin(Mathf.PI * Mathf.Lerp(0, 180, t) / 360) * distance;
            Vector3 finalPos = initialPos.position;
            finalPos.y += y;

            fireball.transform.position = Vector3.Lerp(finalPos, target.position, t);
            yield return null;
        }
    }
}
