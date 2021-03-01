﻿
namespace Slantar.Architecture.Tests
{
	public class StateA : IFSMState
	{
		private Flag boolFlag;

		public StateA(Flag boolFlag) => this.boolFlag = boolFlag;


		public void Enter()
		{
			boolFlag.value = true;
		}

		public void Update()
		{
		}

		public void Exit()
		{
		}
	}
}
