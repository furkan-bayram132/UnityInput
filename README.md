# UnityInput

A script to get input with less code.

To use:

Create a empty game object and attach KeyPresses.cs to it.

![Screenshot_161](https://user-images.githubusercontent.com/53917292/91600246-5337db80-e970-11ea-8d67-8d6ef3415803.png)

Select the keys that you want to get input from.

![image](https://user-images.githubusercontent.com/53917292/91600546-ca6d6f80-e970-11ea-81b4-6e760effaa80.png)

Create a reference to KeyPresses class

![image](https://user-images.githubusercontent.com/53917292/91600985-8a5abc80-e971-11ea-861d-545040d33c27.png)

Drag and drop InputManager game object to the serialized field. This way Unity will automatically assign the KeyPresses script to the reference called keyPresses.

![image](https://user-images.githubusercontent.com/53917292/91601169-d73e9300-e971-11ea-9fc5-dcbab4e2d8b1.png)

Now you can check whether the key is beign pressed (KeysBeingPressed), the key was pressed(KeysWasPressed), or the key was released(KeyWasReleased) using the following syntax

![image](https://user-images.githubusercontent.com/53917292/91601744-d9552180-e972-11ea-80ae-f6624a56d883.png)
