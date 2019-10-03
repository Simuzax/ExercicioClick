using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Operations
{
    public static void movement(Transform player, Vector3 destination, float speed)
    {
        player.Translate(destination * speed * Time.deltaTime, Space.World);
    }
}
