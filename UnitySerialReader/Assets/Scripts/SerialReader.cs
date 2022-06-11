using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports; //to enable reading porst NEEDS .NET 4.X FRAMEWORK

public class SerialReader : MonoBehaviour
{
    //start serial port and call it stream_data
    //update port for project
    SerialPort data_stream = new SerialPort("/dev/cu.usbmodem14101", 9600);
    public string receivedString;
    public string[] datas;

    // Start is called before the first frame update
    void Start()
    {
        //open the port
        data_stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        receivedString = data_stream.ReadLine();

        string[] datas = receivedString.Split(','); //split the data
        Debug.Log(datas); //print the data
    }
}
