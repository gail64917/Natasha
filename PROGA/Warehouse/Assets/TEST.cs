using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject Data = GameObject.Find("GlobalArticles");
        List<int> ShellvesPicked = Data.GetComponent<ValuesScript>().activeArticlesOnMap;
        
        GameObject[] allShelves = GameObject.FindGameObjectsWithTag("Shelf");
        
        for (int i=0; i<allShelves.Length; i++)
        {
            allShelves[i].SetActive(false);
            for (int j = 0; j < ShellvesPicked.Count; j++)
            {
                Debug.Log(ShellvesPicked[j]);
                if (i == ShellvesPicked[j])
                {
                    allShelves[i].SetActive(true);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
