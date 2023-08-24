using Godot;
using System;

public class Player : KinematicBody2D
{
    private int speed = 600;
    private int gravity = 4000;
    private float friction = .25f;
    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        Vector2 velocity = new Vector2();
        int direction = 0;
        if (Input.IsActionPressed("ui_left"))
        {
            direction += 1;
            velocity.x -= speed;
        }
        if (Input.IsActionPressed("ui_right"))
        {
            direction -= 1;
            velocity.x += speed;
        }
        if (Input.IsActionJustPressed("jump"))
        {
            if (IsOnFloor())
            {
                velocity.y -= 2000;
            }
        }
        velocity.y += 500 * delta;
        MoveAndSlide(velocity, Vector2.Up);
    }
}
