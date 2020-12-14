using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour

{
    [SerializeField]
    private Transform[] landpreps;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;
    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(landpreps[0].rotation.z == 0&&
            landpreps[1].rotation.z == 0 &&
            landpreps[2].rotation.z == 0 &&
            landpreps[3].rotation.z == 0 &&
            landpreps[4].rotation.z == 0 &&
            landpreps[5].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
        }
    }
}
