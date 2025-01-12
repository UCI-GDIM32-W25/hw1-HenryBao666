[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

HW1 break-down

Object
UI
Seeds planted UI
Attributes: text
Actions: count goes up when the player plants a seed
Seeds remaining UI
Attributes: text
Actions: count goes down when the player plants a seed
Player
Attributes
Bunny sprite
Actions
Movements: Can move in all directions with WASD
Plants
Attributes
Spawned in the position of the player at the time of planting

## Devlog
Object:
    UI
        Seeds planted UI
            Attributes: text
            Actions: count goes up when player plants seed
        Seeds remaining UI
            Attributes: text
            Actions: count goes down when player plants seed
    Player  
        Attributes: Bunny sprite
        Actions: 
            Movements: Can move in all directions with WASD
            Plants seed when pressing 'space'
    Plants
        Attributes: Seed sprite
        Actions: Spawned in the position of the player at the time of planting

Player
    Attributes:
        Movement speed: A float number is set for movement speed, _speed controls that
        Seed Count:
            Two integer variables:
                _numSeeds: The total number of seeds available at the start
                _numSeedsLeft: Tracks how many seeds are still available to plant  
    Movement:
        Movement logic implemented in the PlayerMovement() method
        Called in the updated method to be updated every frame
    Planting Seeds:
	    Implemented in the PlantSeed() method
	    Spawns a seed prefab at the player’s position
	    Updates _numSeedsLeft and _numSeedsPlanted
	    Dynamically updates the UI with PlantCountUI component
UI
    Seeds Planted UI
        Attributes:
            A TextMeshPro - Text field that displays the number of seeds planted by the player
        Actions:
	        Increases the count when the player plants a seed
	        Updated dynamically through the UpdateSeeds() method in the PlantCountUI class


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
