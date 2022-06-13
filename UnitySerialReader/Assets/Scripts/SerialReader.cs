using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports; //to enable reading ports NEEDS .NET 4.X FRAMEWORK

public class SerialReader : MonoBehaviour
{
    List<Sensors> sensors = new List<Sensors>();
    //start serial port and call it stream_data
    //update port for project
    SerialPort data_stream = new SerialPort("/dev/cu.usbserial-0001", 9600);
    public string receivedString;
    public string[] dataRows;
    public string[] datas;
    public string[] port_names = SerialPort.GetPortNames();

    // Start is called before the first frame update
    void Start()
    {
        
        //open the port
        
        //for (int i = 0; i < port_names.Length; i++)
        //{
        //    Debug.Log(port_names[i]);
        //}
        data_stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        receivedString = data_stream.ReadLine();

        string[] dataRows = receivedString.Split('\n'); //split the data

        for (int i = 0; i == dataRows.Length - 1; i++)
        {
            string[] row = dataRows[i].Split(',');

            Sensors s = new Sensors();
            s.SensorName = row[0];
            s.SensorID = row[2];
            s.Time = row[4];
            s.Value = row[6];

            sensors.Add(s);
        }

        foreach(Sensors s in sensors)
        {
            //string[] datas = receivedString.Split(' '); //split the data
            Debug.Log(s.SensorName + " " + s.SensorID + " " + s.Value); //print the data
        }
    }
}
