# GEDLabAssignment2
Jacob Coleman
100829087

Gameplay: Get to the top of the screen using WASD without getting hit by a car

Diagram: https://www.figma.com/board/wTazlORf7u5c4vqpH6dYXk/Untitled?node-id=3-79&t=2VoZxE92seg6t7pE-0

What types of objects can your factory create?
I created 3 types of spawners for 3 types of vehicles

Why is the factory pattern a good choice for spawning these objects?
For the spawners, it was honestly kind of pointless. I could have just swapped out the the prefab in each spawner and it would have had the same effect. 
As for the vehicles, they all need to be detroyed after they go off screen and they also all need to do their movement on update but they each had unique movement so Factory works perfectly because they can inhereat both features from the vehicle class.
