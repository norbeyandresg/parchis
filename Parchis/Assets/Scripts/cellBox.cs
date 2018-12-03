using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class cellBox : MonoBehaviour {

    //0: Normal cell | 1: Exit cell | 2: Dinamic cell | 3: Safe cell
    public int cellType = 0;
    // 0 if the cell is not sky, 1-6 depend the player
    public int skyId = 0;
    // 1 <= cellID <= 156 (totall of cells)
    public int cellID = 0;
    // 1 <= 10
    public int skyNumber = 0;

    //Array of pieces in the cell, 0 not have piece, 1-6 class of player in the cell.
    protected int[] pieces = new int[] { 0, 0, 0, 0, 0 };

    //Put to shine the cell
    public void Shine()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");
        GetComponent<ParticleSystem>().Play();
        halo.enabled = true;
    }

    //
    public void UnShine()
    {
        Behaviour halo = (Behaviour)GetComponent("Halo");
        GetComponent<ParticleSystem>().Stop();
        halo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Start()
    {
        UnShine();
    }

    public double[] getPos()
    {
        float x = this.transform.position.x;
        float z = this.transform.position.z;
        double angle = this.transform.rotation.y;
        double[] pos = new double[] { x, z };
        for (int i = 0; i < pieces.Length; i++)
        {
            if (pieces[i] == 0)
            {
                if (i > 1)
                {
                    pos[0] = x + i * (2.05 * Math.Cos(angle * Mathf.Rad2Deg));
                    pos[1] = z + i * (2.05 * Math.Sin(angle * Mathf.Rad2Deg)) ;
                    pieces[i] = 1;
                    return pos;
                }else
                {
                    pos[0] = x - i * (2.05 * Math.Cos(angle * Mathf.Rad2Deg));
                    pos[1] = z - i * (2.05 * Math.Sin(angle * Mathf.Rad2Deg));
                    pieces[i] = 1;
                    return pos;
                }
            }
        }
        return pos;
    }

    public void Action()
    {
        switch (cellType)
        {
        }
    }
}
