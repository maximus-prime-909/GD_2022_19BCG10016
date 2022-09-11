using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTile : MonoBehaviour
{

    [SerializeField] float destroyAfter = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", destroyAfter);
        
    }

    // Update is called once per frame
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
