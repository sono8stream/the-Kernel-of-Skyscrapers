﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObject : MonoBehaviour {

    protected int range = 1;//大きさ
    public int Range { get { return range; } }
    protected int viewRange;//視野の大きさ
    public int ViewRange { get { return viewRange; } }
    protected int dire = 0;//方向
    public int Dire
    {
        get { return dire; }
        set { dire = value; }
    }
    protected int no;//オブジェクト番号
    public int No
    {
        get { return no; }
    }
    protected int floor;
    public int Floor
    {
        get { return floor;}
        set { floor = value; }
    }

    protected MapLoader map;
    public MapLoader Map
    {
        get { return map; }
        set { map = value; }
    }

    void Awake()
    {
        map = GameObject.Find("Map").GetComponent<MapLoader>();
    }

    // Use this for initialization
    protected void Start()
    {
        no = map.RecObj(this, range);
        viewRange = 1;
        Debug.Log("origin" + viewRange);
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected Vector3 DtoV(int direction)
        {
        Vector2 pos = Vector2.zero;
        switch(direction)
        {
            case 0:
                pos = Vector2.down;
                break;
            case 1:
                pos = Vector2.right;
                break;
            case 2:
                pos = Vector2.up;
                break;
            case 3:
                pos = Vector2.left;
                break;
        }
        return pos;
    }
}