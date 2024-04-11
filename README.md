# BO-ArcadeMechanics



2D platformer using 3d models, the camera follows the player. the player can only walk right and left using the a (left) and d (right) buttons and can jump using the space button. he can jump from platform to platform that aren't connected and are floating with a background. on the platforms he can find coins of a yellow/gold colour, kinda like a bitcoin. on collision with the coin it dissapears and 1 point gets added to the counter. also when you pickup a coin, that becomes your checkpoint. if you die by falling off a platform or getting killed by an enemy you respown at the place you picked up the coin. 


We struggled the most wuth the heart system. Anthony made the invisible hitbox where you got teleported back to the spawn point. The mechanic we struggled was linking the heart images to the life system. When Anthony had the base code he eventually searched online and changed the few code to make the game work. He made an Array to hold heart images, an int for current number of lives and an int for the maximum number of lives. He made a code that got the components images in the children of the canvas. Set initial lives and maxLives based on the number of hearts. A code that enables all hearts initially. Made a lives code that when all images are gone, the game "pauses" and sends you to the menu so you can start over.


Another mechanic we struggled with was the waking script. Our first script walked fine, but when you jumped you could walk midair without losing air. Our second code works better for jumping, but it feels more like you are gliding on ice or sometimes he wouldn't walk at all. So when we asked the teacher he suggested to use the drag on the player's Rigidbody and now it works better, but not exactly as we hoped. We have learned that for the next time if we want to make an arcade game we should use a Character Controller.