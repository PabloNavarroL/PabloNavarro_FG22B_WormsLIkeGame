# PabloNavarro_FG22B_WormsLIkeGame
2022 Coding Assignment. 

FG22 C# Beginners assignment. By Pablo Navarro. Please check read me.

This is how I decided to hand in the assignment.

I'm quite happy with the result, yet I think I tackled more than I can handle in these couple of weeks.

My biggest main issue right now is the inability to use Unity.UI; library and TMPro as well, so UI is nonexistent. How this problem presented itself is beyond what I could figure out, even with help from Erik was not possible to solve in the short time I have left.

The controls:

W: Camera forward S: Camera Backward. D: Camera Right A: Camera Left

E: Camera Rotation Left Q: Camera Rotation Right

Right Mouse Click: Player Move To Left mouse Click: Shoot projectile.

Tab: Switch player.

Basic rules:

Shoot the other player until they burst into magic. The shot strength is relevant to the distance the mouse is clicked from the player. If close to the character the less force the attack will have the further away more force!

Each character has a limited amount of movement.

It takes 4 shots to drain the health of the other character.

Navigate through the level. Open and close doors at the altars, and gain control of the areas.

Bugs and Current Issues:

Camera and movement.

For the character movement and shooting, I used Ray tracing. There is no significant bug in the movement, but sometimes there is an issue when the shooting will get "stuck" and does not read the proper mouse input.

I wanted to add a second camera that follows P2 but that was also messing with the nav mesh reading Ray tracing and I spent too much time trying to figure it out so I decided to proceed with other Issues and leave the camera movement to the player.

Since I have no UI for the reasons explained at the top of this document, I can Instantiate a Victory screen or any other UI-related elements, so the game is over when one character dies and the game basically crashes when trying to change back to that character.
