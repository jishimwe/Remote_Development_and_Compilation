/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VsSDK.UnitTestLibrary;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio.Project.Samples.CustomProject.UnitTests
{
	public static class MockIVsTaskList
	{
		private static GenericMockFactory factory;

		static MockIVsTaskList()
		{
			factory = new GenericMockFactory("MockIVsTaskList", new Type[] { typeof(IVsTaskList) });
		}

		public static BaseMock GetInstance()
		{
			return factory.GetInstance();
		}
	}
}