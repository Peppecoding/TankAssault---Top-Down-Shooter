# Tank Assault - Top-Down Shooter

This repository contains the C# script for a simple **top-down tank shooter** created in **Unity**. The focus of this project is on showcasing basic **tank movement** and **shooting mechanics** in a top-down view.

## Game Overview

In **Tank Assault**, the player controls a tank from a top-down perspective, navigating the game environment, aiming the turret, and shooting at targets.

### Features

- **Tank Movement**: The player can move the tank forward, backward, and rotate it to face different directions using the keyboard.
- **Tank Shooting**: The tank can shoot bullets in the direction of the turret's aim.
- **Aiming**: The tank's turret automatically tracks the mouse pointer, allowing for precise aiming and shooting.
  
## Script Overview

This project highlights a C# script that controls the core gameplay elements:

### Core Components:
- **Movement**: Uses Unity's physics system (`Rigidbody`) to control the tank's forward, backward, and rotational movement.
- **Aiming**: Aims the tank's turret toward the mouse cursor using raycasting to detect where the player is pointing.
- **Shooting**: Implements a basic shooting system where the player fires a bullet when pressing the left mouse button.

### Key Variables:
- `moveSpeed`: Controls how fast the tank moves forward and backward.
- `rotationSpeed`: Controls how fast the tank rotates.
- `bulletSpeed`: Sets the speed at which the bullets travel after being fired.
- `aimTransform`: A transform used to aim the tank's turret.
- `whatIsAimMask`: A LayerMask that defines which objects the player can aim at.

### How the Script Works

1. **Tank Movement**:
   - The script captures player input (W/S keys for moving, A/D keys for rotating) and moves the tank accordingly.
   - Rotation is smooth and depends on player input.

2. **Aiming**:
   - The tank's turret follows the position of the mouse, allowing for intuitive aiming.
   - A raycast is used to detect where the mouse is pointing in 3D space, and the turret adjusts its rotation accordingly.

3. **Shooting**:
   - When the player clicks the left mouse button, a bullet is fired. The bullet travels in the direction the turret is facing.
   - The shooting method is currently a placeholder for adding more advanced projectile functionality.

### How to Use the Script

1. **Attach the script** to your tank GameObject in Unity.
2. **Assign required components** in the Unity Editor:
   - Drag and drop the `Rigidbody` and `Transform` components (for the gun point, turret, etc.) into the relevant fields.
   - Set values for `moveSpeed`, `rotationSpeed`, and `bulletSpeed`.
   - Set up the Layer Mask for aiming.
3. **Test the Game**: Run the game in Unity to control the tank and try out the movement and shooting mechanics.

### Controls
- **W / S**: Move the tank forward/backward.
- **A / D**: Rotate the tank.
- **Mouse Movement**: Aim the turret.
- **Left Mouse Button**: Shoot bullets.

## Future Improvements

This project is a basic demo, and future iterations may include:
- **Bullet firing mechanics** with actual projectiles.
- **Enemy AI** for target practice.
- **Score system** or timed challenges.

## How to Play the Full Game

Follow my social media to watch gameplay videos and receive updates on this and other projects:

- [Instagram](#) (https://www.instagram.com/peppeproduction/?hl=en)
- [YouTube](#) (https://www.youtube.com/@PeppeProductionHQ/videos)

## License

This project is open-source and available for educational purposes. Feel free to fork, clone, and modify it for your own projects. If you share it, a credit would be appreciated!

---

Enjoy experimenting with **Tank Assault** and follow me on social media for more updates!
