using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject sphere;

    public int s_pos_x = 0;
    public int s_pos_y = 2;
    public int s_pos_z = 0;

    public int s_mass = 5;

    void Start()
    {
        sphere.GetComponent<Transform>().position = new Vector3(s_pos_x,s_pos_y,s_pos_z);
        sphere.GetComponent<Rigidbody>().mass = s_mass;
    }

   // void Update(){
    //     if (s_pos_y < -1)
    //     {
    //         Destroy(sphere);
    //         Start();
    //         // int s_pos_x = 0;
    //         // int s_pos_y = 2;
    //         // int s_pos_z = 0;
    //     }
   // }


}
