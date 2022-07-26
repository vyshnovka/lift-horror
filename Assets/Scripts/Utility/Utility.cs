using System;
using System.Collections;
using UnityEngine;

public static class Utility
{
    public static IEnumerator TimedEvent(Action targetAction, float time)
    {
        yield return new WaitForSeconds(time);
        targetAction.Invoke();
    }

    public static float LeftOrRight(Vector3 forward, Vector3 reference, Vector3 up)
    {
        Vector3 cross = Vector3.Cross(forward, reference);
        float side = Vector3.Dot(cross, up);

        if (side > 0f) //left
        {
            return 1f;
        }
        else if (side < 0f) //right
        {
            return -1f;
        }
        else
        {
            return 0f;
        }
    }
}
