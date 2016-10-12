﻿using UnityEngine;
using System.Collections;
using SimplexNoise;

public class BaseChunkFiller : MonoBehaviour {

    public Noise noise;
    protected Voxelmetric vm;

    public virtual void Initialize(Voxelmetric vm)
    {
        noise = new Noise();
        this.vm = vm;
    }

    public virtual void FillChunk(BaseChunk chunk)
    {
        chunk.chunkIsFilled = true;
    }

    public virtual void SetBlocks(int x, int z, int startPlaceHeight, int endPlaceHeight, Block blockToPlace)
    {

    }
}
