# SpaceBattleSim
A repo for GE2 project. A recreation of Battlestar Galctica spaceship battle sequence.

## Storyboard:
Scene 1:
- Camera is fixed on the Hero Carrier Ship that slowly move forward using Boid & Pathfinding Behaviour scripts.
- 3-5 Hero Fighter Ships will fly from behind and over the Carrier Ship towards the camera, using the Boid & Path Finding Behaviour as well.

![DiagramOnly1](https://user-images.githubusercontent.com/26767832/54529185-05dfce00-4977-11e9-99f2-a773b34c9e85.jpg)

Scene2:
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

Scene 4:
- Camera showing Enemy Troops retreating, going into a warp/hyperspace while there's some explosion surrounding the area. Simply just some Path Following or Arrive Behaviour and a portal/wormhole VFX at the end.

![DiagramOnly4](https://user-images.githubusercontent.com/26767832/54529249-42abc500-4977-11e9-8f5b-18e27f3f0025.jpg)

Transitions...

Scene 5:
- The remaining Enemy Troop reappearing just to meet with another Hero troop. (Arrive Behaviour after portal/wormhole VFX is played and then some Path Following.)
- Hero Mothership fire a beam at the enemy troop, destroying all of them. VFX with Shooting behaviour.
- Fade to black.

![DiagramOnly5](https://user-images.githubusercontent.com/26767832/54529271-4ccdc380-4977-11e9-92a3-e67f354cbaef.jpg)

Scene 6:
- May have a cliffhanger, Camera showing a multiple Enemy Troops slowly coming into view from the bottom of the camera, heading towards the Hero homebase.

![DiagramOnly6](https://user-images.githubusercontent.com/26767832/54529277-53f4d180-4977-11e9-95df-b6bc64bff289.jpg)

-END-
