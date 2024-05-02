using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int speed;
    public GameObject player;
    void Update()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
        if (HitWall() == true)
        {

        }
    }
    public bool HitWall()
    {
        bool hitWall = false;
        Vector3 raycastOrgin = transform.position;
        Vector3 originOffset = new Vector3(0, 0.9f, 0);
        float playerWidth = 0.5f;
        RaycastHit hit;
        if (Physics.Raycast(raycastOrgin, Vector3.forward, out hit, playerWidth))
        {
            hitWall = true;
        }
        if (Physics.Raycast(raycastOrgin + originOffset, Vector3.forward, out hit, playerWidth))
        {
            hitWall = true;
        }
        if (Physics.Raycast(raycastOrgin - originOffset, Vector3.forward, out hit, playerWidth))
        {
            hitWall = true;
        }
        return hitWall;
    }
}
