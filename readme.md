# Unity Environment Task 
Your task will be to build an open world urban environment and write a C# Unity script to map Unity coordinates to GPS coordinates to a Unity object (such as a Cube)

### Deliverables for the World Map 
- The environment should be approximately 1 km by 1 km (Hint 1 Unity unit is 1 meter)
- Terrain should vary in color, size, and gradient of terrain (hilly and flat)
- Include buildings  

### Deliverables for GPS Script 
- The GPS C# code should be able to do the following 
	-  Be attached to a game object take in the Unity position and convert to respective latitutde, longitude, and altitude.
	- Have this display the location of the game object in **Unity coordinates and GPS coordinates**
	- Have the user be able to define the base origin for the latitude, longitude, and altitude (we're not always going to be based at 0,0,0 for lat,long,alt)

You are free to use whatever resource available to you. If you ever feel stuck (5-minute rule/grinding your wheels) don't be scared to ask for help, as well as if instructions are unclear. For status checks please push your project to github named **unity_environment_task** and send the link to Justin   

## Initial Setup/Getting Started
- Run the install_unityhub.sh to download UnityHub and vscode 
- Before starting a new project, add the following  free assets:
	- Environments
		- https://assetstore.unity.com/packages/3d/environments/landscapes/terrain-sample-asset-pack-145808
	- Better terrain:
		- https://assetstore.unity.com/packages/2d/textures-materials/floors/outdoor-ground-textures-12555?aid=1011ld79j&utm_campaign=unity_affiliate&utm_medium=affiliate&utm_source=partnerize-linkmaker
	- Buildings:
		- https://assetstore.unity.com/packages/3d/environments/urban/simple-urban-buildings-pack-1-33563 
	- Skies:
		- https://assetstore.unity.com/packages/2d/textures-materials/sky/free-real-skies-87740
	- Grass terrain:
		- https://assetstore.unity.com/packages/2d/textures-materials/nature/grass-flowers-pack-free-138810
- To find your assets:
	- On Unity editor go to:
		- Window -> Package Manager -> Packages -> My Assets
		- Click on **download** and then **import**
	- If you don't see it click on the refresh button on the lower left
- And then follow this tutorial on how to build a terrain with Unity:
	- https://www.youtube.com/watch?v=ddy12WHqt-M&ab_channel=UGuruz