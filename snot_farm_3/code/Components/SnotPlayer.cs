using Sandbox.Citizen;

public sealed class SnotPlayer : Component
{
	[Property]
	 public GameObject Camera { get; set; }


	[Property]
	public CitizenAnimationHelper AnimationHelper { get; set; }

	[Property]
	[Range(0f, 400f, 1f)]
	public float WalkSpeed { get; set; } = 120f;

	[Property]
	[Range(0f, 800f, 1f)]
	public float RunSpeed { get; set; } = 250f;

	[Property]
	[Range(0f, 1000f, 10f)]
	public float JumpStrength { get; set; } = 400f;

	protected override void OnUpdate()
	{

	}

	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
	}
}