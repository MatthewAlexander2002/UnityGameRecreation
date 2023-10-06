using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    // [SerializeField] private Tweener tweener;
    private Tweener tweener;
    public AudioSource clickSound;
    // private Vector3[] positionArray;
    // private int counter;
    
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        
        if (tweener == null)
        {
            tweener = GetComponent<Tweener>();
        }
        //
        // counter = 0;
        //
        // positionArray = new []
        // {
        //     new Vector3(6.0f, 0.0f, 0.0f),
        //     new Vector3(0.0f, -4.0f, 0.0f),
        //     new Vector3(-6.0f, 0.0f, 0.0f),
        //     new Vector3(0.0f, 4.0f, 0.0f)
        // };

    }

    // Update is called once per frame
    void Update()
    {
        // if (counter <= 3)
        // {
        //     tweener.AddTween(item.transform, item.transform.position,  positionArray[counter++], 1.5f);
        //     if (counter >= 3)
        //     {
        //         counter = 0;
        //     }
        // }
        if (Input.GetKeyDown("a"))
        {
            tweener.AddTween(item.transform, item.transform.position,  new Vector3(0.0f,-1.0f,0.0f), 1.5f);
            clickSound.Play();
        }
        if (Input.GetKeyDown("d"))
        {
            tweener.AddTween(item.transform, item.transform.position,  new Vector3(1.0f,0.0f,0.0f), 1.5f);
        }
        if (Input.GetKeyDown("s"))
        {
            tweener.AddTween(item.transform, item.transform.position,  new Vector3(-1.0f,0.0f,0.0f), 1.5f);
        }
        if (Input.GetKeyDown("w"))
        {
            tweener.AddTween(item.transform, item.transform.position,  new Vector3(0.0f,1.0f,0.0f), 1.5f);
        }
    }
}
