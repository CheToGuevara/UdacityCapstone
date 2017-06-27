# UdacityCapstone

A VR experience where you can be very small and feel innocence as a small toy like Toy Story or you can feel joy where you are destroying buildings as a monster.


#Commitments in this Project

##Fundamentals **500 pts**

###Scale achievement **(100 points)**

I create a history, where you find a tent in the middle of the forest. There, you can find 2 bottles! Each bottle produces you a different hallucination.
You can be as small as a train toy or you can be a big monster destroying cities. You feel smaller or bigger depends on your election.

###Lighting achievement **(100 points)**

I create a cycle of the day in each scene to introduce some mood of darkness. I added some baked lights in each scene in static objects to make realistic and avoid computation in the phone.

###Locomotion achievement **(100 points)**

In each scene, the user will be moved accordingly to the situation. At first, a user is guided on rails to avoid the user escapes. On the train, the train is moved over the rails logically.
At the end, the user can move the monster in the direction he or she looks. Monster gets a head movement to get a realistic movement, not linear.

###Video Player achievement **(100 points) **
(2x if Lighting achievement is also completed)

A video inside the tent explains to the user what do bottles do. Like Android is not able to reproduce movie player, I use the workaround with the Playback plugin splitting the video.


##Completeness  **750 pts**

###Diegetic UI achievement **(250 points)**

To avoid too much text, I create a video where I explain which bottle is that you make smaller or bigger. As the most of the cardboard has only one button, the user does all with clicking the screen. Selects bottle, play a horn and move in the big scene.

###Alternative Storyline achievement **(250 points)**

The user can choose between be smaller or bigger when he or she enters on the tent.

###3D Modeling achievement **(250 points)**

I create a house, with some props. Fridge, sink, a fireplace, a TV, chairs and table. I created more things like a bed and a sofa but they didn't fit at all. I create the UV and the textures also.


##Challenges  **500 pts**

###User Testing achievement **(250 points)**
(2x if you completed 750 points in Completeness)

I give my application to 3 users and I interviewed them in order to know issues and improve the application. As the audio is in Spanish, I translate and write it to you here.





#Transcript of User Test


1. In Scene 1, what do you see? What is your opinion?
> User 1: It is like a forest, a valley, I see a tent, but I'm not moving. Now, yes. It is very shiny, the crickets sound at the day, so strange.
> Improvements: The animation starts earlier. I create a circle day.
> User 2: A fair? there is a tent. There are trees around me, and night comes. Creepy...
> User 3: I see a forest and a tent. I hear crickets and night falls.

2. In Scene 2, what do you see? Do you feel small? What is your opinion?
> User 1: Yes, I feel small. I see a big house and miniatures, cool!
> User 2: Wuuiiii, I drive the train. Look trees and mini cars! Maybe the big house it's quite poor and static.
> Improvements: I add a particle system to the fireplace, and a cart is falling.
> User 3: I like it, it is like toy story. I see small buildings and two cars crashed.


3. In Scene 3, what do you see? Do you feel big? What is your opinion?
> User 1: YESS I am a monster. OMG, the buildings disappear... The movement is quite linear to be too big.
> User 2: Too high, It is cool. I destroy buildings if I move to them but it can sound like a film?
> Improvements: I add some people yelling and build collapsing.
> User 3: Heheheh, I am giant. I see police lights. I see few buildings to destroy....


4. About interface, what do you see when you enter in the tent?
> User 1: I see a video, I see 2 bottles, and I understand each bottle make a different effect over me.
> User 2: An explanation about each bottle is like an experience.
> User 3: The video explains what each bottle do to me. It is easy to understand.


5. Do you know what to do after seeing the video?
> User 1: Yes, the phone only allows me to click, but maybe you can emphasise the bottles with something.
Improvements: Bottles is moved when the pointer moves over the collider.
> User 2: Yes, bottles move when I look them.
> User 3: Yes, if I click on the bottle I change the level.

6. How do you feel the movement? Some sickness?
> User 1: Good, no sick. But some slow and the monster I didn't feel... correctly.
> Improvements: I add head movement to the monster.
> User 2: Nothing, the movement is quite and fine, and the monster moves the head good.
> User 3: Correct movement, nothing to add.

7. Do you notice the spatial audio?
> User 1: Yes, I hear a lot of sounds.
> User 2: Yes, but you can make that the train has a horn?
>Improvements: User can play the train's horn.
> User 3: Good mood, there are crickets, horns, and yells!



#Comments to the submit

Now I have finished the course. I will upload all my applications to the Play Store, and maybe I will get 100 downloads, how knows.

#Build requirements

* [Unity 5.4 or newer](https://unity3d.com/)
* Google Cardboard plugin
* Android Builder Unity 


#Author
Aaron Sujar