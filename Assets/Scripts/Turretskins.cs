using UnityEngine;

public class Turretskins : MonoBehaviour
{
    public Material[] materials = new Material[10]; //for 10 materials
    public GameObject turret;
    public GameObject turretfpannel;
    public GameObject turretpref;
    public GameObject turretfpannelpref;
    public MeshRenderer turretrend;
    public MeshRenderer turretfpannelrend;
    public MeshRenderer turretprefrend;
    public MeshRenderer turretfpannelprefrend;
    void start()
    {

        turretrend = GetComponent<MeshRenderer>();
        turretfpannelrend = GetComponent<MeshRenderer>();
        turretprefrend = GetComponent<MeshRenderer>();
        turretfpannelprefrend = GetComponent<MeshRenderer>();


    }

    public void changeMaterial(int index)
    {

        turret.GetComponent<MeshRenderer>().material = materials[index];
        turretfpannel.GetComponent<MeshRenderer>().material = materials[index];
        turretpref.GetComponent<MeshRenderer>().material = materials[index];
        turretfpannelpref.GetComponent<MeshRenderer>().material = materials[index];
    }

}
