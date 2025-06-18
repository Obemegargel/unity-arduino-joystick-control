using UnityEngine;
using System.IO;

public class JoystickMovement : MonoBehaviour
{
    void Update()
    {
        try
        {
            string path = Application.dataPath + "/../joystick_data.txt";

            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                string[] parts = data.Split(',');

                if (parts.Length == 2)
                {
                    int x = int.Parse(parts[0]);
                    int y = int.Parse(parts[1]);

                    // 512 is center of joystick, takes difference to know where moving and Mathf.Clamp helps it be less choppy
                    float dx = Mathf.Clamp((x - 512) / 100f, -1f, 1f); // left/right movement
                    float dz = Mathf.Clamp(-(y - 512) / 100f, -1f, 1f); // forward/backward movement

                    Vector3 move = new Vector3(dx, 0, dz);
                    transform.Translate(move * Time.deltaTime * 5f);
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogWarning("Joystick Read Error:" + e.Message);
        }
    }
}