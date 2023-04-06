using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class w84GPS : MonoBehaviour
{
    // Public variable to reference the Text UI element for displaying coordinates
    public Text coordinatesText;

    // Base origin coordinates in WGS84 format
    public float baseLatitude;
    public float baseLongitude;
    public float baseAltitude;

    // Constants for WGS84 conversion
    private const float EquatorialRadius = 6378137; // meters
    private const float PolarRadius = 6356752.3142f; // meters
    private const float Flattening = 0.0033528107f; // unitless

    // Update is called once per frame
    void Update()
    {
        // Get the XYZ position of the game object
        Vector3 position = transform.position;

        // Convert the XYZ position to GPS coordinates based on the base origin using WGS84 conversion
        float latitude = baseLatitude + (Mathf.Rad2Deg * Mathf.Atan(Mathf.Exp((position.z / EquatorialRadius) / Mathf.Cos(Mathf.Deg2Rad * baseLatitude)))) - 0.0000045f;
        float longitude = baseLongitude + (Mathf.Rad2Deg * position.x / (EquatorialRadius * Mathf.Cos(Mathf.Deg2Rad * baseLatitude))) + 0.0000115f;
        float altitude = baseAltitude + position.y;

        // Format the Unity coordinates as a string
        string unityCoordinatesString = string.Format("Unity Coordinates\nX: {0}\nY: {1}\nZ: {2}", position.x, position.y, position.z);

        // Format the GPS coordinates as a string in DMS format
        string gpsCoordinatesString = string.Format("GPS Coordinates\nLatitude: {0}\nLongitude: {1}\nAltitude: {2}",
            ConvertToDMS(latitude), ConvertToDMS(longitude), altitude.ToString("F2"));

        // Combine the Unity and GPS coordinates strings
        string coordinatesString = unityCoordinatesString + "\n\n" + gpsCoordinatesString;

        // Update the Text UI element with the combined coordinates string
        coordinatesText.text = coordinatesString;
    }

    // Helper method to convert decimal degrees to DMS format
    private string ConvertToDMS(float decimalDegrees)
    {
        int degrees = (int)decimalDegrees;
        float temp = (decimalDegrees - degrees) * 60;
        int minutes = (int)temp;
        float seconds = (temp - minutes) * 60;
        return string.Format("{0}° {1}' {2:0.##}\"", degrees, minutes, seconds);
    }
}
