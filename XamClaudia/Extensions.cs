﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace XamClaudia
{
	public static class Extensions
	{
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			foreach (var item in source) action(item);
		}
	}
}
