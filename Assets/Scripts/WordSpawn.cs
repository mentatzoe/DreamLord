using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class WordSpawn : MonoBehaviour
{

    GameObject t;
    public int id;
    public bool ready = true;
    public bool spawn = true;
    private Dictionary<GameObject, int> blockTypes = new Dictionary<GameObject, int>();

    void Start()
    {
        renderer.enabled = false;
        blockTypes.Add((GameObject)Resources.Load("box"), 30);
        blockTypes.Add((GameObject)Resources.Load("CrackedBox"), 1);
        blockTypes.Add((GameObject)Resources.Load("DragBox"), 8);
        blockTypes.Add((GameObject)Resources.Load("ladder"), 2);
        blockTypes.Add((GameObject)Resources.Load("empty"), 1);
    }

    IEnumerator Spawn()
    {
        ready = false;

        while (true)
        {
            yield return new WaitForSeconds(0.20f);
            if (spawn)
            {
                /*
                blockTypes.Add((GameObject)Resources.Load("box"), 30);
                blockTypes.Add((GameObject)Resources.Load("CrackedBox"), 1);
				blockTypes.Add((GameObject)Resources.Load("DragBox"), 3);
                blockTypes.Add((GameObject)Resources.Load("ladder"), 2);
                 */
                GameObject word = WeightedRandomizer.From(blockTypes).TakeOne();
                Instantiate(word);
                word.transform.position = new Vector3(this.transform.position.x, this.transform.position.y);
                //blockTypes.Clear();
                //spawn = false;
            }
            spawn = true;
        }
        ready = true;
    }

    void FixedUpdate()
    {
        if (ready)
        {

            StartCoroutine(Spawn());
        }
    }


    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "climb" || coll.gameObject.tag == "helper" || coll.gameObject.tag == "break" || coll.gameObject.tag == "empty")
        {
            //Debug.Log("spawn ready");
            spawn = true;
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "climb" || coll.gameObject.tag == "helper" || coll.gameObject.tag == "break" || coll.gameObject.tag == "empty")
        {
            //Debug.Log("spawn ready");
            spawn = false;
        }
    }

}
