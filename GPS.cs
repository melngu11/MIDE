using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPS : MonoBehaviour
{
    // Public variable to reference the Text UI element for displaying coordinates
    public Text coordinatesText;

    // Base origin coordinates
    public float baseLatitude;
    public float baseLongitude;
    public float baseAltitude;

    // Update is called once per frame
    void Update()
    {
        // Get the XYZ position of the game object
        Vector3 position = transform.position;

        // Convert the XYZ position to GPS coordinates based on the base origin
        float latitude = baseLatitude + position.z * 111111f;
        float longitude = baseLongitude + position.x * 111111f;
        float altitude = baseAltitude + position.y;

        // Format the Unity coordinates as a string
        string unityCoordinatesString = string.Format("Unity Coordinates\nX: {0}\nY: {1}\nZ: {2}", position.x, position.y, position.z);

        // Format the GPS coordinates as a string
        string gpsCoordinatesString = string.Format("GPS Coordinates\nLatitude: {0}\nLongitude: {1}\nAltitude: {2}", latitude, longitude, altitude);

        // Combine the Unity and GPS coordinates strings
        string coordinatesString = unityCoordinatesString + "\n\n" + gpsCoordinatesString;

        // Update the Text UI element with the combined coordinates string
        coordinatesText.text = coordinatesString;
    }
}


Assign GPS script to object and UI text to coordinate text
User may adjust base coordinates from inspector
#TODO:
Rect Transform:(-400, 330, 0)
Bold, font size 16, overflow
