[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

HW1 break-down
Object
- UI
	- Seeds planted UI
		- Attributes: text
		- Actions: count goes up when the player plants a seed
	- Seeds remaining UI
		- Attributes: text
		- Actions: count goes down when the player plants a seed
- Player
	- Attributes
		- Bunny sprite
	- Actions
		- Movements: Can move in all directions with WASD
- Plants
	- Attributes
	- Spawned in the position of the player at the time of planting

Object:
- UI
	- Seeds planted UI
		- Attributes: text
		- Actions: count goes up when player plants seed
	- Seeds remaining UI
		- Attributes: text
		- Actions: count goes down when player plants seed
- Player  
	- Attributes: Bunny sprite
	- Actions: 
		- Movements: Can move in all directions with WASD
		- Plants seed when pressing 'space'
	- Attributes:
		- Movement speed: A float number is set for movement speed, _speed controls that
		- Seed Count:
		- Two integer variables:
			- _numSeeds: The total number of seeds available at the start
			- _numSeedsLeft: Tracks how many seeds are still available to plant  
	- Movement:
		- Movement logic implemented in the PlayerMovement() method
		- Called in the updated method to be updated every frame
	- Planting Seeds:
		- Implemented in the PlantSeed() method
		- Spawns a seed prefab at the player’s position
		- Updates _numSeedsLeft and _numSeedsPlanted
		- Dynamically updates the UI with PlantCountUI component
- Plants
	- Attributes: Seed sprite
	- Actions: Spawned in the position of the player at the time of planting
- UI
	- Seeds Planted UI
		- Attributes:
			- A TextMeshPro - Text field that displays the number of seeds planted by the player
		- Actions:
			- Increases the count when the player plants a seed
			- Updated dynamically through the UpdateSeeds() method in the PlantCountUI class
	- Seeds Remaining UI
		- Attributes:
			- A TextMeshPro - Text field that displays the number of seeds planted by the player
		- Actions:
			- Decreases the count when the player plants a seed
			- Updated dynamically through the UpdateSeeds() method in the PlantCountUI class

## Devlog
I seporated the project to three parts, UI which displays planted and remaining seed count. Player, which controls movement and seed planting, and Plants which spawns the seed at the player's location. The player script implemented movement from the PlayerMovement() method and seed planting function from PlantSeed() method. The script interacts with PlantCountUI by calling UpdateSeeds() when a seed it planted. There are two classes, player class which handles movement, input and seed planting and PlantCountUI which updates the seed count through the UpdateSeeds() method. This project has 3 game objects, player which implements movement and planting, PlantCountUI which manages UI text update, Canvas (texts) which only displays the seed counts, and PlantPrefab which is the seed object.

One difficulty that I encountered is trying to link the scrip that updates the seed count and the text object, initially, I tried to add a component directly on to the two text objects and linking them to PlantCountUI which will not work because it has to like with the player as well which I figured out later after trying for a while.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax). Great Devlog otherwise, thank you!
