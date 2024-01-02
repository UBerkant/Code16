using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunesDonus : MonoBehaviour
{
    public Transform Target;
    public int hiz;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.transform.position, Target.transform.up, hiz * Time.deltaTime);
    }
}
