﻿using System;


namespace XIL.AI.BehaviorTrees
{
	public abstract class Decorator<T> : Behavior<T>
	{
		public Behavior<T> child;


		public override void invalidate()
		{
			base.invalidate();
			child.invalidate();
		}
	}
}

