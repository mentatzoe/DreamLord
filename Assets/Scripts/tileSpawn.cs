using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class tileSpawn : MonoBehaviour {

	// Use this for initialization
    private Dictionary<int, int> blockTypes = new Dictionary<int, int>();
    bool spawnRandom = true;
    bool isClimbing;
    public bool spawn;
    int score;
    float fallSpeed;
    float increase;
    PlayerController controller;
    public int[,] tiles;
    private int spawnRow = 0;
    private Vector2 spawn1pos;
    private Vector2 spawn2pos;
    private Vector2 spawn3pos;
    private Vector2 spawn4pos;
    private float spawnDistance = 1.9f;
    bool firstspawn = true;
	void Start () {
        blockTypes.Add(3, 30); //box
        blockTypes.Add(4, 1); //crackedbox
        blockTypes.Add(1, 5); //DragBox
        blockTypes.Add(2, 2); //Ladder
        spawnRow = 1;
        GameObject player = GameObject.Find("Character");
        controller = player.GetComponent<PlayerController>();
        tiles = randomMatrix();
	}
	
	// Update is called once per frame
	void Update () {
        isClimbing = controller.isClimbing;
        score = controller.score;
        increase = score * 0.0005f;
        fallSpeed = 0.05f + increase;
        if (isClimbing || !controller.playing)
            spawnDistance = spawnDistance - fallSpeed;
        if ((firstspawn && transform.position.y - spawnDistance >= 0.75) || (!firstspawn && transform.position.y - spawnDistance >= 1.42)) //1.42, 0.80
        {
            spawn1pos = new Vector2(-3.964183f, transform.position.y);
            spawn2pos = new Vector2(-2.461335f, transform.position.y);
            spawn3pos = new Vector2(-0.9372464f, transform.position.y);
            spawn4pos = new Vector2(0.583663f, transform.position.y);
            spawnDistance = transform.position.y;
            spawn1(spawnRow);
            spawn2(spawnRow);
            spawn3(spawnRow);
            spawn4(spawnRow);
            spawnRow++;
            if (spawnRow > 3)
            {
                spawnRow = 0;
                if (spawnRandom)
                {
                    tiles = randomMatrix();
                    spawnRandom = false;
                }
                else
                {
                    int randomInt = Random.Range(1, 4);
                    switch(randomInt)
                    {
                        case 1: tiles = myMatrix1();
                            break;
                        case 2: tiles = myMatrix2();
                            break;
                        case 3: tiles = myMatrix3();
                            break;
                        case 4:tiles = myMatrix4();
                            break;
                        default:tiles = myMatrix3();
                            break;
                    }
                    spawnRandom = true;
                    firstspawn = false;
                }
            }
        }
	}

    void spawn1(int row)
    {
        GameObject block;
        switch(tiles[row,0])
        {
            case 1: block = (GameObject)Resources.Load("DragBox");
                    break;
            case 2: block = (GameObject)Resources.Load("ladder");
                    break;
            case 3: block = (GameObject)Resources.Load("box");
                    break;
            case 4: block = (GameObject)Resources.Load("CrackedBox");
                    break;
            case 0: block = (GameObject)Resources.Load("empty");
                    break;
            default: block = (GameObject)Resources.Load("empty");
                    break;
        }
        Instantiate(block);
        block.transform.position = spawn1pos;
    }

    void spawn2(int row)
    {
        GameObject block;
        switch (tiles[row, 1])
        {
            case 1: block = (GameObject)Resources.Load("DragBox");
                break;
            case 2: block = (GameObject)Resources.Load("ladder");
                break;
            case 3: block = (GameObject)Resources.Load("box");
                break;
            case 4: block = (GameObject)Resources.Load("CrackedBox");
                break;
            case 0: block = (GameObject)Resources.Load("empty");
                break;
            default: block = (GameObject)Resources.Load("empty");
                break;
        }
        Instantiate(block);
        block.transform.position = spawn2pos;
    }

    void spawn3(int row)
    {
        GameObject block;
        switch (tiles[row, 2])
        {
            case 1: block = (GameObject)Resources.Load("DragBox");
                break;
            case 2: block = (GameObject)Resources.Load("ladder");
                break;
            case 3: block = (GameObject)Resources.Load("box");
                break;
            case 4: block = (GameObject)Resources.Load("CrackedBox");
                break;
            case 0: block = (GameObject)Resources.Load("empty");
                break;
            default: block = (GameObject)Resources.Load("empty");
                break;
        }
        Instantiate(block);
        block.transform.position = spawn3pos;
    }

    void spawn4(int row)
    {
        GameObject block;
        switch (tiles[row, 3])
        {
            case 1: block = (GameObject)Resources.Load("DragBox");
                break;
            case 2: block = (GameObject)Resources.Load("ladder");
                break;
            case 3: block = (GameObject)Resources.Load("box");
                break;
            case 4: block = (GameObject)Resources.Load("CrackedBox");
                break;
            case 0: block = (GameObject)Resources.Load("empty");
                break;
            default: block = (GameObject)Resources.Load("empty");
                break;
        }
        Instantiate(block);
        block.transform.position = spawn4pos;
    }

    int[,] randomMatrix()
    {
        int[,] result = new int[4,4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int random = WeightedRandomizer.From(blockTypes).TakeOne();
                if (!firstspawn)
                    result[i, j] = random;
                else
                    result[i, j] = 3;
            }
        }
            return result;
    }

    int[,] myMatrix1()
    {
        int[,] result = new int[,]
        {
            {1,3,4,3},
            {0,2,3,3},
            {3,2,0,3},
            {0,2,0,3}
        };
        return result;
    }
    int[,] myMatrix2()
    {
        int[,] result = new int[,]
        {
            {0,3,3,3},
            {1,0,3,4},
            {0,3,3,3},
            {3,3,1,3}
        };
        return result;
    }
    int[,] myMatrix3()
    {
        int[,] result = new int[,]
        {
            {0,0,1,0},
            {3,3,0,1},
            {3,1,4,2},
            {0,3,3,2}
        };
        return result;
    }
    int[,] myMatrix4()
    {
        int[,] result = new int[,]
        {
            {0,3,4,3},
            {3,3,3,4},
            {3,4,1,3},
            {0,3,3,3}
        };
        return result;
    }
}
