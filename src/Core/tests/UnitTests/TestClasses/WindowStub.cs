namespace Microsoft.Maui.UnitTests.TestClasses
{
	class WindowStub : IWindow
	{
		public IPage Page { get; set; }
		public IMauiContext MauiContext { get; set; }
	}
}
