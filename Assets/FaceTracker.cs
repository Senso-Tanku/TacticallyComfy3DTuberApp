using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;
using UniGLTF;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


public class FaceTracker : MonoBehaviour
{

    [Header("Basic Model Setup Stuff")]
    public GameObject Model = null;
    public Transform RootPositionTransform = null; //Gets the root transform bone (hips) position
    public Transform RootRotationTransform = null; //Same as above but rotation

    /*
    [Header("Camera Stuff")]
    public string requestedDeviceName = null;
    public int requestedWidth = 320;
    public int requestedHeight = 240;
    public int requestedFPS = 30;
    public bool requestedIsFrontFacing = false;

    [Header("Stuff that probably shouldn't be touched")]
    public bool Freeze = false; //Stop tracking
                                //Put other options here.
    */

    //Constants 

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
