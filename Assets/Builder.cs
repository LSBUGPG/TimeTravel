using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Builder : MonoBehaviour
{
    [System.Serializable]
    public class NamedPrefab
    {
        public string name;
        public Transform prefab;
    }

    public NamedPrefab [] namedPrefabs;

    public class BuildingPlacement
    {
        public string name;
        public Vector3 position;
        public Quaternion rotation;

        public BuildingPlacement(
            string name,
            Vector3 position,
            Quaternion rotation) 
        {
            this.name = name;
            this.position = position;
            this.rotation = rotation;
        }
    }

    static List<BuildingPlacement> buildings = new List<BuildingPlacement>();
    
    Dictionary<string, NamedPrefab> index =
        new Dictionary<string, NamedPrefab>();

    void Awake()
    {
        foreach (NamedPrefab namedPrefab in namedPrefabs)
        {
            index[namedPrefab.name] = namedPrefab; 
        }

        foreach(BuildingPlacement building in buildings)
        {
            PlaceBuilding(building);
        }
    }

    void PlaceBuilding(BuildingPlacement building)
    {
        Transform prefab = index[building.name].prefab;
        Instantiate(prefab, building.position, building.rotation);
    }

    void Update()
    {
        string building = string.Empty;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            building = "BlueObject";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            building = "RedObject";
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("TheFuture");
        }

        if (building != string.Empty)
        {
            Vector3 position = transform.position + transform.forward * 3.0f;
            Quaternion rotation = transform.rotation;
            BuildingPlacement placement =
                new BuildingPlacement(building, position, rotation);

            buildings.Add(placement);
            PlaceBuilding(placement);
        }
    }
}
