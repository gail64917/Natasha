using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuesScript : MonoBehaviour {

    public List<Article> AllAvailableArticles = new List<Article>() {
        new Article { Name = "38463", index = 0 },
        new Article { Name = "02846", index = 1 },
        new Article { Name = "64917", index = 2 },
        new Article { Name = "11111", index = 3 },
        new Article { Name = "00000", index = 4 },
    };

    public List<int> activeArticlesOnMap = new List<int>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public class Article
    {
        public string Name;
        public int index;
    }
}
