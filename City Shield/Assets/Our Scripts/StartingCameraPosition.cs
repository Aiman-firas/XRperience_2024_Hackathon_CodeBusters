using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingCameraPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0, 2f, 0);
    }
}
