using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldSystem : MonoBehaviour
{
    public Vector2Int GridSize = new Vector2Int(10, 10);
    
    private Building[,] grid;
    private Building flyingBuilding;

    private Camera mainCamera;

    private void Awake()
    {
        grid = new Building[GridSize.x, GridSize.y];

        mainCamera = Camera.main;
    }

    public void StartPlacingBuilding(Building buildingPrefab)
    {
        if(flyingBuilding != null)
        {
            Destroy(flyingBuilding);
        }

        flyingBuilding = Instantiate(buildingPrefab);
    }

    private void Update()
    {
        if(flyingBuilding != null)
        {
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if(groundPlane.Raycast(ray, out float position))
            {
                Vector3 worldPosition = ray.GetPoint(position);

                int x = Mathf.RoundToInt(worldPosition.x);
                int y = Mathf.RoundToInt(worldPosition.z);

                bool available = true;

                if(x < 0 || x > GridSize.x - flyingBuilding.Size.x) available = false;
                if(y < 0 || x > GridSize.y - flyingBuilding.Size.y) available = false;

                flyingBuilding.transform.position = new Vector3(x, 0, y);

                if(available && Input.GetMouseButtonDown(0))
                {
                    flyingBuilding = null;
                }
            }
        }
    }
}