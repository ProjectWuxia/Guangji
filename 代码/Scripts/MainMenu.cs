using Godot;

/// <summary>
/// 用于控制和管理 MainMenu 的脚本
/// 主要用于控制和管理界面上的按钮(Buttons)
/// 关于按钮的一些用法，可以查看 <a href="https://docs.godotengine.org/zh_CN/4.x/classes/class_button.html#description">官方文档</a>
/// </summary>
public partial class MainMenu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		TextureButton btn_Start = GetNode<TextureButton>("Buttons/StartButton");
		TextureButton btn_Online = GetNode<TextureButton>("Buttons/OnlineButton");
		btn_Start.Pressed += OnStartButtonClicked;
		btn_Online.Pressed += OnOnlineButtonClicked;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	/// <summary>
	/// 开始按钮点击后执行的一系列操作
	/// </summary>
	private void OnStartButtonClicked()
	{
		// 输出Hello World到控制台
		GD.Print("Hello World");

		var simultaneousScene = ResourceLoader.Load<PackedScene>("res://Sences/Battle.tscn");
        GetTree().ChangeSceneToPacked(simultaneousScene);
	}

	private void OnOnlineButtonClicked(){
		System.Diagnostics.Process.Start("http://www.bing.com");
	}
}
