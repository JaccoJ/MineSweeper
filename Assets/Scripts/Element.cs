using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Element : MonoBehaviour {

    
    public bool mine;

    [SerializeField]
    private Sprite[] emptytextures;

    [SerializeField]
    private Sprite minetextures;

    // Use this for initialization
	void Start () {
        mine = Random.value < 0.15;

        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        BetterGrid.elements[x, y] = this;
	}
	
    public void loadTexture(int count)
    {
        if (mine)
        {
           
            GetComponent<SpriteRenderer>().sprite = minetextures;
        }
        else GetComponent<SpriteRenderer>().sprite = emptytextures[count];
    }

    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }

    void OnMouseUpAsButton()
    {
        if (mine)
        {
            BetterGrid.UncoverMines();
            print("u lsoe lol");
        }
        else
        {
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            loadTexture(BetterGrid.adjacentMines(x, y));

            BetterGrid.floodfill(x, y, new bool[BetterGrid.w, BetterGrid.h]);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
