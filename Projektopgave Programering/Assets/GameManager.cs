using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;

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
            
            Vector3 direction = (Camera.main.transform.position - DammageTextInstance.transform.position).normalized;
            DammageTextInstance.transform.GetChild(0).rotation = Quaternion.LookRotation(direction);

        
            Vector3 scale = DammageTextInstance.transform.GetChild(0).localScale;
            DammageTextInstance.transform.GetChild(0).localScale = new Vector3(-scale.x, scale.y, scale.z);
            
        }
    }
}
