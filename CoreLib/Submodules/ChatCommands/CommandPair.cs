﻿namespace CoreLib.Submodules.ChatCommands;

public static partial class CommandsModule
{
    public struct CommandPair
    {
        public IChatCommandHandler handler;
        public string modName;

        public CommandPair(IChatCommandHandler handler, string modName)
        {
            this.handler = handler;
            this.modName = modName;
        }
    }
}