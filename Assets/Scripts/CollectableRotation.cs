using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
}
