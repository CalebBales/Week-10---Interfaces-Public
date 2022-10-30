using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTextValue : MonoBehaviour
{
    // DIRECTIONS: The goal of this script is to show the Y coordinate of the cube on
    // the screen. You will need to add some stuff to this script to make it work...

    TextMeshProUGUI textMeshProUGUI;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        cube = GameObject.Find("Cube");
        textMeshProUGUI.text = "Y: " + cube.transform.position.y.ToString();
    }
}
