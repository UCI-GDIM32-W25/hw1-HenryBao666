using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f; // Speed of player movement
    [SerializeField] private Transform _playerTransform; // Reference to the player's transform
    [SerializeField] private GameObject _plantPrefab; // Prefab for the seed to plant
    [SerializeField] private int _numSeeds = 5; // Total number of seeds available
    [SerializeField] private PlantCountUI _plantCountUI; // UI to display seed count

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start()
    {
        _numSeedsLeft = _numSeeds;
        if (_plantCountUI != null)
        {
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        }
    }

    private void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    private void PlayerMovement()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(xMove, yMove) * _speed * Time.deltaTime;
        _playerTransform.Translate(new Vector3(movement.x, movement.y, 0), Space.World);
    }

    public void PlantSeed()
    {
        if (_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            _numSeedsLeft--;
            _numSeedsPlanted++;
            if (_plantCountUI != null)
            {
                _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            }
        }
    }
}