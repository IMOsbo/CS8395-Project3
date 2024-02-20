# CS8395 Project 3

## Technology Used

- Unity: <https://unity.com/>
- Vuforia: <https://developer.vuforia.com/>

## Book Used

_Modern Military Airpower_ by Thomas Newdick and Tom Cooper

<img src="Assets/frontCover.JPG" style="height:400px;"></img>

<img src="Assets/backCover.JPG" style="height:400px;"></img>

I did have to add the printout to the back of the book to get Vuforia to recognize it as a target. Here's a link to the book: <https://www.amazon.com/Modern-Military-Airpower-1990-Present-Identification/dp/1907446273>. My copy is definitely well loved...

## Video

<whatever YouTube link I come up with>

## Installation

1. `git clone https://github.com/IMOsbo/CS8395-Project3/`
2. Add the folder you just cloned to Unity Hub and open it up <https://docs.unity3d.com/hub/manual/AddProject.html>
3. Once Unity loads, you should be able to go directly into Play Mode and test it out.
   - If you just get an empty scene, go to `Assets/Scenes` and open up `main`
   - To get the space bar to work, you might have to click inside of the Play video window

> [!WARNING]
> I've only tested this on Windows 11 and Unity 2022.3 - not sure how it would go with different OSes or different Unity versions


## Caveat about the User Interaction

I was planning to use Vuforia's Virtual Button functionality to add my interaction, but it turns out they've been deprecated and don't work well anymore. (<https://developer.vuforia.com/library/objects/virtual-buttons>). I tried to use another image target to trigger my show and hide events, but that turned out to be difficult to get it to recognize both of the targets at once (probably a limitation of my crummy laptop / webcam). Eventually, I decided to just show and hide the review when the user presses the space bar. 

## Citations

- 3D Plane Model from `rhildebrandt` <https://rhildebrandt.itch.io/low-poly-air-jets>
- Vuforia's documentation <https://developer.vuforia.com/library/objects/image-targets>
- Unity's wonderful documentation
  - <https://docs.unity3d.com/ScriptReference/Transform.Rotate.html>
  - <https://forum.unity.com/threads/rotate-around-moving-object.1268099/#post-8050688>
  - <https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html>
  - <https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html>  
