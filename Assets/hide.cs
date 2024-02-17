using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{
    public GameObject review;
    public GameObject info;
    private bool infoVisible, reviewVisible;
    // Start is called before the first frame update
    void Start()
    {
        infoVisible = true;
        info.SetActive(true);
        reviewVisible = false;
        review.SetActive(false);
    }

    bool flip(bool value)
    {
        return !value;
    }

    // Update is called once per frame
    void Update()
    {
        // https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html
        // https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
        if (Input.GetKeyDown("space"))
        {
            infoVisible = flip(infoVisible);
            reviewVisible = flip(reviewVisible);

            info.SetActive(infoVisible);
            review.SetActive(reviewVisible);
        }
        // Find out whether current second is odd or even
    }
}
