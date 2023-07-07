using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxDestroy : MonoBehaviour
{
    [SerializeField] private int delay;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }
}
