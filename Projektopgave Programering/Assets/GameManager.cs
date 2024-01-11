using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Gamemaneger : MonoBehaviour
{
    public GameObject dammageTextPrefab, enemyInstance;
    public string textToDisplay;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject DammageTextInstance = Instantiate(dammageTextPrefab, enemyInstance.transform);
            DammageTextInstance.transform.GetChild(0).GetComponent<TextMeshPro>().SetText(textToDisplay);
        }
    }
}
