﻿using CommandLine;

namespace GQLCCG
{
    internal sealed class ConsoleOptions
    {
        [Option('c', "config", Required = false, HelpText = "Config file path.", Default = "config.json")]
        public string Config { get; set; }

        [Option("setup-config", Required = false, HelpText = "Setup config file.", Default = false)]
        public bool SetupConfig { get; set; }
    }
}