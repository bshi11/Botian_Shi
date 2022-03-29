using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void Moveup()
    {
        value = value + 1f;
        human.transform.position = new Vector3(value, 6f, 8f);
    }
    public void Rotate()
    {
        human.transform.Rotate(30f, 30f, 30f);
    }
    public void Grow()
    {
        human.transform.localScale *= 1.2f;
    }
    public void ResetHuman()
    {
        human.transform.position = new Vector3(1f, 6f, 8f);
        human.transform.rotation = Quaternion.Euler(new Vector3(90f, 65f, -25f));
        human.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
