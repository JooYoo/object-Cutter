using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DestroyChild : MonoBehaviour
{
    private List<GameObject> AllChildren;
    public int ChildIndex;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //// if the object has children
        //if (transform.childCount > 0)
        //{
        //    // get all children
        //    foreach (Object child in transform)
        //    {
        //        AllChildren.Add(child);
        //    }

        //    Debug.Log("Children count:" + AllChildren.Count);
        //}


        //find all children called "TargetObj"
        AllChildren = GameObject.FindGameObjectsWithTag("TargetObj").ToList();
        if (AllChildren.Count>1)
        {
            // if the DeleteTarget exist then destroy it
            if (AllChildren[ChildIndex-1] != null)
            {
                Destroy(AllChildren[ChildIndex-1]);
            }
        }
    }
}
