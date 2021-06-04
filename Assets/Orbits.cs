using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbits : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    [SerializeField] private float alpha;
    public Vector3 center;
    [SerializeField] float deltaAlpha;
    public Transform focus1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        c = Mathf.Sqrt(Mathf.Abs(a * a - b * b));
        center = new Vector3(focus1.position.x + c, 0, focus1.position.z);
        
        transform.position = new Vector3(center.x + a * Mathf.Cos(alpha), 0, center.z + b * Mathf.Sin(alpha));
        c = Mathf.Sqrt(a * a - b * b);
        alpha += deltaAlpha;
    }
}
