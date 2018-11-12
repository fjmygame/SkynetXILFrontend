﻿using System;


namespace XIL.AI.UtilityAI
{
	/// <summary>
	/// Action that logs text
	/// </summary>
	public class LogAction<T> : IAction<T>
	{
		string _text;


		public LogAction( string text )
		{
			_text = text;
		}


		void IAction<T>.execute( T context )
		{
			//Debug.log( _text );
		}

	}
}
