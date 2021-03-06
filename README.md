# SpaceBattleSim

Name: Pasin Tipprasert

Student ID: C16347416

# Project Description
A repo for GE2 project. A creation of a Sci-Fi spaceship battle sequence. The battle depicted is not based on any Sci-Fi film, it is from myu own imagination. This project is done as a part of Game Engine 2 assignment for DT508 Game Design course in TU Dublin.

# Instructions & How it Works
To observe/play the project, clone the master branch, open Unity preferably of version 2019.1.0f2 as it was the version this project is built on.

After the project is opened, navigate to the Scenes folder and open up Scene1. Click the play button and enjoy the show!

How this whole project:

From Scene1 - The Camera have a script that make it look at the main spaceship moving towards it, avoding their Carrier ship by going upward. Once it hit a cetain point near a sawrm of asteroids, it triggers another script which will switch from Scene1 to Scene2.

![Scene1](https://user-images.githubusercontent.com/26767832/57327586-3803e580-7107-11e9-8cf8-0661afcf0e33.PNG)

Scene 2 - This is where the main battle comes in. It is 'automated' to a certain extend. The ships are setted up in a battlefield, flying and shooting at each other, sparks/small explosion will happen when the ship gets hit. The Carrier Ships from both sides (Hero vs Villian) will circle around the vicinity, the Cameras will switch between each other in a loop, looking at the main fight sequence between Hero Covette and Villian Frigate Ships. 

![Scene2](https://user-images.githubusercontent.com/26767832/57327604-42be7a80-7107-11e9-99ee-a77f3d8812b1.PNG)

Once the main Villian Frigate ship got destroy, an explosion will occur and the Scene will fades to Scene3. The time of the fights varies due to missing lazer shots and behaviours.

![Scene2 5](https://user-images.githubusercontent.com/26767832/57327621-4b16b580-7107-11e9-8b3f-5636c34608bd.PNG)

Scene3 - This is when the Villian troops retreats. Turning around and go through a portal that is essentially a wormhole/space vortex. This will then transitions into Scene4 once all the ships disappear.

![Scene3](https://user-images.githubusercontent.com/26767832/57327634-51a52d00-7107-11e9-887a-8198615e995e.PNG)

Scene4 - This scene shows the Villian troop reappear back in another part of space and being ambushed by the Main Hero troop with an energy cannon. The camera switches and shows the Energy Cannon being charged with VFX, then it fired at the Villian troop, decimating them with a huge explosion effects. Then the Scene will switch to Scene5.

![Scene4](https://user-images.githubusercontent.com/26767832/57327656-5b2e9500-7107-11e9-80f7-dfe6f3db76eb.PNG)

![Scene4 5](https://user-images.githubusercontent.com/26767832/57327673-64b7fd00-7107-11e9-8675-193f44800b32.PNG)

Scene5 - This scene is the final Scene, showing troops of Villians with multiple of their Energy Cannons and their Mother ships slowly approaching the Main Hero Base. Then the Scene will fade to black and switch to Scene6.

![Scene5](https://user-images.githubusercontent.com/26767832/57327681-6b467480-7107-11e9-8312-a1b300a6f4c0.PNG)

Scene6 - This is just a scene that have a message of how to replay the game by pressing the 'R' button.

# Most Proud Aspects
Most proud aspect in this project would be the custom shader I've learned and created. The custom shader is used on the Space Portal effects as due to Unity version 2019.1.0f2 does not allow me to use HDRP and Shader graph packages weithout ruining every textures and materials in the project, and they will always reverted to corruupted pink textures even after several attempts at Manual material selection updates.

However, I found a blog discussing about how to create a custom shader, and learn how to create and implemnet one myself. 

![Portal](https://user-images.githubusercontent.com/26767832/57327699-726d8280-7107-11e9-9dac-08186fc62910.PNG)

The other Visual Effects are also done by me, the Laser had the help of the Volumetric Lines asset from Unity Asset Store.

### Examples

![Explosion](https://user-images.githubusercontent.com/26767832/57327707-79949080-7107-11e9-85c5-266d48049f26.PNG)

![LazerConnon](https://user-images.githubusercontent.com/26767832/57327720-80230800-7107-11e9-8d02-ce403e04f932.PNG)

The scripts that I'm most proud of are the CameraAutoSwitch, the TakeDmg and the ShootDetectSphereTest scripts. These scripts I've coded myself with helps from Unity forums and friends.

## Youtube Video of the project

[![IMAGE ALT TEXT HERE](https://i9.ytimg.com/vi/SGVkQizMohc/mq2.jpg?sqp=COjCx-YF&rs=AOn4CLBt-W3VkIunRa9Rr4S1MfOh8CTLOw)](https://youtu.be/SGVkQizMohc)

## Storyboard:
Scene 1:
- Camera is fixed on the Hero Carrier Ship that slowly move forward using Boid & Pathfinding Behaviour scripts.
- 3-5 Hero Fighter Ships will fly from behind and over the Carrier Ship towards the camera, using the Boid & Path Finding Behaviour as well.

![DiagramOnly1](https://user-images.githubusercontent.com/26767832/54529185-05dfce00-4977-11e9-99f2-a773b34c9e85.jpg)

Transitions...

Scene 2:
- Camera follows the main Hero Fighter Ships into the battlefield where mass battle is happening between the Hero and the Enemy factions. A set of ships will have Boid, Offset Pursue, Wandering and Shooting Behaviours while some will only have Path Following and Obstacle Avoidance.
- The ships will start splitting off to follow their own targets, firing lasers as they get close. The ships will have Boid, Offset Pursue, Seeking, Obstacle Avoidance, Flee & Shooting Behaviours.
- Camera will follow one of the ship, showing it pursuing an enemy ship, shooting it and destroy it after a certain amount of time.

![DiagramOnly2](https://user-images.githubusercontent.com/26767832/54529228-30ca2200-4977-11e9-9e69-0b46b2bf4141.jpg)

Transitions...

Scene 3:
- Camera is focus on the Enemy troops, showing their number decreasing from the Hero's troop's attack. (Combination of previous Scene Behaviours, eg. Path Following, Shooting, Offset Pursue, etc., with added VFX and ships being continuously destroy one after another)

![DiagramOnly3](https://user-images.githubusercontent.com/26767832/54529240-39baf380-4977-11e9-80b2-b8a7b940a371.jpg)

Transitions...

Scene 4:
- Camera showing Enemy Troops retreating, going into a warp/hyperspace while there's some explosion surrounding the area. Simply just some Path Following or Arrive Behaviour and a portal/wormhole VFX at the end.

![DiagramOnly4](https://user-images.githubusercontent.com/26767832/54529249-42abc500-4977-11e9-8f5b-18e27f3f0025.jpg)

Transitions...

Scene 5:
- The remaining Enemy Troop reappearing just to meet with another Hero troop. (Arrive Behaviour after portal/wormhole VFX is played and then some Path Following.)
- Hero Mothership fire a beam at the enemy troop, destroying all of them. VFX with Shooting behaviour.
- Fade to black.

![DiagramOnly5](https://user-images.githubusercontent.com/26767832/54529271-4ccdc380-4977-11e9-92a3-e67f354cbaef.jpg)

Transitions...

Scene 6:
- May have a cliffhanger, Camera showing a multiple Enemy Troops slowly coming into view from the bottom of the camera, heading towards the Hero homebase.

![DiagramOnly6](https://user-images.githubusercontent.com/26767832/54529277-53f4d180-4977-11e9-95df-b6bc64bff289.jpg)

-END-
