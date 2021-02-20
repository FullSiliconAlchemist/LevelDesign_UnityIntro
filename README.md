# Physics-based 2-player Ball Keep-Up

This game is a third-person physics-based volleyball/Ball Keep-Up game, pretty straight forward.

2Player couch games are dead with the advancements in networking technologies, but the nostalgia we get from sitting with a friend and playing a game will never die.

The Goal of the game is to play Ball Keep-Up with your friend

Things I want to explore in this first prototype:

Q1:
Is the game and objective clear?

"Yes, it's straight-forward."
"Yes it is, very simple and simply put forward. I just wasn't sure at first which one of the 3 scenes was the right one."
"Yes."

A1: 
It seems most that have played the game were able to adopt the controls and interact right away without any trouble. 
During the playtest in class, Avery didn't seem to understand the objective of the game right away. She saw the ball and knew immediately how to control the character, but the puprose was not clear. After restarting the game she read the UI prompt at the start explaining the purpose and then proceeded to keep the ball up a much as possible.

Q2:
Is the game easy to play/understand?

"Yes - it only takes a few seconds to figure out the game objective and how to play. The bullseye is really helpful for the gameplay."
"Very easy to understand, but a lot less easy to play. Was not able to get more than 7 balls, which is not a lot compared to other games in the same style like flappy bird."
"Generally, yes, but I had to figure out that I have to jump for the ball to bounce on the character's head."

A2:
In terms of understanding the game mechanics, most players deemed it simple enough to grasp. The comment by player #2 suggests that although the game is simple to start playing, it is not easy to advance to higher scores. This could be resolved by increasing the hitbox of the character's head, potentially by using a larger sphere collider instead of the character's pill-shaped collider instead. Comment #3 suggests that there needs to be clearer indication of the game mechanics IF there was more complexity involved, such as NEEDING to jump in order to bounce the ball for better height, etc. During the live playtest, Avery was able to grasp the concept but the gameplay has shown bugs where the ball escaped the collider arena.

Q3:
Does a simple game mechanic still provide an entertainment factor?

"Yes, simple games can certainly be entertaining. There's no need to learn/adapt to particular controls or ways of playing so it's quick and easy to get going. You can play them repeatedly and create challenges for yourself which can be satisfying."
"Yes very much so. I would also say it provides an addictive factor, the type of game that is infinitely long, but addictive because you always want to get more points, like Flappy Bird for example."
"Does a simple game mechanic still provide an entertainment factor?
Of course, look at Super Mario Bros."

A3:
There was an underlying problem with the question asked here, which is that rather than specifying the entertainment factor of this particular game, I've asked it as a more general question, and it was interpreted as such. Example games with simple mechanics yet engaging content ranged from Flappy Bird to Mario Bros. The next step from this point would be to develop what Keep-Up's ENGAGEMENT factor is. Is it the sound effect when you hit the ball? Is it the animations? Is it the power ups? There are many ways to go about this. Personally I'd want to develop sound and character animations to make it more interesting.

Q4:
What is the overall difficulty level given to this game without any power-ups or game-intiated help?

"It was pretty easy. A two-player option would be a nice addition!"
"The camera is the hardest thing. With the angle, it's not easy to get to the center of the blue circles, especially when the ball is far from the camera."
"It's pretty difficult to keep the ball bouncing, to be honest. It's very easy for the ball to get too far and it's pretty hard to predict how the ball will react to my headbumps. More area to move, the ball staying in sight as well with allowing faster movement should help."

A4:
The suggestions in this question were very informative. Player #1 suggests a 2-player option, which I agree would be quite entertaining, it could even be more interesting if it were playable online. Player #2 suggested a more natural camera movement rather than something stationary. Perhaps changing the angle to a top-down view or some rotation on an axis in the center of the stage would help. Camera development is a crucial part in any game, so this would require some time in itself since there are many ways to implement the camera. I think testing camera views would even be necessary to some degree. Player #3 suggests the ball-bounce factor needs to be lowered, I would even go so far as to incrementaly increase the bounce factor as the game progresses. Player #3 also suggests that despite the target marker, it's still difficult to predict the ball's movements as well as its rebound angle off the player's head. They also suggest to allow faster run speeds and having the ball remain in sight, could be due to the camera work.

CONCLUSIONS:

From what I've gathered in the answers given, the game is simple, it's easy to play and understand, and provides a more or less mediocre engagement factor. Granted, it's simplicity in design is also it's underlying issue. There's nothing particularly captivating in the game as it stands. I've created an objective that stands as the core gameplay mechanic, but to improve it needs some refinement, some added complexity and perhaps some visual cohesiveness to make it more valuable for the player's time.

If I were to pursue this game, the first thing I would want to change or improve is the Camera, and camera behaviors. Should it focus on the player or the ball, should I allow players to control it, these are curcial to giving the player the tools to playing the game as efficiently as possible. Next I would focus on new character models and implementing animations for them. Having them run around, potentially dive for the ball instead of just jumping, maybe even implement an auto-aim system for the player's limbs to hit the ball when in proximity and the ball's direction would be chosen randomly. These two factors would probably improve the game to a significant degree.
