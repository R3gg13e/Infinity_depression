using UnityEngine;

public class RoadPiece : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    

    public Transform StartPos;
    public Transform EndPos;

    [SerializeField] Transform[] buildingSpawnPoints;
    [SerializeField] Transform[] treeSpawnPoints;
    [SerializeField] Transform[] lanes;

    LevelManager levelmanager;

    private void Awake()
    {
        levelmanager = FindAnyObjectByType<LevelManager>();
    }

    //Moves road towards the player
    private void FixedUpdate()
    {
        //If the current gamestate is not running then return out of there
        if (levelmanager.CurrentGameState != GameState.Running)
            return;
        

        //transform.Translate(direction * MoveSpeed * Time.deltaTime);
        transform.position += direction* levelmanager.GetSpeed() * Time.fixedDeltaTime;
    }

    public Transform[] GetBuildingSpawnPoint()
    {
        return buildingSpawnPoints;
    }

    public Transform[] GetTreeSpawnPoints()
    {
        return treeSpawnPoints;
    }

    public Transform[] GetLanes()
    {
        return lanes;
    }

}
