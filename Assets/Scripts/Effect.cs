using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public float life = 1;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
    }
}
