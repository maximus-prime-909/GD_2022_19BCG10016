using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTile : MonoBehaviour
{

    public int max_destroy = 5;
    public int min_destroy = 4;
    [SerializeField] float destroyAfter;
    // Start is called before the first frame update
    void Start()
    {
        destroyAfter = Random.Range(min_destroy, max_destroy);
        Invoke("Destroy", destroyAfter);
        
    }

    // Update is called once per frame
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
