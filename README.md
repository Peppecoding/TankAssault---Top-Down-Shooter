# Tank Assault - Top-Down Shooter

This repository contains the C# script for a simple **top-down tank shooter** created in **Unity**. The focus of this project is on showcasing basic **tank movement**, **shooting mechanics**, and additional features like **camera follow** and **target hit detection** in a top-down view.

## Game Overview

In **Tank Assault**, the player controls a tank from a top-down perspective, navigating the game environment, aiming the turret, and shooting at targets. The game includes smooth camera tracking and visual feedback when targets are hit.

### Features

- **Tank Movement**: The player can move the tank forward, backward, and rotate it to face different directions using the keyboard.
- **Tank Shooting**: The tank can shoot bullets in the direction of the turret's aim.
- **Aiming**: The tank's turret automatically tracks the mouse pointer, allowing for precise aiming and shooting.
- **Camera Follow**: The camera smoothly follows the tank, maintaining a fixed distance behind it.
- **Target Hit Detection**: Targets change their material when hit by a bullet to provide visual feedback.

## Script Overview

This project highlights several C# scripts that control the core gameplay elements:

### Core Components:

- **Movement**: Uses Unity's physics system (`Rigidbody`) to control the tank's forward, backward, and rotational movement.
- **Aiming**: Aims the tank's turret toward the mouse cursor using raycasting to detect where the player is pointing.
- **Shooting**: Implements a basic shooting system where the player fires a bullet when pressing the left mouse button.
- **Camera Follow**: The camera smoothly follows the tank’s movement, maintaining a fixed distance behind it.
- **Target Hit Detection**: Targets change material when hit by bullets, providing visual feedback to the player.

### Key Variables:
- `moveSpeed`: Controls how fast the tank moves forward and backward.
- `rotationSpeed`: Controls how fast the tank rotates.
- `bulletSpeed`: Sets the speed at which the bullets travel after being fired.
- `aimTransform`: A transform used to aim the tank's turret.
- `whatIsAimMask`: A LayerMask that defines which objects the player can aim at.
- `followDistance`: Determines how far the camera stays behind the tank.
- `smoothSpeed`: Controls the speed of the camera follow.
- `gotHitMaterial`: The material to switch to when a target is hit.

### How the Scripts Work

1. **Tank Movement**:
   - The script captures player input (W/S keys for moving, A/D keys for rotating) and moves the tank accordingly.
   - Rotation is smooth and depends on player input.

2. **Aiming**:
   - The tank's turret follows the position of the mouse, allowing for intuitive aiming.
   - A raycast is used to detect where the mouse is pointing in 3D space, and the turret adjusts its rotation accordingly.

3. **Shooting**:
   - When the player clicks the left mouse button, a bullet is fired. The bullet travels in the direction the turret is facing.

4. **Camera Follow**:
   - The camera follows the player's tank, staying a set distance behind it, with smooth transitions to avoid jerky movement. The camera position is updated each frame, based on the player’s movement, with adjustable speed and distance.

5. **Target Hit Detection**:
   - When a bullet hits a target, the target’s material changes to provide visual feedback. The detection works based on collision events, and the bullet is identified by its tag (e.g., "Bullet").

### How to Use the Scripts

1. **Attach the movement, aiming, and shooting scripts** to your tank GameObject in Unity.
   - Assign the necessary Rigidbody and Transform components in the Unity Editor.
   - Set values for `moveSpeed`, `rotationSpeed`, and `bulletSpeed`.
   - Set up the Layer Mask for aiming.

2. **Attach the camera follow script** to the camera GameObject.
   - Assign the player's Transform to the script in the Inspector.
   - Adjust the `followDistance` and `smoothSpeed` to fit your game.

3. **Attach the target hit detection script** to any GameObject acting as a target.
   - Assign the `gotHitMaterial` in the Inspector to specify the material that should appear when the target is hit.
   - Ensure bullets have the "Bullet" tag for proper detection.

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

- [Instagram](https://www.instagram.com/peppeproduction/?hl=en)
- [YouTube](https://www.youtube.com/shorts/iVWYiI2XHeI)

## License

This project is open-source and available for educational purposes. Feel free to fork, clone, and modify it for your own projects. If you share it, a credit would be appreciated!

---

Enjoy experimenting with **Tank Assault** and follow me on social media for more updates!
