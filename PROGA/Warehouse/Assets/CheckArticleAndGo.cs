using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckArticleAndGo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void Go()
    {
        GameObject field = GameObject.FindGameObjectWithTag("InputField");
        int index = -1;
        ValuesScript values = GameObject.FindGameObjectWithTag("GlobalValues").GetComponent<ValuesScript>();
        for (int i = 0; i<values.AllAvailableArticles.Count; i++)
        {
            if(values.AllAvailableArticles[i].Name == field.GetComponent<InputField>().text)
            {
                index = values.AllAvailableArticles[i].index;
            }
        }

        GameObject findResult = GameObject.Find("FindResult");
        if (index == -1)
        {
            Debug.Log("ТАКОГО АРТИКЛЯ НЕТ");
            findResult.GetComponent<Text>().color = Color.red;
            findResult.GetComponent<Text>().text = "ARTICLE NOT FOUND";
        }
        else
        {
            string text = "Артикль с индексом: " + index;
            Debug.Log(text);
            values.activeArticlesOnMap.Add(index);
            findResult.GetComponent<Text>().color = Color.green;
            findResult.GetComponent<Text>().text = "ARTICLE FOUND";
        }

        //filling viewList
        GameObject listView = GameObject.Find("ArticleListView");
        listView.GetComponent<Text>().text = "";
        //ValuesScript values = GameObject.FindGameObjectWithTag("GlobalValues").GetComponent<ValuesScript>();
        for (int i = 0; i < values.activeArticlesOnMap.Count; i++)
        {
            //listView.GetComponent<Text>().text += values.activeArticlesOnMap[i] + "/r/n";
            for (int j = 0; j< values.AllAvailableArticles.Count; j++)
            {
                if(values.activeArticlesOnMap[i] == values.AllAvailableArticles[j].index)
                {
                    listView.GetComponent<Text>().text += values.AllAvailableArticles[j].Name + "\r\n";
                }
            }
        }
    }
}
