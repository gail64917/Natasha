using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetInputField : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public  void Reset()
    {
        //GameObject Field = GameObject.FindGameObjectWithTag("InputField");
        //Field.GetComponent<InputField>().text = "";
        
        GameObject Data = GameObject.Find("GlobalArticles");
        Data.GetComponent<ValuesScript>().activeArticlesOnMap.Clear();

        GameObject listView = GameObject.Find("ArticleListView");
        listView.GetComponent<Text>().text = "";
    }
}
