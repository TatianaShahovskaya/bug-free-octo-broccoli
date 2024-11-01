using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class night : MonoBehaviour
{
    [Tooltip("Day lenght in second")]
    public float dayLanght = 360f;
    Transform lightTransform;
    [SerializeField]
    float partTransf = 0;
    [SerializeField]
    float time;
    [SerializeField] float x;
    Quaternion q = new Quaternion();

    // Start is called before the first frame update
    void Start()
    {
        lightTransform = GetComponent<Transform>();
        //partTransf = 360 / (dayLanght / Time.deltaTime); //360 - количество градусов круга.
        Debug.Log(Time.deltaTime);
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        partTransf = 360 / (dayLanght / Time.deltaTime);
        time += Time.deltaTime;
        x += partTransf;
        q = Quaternion.Euler(x, -30,0);
        transform.rotation = q;

        if (time >= dayLanght)
        {
            x = 0;
            time = 0;
        }
    }
}
