﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Maui.DeviceTests.Stubs
{
	class ContextStub : IMauiContext, IDisposable
	{
		ApplicationStub _app;

		public ContextStub(ApplicationStub app)
		{
			_app = app;
		}

		public IServiceProvider Services =>
			_app.Services;

		public IMauiHandlersServiceProvider Handlers =>
			Services.GetRequiredService<IMauiHandlersServiceProvider>();

#if __ANDROID__
		public Android.Content.Context Context =>
			Android.App.Application.Context;
#endif

		public void Dispose()
		{
			_app = null;
		}
	}
}